using System;
using System.Collections;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    internal static class ReflectionUtility
    {
        public delegate string ReplacePropertyStringValueReplacement(object obj, PropertyInfo prop, string value);

        public static void ReplacePropertyStringValue<T>(ref T obj, ReplacePropertyStringValueReplacement replacement)
        {
            InnerReplacePropertyStringValue(ref obj, replacement, null);
        }

        private static void InnerReplacePropertyStringValue<T>(ref T obj, ReplacePropertyStringValueReplacement replacement, PropertyInfo? currentProp)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (replacement == null) throw new ArgumentNullException(nameof(replacement));

            Type objType = obj.GetType();
            if (!objType.IsClass)
                throw new NotSupportedException();

            if (objType.IsArray)
            {
                var array = (obj as Array)!;
                for (int i = 0, len = array.Length; i < len; i++)
                {
                    object? element = array.GetValue(i);
                    if (element is null)
                        continue;

                    Type elementType = element.GetType();
                    if (elementType == typeof(string))
                    {
                        if (currentProp == null)
                            continue;

                        string oldValue = (string)element!;
                        string newValue = replacement(obj, currentProp, oldValue);
                        array.SetValue(newValue, i);
                    }
                    else if (elementType.IsClass)
                    {
                        InnerReplacePropertyStringValue(ref element, replacement, currentProp);
                        array.SetValue(element, i);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (obj is IList list)
            {
                for (int i = 0, len = list.Count; i < len; i++)
                {
                    object? element = list[i];
                    if (element is null)
                        continue;

                    Type elementType = element.GetType();
                    if (elementType == typeof(string))
                    {
                        if (currentProp == null)
                            continue;

                        string oldValue = (string)element!;
                        string newValue = replacement(obj, currentProp, oldValue);
                        list[i] = newValue;
                    }
                    else if (elementType.IsClass)
                    {
                        InnerReplacePropertyStringValue(ref element, replacement, currentProp);
                        list[i] = element;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (obj is IDictionary dict)
            {
                foreach (DictionaryEntry entry in dict)
                {
                    object? entryValue = entry.Value;
                    if (entryValue is null)
                        continue;

                    Type entryValueType = entryValue.GetType();
                    if (entryValueType == typeof(string))
                    {
                        if (currentProp == null)
                            continue;

                        string oldValue = (string)entryValue!;
                        string newValue = replacement(obj, currentProp, oldValue);
                        dict[entry.Key] = newValue;
                    }
                    else if (entryValueType.IsClass)
                    {
                        InnerReplacePropertyStringValue(ref entryValue, replacement, currentProp);
                        dict[entry.Key] = entryValue;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                foreach (var childProp in objType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if (!childProp.CanWrite)
                        continue;

                    Type propType = childProp.PropertyType;
                    if (propType == typeof(string))
                    {
                        object? value = childProp.GetValue(obj, null);
                        if (value is null)
                            continue;

                        string oldValue = (string)value!;
                        string newValue = replacement(obj, childProp, oldValue);
                        childProp.SetValue(obj, newValue);
                    }
                    else if (propType.IsClass)
                    {
                        object? value = childProp.GetValue(obj, null);
                        if (value is null)
                            continue;

                        InnerReplacePropertyStringValue(ref value, replacement, childProp);
                        childProp.SetValue(obj, value);
                    }
                }
            }
        }
    }
}
