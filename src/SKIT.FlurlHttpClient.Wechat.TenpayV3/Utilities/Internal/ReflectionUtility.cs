using System;
using System.Collections;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    internal static class ReflectionUtility
    {
        public delegate (bool Modified, string NewValue) ReplacePropertyStringValueReplacementHandler(object target, PropertyInfo currentProp, string oldValue);

        public static void ReplacePropertyStringValue<T>(ref T obj, ReplacePropertyStringValueReplacementHandler replacement)
        {
            InnerReplacePropertyStringValue(ref obj, replacement);
        }

        private static void InnerReplacePropertyStringValue<T>(ref T obj, ReplacePropertyStringValueReplacementHandler replacement)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (replacement == null) throw new ArgumentNullException(nameof(replacement));

            Type objType = obj.GetType();
            if (!objType.IsClass)
                throw new NotSupportedException();

            if (objType.IsArray || obj is IList || obj is IDictionary)
            {
                InnerReplaceEachCollectionPropertyStringValue(ref obj, objType, replacement, null);
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
                        string oldValue = (string)childProp.GetValue(obj, null)!;
                        var result = replacement(obj, childProp, oldValue);
                        if (result.Modified)
                        {
                            childProp.SetValue(obj, result.NewValue);
                        }
                    }
                    else if (propType.IsClass)
                    {
                        object? value = childProp.GetValue(obj, null);
                        if (value is null)
                            continue;

                        InnerReplacePropertyStringValue(ref value, replacement);
                        childProp.SetValue(obj, value);
                    }
                    else
                    {
                        object? value = childProp.GetValue(obj, null);
                        if (value is null)
                            continue;

                        InnerReplaceEachCollectionPropertyStringValue(ref value, propType, replacement, childProp);
                    }
                }
            }
        }
        
        private static void InnerReplaceEachCollectionPropertyStringValue<T>(ref T obj, Type objType, ReplacePropertyStringValueReplacementHandler replacement, PropertyInfo? currentProp)
        {
            if (objType.IsArray)
            {
                var array = (obj as Array)!;
                if (array.IsReadOnly)
                    return;

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
                        if (!currentProp.CanWrite)
                            continue;

                        var oldValue = (string)element!;
                        var resHandler = replacement(obj!, currentProp, oldValue);
                        if (resHandler.Modified)
                        {
                            array.SetValue(resHandler.NewValue, i);
                        }
                    }
                    else if (elementType.IsClass)
                    {
                        InnerReplacePropertyStringValue(ref element, replacement);
                        array.SetValue(element, i);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (obj is IList)
            {
                var list = (obj as IList)!;
                if (list.IsReadOnly)
                    return;

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
                        if (!currentProp.CanWrite)
                            continue;

                        var oldValue = (string)element!;
                        var resHandler = replacement(obj, currentProp, oldValue);
                        if (resHandler.Modified)
                        {
                            list[i] = resHandler.NewValue;
                        }
                    }
                    else if (elementType.IsClass)
                    {
                        InnerReplacePropertyStringValue(ref element, replacement);
                        list[i] = element;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (obj is IDictionary)
            {
                var dict = (obj as IDictionary)!;
                if (dict.IsReadOnly)
                    return;

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
                        if (!currentProp.CanWrite)
                            continue;

                        string oldValue = (string)entryValue!;
                        var resHandler = replacement(obj, currentProp, oldValue);
                        if (resHandler.Modified)
                        {
                            dict[entry.Key] = resHandler.NewValue;
                        }
                    }
                    else if (entryValueType.IsClass)
                    {
                        InnerReplacePropertyStringValue(ref entryValue, replacement);
                        dict[entry.Key] = entryValue;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
