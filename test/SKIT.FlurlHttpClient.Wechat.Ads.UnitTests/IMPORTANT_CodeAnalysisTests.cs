using System;
using System.IO;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests
{
    using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;

    public class CodeAnalysisTests
    {
        // NOTICE:
        //   如果在 Visual Studio 打开时遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
        //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

        [Fact(DisplayName = "代码分析：类型声明")]
        public void CodeAnalysis_TypeDeclaration()
        {
            Assert.Multiple(() =>
            {
                var options = TypeDeclarationAnalyzerOptions.LoadFromClient(typeof(WechatAdsClient));
                options.ReportOnMissingSDKModels = true;
                options.ReportOnMissingSDKMethods = true;

                var analyzer = new TypeDeclarationAnalyzer(options);

                var issues = analyzer.Analyze();
                Assert.Empty(issues);
            });
        }

        [Fact(DisplayName = "代码分析：静态文件")]
        public void CodeAnalysis_StaticFile()
        {
            Assert.Multiple(() =>
            {
                string workDir = Environment.CurrentDirectory;
                string projDir = Path.Combine(workDir, "../../../../../");

                var options = StaticFileAnalyzerOptions.LoadFromClient(typeof(WechatAdsClient));
                options.ProjectRootPath = Path.Combine(projDir, "./src/SKIT.FlurlHttpClient.Wechat.Ads/");
                options.ReportOnMissingSDKModelsCodes = true;
                options.ReportOnMissingSDKModelsFixtures = true;
                options.ReportOnMissingSDKMethodsCodes = true;

                var analyzer = new StaticFileAnalyzer(options);

                var issues = analyzer.Analyze();
                Assert.Empty(issues);
            });
        }
    }
}
