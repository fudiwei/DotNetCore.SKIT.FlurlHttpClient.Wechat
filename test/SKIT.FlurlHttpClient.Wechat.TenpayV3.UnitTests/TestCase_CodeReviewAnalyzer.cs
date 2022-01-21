using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_CodeReviewAnalyzer
    {
        private Assembly SourceAssembly { get; } = Assembly.Load("SKIT.FlurlHttpClient.Wechat.TenpayV3");

        [Fact(DisplayName = "代码评审：分析 API 模型命名")]
        public void ApiModelsNamingTest()
        {
            CodeStyleUtil.VerifyApiModelsNaming(SourceAssembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "代码评审：分析 API 模型定义")]
        public void ApiModelsDefinitionTest()
        {
            string workdir = Path.Combine(TestConfigs.ProjectTestDirectory, "ModelSamples");
            CodeStyleUtil.VerifyApiModelsDefinition(SourceAssembly, workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "代码评审：分析 API 事件定义")]
        public void ApiEventsDefinitionTest()
        {
            string workdir = Path.Combine(TestConfigs.ProjectTestDirectory, "EventSamples");
            CodeStyleUtil.VerifyApiEventsDefinition(SourceAssembly, workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "代码评审：分析 API 接口命名")]
        public void ApiExtensionsNamingTest()
        {
            CodeStyleUtil.VerifyApiExtensionsNaming(SourceAssembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "代码评审：分析代码规范")]
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
