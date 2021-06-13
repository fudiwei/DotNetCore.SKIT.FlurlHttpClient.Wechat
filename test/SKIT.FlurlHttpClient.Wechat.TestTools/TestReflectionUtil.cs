using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat
{
    public static class TestReflectionUtil
    {
        public static Type[] GetAllApiModelsTypes(Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));

            return assembly.GetTypes()
                .Where(e =>
                    e.Namespace != null &&
                    e.Namespace.Equals(assembly.GetName().Name + ".Models") &&
                    e.IsClass &&
                    !e.IsAbstract &&
                    !e.IsInterface &&
                    !e.IsNested
                )
                .ToArray();
        }

        public static Type[] GetAllApiExtensionsTypes(Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));

            return assembly.GetTypes()
                .Where(e =>
                    e.Namespace != null &&
                    e.Namespace.Equals(assembly.GetName().Name) &&
                    e.Name.StartsWith("Wechat") &&
                    e.Name.Contains("ClientExecute") &&
                    e.Name.EndsWith("Extensions")
                )
                .ToArray();
        }

        public static Type[] GetAllApiEventsTypes(Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));

            return assembly.GetTypes()
                .Where(e =>
                    e.Namespace != null &&
                    e.Namespace.Equals(assembly.GetName().Name + ".Events") &&
                    e.IsClass &&
                    !e.IsAbstract &&
                    !e.IsInterface &&
                    !e.IsNested
                )
                .ToArray();
        }

        public static PropertyInfo[] GetAllProperties(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            static Type[] GetAllNestedTypes(Type externalType)
            {
                List<Type> lstType = new List<Type>();
                foreach (Type innerType in externalType.GetNestedTypes())
                {
                    if (innerType.IsClass)
                    {
                        lstType.Add(innerType);
                        lstType.AddRange(GetAllNestedTypes(innerType));
                    }
                }

                return lstType
                    .Where(e =>
                        !e.IsAbstract &&
                        e.IsNestedPublic
                    )
                    .ToArray();
            }

            var lstProperty = type.GetProperties(BindingFlags.Public | BindingFlags.Instance).ToList();
            GetAllNestedTypes(type)
                .ToList()
                .ForEach(e =>
                {
                    lstProperty.AddRange(GetAllProperties(e));
                });

            return lstProperty.Distinct().ToArray();
        }

        public static object InitializeProperties(object obj)
        {
            const int MAX_DEPTH = 10; // 防止无限递归
            int CUR_DEPTH = 0;

            Func<object, object> func = null;
            func = new Func<object, object>((obj) =>
            {
                CUR_DEPTH++;

                if (CUR_DEPTH >= MAX_DEPTH)
                    return obj;

                PropertyInfo[] lstPropInfo = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo propInfo in lstPropInfo)
                {
                    if (propInfo.SetMethod == null || !propInfo.SetMethod.IsPublic)
                        continue;

                    if (propInfo.PropertyType.IsPrimitive)
                    {
                        // noop
                    }
                    else if (propInfo.PropertyType.IsArray)
                    {
                        if (propInfo.PropertyType.FullName.Contains("[][]"))
                        {
                            // noop
                        }
                        else
                        {
                            Type elType = propInfo.PropertyType.Assembly.GetType(propInfo.PropertyType.FullName.Replace("[]", string.Empty));
                            object elObj = (elType == typeof(string)) ? string.Empty : Activator.CreateInstance(elType);
                            elObj = Convert.ChangeType(elObj, elType);
                            func(elObj);

                            Array prop = Array.CreateInstance(elType, 1);
                            prop.SetValue(elObj, 0);

                            propInfo.SetValue(obj, prop);
                        }
                    }
                    else if (propInfo.PropertyType == typeof(string))
                    {
                        propInfo.SetValue(obj, string.Empty);
                    }
                    else if (propInfo.PropertyType.Namespace == "System" &&
                             propInfo.PropertyType.Name.StartsWith("Nullable"))
                    {
                        // noop
                    }
                    else if (propInfo.PropertyType.Namespace == "System.Collections.Generic" &&
                            (propInfo.PropertyType.Name.StartsWith("IDictionary") || propInfo.PropertyType.Name.StartsWith("Dictionary")))
                    {
                        // noop
                    }
                    else if (propInfo.PropertyType.Namespace == "System.Collections.Generic" &&
                            (propInfo.PropertyType.Name.StartsWith("IList") || propInfo.PropertyType.Name.StartsWith("List")))
                    {
                        Type elElementType = propInfo.PropertyType.GetGenericArguments().Single();
                        object elElementObj = (elElementType == typeof(string)) ? string.Empty : Activator.CreateInstance(elElementType);
                        elElementObj = Convert.ChangeType(elElementObj, elElementType);
                        func(elElementObj);

                        Type elListType = typeof(List<>).MakeGenericType(new Type[] { elElementType });
                        object elListObj = Activator.CreateInstance(elListType);
                        elListType.GetMethod("Add").Invoke(elListObj, new[] { elElementObj });

                        propInfo.SetValue(obj, elListObj);
                    }
                    else
                    {
                        object elObj = Activator.CreateInstance(propInfo.PropertyType);
                        func(elObj);

                        propInfo.SetValue(obj, elObj);
                    }
                }

                return obj;
            });

            return func(obj);
        }
    }
}
