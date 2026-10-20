using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
    using SKIT.FlurlHttpClient.Tools.CodeAnalyzer.Helpers;

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
                var options = TypeDeclarationAnalyzerOptions.LoadFromClient(typeof(WechatApiClient));
                options.ReportOnMissingSDKModels = true;
                options.ReportOnMissingSDKMethods = true;
                options.ReportOnMissingSDKWebhooks = true;

                var analyzer = new TypeDeclarationAnalyzer(options)
                    .AddRule("addon/model-require-inferable", (ctx) =>
                    {
                        IList<TypeDeclarationAnalysisIssue> results = new List<TypeDeclarationAnalysisIssue>();

                        foreach (TypeDeclarationAnalysisUnit unit in ctx.UnitsOfSDKModels)
                        {
                            if (unit.Kind != TypeDeclarationKind.RequestModel)
                                continue;

                            string reqTypeName = unit.GetMemberAsType().GetNameWithoutGenerics();
                            string respTypeName = Regex.Replace(unit.GetMemberAsType().GetNameWithoutGenerics(), "Request$", "Response");
                            Type? inferType = unit.GetMemberAsType().GetInterfaces()
                                .Where(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Models.IInferable<,>))
                                .Where(t => t.GenericTypeArguments[0].GetNameWithoutGenerics() == reqTypeName)
                                .Where(t => t.GenericTypeArguments[1].GetNameWithoutGenerics() == respTypeName)
                                .FirstOrDefault();
                            if (inferType is null)
                                results.Add(new TypeDeclarationAnalysisIssue(string.Empty, "请求模型未正确实现 IInferable 接口", unit));
                        }

                        return results;
                    });

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

                var options = StaticFileAnalyzerOptions.LoadFromClient(typeof(WechatApiClient));
                options.ProjectRootPath = Path.Combine(projDir, "./src/SKIT.FlurlHttpClient.Wechat.Api/");
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
