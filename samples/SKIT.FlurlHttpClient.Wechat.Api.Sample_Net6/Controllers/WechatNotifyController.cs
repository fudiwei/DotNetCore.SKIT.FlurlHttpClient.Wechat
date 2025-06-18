using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Controllers
{
    using SKIT.FlurlHttpClient.Wechat.Api.Events;

    [ApiController]
    [Route("api/notify")]
    public class WechatNotifyController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly Services.HttpClients.IWechatApiClientFactory _wechatApiClientFactory;

        public WechatNotifyController(
            ILoggerFactory loggerFactory,
            Services.HttpClients.IWechatApiClientFactory wechatApiClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _wechatApiClientFactory = wechatApiClientFactory;
        }

        [HttpGet]
        [Route("a-{app_id}/message-push")]
        public IActionResult VerifyMessage(
            [FromRoute(Name = "app_id")] string appId,
            [FromQuery(Name = "timestamp")] string timestamp,
            [FromQuery(Name = "nonce")] string nonce,
            [FromQuery(Name = "signature")] string signature,
            [FromQuery(Name = "echostr")] string echoString)
        {
            // 验证服务器推送
            // 文档：https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Access_Overview.html

            var client = _wechatApiClientFactory.Create(appId);
            bool valid = client.VerifyEventSignatureForEcho(webhookTimestamp: timestamp, webhookNonce: nonce, webhookSignature: signature);
            if (!valid)
            {
                return Content("fail");
            }

            return Content(echoString);
        }

        [HttpPost]
        [Route("a-{app_id}/message-push")]
        public async Task<IActionResult> ReceiveMessage(
            [FromRoute(Name = "app_id")] string appId)
        {
            // 接收服务器推送
            // 文档：https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Receiving_event_pushes.html

            using var reader = new StreamReader(Request.Body, Encoding.UTF8);
            string content = await reader.ReadToEndAsync();
            _logger.LogInformation("接收到微信推送的数据：{0}", content);

            var client = _wechatApiClientFactory.Create(appId);
            var msgType = client.DeserializeEventFromXml(content).MessageType?.ToUpper();
            switch (msgType)
            {
                case "TEXT":
                    {
                        var eventModel = client.DeserializeEventFromXml<TextMessageEvent>(content);
                        _logger.LogInformation("接收到微信推送的文本消息，消息内容：{0}", eventModel.Content);
                        // 后续处理略
                    }
                    break;

                case "IMAGE":
                    {
                        var eventModel = client.DeserializeEventFromXml<ImageMessageEvent>(content);
                        _logger.LogInformation("接收到微信推送的图片消息，图片链接：{0}", eventModel.PictureUrl);
                        // 后续处理略
                    }
                    break;

                default:
                    {
                        // 其他情况略
                    }
                    break;
            }

            return Content("success");
        }
    }
}
