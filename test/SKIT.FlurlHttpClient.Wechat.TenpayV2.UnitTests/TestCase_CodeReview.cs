using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    public class TestCase_CodeReview
    {
        [Fact(DisplayName = "测试用例：代码质量分析")]
        public void TestCodeAnalyzer()
        {
            Assert.Null(Record.Exception(() =>
            {
                CodeAnalyzerOptions options = new CodeAnalyzerOptions()
                {
                    AssemblyName = "SKIT.FlurlHttpClient.Wechat.TenpayV2",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    AllowNotFoundEventTypes = true,
                    AllowNotFoundEventSamples = true
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));
        }
    }
}
