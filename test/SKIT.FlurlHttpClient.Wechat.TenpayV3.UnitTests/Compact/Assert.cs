namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    internal static class CompactAssert
    {
        public static void SkipWhen(bool condition, string reason)
        {
#if XUNIT2
            if (condition) throw Xunit.Sdk.SkipException.ForSkip(reason);
#else
            Xunit.Assert.SkipWhen(condition, reason);
#endif
        }
    }
}
