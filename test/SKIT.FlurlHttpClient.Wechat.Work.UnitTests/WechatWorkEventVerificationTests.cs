using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    public class WechatWorkEventVerificationTests
    {
        [Fact(DisplayName = "验证微信服务器")]
        public void GetEventMessageTypeTest()
        {
            string callbacMsgSig = "5c45ff5e21c57e6ad56bac8758b79b1d9ac89fd3";
            string callbacTimeStamp = "1409659589";
            string callbacNonce = "263014780";
            string callbackEcho = "P9nAzCzyDtyTWESHep1vC5X9xho/qYX3Zpb4yKa9SKld1DsH3Iyt3tP3zNdtp+4RPcs8TgAE7OaBO+FZXvnaqQ==";

            var options = new WechatWorkClientOptions()
            {
                CorpId = "wx5823bf96d3bd56c7",
                PushEncodingAESKey = "jWmYm7qr5nMoAUwZRjGtBxmz3KA1tkAj3ykkR6q2B2C",
                PushToken = "QDG6eK"
            };
            var client = new WechatWorkClient(options);

            Assert.True(client.VerifyEventSignatureForEcho(callbacTimeStamp, callbacNonce, callbackEcho, callbacMsgSig, out string replyEcho));
            Assert.Equal("1616140317555161061", replyEcho);
        }
    }
}
