using System;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    internal static class ReflectionUtility
    {
        public static void CreateOrExpandArray(ref Array? array, Type elementType, int capacity)
        {
            if (elementType == null) throw new ArgumentNullException(nameof(elementType));
            if (capacity <= 0) throw new ArgumentOutOfRangeException(nameof(capacity));

            if (array == null)
            {
                array = Array.CreateInstance(elementType, capacity);
            }
            else if (array.Length < capacity)
            {
                Array tmpArray = Array.CreateInstance(elementType, capacity);
                Array.Copy(array, tmpArray, array.Length);
                array = tmpArray;
            }
        }

        public static void CreateOrExpandArrayElement(Array array, int index, Func<object, object>? updateFactory)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (index < 0 || index >= array.Length) throw new ArgumentOutOfRangeException(nameof(index));
            if (updateFactory == null) throw new ArgumentNullException(nameof(updateFactory));

            object? element = array.GetValue(index);
            if (element is null)
            {
                Type elementType = array.GetType().GetElementType()!;

                if (elementType.IsAbstract || elementType.IsInterface)
                {
                    throw new NotSupportedException();
                }
                else if (elementType.IsArray)
                {
                    element = Array.CreateInstance(elementType, 0);
                }
                else
                {
                    element = Activator.CreateInstance(elementType);
                }
            }

            element = updateFactory(element!);
            array.SetValue(element, index);
        }

        public static bool CheckTypeIsSubclassOf(Type childType, Type baseType)
        {
            bool IsTheRawGenericType(Type type)
                => baseType == (type.IsGenericType ? type.GetGenericTypeDefinition() : type);

            bool isTheRawGenericType = childType.GetInterfaces().Any(IsTheRawGenericType);
            if (isTheRawGenericType)
                return true;

            Type? t = childType;
            while (t != null && t != typeof(object))
            {
                isTheRawGenericType = IsTheRawGenericType(t);
                if (isTheRawGenericType) return true;
                t = t.BaseType;
            }

            return false;
        }
    }
}
