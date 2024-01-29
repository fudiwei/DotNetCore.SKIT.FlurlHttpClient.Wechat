using System;
using System.IO;
using System.Reflection;
using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests
{
    public class CodeAnalyzeTests
    {
        [Fact(DisplayName = "代码质量分析")]
        public void TestCodeAnalyzer()
        {
            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatAdsClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.Ads.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.Ads.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.Ads",
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
                    SdkAssembly = Assembly.GetAssembly(typeof(WechatAdsClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.Ads.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.Wechat.Ads.Models",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.Wechat.Ads/"),
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.Wechat.Ads.UnitTests/"),
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
