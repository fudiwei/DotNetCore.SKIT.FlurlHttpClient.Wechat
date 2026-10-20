using System;
using System.IO;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
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
                var options = TypeDeclarationAnalyzerOptions.LoadFromClient(typeof(WechatWorkClient));
                options.ReportOnMissingSDKModels = true;
                options.ReportOnMissingSDKMethods = true;
                options.ReportOnMissingSDKWebhooks = true;

                var analyzer = new TypeDeclarationAnalyzer(options);

                var issues = analyzer.Analyze();
                Assert.Empty(issues);
            });

            Assert.Multiple(() =>
            {
                var options = TypeDeclarationAnalyzerOptions.LoadFromClient(typeof(ExtendedSDK.AIBot.WechatWorkAIBotClient));
                options.ReportOnMissingSDKModels = true;
                options.ReportOnMissingSDKMethods = true;
                options.ReportOnMissingSDKWebhooks = true;

                var analyzer = new TypeDeclarationAnalyzer(options);

                var issues = analyzer.Analyze();
                Assert.Empty(issues);
            });

            Assert.Multiple(() =>
            {
                var options = TypeDeclarationAnalyzerOptions.LoadFromClient(typeof(ExtendedSDK.Finance.WechatWorkFinanceClient));
                options.IgnoreMethods = (_) => true;
                options.DisallowedRules = new string[]
                {
                    "type-declaration/no-unused-models",
                };
                options.ReportOnMissingSDKModels = true;

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

                var options = StaticFileAnalyzerOptions.LoadFromClient(typeof(WechatWorkClient));
                options.ProjectRootPath = Path.Combine(projDir, "./src/SKIT.FlurlHttpClient.Wechat.Work/");
                options.ReportOnMissingSDKModelsCodes = true;
                options.ReportOnMissingSDKModelsFixtures = true;
                options.ReportOnMissingSDKMethodsCodes = true;
                options.ReportOnMissingSDKWebhooksCodes = true;
                options.ReportOnMissingSDKWebhooksFixtures = true;

                var analyzer = new StaticFileAnalyzer(options);

                var issues = analyzer.Analyze();
                Assert.Empty(issues);
            });

            Assert.Multiple(() =>
            {
                string workDir = Environment.CurrentDirectory;
                string projDir = Path.Combine(workDir, "../../../../../");

                var options = StaticFileAnalyzerOptions.LoadFromClient(typeof(ExtendedSDK.AIBot.WechatWorkAIBotClient));
                options.ProjectRootPath = Path.Combine(projDir, "./src/SKIT.FlurlHttpClient.Wechat.Work/ExtendedSDK/AIBot/");
                options.ReportOnMissingSDKModelsCodes = true;
                options.ReportOnMissingSDKModelsFixtures = true;
                options.ReportOnMissingSDKMethodsCodes = true;
                options.ReportOnMissingSDKWebhooksCodes = true;
                options.ReportOnMissingSDKWebhooksFixtures = true;

                var analyzer = new StaticFileAnalyzer(options);

                var issues = analyzer.Analyze();
                Assert.Empty(issues);
            });

            Assert.Multiple(() =>
            {
                string workDir = Environment.CurrentDirectory;
                string projDir = Path.Combine(workDir, "../../../../../");

                var options = StaticFileAnalyzerOptions.LoadFromClient(typeof(ExtendedSDK.Finance.WechatWorkFinanceClient));
                options.ProjectRootPath = Path.Combine(projDir, "./src/SKIT.FlurlHttpClient.Wechat.Work/ExtendedSDK/Finance/");
                options.DisallowedRules = new string[]
                {
                    "static-file/model-documented",
                    "static-file/method-documented",
                };
                options.ReportOnMissingSDKModelsCodes = true;

                var analyzer = new StaticFileAnalyzer(options);

                var issues = analyzer.Analyze();
                Assert.Empty(issues);
            });
        }
    }
}
