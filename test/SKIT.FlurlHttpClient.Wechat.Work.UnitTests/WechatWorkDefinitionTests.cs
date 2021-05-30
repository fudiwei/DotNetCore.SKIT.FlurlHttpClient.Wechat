using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    public class WechatWorkDefinitionTests
    {
        private static readonly Assembly _assembly = Assembly.Load("SKIT.FlurlHttpClient.Wechat.Work");

        [Fact(DisplayName = "验证模型定义")]
        public void ModelDefinitionsTest()
        {
            static void TrySetPropertiesValueRecursively(object obj)
            {
                var lstProperty = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (var tProperty in lstProperty)
                {
                    if (tProperty.SetMethod == null || !tProperty.SetMethod.IsPublic)
                        continue;

                    var newtonsoftJsonAttribute = tProperty.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>();
                    var systemTextJsonAttribute = tProperty.GetCustomAttribute<System.Text.Json.Serialization.JsonPropertyNameAttribute>();
                    if (newtonsoftJsonAttribute?.PropertyName != systemTextJsonAttribute?.Name)
                        throw new Exception($"`{obj.GetType().Name}` fields mismatching: `{newtonsoftJsonAttribute.PropertyName}` & `{systemTextJsonAttribute.Name}`");

                    if (tProperty.PropertyType.IsPrimitive)
                    {
                        // noop
                    }
                    else if (tProperty.PropertyType.IsArray)
                    {
                        Type tEl = tProperty.PropertyType.Assembly.GetType(tProperty.PropertyType.FullName.Replace("[]", string.Empty));
                        object propEl = (tEl == typeof(string)) ? string.Empty : Activator.CreateInstance(tEl);
                        propEl = Convert.ChangeType(propEl, tEl);
                        TrySetPropertiesValueRecursively(propEl);

                        Array prop = Array.CreateInstance(tEl, 1);
                        prop.SetValue(propEl, 0);

                        tProperty.SetValue(obj, prop);
                    }
                    else if (tProperty.PropertyType == typeof(string))
                    {
                        tProperty.SetValue(obj, string.Empty);
                    }
                    else if (tProperty.PropertyType.Namespace == "System" &&
                             tProperty.PropertyType.Name.StartsWith("Nullable"))
                    {
                        // noop
                    }
                    else if (tProperty.PropertyType.Namespace == "System.Collections.Generic" &&
                            (tProperty.PropertyType.Name.StartsWith("IDictionary") || tProperty.PropertyType.Name.StartsWith("Dictionary")))
                    {
                        // noop
                    }
                    else if (tProperty.PropertyType.Namespace == "System.Collections.Generic" &&
                            (tProperty.PropertyType.Name.StartsWith("IList") || tProperty.PropertyType.Name.StartsWith("List")))
                    {
                        Type tGeneric = tProperty.PropertyType.GetGenericArguments().Single();
                        object propEl = (tGeneric == typeof(string)) ? string.Empty : Activator.CreateInstance(tGeneric);
                        propEl = Convert.ChangeType(propEl, tGeneric);
                        TrySetPropertiesValueRecursively(propEl);

                        Type tList = typeof(List<>).MakeGenericType(new Type[] { tGeneric });
                        object prop = Activator.CreateInstance(tList);

                        tList.GetMethod("Add").Invoke(prop, new[] { propEl });

                        tProperty.SetValue(obj, prop);
                    }
                    else
                    {
                        object prop = Activator.CreateInstance(tProperty.PropertyType);
                        TrySetPropertiesValueRecursively(prop);

                        tProperty.SetValue(obj, prop);
                    }
                }
            };

            var lstModel = _assembly.GetTypes()
                .Where(e =>
                    e.Namespace != null &&
                    e.Namespace.Equals(_assembly.GetName().Name + ".Models") &&
                    e.IsClass &&
                    !e.IsAbstract &&
                    !e.IsInterface &&
                    !e.IsNested
                )
                .ToList();

            var exceptions = new List<Type>();

            foreach (Type tModel in lstModel)
            {
                // 模型命名结尾必为 Request 或 Response
                if (!tModel.Name.EndsWith("Request") && !tModel.Name.EndsWith("Response"))
                {
                    exceptions.Add(tModel);
                    continue;
                }

                // Request 必继承自 WechatTenpayRequest、且有同名 Response
                if (tModel.Name.EndsWith("Request"))
                {
                    if (!typeof(WechatWorkRequest).IsAssignableFrom(tModel))
                    {
                        exceptions.Add(tModel);
                        continue;
                    }

                    if (!lstModel.Any(e => e.Name == $"{tModel.Name.Substring(0, tModel.Name.Length - "Request".Length)}Response"))
                    {
                        exceptions.Add(tModel);
                        continue;
                    }
                }

                // Request 必继承自 WechatTenpayResponse、且有同名 Request
                if (tModel.Name.EndsWith("Response"))
                {
                    if (!typeof(WechatWorkResponse).IsAssignableFrom(tModel))
                    {
                        exceptions.Add(tModel);
                        continue;
                    }

                    if (!lstModel.Any(e => e.Name == $"{tModel.Name.Substring(0, tModel.Name.Length - "Response".Length)}Request"))
                    {
                        exceptions.Add(tModel);
                        continue;
                    }
                }

                // 递归构造模型，并尝试 JSON 序列化以检测是否有序列化问题
                try
                {
                    object instance = _assembly.CreateInstance(tModel.Namespace + "." + tModel.Name);
                    TrySetPropertiesValueRecursively(instance);

                    new FlurlNewtonsoftJsonSerializer().Serialize(instance);
                    new FlurlSystemTextJsonSerializer().Serialize(instance);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Serialize `{tModel.Name}` failed.", ex);
                }
            }

            Assert.Empty(exceptions);
        }

        [Fact(DisplayName = "验证接口定义")]
        public void InterfaceDefinitionsTest()
        {
            var lstInterface = _assembly.GetTypes()
                .Where(e =>
                    e.Namespace != null &&
                    e.Namespace.Equals(_assembly.GetName().Name) &&
                    e.Name.StartsWith("WechatTenpayClientExecute") &&
                    e.Name.EndsWith("Extensions")
                )
                .ToList();

            var exceptions = new List<MethodInfo>();

            foreach (Type tInterface in lstInterface)
            {
                var lstMethod = tInterface.GetMethods()
                    .Where(e => 
                        e.IsPublic &&
                        e.IsStatic &&
                        e.GetParameters().FirstOrDefault().ParameterType == typeof(WechatWorkClient)
                    )
                    .ToList();
                foreach (MethodInfo tMethod in lstMethod)
                {
                    var lstParam = tMethod.GetParameters();

                    // 参数签名必为 this client + request + cancelToken
                    if (lstParam.Length != 3)
                    {
                        exceptions.Add(tMethod);
                        continue;
                    }

                    // 第二个参数必为 WechatTenpayRequest 子类
                    if (!typeof(WechatWorkRequest).IsAssignableFrom(lstParam[1].ParameterType))
                    {
                        exceptions.Add(tMethod);
                        continue;
                    }

                    // 方法名与第二个参数、返回值均有相同命名
                    string func = tMethod.Name;
                    string para = lstParam[1].ParameterType.Name;
                    string retv = tMethod.ReturnType.GenericTypeArguments.FirstOrDefault()?.Name;
                    if (para == null || !para.EndsWith("Request"))
                    {
                        exceptions.Add(tMethod);
                        continue;
                    }
                    else if (retv == null || !retv.EndsWith("Response"))
                    {
                        exceptions.Add(tMethod);
                        continue;
                    }
                    else if (!string.Equals(func, $"Execute{para.Substring(0, para.Length - "Request".Length)}Async"))
                    {
                        exceptions.Add(tMethod);
                        continue;
                    }
                    else if (!string.Equals(func, $"Execute{retv.Substring(0, retv.Length - "Response".Length)}Async"))
                    {
                        exceptions.Add(tMethod);
                        continue;
                    }
                }
            }

            Assert.Empty(exceptions);
        }

        [Fact(DisplayName = "验证字段定义")]
        public void FieldDefinitionsTest()
        {
            var exceptions = new List<string>();

            string[] GetAllFiles(string path)
            {
                var results = new List<string>();

                string[] dirs = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                results.AddRange(files);

                foreach (string dir in dirs)
                {
                    results.AddRange(GetAllFiles(dir));
                }

                return results.ToArray();
            }

            void VerifyJsonSamples(string subdir, string subns)
            {
                string workdir = Path.Combine(Environment.CurrentDirectory, subdir);
                Assert.True(Directory.Exists(workdir));

                var lstFile = GetAllFiles(workdir)
                    .Where(e => string.Equals(Path.GetExtension(e), ".json", StringComparison.InvariantCultureIgnoreCase))
                    .ToList();
                Assert.NotEmpty(lstFile);

                foreach (string file in lstFile)
                {
                    string json = File.ReadAllText(file);
                    string name = Path.GetFileNameWithoutExtension(file);

                    Type type = _assembly.GetType($"{_assembly.GetName().Name}.{subns}.{name}");
                    if (type == null)
                    {
                        exceptions.Add(name);
                        continue;
                    }

                    try
                    {
                        var settings = FlurlNewtonsoftJsonSerializer.GetDefaultSerializerSettings();
                        settings.CheckAdditionalContent = true;
                        settings.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Error;
                        new FlurlNewtonsoftJsonSerializer(settings).Deserialize(json, type);

                        new FlurlSystemTextJsonSerializer().Deserialize(json, type);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(name);

                        if (ex is Newtonsoft.Json.JsonException)
                            throw new Exception($"Deserialize `{name}` by Newtonsoft.Json failed.", ex);
                        else if (ex is System.Text.Json.JsonException)
                            throw new Exception($"Deserialize `{name}` by System.Text.Json failed.", ex);
                        else
                            throw new Exception($"Deserialize `{name}` failed.", ex);
                    }
                }
            }

            VerifyJsonSamples("ModelSamples", "Models");

            Assert.Empty(exceptions);
        }
    }
}
