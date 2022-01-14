using System.IO;
using System.Reflection;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.UnitTests
{
    public class UnitTest_CodeReviewAnalyzer
    {
        private static readonly Assembly _assembly = Assembly.Load("SKIT.FlurlHttpClient.Wechat.TenpayV2");

        [Fact(DisplayName = "验证 API 模型命名")]
        public void ApiModelsNamingTest()
        {
            CodeStyleUtil.VerifyApiModelsNaming(_assembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 模型定义")]
        public void ApiModelsDefinitionTest()
        {
            string workdir = Path.Combine(TestConfigs.ProjectTestDirectory, "ModelSamples");
            CodeStyleUtil.VerifyApiModelsDefinition(_assembly, workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 接口命名")]
        public void ApiExtensionsNamingTest()
        {
            CodeStyleUtil.VerifyApiExtensionsNaming(_assembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证代码规范")]
        public void CodeStyleTest()
        {
            string workdir = Path.Combine(TestConfigs.ProjectSourceDirectory);
            CodeStyleUtil.VerifySourceCodeStyle(workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }
    }
}
