﻿using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Controllers
{
    [ApiController]
    [Route("api/notify")]
    public class TenpayNotifyController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly Services.HttpClients.IWechatTenpayHttpClientFactory _tenpayHttpClientFactory;

        public TenpayNotifyController(
            ILoggerFactory loggerFactory,
            Services.HttpClients.IWechatTenpayHttpClientFactory tenpayHttpClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _tenpayHttpClientFactory = tenpayHttpClientFactory;
        }


        [HttpPost]
        [Route("m-{merchant_id}/message-push")]
        public async Task<IActionResult> ReceiveMessage(
            [FromRoute(Name = "merchant_id")] string merchantId,
            [FromHeader(Name = "Wechatpay-Timestamp")] string timestamp,
            [FromHeader(Name = "Wechatpay-Nonce")] string nonce,
            [FromHeader(Name = "Wechatpay-Signature")] string signature,
            [FromHeader(Name = "Wechatpay-Serial")] string serialNumber)
        {
            using var reader = new StreamReader(Request.Body, Encoding.UTF8);
            string content = await reader.ReadToEndAsync();
            _logger.LogInformation("接收到微信支付推送的数据：{0}", content);

            var client = _tenpayHttpClientFactory.Create(merchantId);
            bool valid = client.VerifyEventSignature(
                callbackTimestamp: timestamp,
                callbackNonce: nonce,
                callbackBody: content,
                callbackSignature: signature,
                callbackSerialNumber: serialNumber
            );
            if (!valid)
            {
                // NOTICE:
                //   需提前注入 CertificateManager、并添加平台证书，才可以使用扩展方法执行验签操作。
                //   有关 CertificateManager 的用法请参阅《开发文档 / 高级技巧 / 如何验证回调通知事件签名？》。
                //   后续如何解密并反序列化，请参阅《开发文档 / 高级技巧 / 如何解密回调通知事件中的敏感数据？》。

                return new JsonResult(new { code = "FAIL", message = "验签失败" });
            }

            return new JsonResult(new { code = "SUCCESS", message = "成功" });
        }
    }
}
