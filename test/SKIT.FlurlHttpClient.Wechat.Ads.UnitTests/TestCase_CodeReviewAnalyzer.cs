using System.IO;
using System.Reflection;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Ads.UnitTests
{
    public class TestCase_CodeReviewAnalyzer
    {
        private Assembly SourceAssembly { get; } = Assembly.Load("SKIT.FlurlHttpClient.Wechat.Ads");

        [Fact(DisplayName = "代码评审：分析 API 模型命名")]
        public void TestApiModelsNaming()
        {
            CodeStyleUtil.VerifyApiModelsNaming(SourceAssembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "代码评审：分析 API 模型定义")]
        public void TestApiModelsDefinition()
        {
            string workdir = Path.Combine(TestConfigs.ProjectTestDirectory, "ModelSamples");
            CodeStyleUtil.VerifyApiModelsDefinition(SourceAssembly, workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "代码评审：分析 API 接口命名")]
        public void TestApiExtensionsNaming()
        {
            CodeStyleUtil.VerifyApiExtensionsNaming(SourceAssembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "代码评审：分析代码规范")]
        public void TestCodeStyle()
        {
            string workdir = Path.Combine(TestConfigs.ProjectSourceDirectory);
            CodeStyleUtil.VerifySourceCodeStyle(workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }
    }
}
