using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
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
                    AssemblyName = "SKIT.FlurlHttpClient.Wechat.Api",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));
        }
    }
}
