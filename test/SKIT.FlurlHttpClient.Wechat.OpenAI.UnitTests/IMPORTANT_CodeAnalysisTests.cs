using System;
using System.IO;
using System.Linq;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
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
                var options = TypeDeclarationAnalyzerOptions.LoadFromClient(typeof(WechatOpenAIClient));
                options.IgnoreTypes = (type) =>
                {
                    if (typeof(ICommonRequest).IsAssignableFrom(type))
                        return !typeof(WechatOpenAIRequest).IsAssignableFrom(type);

                    if (typeof(ICommonResponse).IsAssignableFrom(type))
                        return !typeof(WechatOpenAIResponse).IsAssignableFrom(type);

                    if (typeof(ICommonWebhookEvent).IsAssignableFrom(type))
                        return true;

                    return false;
                };
                options.IgnoreMethods = (method) =>
                {
                    return typeof(WechatOpenAIClient) != method.GetParameters().First().ParameterType;
                };
                options.DisallowedRules = new string[]
                {
                    "type-declaration/webhook-json-property-name-match",
                    "type-declaration/webhook-json-serializable",
                    "type-declaration/no-unused-models",
                };
                options.ReportOnMissingSDKModels = true;
                options.ReportOnMissingSDKMethods = true;

                var analyzer = new TypeDeclarationAnalyzer(options);

                var issues = analyzer.Analyze();
                Assert.Empty(issues);
            });

            Assert.Multiple(() =>
            {
                var options = TypeDeclarationAnalyzerOptions.LoadFromClient(typeof(WechatChatbotClient));
                options.IgnoreTypes = (type) =>
                {
                    if (typeof(ICommonRequest).IsAssignableFrom(type))
                        return !typeof(WechatChatbotRequest).IsAssignableFrom(type);

                    if (typeof(ICommonResponse).IsAssignableFrom(type))
                        return !typeof(WechatChatbotResponse).IsAssignableFrom(type);

                    if (typeof(ICommonWebhookEvent).IsAssignableFrom(type))
                        return !typeof(WechatChatbotEvent).IsAssignableFrom(type);

                    return false;
                };
                options.IgnoreMethods = (method) =>
                {
                    return typeof(WechatChatbotClient) != method.GetParameters().First().ParameterType;
                };
                options.ReportOnMissingSDKModels = true;
                options.ReportOnMissingSDKMethods = true;
                options.ReportOnMissingSDKWebhooks = true;

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

                var options = StaticFileAnalyzerOptions.LoadFromClient(typeof(WechatOpenAIClient));
                options.ProjectRootPath = Path.Combine(projDir, "./src/SKIT.FlurlHttpClient.Wechat.OpenAI/");
                options.ProjectSDKModelsCodeFolder = "Models/OpenAI";
                options.ProjectSDKModelsFixtureFolder = "ModelsFixtures/OpenAI";
                options.ProjectSDKWebhooksCodeFolder = "Events/OpenAI";
                options.ProjectSDKWebhooksFixtureFolder = "Events/OpenAI";
                options.IgnoreFiles = (file) =>
                {
                    if (file.FullName.Contains(Path.Combine("SKIT.FlurlHttpClient.Wechat.OpenAI", "Extensions")))
                        return !file.Name.StartsWith(nameof(WechatOpenAIClient));

                    return false;
                };
                options.DisallowedRules = new string[]
                {
                    "static-file/webhook-name-case",
                };
                options.ReportOnMissingSDKModelsCodes = true;
                options.ReportOnMissingSDKModelsFixtures = true;
                options.ReportOnMissingSDKMethodsCodes = true;

                var analyzer = new StaticFileAnalyzer(options);

                var issues = analyzer.Analyze();
                Assert.Empty(issues);
            });

            Assert.Multiple(() =>
            {
                string workDir = Environment.CurrentDirectory;
                string projDir = Path.Combine(workDir, "../../../../../");

                var options = StaticFileAnalyzerOptions.LoadFromClient(typeof(WechatChatbotClient));
                options.ProjectRootPath = Path.Combine(projDir, "./src/SKIT.FlurlHttpClient.Wechat.OpenAI/");
                options.ProjectSDKModelsCodeFolder = "Models/Chatbot";
                options.ProjectSDKModelsFixtureFolder = "ModelsFixtures/Chatbot";
                options.ProjectSDKWebhooksCodeFolder = "Events/Chatbot";
                options.ProjectSDKWebhooksFixtureFolder = "Events/Chatbot";
                options.IgnoreFiles = (file) =>
                {
                    if (file.FullName.Contains(Path.Combine("SKIT.FlurlHttpClient.Wechat.OpenAI", "Extensions")))
                        return !file.Name.StartsWith(nameof(WechatChatbotClient));

                    return false;
                };
                options.ReportOnMissingSDKModelsCodes = true;
                options.ReportOnMissingSDKModelsFixtures = true;
                options.ReportOnMissingSDKMethodsCodes = true;
                options.ReportOnMissingSDKWebhooksCodes = true;
                options.ReportOnMissingSDKWebhooksFixtures = true;

                var analyzer = new StaticFileAnalyzer(options);

                var issues = analyzer.Analyze();
                Assert.Empty(issues);
            });
        }
    }
}
