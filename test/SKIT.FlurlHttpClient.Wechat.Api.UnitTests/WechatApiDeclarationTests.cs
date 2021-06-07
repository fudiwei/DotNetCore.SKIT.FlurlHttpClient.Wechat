using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiDeclarationTests
    {
        private static readonly Assembly _assembly = Assembly.Load("SKIT.FlurlHttpClient.Wechat.Api");

        [Fact(DisplayName = "验证 API 模型命名")]
        public void ApiModelsNamingTest()
        {
            TestAssertUtil.VerifyApiModelsNaming(_assembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 模型定义")]
        public void ApiModelsDefinitionTest()
        {
            string workdir = Path.Combine(TestConfigs.ProjectTestDirectory, "ModelSamples");
            Assert.True(Directory.Exists(workdir));

            TestAssertUtil.VerifyApiModelsDefinition(_assembly, workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 事件定义")]
        public void ApiEventsDefinitionTest()
        {
            string workdir = Path.Combine(TestConfigs.ProjectTestDirectory, "EventSamples");
            Assert.True(Directory.Exists(workdir));

            TestAssertUtil.VerifyApiEventsDefinition(_assembly, workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 接口命名")]
        public void ApiExtensionsNamingTest()
        {
            TestAssertUtil.VerifyApiExtensionsNaming(_assembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 接口文档注释")]
        public void ApiExtensionsDocumentationTest()
        {
            string workdir = Path.Combine(TestConfigs.ProjectSourceDirectory, "Extensions");
            Assert.True(Directory.Exists(workdir));

            TestAssertUtil.VerifyApiExtensionsSourceCodeStyle(workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }
    }
}
