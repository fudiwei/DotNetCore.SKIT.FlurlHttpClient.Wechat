using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    internal static partial class ReflectionHelper
    {
        public static void ReplaceObjectStringProperties<T>(ref T targetObj, ReplaceObjectStringPropertiesReplacementDelegate replacement)
        {
            if (targetObj is null) throw new ArgumentNullException(nameof(targetObj));
            if (replacement is null) throw new ArgumentNullException(nameof(replacement));

            ISet<object> visited = new HashSet<object>(ReferenceEqualityComparer.Instance); // 处理循环引用问题
            InnerReplaceObjectStringProperties(ref targetObj, null, replacement, visited);
        }
    }

    partial class ReflectionHelper
    {
        public delegate (bool IsModified, string NewValue) ReplaceObjectStringPropertiesReplacementDelegate(object currentObj, PropertyInfo? currentProp, string oldValue);

        private static void InnerReplaceObjectStringProperties<T>(ref T currentObj, PropertyInfo? currentProp, ReplaceObjectStringPropertiesReplacementDelegate replacement, ISet<object> visited)
        {
            if (currentObj is null) throw new ArgumentNullException(nameof(currentObj));
            if (replacement is null) throw new ArgumentNullException(nameof(replacement));

            if (!visited.Add(currentObj)) return;

            Type type = currentObj.GetType();

            // 跳过基元类型、枚举类型、抽象或接口类型，及部分 CLR 内置类型
            if (type.IsPrimitive ||
                type.IsEnum ||
                type.IsAbstract ||
                type.IsInterface ||
                type == typeof(Guid) ||
                type == typeof(DateTime) ||
                type == typeof(DateTimeOffset) ||
#if NET5_0_OR_GREATER
                type == typeof(DateOnly) ||
                type == typeof(TimeOnly) ||
#endif
                type == typeof(TimeSpan))
            {
                return;
            }

            // 处理数组类型
            if (type.IsArray)
            {
                Array currentObjAsArray = (currentObj as Array)!;
                for (int i = 0; i < currentObjAsArray.Length; i++)
                {
                    object? element = currentObjAsArray.GetValue(i);
                    if (element is null)
                        continue;

                    Type elementType = element.GetType();
                    if (elementType == typeof(string))
                    {
                        if (currentObjAsArray.IsReadOnly)
                            continue;
                        if ((string)element == string.Empty)
                            continue;

                        var res = replacement(currentObjAsArray, currentProp, (string)element);
                        if (res.IsModified)
                            currentObjAsArray.SetValue(res.NewValue, i);
                    }
                    else
                    {
                        InnerReplaceObjectStringProperties(ref element, currentProp, replacement, visited);
                    }
                }

                return;
            }

            // 处理列表类型
            if (currentObj is IList)
            {
                IList currentObjAsList = (IList)currentObj;
                for (int i = 0; i < currentObjAsList.Count; i++)
                {
                    object? element = currentObjAsList[i];
                    if (element is null)
                        continue;

                    Type elementType = element.GetType();
                    if (elementType == typeof(string))
                    {
                        if (currentObjAsList.IsReadOnly)
                            continue;
                        if ((string)element == string.Empty)
                            continue;

                        var res = replacement(currentObjAsList, currentProp, (string)element);
                        if (res.IsModified)
                            currentObjAsList[i] = res.NewValue;
                    }
                    else
                    {
                        InnerReplaceObjectStringProperties(ref element, currentProp, replacement, visited);
                    }
                }

                return;
            }

            // 处理字典类型
            if (currentObj is IDictionary)
            {
                IDictionary currentObjAsDictionary = (IDictionary)currentObj;
                foreach (DictionaryEntry entry in currentObjAsDictionary)
                {
                    object? entryValue = entry.Value;
                    if (entryValue is null)
                        continue;

                    Type entryValueType = entryValue.GetType();
                    if (entryValueType == typeof(string))
                    {
                        if (currentObjAsDictionary.IsReadOnly)
                            continue;
                        if ((string)entryValue == string.Empty)
                            continue;

                        var res = replacement(currentObjAsDictionary, currentProp, (string)entryValue);
                        if (res.IsModified)
                            currentObjAsDictionary[entry.Key] = res.NewValue;
                    }
                    else
                    {
                        InnerReplaceObjectStringProperties(ref entryValue, currentProp, replacement, visited);
                    }
                }

                return;
            }

            // 遍历属性
            foreach (PropertyInfo property in GetWritableProperties(type))
            {
                Type propertyType = property.PropertyType;
                if (propertyType == typeof(string))
                {
                    string? propertyValue = GetPropertyValue<string>(currentObj, property);
                    if (propertyValue is null || propertyValue == string.Empty)
                        continue;

                    var res = replacement(currentObj, property, propertyValue);
                    if (res.IsModified)
                        SetPropertyValue(currentObj, property, res.NewValue);
                }
                else
                {
                    object? propertyValue = GetPropertyValue<object>(currentObj, property);
                    if (propertyValue is null)
                        continue;

                    InnerReplaceObjectStringProperties(ref propertyValue, property, replacement, visited);
                }
            }
        }
    }

    partial class ReflectionHelper
    {
        private static readonly IDictionary<Type, PropertyInfo[]> _propsCache = new Dictionary<Type, PropertyInfo[]>(capacity: 128);
        private static readonly Hashtable _getterCache = new Hashtable(capacity: 128);
        private static readonly Hashtable _setterCache = new Hashtable(capacity: 128);

        private static PropertyInfo[] GetWritableProperties(Type type)
        {
            if (type is null) throw new ArgumentNullException(nameof(type));

            if (!_propsCache.TryGetValue(type, out PropertyInfo[]? properties))
            {
                properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(e => e.CanRead && e.CanWrite)
                    .ToArray();
                _propsCache[type] = properties;
            }

            return properties;
        }

        private static T? GetPropertyValue<T>(object targetObj, PropertyInfo property)
        {
            // 提供比 PropertyInfo.GetValue() 更快的属性取值方法
            // 只可针对热点类型使用，否则可能会更慢

            if (targetObj is null) throw new ArgumentNullException(nameof(targetObj));
            if (property is null) throw new ArgumentNullException(nameof(property));

            if (!property.CanRead)
                throw new InvalidOperationException($"Property '{property.Name}' of type '{typeof(T).FullName}' does not have a getter.");

            Func<object, T>? getter = _getterCache[property] as Func<object, T>;
            if (getter is null)
            {
                ParameterExpression targetExpr = Expression.Parameter(typeof(object));
                UnaryExpression castTargetExpr = Expression.Convert(targetExpr, targetObj.GetType());
                MemberExpression getPropertyValueExpr = Expression.Property(castTargetExpr, property);
                UnaryExpression castPropertyValueExpr = Expression.Convert(getPropertyValueExpr, typeof(T));
                getter = Expression.Lambda<Func<object, T>>(castPropertyValueExpr, targetExpr).Compile();
                _getterCache[property] = getter;
            }

            return getter.Invoke(targetObj);
        }

        private static void SetPropertyValue<T>(object targetObj, PropertyInfo property, T? value)
        {
            // 提供比 PropertyInfo.SetValue() 更快的属性赋值方法
            // 只可针对热点类型使用，否则可能会更慢

            if (targetObj is null) throw new ArgumentNullException(nameof(targetObj));
            if (property is null) throw new ArgumentNullException(nameof(property));

            if (!property.CanWrite)
                throw new InvalidOperationException($"Property '{property.Name}' of type '{typeof(T).FullName}' does not have a setter.");

            Action<object, T?>? setter = _setterCache[property] as Action<object, T?>;
            if (setter is null)
            {
                ParameterExpression targetExpr = Expression.Parameter(typeof(object));
                ParameterExpression propertyValueExpr = Expression.Parameter(typeof(T));
                UnaryExpression castTargetExpr = Expression.Convert(targetExpr, targetObj.GetType());
                UnaryExpression castPropertyValueExpr = Expression.Convert(propertyValueExpr, property.PropertyType);
                MethodCallExpression setPropertyValueExpr = Expression.Call(castTargetExpr, property.GetSetMethod()!, castPropertyValueExpr);
                setter = Expression.Lambda<Action<object, T?>>(setPropertyValueExpr, targetExpr, propertyValueExpr).Compile();
                _setterCache[property] = setter;
            }

            setter.Invoke(targetObj, value);
        }
    }

    partial class ReflectionHelper
    {
#if NET5_0_OR_GREATER
#else
        private sealed class ReferenceEqualityComparer : IEqualityComparer<object?>, IEqualityComparer
        {
            public static ReferenceEqualityComparer Instance { get; } = new ReferenceEqualityComparer();

            private ReferenceEqualityComparer() { }

            public new bool Equals(object? x, object? y) => ReferenceEquals(x, y);

            public int GetHashCode(object? obj) => RuntimeHelpers.GetHashCode(obj!);
        }
#endif
    }
}
