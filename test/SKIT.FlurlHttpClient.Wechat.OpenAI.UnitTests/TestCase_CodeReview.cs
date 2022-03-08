using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
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
                    AssemblyName = "SKIT.FlurlHttpClient.Wechat.OpenAI",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkSubDirectoryForApiModels = "Models/Platform",
                    WorkSubDirectoryForApiEvents = "Events/Platform",
                    WorkSubDirectoryForApiMethods = "Extensions/Platform",
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    WorkSubDirectoryForApiModelSamples = "ModelSamples/Platform",
                    WorkSubDirectoryForApiEventSamples = "EventSamples/Platform",
                    TargetSdkApiModelNamespaceUnderAssemblyIdentifier = "Models.Platform",
                    TargetSdkApiEventNamespaceUnderAssemblyIdentifier = "Events.Platform",
                    AllowNotFoundEventTypes = true,
                    AllowNotFoundEventSamples = true
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));


            Assert.Null(Record.Exception(() =>
            {
                CodeAnalyzerOptions options = new CodeAnalyzerOptions()
                {
                    AssemblyName = "SKIT.FlurlHttpClient.Wechat.OpenAI",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkSubDirectoryForApiModels = "Models/ThirdParty",
                    WorkSubDirectoryForApiEvents = "Events/ThirdParty",
                    WorkSubDirectoryForApiMethods = "Extensions/ThirdParty",
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    WorkSubDirectoryForApiModelSamples = "ModelSamples/ThirdParty",
                    WorkSubDirectoryForApiEventSamples = "EventSamples/ThirdParty",
                    TargetSdkApiModelNamespaceUnderAssemblyIdentifier = "Models.ThirdParty",
                    TargetSdkApiEventNamespaceUnderAssemblyIdentifier = "Events.ThirdParty",
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
