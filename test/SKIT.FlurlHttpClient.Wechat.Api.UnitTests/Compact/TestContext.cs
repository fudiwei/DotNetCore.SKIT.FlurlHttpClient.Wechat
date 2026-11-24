namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    internal class CompactTestContext
    {
        public readonly static CompactTestContext Current = new CompactTestContext();

        public CancellationToken CancellationToken
        {
            get
            {
#if XUNIT2
                return default;
#else
                return Xunit.TestContext.Current.CancellationToken;
#endif
            }
        }

        private CompactTestContext()
        {
        }
    }
}
