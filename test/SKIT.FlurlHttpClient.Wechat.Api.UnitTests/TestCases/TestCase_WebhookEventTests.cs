namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases
{
    public class TestCase_WebhookEventTests
    {
        [Fact(DisplayName = "测试用例：验签并解密 XML 回调数据")]
        public void TestVerifyEventXml()
        {
            const string evMsgSig = "477715d11cdb4164915debcba66cb864d751f3e6";
            const string evTimeStamp = "1409659813";
            const string evNonce = "1372623149";
            const string evXml = "<xml><ToUserName><![CDATA[wx5823bf96d3bd56c7]]></ToUserName><Encrypt><![CDATA[RypEvHKD8QQKFhvQ6QleEB4J58tiPdvo+rtK1I9qca6aM/wvqnLSV5zEPeusUiX5L5X/0lWfrf0QADHHhGd3QczcdCUpj911L3vg3W/sYYvuJTs3TUUkSUXxaccAS0qhxchrRYt66wiSpGLYL42aM6A8dTT+6k4aSknmPj48kzJs8qLjvd4Xgpue06DOdnLxAUHzM6+kDZ+HMZfJYuR+LtwGc2hgf5gsijff0ekUNXZiqATP7PF5mZxZ3Izoun1s4zG4LUMnvw2r+KqCKIw+3IQH03v+BCA9nMELNqbSf6tiWSrXJB3LAVGUcallcrw8V2t9EL4EhzJWrQUax5wLVMNS0+rUPA3k22Ncx4XXZS9o0MBH27Bo6BpNelZpS+/uh9KsNlY6bHCmJU9p8g7m3fVKn28H3KDYA5Pl/T8Z1ptDAVe0lXdQ2YoyyH2uyPIGHBZZIs2pDBS8R07+qN+E7Q==]]></Encrypt></xml>";

            using var mockClient = new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = "wx5823bf96d3bd56c7",
                PushEncodingAESKey = "jWmYm7qr5nMoAUwZRjGtBxmz3KA1tkAj3ykkR6q2B2C",
                PushToken = "QDG6eK"
            });

            var eventModel = mockClient.DeserializeEventFromXml<Events.TextMessageEvent>(evXml);
            Assert.True(mockClient.VerifyEventSignatureFromXml(evTimeStamp, evNonce, evXml, evMsgSig));
            Assert.Equal("text", eventModel.MessageType, ignoreCase: true);
            Assert.Equal("hello", eventModel.Content);
            Assert.Equal("wx5823bf96d3bd56c7", eventModel.ToUserName);
            Assert.Equal("mycreate", eventModel.FromUserName);
        }

        [Fact(DisplayName = "测试用例：获取事件消息类型")]
        public void TestGetEventMessageType()
        {
            const string evXml = "<xml><ToUserName><![CDATA[toUser]]></ToUserName><FromUserName><![CDATA[fromUser]]></FromUserName><CreateTime>1348831860</CreateTime><MsgType><![CDATA[text]]></MsgType><Content><![CDATA[this is a test]]></Content><MsgId>1234567890123456</MsgId></xml>";

            using var mockClient = new WechatApiClient(new WechatApiClientOptions());

            var eventModel = mockClient.DeserializeEventFromXml(evXml);
            Assert.Equal("TEXT", eventModel.MessageType, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：反序列化 TEXT 事件")]
        public void TestDeserializeTextMessageEvent()
        {
            const string evXml = "<xml><ToUserName><![CDATA[toUser]]></ToUserName><FromUserName><![CDATA[fromUser]]></FromUserName><CreateTime>1348831860</CreateTime><MsgType><![CDATA[text]]></MsgType><Content><![CDATA[this is a test]]></Content><MsgId>1234567890123456</MsgId></xml>";

            using var mockClient = new WechatApiClient(new WechatApiClientOptions());

            var eventModel = mockClient.DeserializeEventFromXml<Events.TextMessageEvent>(evXml);
            Assert.Equal("fromUser", eventModel.FromUserName);
            Assert.Equal("toUser", eventModel.ToUserName);
            Assert.Equal("text", eventModel.MessageType);
            Assert.Equal(1234567890123456L, eventModel.MessageId);
            Assert.Equal("this is a test", eventModel.Content);
        }
    }
}
