using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat
{
    public static class CodeStyleUtil
    {
        private static readonly Regex CODESTYLE_RULE_REGEX_NO_JSONABLE_PROPERTY_IN_REQUEST = new Regex(@"\/\* \@codestyle-disable[a-zA-Z0-9,\-\s]*no-jsonable-property-in-request-get[a-zA-Z0-9,\-\s]*\*\/", RegexOptions.Compiled);
        private static readonly Regex CODESTYLE_RULE_REGEX_NO_INSTANTIATED_PROPERTY_IN_RESPONSE = new Regex(@"\/\* \@codestyle-disable[a-zA-Z0-9,\-\s]*no-instantiated-property-in-response[a-zA-Z0-9,\-\s]*\*\/", RegexOptions.Compiled);

        private static bool TryJsonize(Type type, string json, out Exception exception)
        {
            exception = null;

            var newtonsoftJsonSettings = FlurlNewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            newtonsoftJsonSettings.CheckAdditionalContent = true;
            newtonsoftJsonSettings.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Error;
            var newtonsoftJsonSerializer = new FlurlNewtonsoftJsonSerializer(newtonsoftJsonSettings);
            var systemTextJsonSerializer = new FlurlSystemTextJsonSerializer();

            try
            {
                newtonsoftJsonSerializer.Deserialize(json, type);
                systemTextJsonSerializer.Deserialize(json, type);
            }
            catch (Exception ex)
            {
                if (ex is Newtonsoft.Json.JsonException)
                    exception = new Exception($"[模型] 通过 Newtonsoft.Json 反序列化 `{type.Name}` 失败。", ex);
                else if (ex is System.Text.Json.JsonException)
                    exception = new Exception($"[模型] 通过 System.Text.Json 反序列化 `{type.Name}` 失败。", ex);
                else
                    exception = new Exception($"[模型] JSON 反序列化 `{type.Name}` 遇到问题。", ex);

                return false;
            }

            try
            {
                object instance = Activator.CreateInstance(type);
                TestReflectionUtil.InitializeProperties(instance);

                newtonsoftJsonSerializer.Serialize(instance, type);
                systemTextJsonSerializer.Serialize(instance, type);
            }
            catch (Exception ex)
            {
                if (ex is Newtonsoft.Json.JsonException)
                    exception = new Exception($"[模型] 通过 Newtonsoft.Json 序列化 `{type.Name}` 失败。", ex);
                else if (ex is System.Text.Json.JsonException)
                    exception = new Exception($"[模型] 通过 System.Text.Json 序列化 `{type.Name}` 失败。", ex);
                else
                    exception = new Exception($"[模型] JSON 序列化 `{type.Name}` 遇到问题。", ex);

                return false;
            }

            try
            {
                PropertyInfo[] lstPropInfo = TestReflectionUtil.GetAllProperties(type);
                foreach (PropertyInfo propInfo in lstPropInfo)
                {
                    var newtonsoftJsonAttribute = propInfo.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>(inherit: true);
                    var systemTextJsonAttribute = propInfo.GetCustomAttribute<System.Text.Json.Serialization.JsonPropertyNameAttribute>(inherit: true);
                    if (newtonsoftJsonAttribute?.PropertyName != systemTextJsonAttribute?.Name)
                    {
                        exception = new Exception($"[模型] 类型 `{type.Name}` 的可 JSON 序列化字段 `{propInfo.Name}` 声明不一致：`{newtonsoftJsonAttribute.PropertyName}` & `{systemTextJsonAttribute.Name}`。");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                exception = new Exception($"[模型] JSON 分析 `{type.Name}` 遇到问题。", ex);
                return false;
            }

            return exception == null;
        }

        private static bool TryXmlize(Type type, string xml, out Exception exception)
        {
            exception = null;

            try
            {
                using var reader = new StringReader(xml);
                var xmlSerializer = new XmlSerializer(type, new XmlRootAttribute("xml"));
                xmlSerializer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                exception = new Exception($"[模型] XML 反序列化 `{type.Name}` 遇到问题。", ex);
                return false;
            }

            try
            {
                var xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.LoadXml(xml);

                Func<System.Xml.XmlNode, Exception> fn = default;
                fn = new Func<System.Xml.XmlNode, Exception>((xmlNode) =>
                {
                    if (xmlNode.NodeType == System.Xml.XmlNodeType.Element)
                    {
                        PropertyInfo[] lstPropInfo = TestReflectionUtil.GetAllProperties(type);
                        var xmlElementAttributes = lstPropInfo.SelectMany(e => e.GetCustomAttributes<XmlElementAttribute>(inherit: true)).ToArray();
                        var xmlArrayAttributes = lstPropInfo.SelectMany(e => e.GetCustomAttributes<XmlArrayAttribute>(inherit: true)).ToArray();
                        var xmlArrayItemAttributes = lstPropInfo.SelectMany(e => e.GetCustomAttributes<XmlArrayItemAttribute>(inherit: true)).ToArray();
                        if (!xmlElementAttributes.Any(e => e.ElementName == xmlNode.Name) &&
                            !xmlArrayAttributes.Any(e => e.ElementName == xmlNode.Name) &&
                            !xmlArrayItemAttributes.Any(e => e.ElementName == xmlNode.Name))
                        {
                            return new Exception($"[模型] 类型 `{type.Name}` 的可 XML 序列化字段缺失项：`{xmlNode.Name}`。");
                        }
                    }

                    for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                    {
                        Exception ex = fn.Invoke(xmlNode.ChildNodes[i]);
                        if (ex != null)
                            return ex;
                    }

                    return null;
                });

                for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
                { 
                    exception = fn.Invoke(xmlDoc.DocumentElement.ChildNodes[i]);
                    if (exception != null)
                        return false;
                }
            }
            catch (Exception ex)
            {
                exception = new Exception($"[模型] XML 分析 `{type.Name}` 遇到问题。", ex);
                return false;
            }

            return exception == null;
        }

        public static bool VerifyApiModelsNaming(Assembly assembly, out Exception exception)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));

            var lstModelType = TestReflectionUtil.GetAllApiModelsTypes(assembly);
            var lstError = new List<Exception>();

            foreach (Type modelType in lstModelType)
            {
                string name = modelType.Name.Split('`')[0];

                if (!name.EndsWith("Request") && !name.EndsWith("Response"))
                {
                    lstError.Add(new Exception($"[模型] `{name}` 类名结尾应为 \"Request\" 或 \"Response\"。"));
                    continue;
                }

                if (name.EndsWith("Request"))
                {
                    if (!typeof(ICommonRequest).IsAssignableFrom(modelType))
                    {
                        lstError.Add(new Exception($"[模型] `{name}` 是请求模型，需实现自 `{nameof(ICommonRequest)}`。"));
                        continue;
                    }

                    if (!lstModelType.Any(e => e.Name == $"{name.Substring(0, name.Length - "Request".Length)}Response"))
                    {
                        lstError.Add(new Exception($"[模型] `{name}` 是请求模型，但不存在对应的响应模型。"));
                        continue;
                    }
                }

                if (name.EndsWith("Response"))
                {
                    if (!typeof(ICommonResponse).IsAssignableFrom(modelType))
                    {
                        lstError.Add(new Exception($"[模型] `{name}` 是响应模型，需实现自 `{nameof(ICommonResponse)}`。"));
                        continue;
                    }

                    if (!lstModelType.Any(e => e.Name == $"{name.Substring(0, name.Length - "Response".Length)}Request"))
                    {
                        lstError.Add(new Exception($"[模型] `{name}` 是响应模型，但不存在对应的请求模型。"));
                        continue;
                    }
                }
            }

            if (lstError.Any())
            {
                exception = new AggregateException(lstError);
                return false;
            }

            exception = null;
            return true;
        }

        public static bool VerifyApiModelsDefinition(Assembly assembly, string workdir, out Exception exception)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));
            if (workdir == null) throw new ArgumentNullException(nameof(workdir));

            var lstModelType = TestReflectionUtil.GetAllApiModelsTypes(assembly);
            var lstError = new List<Exception>();

            var lstFilePath = TestIOUtil.GetAllFiles(workdir)
                .Where(e => string.Equals(Path.GetExtension(e), ".json", StringComparison.OrdinalIgnoreCase))
                .ToList();
            if (!lstFilePath.Any())
            {
                lstError.Add(new Exception($"[模型] \"{workdir}\" 下不存在示例文件，请检查配置的扫描路径是否正确。"));
            }

            foreach (string filePath in lstFilePath)
            {
                string name = Path.GetFileNameWithoutExtension(filePath).Split('.')[0];

                Type type = assembly.GetTypes().FirstOrDefault(e => e.FullName.StartsWith($"{assembly.GetName().Name}.Models.") && e.Name == name);
                if (type == null)
                {
                    lstError.Add(new Exception($"[模型] 扫描到示例文件 \"{filePath}\"，但类型 `{name}` 不存在。"));
                    continue;
                }

                if (string.Equals(Path.GetExtension(filePath), ".json", StringComparison.OrdinalIgnoreCase))
                {
                    string json = File.ReadAllText(filePath);
                    if (!TryJsonize(type, json, out Exception ex))
                    {
                        lstError.Add(ex);
                    }
                }
            }

            if (lstError.Any())
            {
                exception = new AggregateException(lstError);
                return false;
            }

            exception = null;
            return true;
        }

        public static bool VerifyApiEventsDefinition(Assembly assembly, string workdir, out Exception exception)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));
            if (workdir == null) throw new ArgumentNullException(nameof(workdir));

            var lstModelType = TestReflectionUtil.GetAllApiModelsTypes(assembly);
            var lstError = new List<Exception>();

            var lstFilePath = TestIOUtil.GetAllFiles(workdir)
                .Where(e =>
                    string.Equals(Path.GetExtension(e), ".json", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(Path.GetExtension(e), ".xml", StringComparison.OrdinalIgnoreCase)
                )
                .ToArray();
            if (!lstFilePath.Any())
            {
                lstError.Add(new Exception($"[模型] \"{workdir}\" 下不存在示例文件，请检查配置的扫描路径是否正确。"));
            }

            foreach (string filePath in lstFilePath)
            {
                string name = Path.GetFileNameWithoutExtension(filePath).Split('.')[0];

                Type type = assembly.GetTypes().SingleOrDefault(e => e.FullName.StartsWith($"{assembly.GetName().Name}.Events.") && e.Name == name);
                if (type == null)
                {
                    lstError.Add(new Exception($"[模型] 扫描到示例文件 \"{filePath}\"，但类型 `{name}` 不存在。"));
                    continue;
                }

                if (string.Equals(Path.GetExtension(filePath), ".json", StringComparison.OrdinalIgnoreCase))
                {
                    string json = File.ReadAllText(filePath);

                    if (!TryJsonize(type, json, out Exception ex))
                    {
                        lstError.Add(ex);
                    }
                }
                else if (string.Equals(Path.GetExtension(filePath), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    string xml = File.ReadAllText(filePath);

                    if (!TryXmlize(type, xml, out Exception ex))
                    {
                        lstError.Add(ex);
                    }
                }
            }

            if (lstError.Any())
            {
                exception = new AggregateException(lstError);
                return false;
            }

            exception = null;
            return true;
        }

        public static bool VerifyApiExtensionsNaming(Assembly assembly, out Exception exception)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));

            var lstExtType = TestReflectionUtil.GetAllApiExtensionsTypes(assembly);
            var lstError = new List<Exception>();

            foreach (Type extensionsType in lstExtType)
            {
                MethodInfo[] lstMethod = extensionsType.GetMethods()
                    .Where(e =>
                        e.IsPublic && e.IsStatic &&
                        typeof(ICommonClient).IsAssignableFrom(e.GetParameters().FirstOrDefault().ParameterType)
                    )
                    .ToArray();

                foreach (MethodInfo methodInfo in lstMethod)
                {
                    ParameterInfo[] lstParamInfo = methodInfo.GetParameters();

                    if (lstParamInfo.Length != 3)
                    {
                        lstError.Add(new Exception($"[接口] `{extensionsType.Name}.{methodInfo.Name}` 方法需有且仅有 3 个入参。"));
                        continue;
                    }

                    if (!typeof(ICommonRequest).IsAssignableFrom(lstParamInfo[1].ParameterType))
                    {
                        lstError.Add(new Exception($"[接口] `{extensionsType.Name}.{methodInfo.Name}` 方法第 1 个入参未实现 `{nameof(ICommonRequest)}`。"));
                        continue;
                    }

                    // 方法名与第二个参数、返回值均有相同命名
                    string func = methodInfo.Name;
                    string para = lstParamInfo[1].ParameterType.Name;
                    string retv = methodInfo.ReturnType.GenericTypeArguments.FirstOrDefault()?.Name;
                    if (para == null || !para.EndsWith("Request"))
                    {
                        lstError.Add(new Exception($"[接口] `{extensionsType.Name}.{methodInfo.Name}` 方法第 1 个入参类名未以 `Request` 结尾。"));
                        continue;
                    }
                    else if (retv == null || !retv.EndsWith("Response"))
                    {
                        if (!methodInfo.ReturnType.GenericTypeArguments.First().IsGenericType)
                        {
                            lstError.Add(new Exception($"[接口] `{extensionsType.Name}.{methodInfo.Name}` 方法返回值类名未以 `Response` 结尾。"));
                        }
                        continue;
                    }
                    else if (!string.Equals(func, $"Execute{para.Substring(0, para.Length - "Request".Length)}Async"))
                    {
                        lstError.Add(new Exception($"[接口] `{extensionsType.Name}.{methodInfo.Name}` 方法与请求模型不同名。"));
                        continue;
                    }
                    else if (!string.Equals(func, $"Execute{retv.Substring(0, retv.Length - "Response".Length)}Async"))
                    {
                        lstError.Add(new Exception($"[接口] `{extensionsType.Name}.{methodInfo.Name}` 方法与响应模型不同名。"));
                        continue;
                    }
                }
            }

            if (lstError.Any())
            {
                exception = new AggregateException(lstError);
                return false;
            }

            exception = null;
            return true;
        }

        public static bool VerifySourceCodeStyle(string workdir, out Exception exception)
        {
            if (workdir == null) throw new ArgumentNullException(nameof(workdir));

            var lstError = new List<Exception>();

            var lstExtensionsCodeFile = TestIOUtil.GetAllFiles(workdir)
                .Where(e => string.Equals(Path.GetExtension(e), ".cs", StringComparison.OrdinalIgnoreCase))
                .Where(e => Path.GetDirectoryName(e).StartsWith(Path.Combine(workdir, "Extensions")))
                .Where(e => Path.GetFileNameWithoutExtension(e).Contains("ClientExecute"))
                .Where(e => Path.GetFileNameWithoutExtension(e).EndsWith("Extensions"))
                .ToArray();
            var lstModelsCodeFile = TestIOUtil.GetAllFiles(workdir)
                .Where(e => string.Equals(Path.GetExtension(e), ".cs", StringComparison.OrdinalIgnoreCase))
                .Where(e => Path.GetDirectoryName(e).StartsWith(Path.Combine(workdir, "Models")))
                .Where(e => Path.GetFileNameWithoutExtension(e).EndsWith("Request") || Path.GetFileNameWithoutExtension(e).EndsWith("Response"))
                .ToArray();
            if (!lstExtensionsCodeFile.Any() || !lstModelsCodeFile.Any())
            {
                lstError.Add(new Exception($"[风格] \"{workdir}\" 下不存在源代码文件，请检查配置的扫描路径是否正确。"));
            }

            foreach (string extCodeFilePath in lstExtensionsCodeFile)
            {
                string extCodeFileName = Path.GetFileName(extCodeFilePath);

                string[] segments = File.ReadAllText(extCodeFilePath)
                    .Split(new string[] { "<summary>" }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(e => e.Contains("Async") && !e.Contains("public static class"))
                    .ToArray();
                for (int i = 0; i < segments.Length; i++)
                {
                    bool TryCheckExtensionSourceCode(string sourceCode, out (string Name, string Method, string Url)? request)
                    {
                        request = null;

                        // 匹配 <para> ... </para> 结构
                        var regexPara = new Regex("<para(([\\s\\S])*?)</para>").Match(sourceCode);
                        if (!regexPara.Success)
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{extCodeFileName}\" 下第 {i + 1} 段文档注释不齐全，未能匹配到 \"<para> ... </para>\"。"));
                            return false;
                        }

                        // 匹配 [...] ... 结构
                        var regexApi = new Regex("\\[(\\S*)\\]\\s*(\\S*)").Match(regexPara.Groups[1].Value);
                        if (!regexApi.Success)
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{extCodeFileName}\" 下第 {i + 1} 段文档注释不齐全，未能匹配到 \"异步调用 ... 接口\"。"));
                            return false;
                        }

                        // 比对请求谓词
                        string expectedMethod = regexApi.Groups[1].Value.Trim();
                        string expectedUrl = regexApi.Groups[2].Value.Split('?')[0].Trim();
                        string actualMethod = sourceCode.Contains(".CreateRequest(request, new HttpMethod(\"") ?
                            sourceCode.Split(new string[] { ".CreateRequest(request, new HttpMethod(\"" }, StringSplitOptions.None)[1].Split('\"')[0] :
                            sourceCode.Contains(".CreateRequest(request, HttpMethod.") ?
                            sourceCode.Split(new string[] { ".CreateRequest(request, HttpMethod." }, StringSplitOptions.None)[1].Split(',')[0].Split(')')[0] :
                            string.Empty;
                        if (!string.Equals(expectedMethod, actualMethod, StringComparison.OrdinalIgnoreCase))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{extCodeFileName}\" 下第 {i + 1} 段文档注释有误，`[{expectedMethod}] {expectedUrl}` 与实际接口谓词不一致。"));
                            return false;
                        }

                        // 比对请求路由
                        string actualUrl = sourceCode
                            .Split(new string[] { "CreateRequest(request," }, StringSplitOptions.RemoveEmptyEntries)[1]
                            .Substring(sourceCode.Split(new string[] { "CreateRequest(request," }, StringSplitOptions.RemoveEmptyEntries)[1].Split(',')[0].Length + 1)
                            .Split('\n')[0]
                            .Trim()
                            .TrimEnd(')', ';')
                            .Trim();
                        string[] expectedUrlSegments = expectedUrl.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                        string[] actualUrlSegments = actualUrl.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(e => e.Trim()).ToArray();
                        if (expectedUrlSegments.Length != actualUrlSegments.Length)
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{extCodeFileName}\" 下第 {i + 1} 段文档注释有误，`[{expectedMethod}] {expectedUrl}` 与实际接口路由不一致：节长不等（实际 {actualUrlSegments.Length}，期望 {expectedUrlSegments.Length}）。"));
                            return false;
                        }
                        else
                        {
                            for (int urlSegmentIndex = 0; urlSegmentIndex < expectedUrlSegments.Length; urlSegmentIndex++)
                            {
                                string expectedUrlSegment = expectedUrlSegments[urlSegmentIndex].Trim('/');
                                string actualUrlSegment = actualUrlSegments[urlSegmentIndex].Trim('/');
                                if (expectedUrlSegment.Contains("{"))
                                {
                                    if (actualUrlSegment.StartsWith("\""))
                                    {
                                        lstError.Add(new Exception($"[风格] 源代码 \"{extCodeFileName}\" 下第 {i + 1} 段文档注释有误，`[{expectedMethod}] {expectedUrl}` 与实际接口路由不一致：第 {urlSegmentIndex} 节值不同。"));
                                        break;
                                    }
                                }
                                else
                                {
                                    actualUrlSegment = actualUrlSegment.Replace("\"", string.Empty).Trim('/');
                                    if (!string.Equals(expectedUrlSegment, actualUrlSegment))
                                    {
                                        lstError.Add(new Exception($"[风格] 源代码 \"{extCodeFileName}\" 下第 {i + 1} 段文档注释有误，`[{expectedMethod}] {expectedUrl}` 与实际接口路由不一致：第 {urlSegmentIndex} 节值不同。"));
                                        break;
                                    }
                                }
                            }
                        }

                        // 比对 .SendRequestAsync() 方法
                        if (!"GET".Equals(actualMethod, StringComparison.OrdinalIgnoreCase))
                        {
                            if (sourceCode.Contains("flurlReq, cancellationToken"))
                            {
                                lstError.Add(new Exception($"[风格] 源代码 \"{extCodeFileName}\" 下第 {i + 1} 段代码有误，`[{expectedMethod}] {expectedUrl}` 为非简单请求但不包含请求正文。"));
                                return false;
                            }
                        }

                        string apiName = new Regex("Execute([a-zA-Z0-9]*)Async").Match(sourceCode).Groups[1].Value;
                        request = (apiName, expectedMethod, expectedUrl);
                        return true;
                    }
                    bool TryCheckRequestModelSourceCode(string filePath, string expectedRequestMethod, string expectedRequestUrl)
                    {
                        if (!File.Exists(filePath))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{filePath}\" 不存在。"));
                            return false;
                        }

                        string reqCodeFileName = Path.GetFileName(filePath);
                        string reqCodeSourceCode = File.ReadAllText(filePath);

                        // 匹配 <para> ... </para> 结构
                        var regexPara = new Regex("<para(([\\s\\S])*?)</para>").Match(reqCodeSourceCode);
                        if (!regexPara.Success)
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{reqCodeFileName}\" 下文档注释不齐全，未能匹配到 \"<para> ... </para>\"。"));
                            return false;
                        }

                        // 匹配 [...] ... 结构
                        var regexApi = new Regex("\\[(\\S*)\\]\\s*(\\S*)").Match(regexPara.Groups[1].Value);
                        if (!regexApi.Success)
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{reqCodeFileName}\" 下文档注释不齐全，未能匹配到 \"异步调用 ... 接口\"。"));
                            return false;
                        }

                        // 比对请求谓词
                        string actualMethod = regexApi.Groups[1].Value.Trim();
                        if (!string.Equals(expectedRequestMethod, actualMethod, StringComparison.OrdinalIgnoreCase))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{reqCodeFileName}\" 下文档注释有误，与实际接口谓词不一致。"));
                            return false;
                        }

                        // 对比请求路由
                        string actualUrl = regexApi.Groups[2].Value.Split('?')[0].Trim();
                        if (!string.Equals(expectedRequestUrl, actualUrl, StringComparison.OrdinalIgnoreCase))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{reqCodeFileName}\" 下文档注释有误，与实际接口路由不一致。"));
                            return false;
                        }

                        // 检验是否包含 `default!` 的赋值
                        if (new Regex("=\\s*default!").IsMatch(reqCodeSourceCode))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{reqCodeFileName}\" 下代码有误，请求模型不应包含 `= default!` 赋值。"));
                            return false;
                        }

                        // 检验是否包含数组类型字段
                        if (new Regex("public\\s*[a-zA-Z0-9.]*\\[\\]\\s*[a-zA-Z0-9]*\\s*{\\s*get;\\s*set;\\s*}").IsMatch(reqCodeSourceCode.Replace("byte[]", string.Empty).Replace("Byte[]", string.Empty)))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{reqCodeFileName}\" 下代码有误，请求模型不应包含数组类型字段。"));
                            return false;
                        }

                        // 校验是否包含可空字段的初始化
                        if (new Regex("\\? [a-zA-Z0-9]* \\{ get; set; \\} =").IsMatch(reqCodeSourceCode))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{reqCodeFileName}\" 下代码有误，可空字段不应初始化。"));
                            return false;
                        }

                        // 如果是 GET 请求，检查是否包含 JSON 序列化字段
                        if ("GET".Equals(expectedRequestMethod, StringComparison.OrdinalIgnoreCase))
                        {
                            if (!(CODESTYLE_RULE_REGEX_NO_JSONABLE_PROPERTY_IN_REQUEST.IsMatch(reqCodeSourceCode)))
                            {
                                if (new Regex("\\[Newtonsoft.Json.JsonProperty\\(\"[a-zA-Z0-9_]*\"\\)\\]").IsMatch(reqCodeSourceCode))
                                {
                                    lstError.Add(new Exception($"[风格] 源代码 \"{reqCodeFileName}\" 下代码有误，请求模型为简单请求、不应包含可 JSON 序列化字段。"));
                                    return false;
                                }

                                if (new Regex("\\[System.Text.Json.Serialization.JsonPropertyName\\(\"[a-zA-Z0-9_]*\"\\)\\]").IsMatch(reqCodeSourceCode))
                                {
                                    lstError.Add(new Exception($"[风格] 源代码 \"{reqCodeFileName}\" 下代码有误，请求模型为简单请求、不应包含可 JSON 序列化字段。"));
                                    return false;
                                }
                            }
                        }

                        return true;
                    }
                    bool TryCheckResponseModelSourceCode(string filePath, string expectedRequestMethod, string expectedRequestUrl)
                    {
                        if (!File.Exists(filePath))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{filePath}\" 不存在。"));
                            return false;
                        }

                        string resCodeFileName = Path.GetFileName(filePath);
                        string resCodeSourceCode = File.ReadAllText(filePath);

                        // 匹配 <para> ... </para> 结构
                        var regexPara = new Regex("<para(([\\s\\S])*?)</para>").Match(resCodeSourceCode);
                        if (!regexPara.Success)
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{resCodeFileName}\" 下文档注释不齐全，未能匹配到 \"<para> ... </para>\"。"));
                            return false;
                        }

                        // 匹配 [...] ... 结构
                        var regexApi = new Regex("\\[(\\S*)\\]\\s*(\\S*)").Match(regexPara.Groups[1].Value);
                        if (!regexApi.Success)
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{resCodeFileName}\" 下文档注释不齐全，未能匹配到 \"异步调用 ... 接口\"。"));
                            return false;
                        }

                        // 比对请求谓词
                        string actualMethod = regexApi.Groups[1].Value.Trim();
                        if (!string.Equals(expectedRequestMethod, actualMethod, StringComparison.OrdinalIgnoreCase))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{resCodeFileName}\" 下文档注释有误，与实际接口谓词不一致。"));
                            return false;
                        }

                        // 对比请求路由
                        string actualUrl = regexApi.Groups[2].Value.Split('?')[0].Trim();
                        if (!string.Equals(expectedRequestUrl, actualUrl, StringComparison.OrdinalIgnoreCase))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{resCodeFileName}\" 下文档注释有误，与实际接口路由不一致。"));
                            return false;
                        }

                        // 检验是否包含 `string.Empty` 的赋值
                        if (new Regex("=\\s*string.Empty").IsMatch(resCodeSourceCode))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{resCodeFileName}\" 下代码有误，响应模型不应包含 `= string.Empty` 赋值。"));
                            return false;
                        }

                        // 检验是否包含 `new class()` 的赋值
                        if (new Regex("=\\s*new\\s[a-zA-Z0-9.]*\\(\\)").IsMatch(resCodeSourceCode))
                        {
                            if (!(CODESTYLE_RULE_REGEX_NO_INSTANTIATED_PROPERTY_IN_RESPONSE.IsMatch(resCodeSourceCode)))
                            {
                                lstError.Add(new Exception($"[风格] 源代码 \"{resCodeFileName}\" 下代码有误，响应模型不应包含 `= new class()` 赋值。"));
                                return false;
                            }
                        }

                        // 检验是否包含列表类型字段
                        if (new Regex("public\\s*IList<[a-zA-Z0-9.]*>\\s*[a-zA-Z0-9]*\\s*{\\s*get;\\s*set;\\s*}").IsMatch(resCodeSourceCode))
                        {
                            lstError.Add(new Exception($"[风格] 源代码 \"{resCodeFileName}\" 下代码有误，响应模型不应包含列表类型字段。"));
                            return false;
                        }

                        return true;
                    }

                    if (!TryCheckExtensionSourceCode(segments[i], out var request))
                    {
                        continue;
                    }
                    else
                    {
                        string reqModelFileName = lstModelsCodeFile.FirstOrDefault(e => string.Equals(Path.GetFileNameWithoutExtension(e), $"{request.Value.Name}Request"));
                        string resModelFileName = lstModelsCodeFile.FirstOrDefault(e => string.Equals(Path.GetFileNameWithoutExtension(e), $"{request.Value.Name}Response"));
                        bool isValidReq = TryCheckRequestModelSourceCode(reqModelFileName, request.Value.Method, request.Value.Url);
                        bool isValidRes = TryCheckResponseModelSourceCode(resModelFileName, request.Value.Method, request.Value.Url);
                        if (!isValidReq || !isValidRes)
                        {
                            continue;
                        }
                    }
                }
            }

            if (lstError.Any())
            {
                exception = new AggregateException(lstError);
                return false;
            }

            exception = null;
            return true;
        }
    }
}
