using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Controllers
{
    using SKIT.FlurlHttpClient.Wechat.Security;
    using SKIT.FlurlHttpClient.Wechat.Api.Events;

    [ApiController]
    [Route("notify")]
    public class WechatNotifyController : ControllerBase
    {
        private readonly ILogger _logger;

        private readonly Options.WechatOptions _wechatOptions;

        private readonly Services.HttpClients.IWechatApiHttpClientFactory _wechatApiHttpClientFactory;

        public WechatNotifyController(
            ILoggerFactory loggerFactory,
            IOptions<Options.WechatOptions> wechatOptions,
            Services.HttpClients.IWechatApiHttpClientFactory wechatApiHttpClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _wechatOptions = wechatOptions.Value;
            _wechatApiHttpClientFactory = wechatApiHttpClientFactory;
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

            var client = _wechatApiHttpClientFactory.Create(appId);
            bool valid = client.VerifyEventSignature(
                callbackTimestamp: timestamp,
                callbackNonce: nonce,
                callbackSignature: signature
            );
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

            var client = _wechatApiHttpClientFactory.Create(appId);
            var msgType = client.DeserializeEventFromXml(content).MessageType;
            switch (msgType)
            {
                case "TEXT":
                    {
                        var eventModel = client.DeserializeEventFromXml<TextMessageEvent>(content);
                        // Do Something
                    }
                    break;

                case "IMAGE":
                    {
                        var eventModel = client.DeserializeEventFromXml<ImageMessageEvent>(content);
                        // Do Something
                    }
                    break;
            }

            return Content("success");
        }
    }
}
