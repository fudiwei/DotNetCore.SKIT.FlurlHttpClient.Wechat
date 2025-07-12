using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants
{
    internal class AssemblyProps
    {
        public static readonly string VERSION = Assembly.GetAssembly(typeof(AssemblyProps))!.GetName()!.Version!.ToString();
    }
}
