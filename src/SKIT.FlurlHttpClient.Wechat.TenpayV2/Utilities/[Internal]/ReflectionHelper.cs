using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static class ReflectionHelper
    {
        private readonly static Hashtable _ctorCache = new Hashtable(capacity: 128);
        private readonly static Hashtable _getterCache = new Hashtable(capacity: 128);
        private readonly static Hashtable _setterCache = new Hashtable(capacity: 128);

        public static T CreateInstance<T>() where T : new()
        {
            // 提供比 new T() 或 Activator.CreateInstance<T>() 更快的无参实例化方法
            // 只可针对热点类型使用，否则可能会更慢

            Type type = typeof(T);

            Func<T>? ctor = _ctorCache[type] as Func<T>;
            if (ctor is null)
            {
                ctor = Expression.Lambda<Func<T>>(Expression.New(typeof(T))).Compile();
                _ctorCache[type] = ctor;
            }

            return ctor.Invoke();
        }

        public static T? GetPropertyValue<T>(object targetObj, PropertyInfo property)
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

        public static void SetPropertyValue<T>(object targetObj, PropertyInfo property, T? value)
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

        public static T? GetElementValue<T>(Array array, int index)
        {
            return (T?)array.GetValue(index);
        }

        public static void SetElementValue<T>(Array array, int index, T? element)
        {
            array.SetValue(element, index);
        }
    }
}
