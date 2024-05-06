using System;
using System.IO;
using System.Reflection;
using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global;

    public class CodeAnalyzeTests
    {
        // NOTICE:
        //   如果 Visual Studio 遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
        //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

        [Fact(DisplayName = "代码质量分析")]
        public void CodeAnalyze()
        {
            Assert.Multiple(
                CodeAnalyze_BaseSDK,
                CodeAnalyze_ExtendedSDK_Global
            );
        }

        private void CodeAnalyze_BaseSDK()
        {
            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatTenpayClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Events",
                    IgnoreExecutingExtensionTypes = static type => type.Namespace!.Contains(".ExtendedSDK."),
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true,
                    ThrowOnNotFoundWebhookEventTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatTenpayClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Models",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.Events",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.Wechat.TenpayV3/"),
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests/"),
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/_/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/_/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/_/",
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundWebhookEventClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true,
                    ThrowOnNotFoundWebhookEventSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options)
                    .SetFileScanner(SourceFileContentKinds.WebhookEventClassCode, (directory) => directory.GetAllFiles("*.cs"))
                    .SetFileScanner(SourceFileContentKinds.WebhookEventSerializationSample, (directory) => directory.GetAllFiles("*.json"))
                    .AssertNoIssues();
            }));
        }

        private void CodeAnalyze_ExtendedSDK_Global()
        {
            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatTenpayGlobalClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global",
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatTenpayGlobalClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.Wechat.TenpayV3/"),
                    ProjectSourceRequestModelClassCodeSubDirectory = "ExtendedSDK/Global/Models/",
                    ProjectSourceResponseModelClassCodeSubDirectory = "ExtendedSDK/Global/Models/",
                    ProjectSourceExecutingExtensionClassCodeSubDirectory = "ExtendedSDK/Global/Extensions/",
                    ProjectSourceWebhookEventClassCodeSubDirectory = "ExtendedSDK/Global/Events/",
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests/"),
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/Global/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/Global/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/Global/",
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options).AssertNoIssues();
            }));
        }
    }
}
