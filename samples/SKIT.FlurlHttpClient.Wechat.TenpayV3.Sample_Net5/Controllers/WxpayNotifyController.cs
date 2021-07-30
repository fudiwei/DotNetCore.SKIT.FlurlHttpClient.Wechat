using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Controllers
{
    [ApiController]
    [Route("notify")]
    public class WxpayNotifyController : ControllerBase
    {
        private readonly ILogger _logger;
        public WxpayNotifyController(
            ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
        }


        [HttpPost]
        public async Task<IActionResult> ReceiveMessage()
        {
            // 接收服务器推送
            // 文档：https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_2.shtml

            using var reader = new StreamReader(Request.Body, Encoding.UTF8);
            string content = await reader.ReadToEndAsync();
            _logger.LogInformation("接收到微信支付推送的数据：{0}", content);

            return new JsonResult(new { code = "SUCCESS", message = "成功" });
        }
    }
}
