using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat
{
    public static class TestAssertUtil
    {
        private static bool TryJsonize(string json, Type type, out Exception exception)
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
                    exception = new Exception($"通过 Newtonsoft.Json 反序列化 `{type.Name}` 失败。", ex);
                else if (ex is System.Text.Json.JsonException)
                    exception = new Exception($"通过 System.Text.Json 反序列化 `{type.Name}` 失败。", ex);
                else
                    exception = new Exception($"JSON 反序列化 `{type.Name}` 遇到问题。", ex);
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
                    exception = new Exception($"通过 Newtonsoft.Json 序列化 `{type.Name}` 失败。", ex);
                else if (ex is System.Text.Json.JsonException)
                    exception = new Exception($"通过 System.Text.Json 序列化 `{type.Name}` 失败。", ex);
                else
                    exception = new Exception($"JSON 序列化 `{type.Name}` 遇到问题。", ex);
            }

            PropertyInfo[] lstPropInfo = TestReflectionUtil.GetAllProperties(type);
            foreach (PropertyInfo propInfo in lstPropInfo)
            {
                var newtonsoftJsonAttribute = propInfo.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>();
                var systemTextJsonAttribute = propInfo.GetCustomAttribute<System.Text.Json.Serialization.JsonPropertyNameAttribute>();
                if (newtonsoftJsonAttribute?.PropertyName != systemTextJsonAttribute?.Name)
                    exception = new Exception($"类型 `{type.Name}` 的可 JSON 序列化字段声明不一致：`{newtonsoftJsonAttribute.PropertyName}` & `{systemTextJsonAttribute.Name}`。");
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
                    lstError.Add(new Exception($"`{name}` 类名结尾应为 \"Request\" 或 \"eponse\"。"));
                    continue;
                }

                if (name.EndsWith("Request"))
                {
                    if (!typeof(IWechatRequest).IsAssignableFrom(modelType))
                    {
                        lstError.Add(new Exception($"`{name}` 类需实现自 `IWechatRequest`。"));
                        continue;
                    }

                    if (!lstModelType.Any(e => e.Name == $"{name.Substring(0, name.Length - "Request".Length)}Response"))
                    {
                        lstError.Add(new Exception($"`{name}` 是请求模型，但不存在对应的响应模型。"));
                        continue;
                    }
                }

                if (name.EndsWith("Response"))
                {
                    if (!typeof(IWechatResponse).IsAssignableFrom(modelType))
                    {
                        lstError.Add(new Exception($"`{name}` 类需实现自 `IWechatResponse`。"));
                        continue;
                    }

                    if (!lstModelType.Any(e => e.Name == $"{name.Substring(0, name.Length - "Response".Length)}Request"))
                    {
                        lstError.Add(new Exception($"`{name}` 是响应模型，但不存在对应的请求模型。"));
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

            var lstFile = TestIOUtil.GetAllFiles(workdir)
                .Where(e => string.Equals(Path.GetExtension(e), ".json", StringComparison.InvariantCultureIgnoreCase))
                .ToList();
            if (!lstFile.Any())
            {
                lstError.Add(new Exception($"路径 \"{workdir}\" 下不存在 JSON 格式的模型示例文件，请检查路径是否正确。"));
            }

            foreach (string file in lstFile)
            {
                string json = File.ReadAllText(file);
                string name = Path.GetFileNameWithoutExtension(file).Split('.')[0];

                Type type = assembly.GetType($"{assembly.GetName().Name}.Models.{name}");
                if (type == null)
                {
                    lstError.Add(new Exception($"类型 `{name}`不存在。"));
                    continue;
                }

                if (!TryJsonize(json, type, out Exception ex))
                {
                    lstError.Add(ex);
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

            var lstJsonFile = TestIOUtil.GetAllFiles(workdir)
                .Where(e => string.Equals(Path.GetExtension(e), ".json", StringComparison.InvariantCultureIgnoreCase))
                .ToArray();
            var lstXmlFile = TestIOUtil.GetAllFiles(workdir)
                .Where(e => string.Equals(Path.GetExtension(e), ".xml", StringComparison.InvariantCultureIgnoreCase))
                .ToArray();
            if (!lstJsonFile.Any() && !lstXmlFile.Any())
            {
                lstError.Add(new Exception($"路径 \"{workdir}\" 下不存在 JSON 或 XML 格式的事件示例文件，请检查路径是否正确。"));
            }

            foreach (string file in lstJsonFile)
            {
                string json = File.ReadAllText(file);
                string name = Path.GetFileNameWithoutExtension(file).Split('.')[0];

                Type type = assembly.GetType($"{assembly.GetName().Name}.Events.{name}");
                if (type == null)
                {
                    lstError.Add(new Exception($"类型 `{name}`不存在。"));
                    continue;
                }

                if (!TryJsonize(json, type, out Exception ex))
                {
                    lstError.Add(ex);
                }
            }

            foreach (string file in lstXmlFile)
            {
                string xml = File.ReadAllText(file);
                string name = Path.GetFileNameWithoutExtension(file).Split('.')[0];

                Type type = assembly.GetType($"{assembly.GetName().Name}.Events.{name}");
                if (type == null)
                {
                    lstError.Add(new Exception($"类型 `{name}`不存在。"));
                    continue;
                }

                try
                {
                    using StringReader reader = new StringReader(xml);
                    XmlSerializer xmlSerializer = new XmlSerializer(type, new XmlRootAttribute("xml"));
                    xmlSerializer.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    exception = new Exception($"XML 反序列化 `{type.Name}` 遇到问题。", ex);
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

            foreach (Type extType in lstExtType)
            {
                MethodInfo[] lstMethod = extType.GetMethods()
                    .Where(e =>
                        e.IsPublic &&
                        e.IsStatic &&
                        typeof(IWechatClient).IsAssignableFrom(e.GetParameters().FirstOrDefault().ParameterType)
                    )
                    .ToArray();

                foreach (MethodInfo methodInfo in lstMethod)
                {
                    ParameterInfo[] lstParamInfo = methodInfo.GetParameters();

                    // 参数签名必为 this client + request + cancelToken
                    if (lstParamInfo.Length != 3)
                    {
                        lstError.Add(new Exception($"`{extType.Name}.{methodInfo.Name}` 方法需有且仅有 3 个入参。"));
                        continue;
                    }

                    // 第二个参数必为 IWechatRequest 子类
                    if (!typeof(IWechatRequest).IsAssignableFrom(lstParamInfo[1].ParameterType))
                    {
                        lstError.Add(new Exception($"`{extType.Name}.{methodInfo.Name}` 方法第 1 个入参需实现自 `IWechatRequest`。"));
                        continue;
                    }

                    // 方法名与第二个参数、返回值均有相同命名
                    string func = methodInfo.Name;
                    string para = lstParamInfo[1].ParameterType.Name;
                    string retv = methodInfo.ReturnType.GenericTypeArguments.FirstOrDefault()?.Name;
                    if (para == null || !para.EndsWith("Request"))
                    {
                        lstError.Add(new Exception($"`{extType.Name}.{methodInfo.Name}` 方法第 1 个入参类名应以 `Request` 结尾。"));
                        continue;
                    }
                    else if (retv == null || !retv.EndsWith("Response"))
                    {
                        if (!methodInfo.ReturnType.GenericTypeArguments.First().IsGenericType)
                        {
                            lstError.Add(new Exception($"`{extType.Name}.{methodInfo.Name}` 方法返回值类名应以 `Response` 结尾。"));
                        }
                        continue;
                    }
                    else if (!string.Equals(func, $"Execute{para.Substring(0, para.Length - "Request".Length)}Async"))
                    {
                        lstError.Add(new Exception($"`{extType.Name}.{methodInfo.Name}` 方法与请求模型应同名。"));
                        continue;
                    }
                    else if (!string.Equals(func, $"Execute{retv.Substring(0, retv.Length - "Response".Length)}Async"))
                    {
                        lstError.Add(new Exception($"`{extType.Name}.{methodInfo.Name}` 方法与响应模型应同名。"));
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
    }
}
