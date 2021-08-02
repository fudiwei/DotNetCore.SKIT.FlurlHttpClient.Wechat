using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests
{
    public class WechatApiEventDeserializationTests
    {
        [Fact(DisplayName = "获取事件消息类型")]
        public void GetEventMessageTypeTest()
        {
            string xml = "<xml><ToUserName><![CDATA[toUser]]></ToUserName><FromUserName><![CDATA[fromUser]]></FromUserName><CreateTime>1348831860</CreateTime><MsgType><![CDATA[text]]></MsgType><Content><![CDATA[this is a test]]></Content><MsgId>1234567890123456</MsgId></xml>";

            var xDoc = XDocument.Parse(xml);
            string msgType = xDoc.Root!.Element("MsgType")!.Value;

            Assert.Equal("TEXT", msgType, ignoreCase: true);

            var eventModel = TestClients.Instance.DeserializeEventFromXml(xml);
            Assert.Equal("TEXT", eventModel.MessageType, ignoreCase: true);
        }

        [Fact(DisplayName = "反序列化 TEXT 事件")]
        public void DeserializeTextMessageEventTest()
        {
            string xml = "<xml><ToUserName><![CDATA[toUser]]></ToUserName><FromUserName><![CDATA[fromUser]]></FromUserName><CreateTime>1348831860</CreateTime><MsgType><![CDATA[text]]></MsgType><Content><![CDATA[this is a test]]></Content><MsgId>1234567890123456</MsgId></xml>";

            var eventModel = TestClients.Instance.DeserializeEventFromXml<Events.TextMessageEvent>(xml);

            Assert.Equal("fromUser", eventModel.FromUserName);
            Assert.Equal("toUser", eventModel.ToUserName);
            Assert.Equal("text", eventModel.MessageType);
            Assert.Equal(1234567890123456L, eventModel.MessageId);
            Assert.Equal("this is a test", eventModel.Content);
        }
    }
}
