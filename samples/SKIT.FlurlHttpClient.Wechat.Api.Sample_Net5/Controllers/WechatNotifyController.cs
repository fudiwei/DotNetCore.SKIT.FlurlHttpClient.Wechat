using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Controllers
{
    using SKIT.FlurlHttpClient.Wechat.Security;

    [ApiController]
    [Route("notify")]
    public class WechatNotifyController : ControllerBase
    {
        private readonly ILogger _logger;

        private readonly Options.WechatOptions _wechatOptions;

        public WechatNotifyController(
            ILoggerFactory loggerFactory,
            IOptions<Options.WechatOptions> wechatOptions)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _wechatOptions = wechatOptions.Value;
        }

        [HttpGet]
        [Route("message-push")]
        public IActionResult VerifyMessage(
            [FromQuery(Name = "app_id")] string? appId,
            [FromQuery(Name = "signature")] string? signature,
            [FromQuery(Name = "timestamp")] string? timestamp,
            [FromQuery(Name = "nonce")] string? nonce,
            [FromQuery(Name = "echostr")] string? echoString)
        {
            // 验证服务器推送
            // 文档：https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Access_Overview.html

            var wechatAccount = _wechatOptions.Accounts?.FirstOrDefault(e => e.AppId == appId);
            if (wechatAccount == null)
                return Content("fail");

            ISet<string> set = new SortedSet<string>() { _wechatOptions.CallbackToken, timestamp!, nonce! };
            string sign = SHA1Utility.Hash(string.Concat(set));
            if (!string.Equals(sign, signature, StringComparison.InvariantCultureIgnoreCase))
                return Content("fail");

            return Content(echoString);
        }

        [HttpPost]
        [Route("message-push")]
        public async Task<IActionResult> ReceiveMessage()
        {
            // 接收服务器推送
            // 文档：https://developers.weixin.qq.com/miniprogram/dev/framework/server-ability/message-push.html

            using var reader = new StreamReader(Request.Body, Encoding.UTF8);
            string content = await reader.ReadToEndAsync();
            _logger.LogInformation("接收到微信推送的数据：{0}", content);

            return Content("success");
        }
    }
}
