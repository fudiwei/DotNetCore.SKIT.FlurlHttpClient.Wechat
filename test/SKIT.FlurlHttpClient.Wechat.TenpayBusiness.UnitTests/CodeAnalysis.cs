namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.UnitTests
{
    using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;

    public class CodeAnalysis
    {
        // NOTICE:
        //   如果在 Visual Studio 打开时遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
        //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

#if XUNIT3_OR_HIGHER
        private readonly ITestOutputHelper _outputHelper;

        public CodeAnalysis(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
#endif

        [Fact(DisplayName = "代码分析：类型声明")]
        public void CodeAnalysis_TypeDeclaration()
        {
            Assert.Multiple(() =>
            {
                var options = TypeDeclarationAnalyzerOptions.LoadFromClient(typeof(WechatTenpayBusinessClient));
                options.ReportOnMissingSDKModels = true;
                options.ReportOnMissingSDKMethods = true;
                options.ReportOnMissingSDKWebhooks = true;

                var analyzer = new TypeDeclarationAnalyzer(options);

                var issues = analyzer.Analyze();
#if DEBUG
                foreach (var issue in issues)
                {
#if XUNIT3_OR_HIGHER
                    _outputHelper.WriteLine(issue.ToString());
#endif
                }
#endif

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

                var options = StaticFileAnalyzerOptions.LoadFromClient(typeof(WechatTenpayBusinessClient));
                options.ProjectRootPath = Path.Combine(projDir, "./src/SKIT.FlurlHttpClient.Wechat.TenpayBusiness/");
                options.ReportOnMissingSDKModelsCodes = true;
                options.ReportOnMissingSDKModelsFixtures = true;
                options.ReportOnMissingSDKMethodsCodes = true;
                options.ReportOnMissingSDKWebhooksCodes = true;
                options.ReportOnMissingSDKWebhooksFixtures = true;

                var analyzer = new StaticFileAnalyzer(options);

                var issues = analyzer.Analyze();
#if DEBUG
                foreach (var issue in issues)
                {
#if XUNIT3_OR_HIGHER
                    _outputHelper.WriteLine(issue.ToString());
#endif
                }
#endif

                Assert.Empty(issues);
            });
        }
    }
}
