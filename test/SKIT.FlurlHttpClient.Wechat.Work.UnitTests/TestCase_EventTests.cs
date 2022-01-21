using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    public class TestCase_EventTests
    {
        [Fact(DisplayName = "测试用例：验签并解密回调数据")]
        public void TestDeserializeEventFromXml()
        {
            string callbacMsgSig = "477715d11cdb4164915debcba66cb864d751f3e6";
            string callbacTimeStamp = "1409659813";
            string callbacNonce = "1372623149";
            string callbackXml = "<xml><ToUserName><![CDATA[wx5823bf96d3bd56c7]]></ToUserName><Encrypt><![CDATA[RypEvHKD8QQKFhvQ6QleEB4J58tiPdvo+rtK1I9qca6aM/wvqnLSV5zEPeusUiX5L5X/0lWfrf0QADHHhGd3QczcdCUpj911L3vg3W/sYYvuJTs3TUUkSUXxaccAS0qhxchrRYt66wiSpGLYL42aM6A8dTT+6k4aSknmPj48kzJs8qLjvd4Xgpue06DOdnLxAUHzM6+kDZ+HMZfJYuR+LtwGc2hgf5gsijff0ekUNXZiqATP7PF5mZxZ3Izoun1s4zG4LUMnvw2r+KqCKIw+3IQH03v+BCA9nMELNqbSf6tiWSrXJB3LAVGUcallcrw8V2t9EL4EhzJWrQUax5wLVMNS0+rUPA3k22Ncx4XXZS9o0MBH27Bo6BpNelZpS+/uh9KsNlY6bHCmJU9p8g7m3fVKn28H3KDYA5Pl/T8Z1ptDAVe0lXdQ2YoyyH2uyPIGHBZZIs2pDBS8R07+qN+E7Q==]]></Encrypt><AgentID><![CDATA[218]]></AgentID></xml>";

            var options = new WechatWorkClientOptions()
            {
                CorpId = "wx5823bf96d3bd56c7",
                PushEncodingAESKey = "jWmYm7qr5nMoAUwZRjGtBxmz3KA1tkAj3ykkR6q2B2C",
                PushToken = "QDG6eK"
            };
            var client = new WechatWorkClient(options);
            var eventModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(callbackXml);

            Assert.True(client.VerifyEventSignatureFromXml(callbacTimeStamp, callbacNonce, callbackXml, callbacMsgSig));
            Assert.Equal("text", eventModel.MessageType, ignoreCase: true);
            Assert.Equal("hello", eventModel.Content);
            Assert.Equal("wx5823bf96d3bd56c7", eventModel.ToUserName);
            Assert.Equal("mycreate", eventModel.FromUserName);
        }

        [Fact(DisplayName = "测试用例：验证微信服务器")]
        public void TestVerifyEventSignatureForEcho()
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
