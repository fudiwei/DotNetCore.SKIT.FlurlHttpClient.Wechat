using System;
using System.IO;
using System.Reflection;
using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.UnitTests
{
    public class CodeAnalyzeTests
    {
        [Fact(DisplayName = "代码质量分析")]
        public void TestCodeAnalyzer()
        {
            // NOTICE:
            //   如果 Visual Studio 遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
            //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatTenpayBusinessClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayBusiness",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Events",
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
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatTenpayBusinessClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Events",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.Wechat.TenpayBusiness/"),
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.Wechat.TenpayBusiness.UnitTests/"),
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundWebhookEventClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true,
                    ThrowOnNotFoundWebhookEventSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options).AssertNoIssues();
            }));
        }
    }
}
