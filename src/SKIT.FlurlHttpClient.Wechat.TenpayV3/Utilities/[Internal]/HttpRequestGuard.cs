namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    internal static class HttpRequestGuard
    {
        public static void ThrowIfUnsetPathVariable(string? varValue, string varName)
        {
            if (string.IsNullOrEmpty(varValue))
                throw new ArgumentException($"Bad request, missing path variable: \"{NormalizePathName(varName)}\".");
        }

        public static void ThrowIfUnsetPathVariable(long? varValue, string varName)
        {
            if (varValue.GetValueOrDefault() == 0)
                throw new ArgumentException($"Bad request, missing path variable: \"{NormalizePathName(varName)}\".");
        }

        private static string NormalizePathName(string varName)
        {
            if (varName is not null && !varName.StartsWith("{") && !varName.EndsWith("}"))
                varName = "{" + varName + "}";
            return varName ?? "{}";
        }
    }
}
