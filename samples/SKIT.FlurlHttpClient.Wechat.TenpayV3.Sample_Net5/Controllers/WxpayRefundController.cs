using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SKIT.FlurlHttpClient.Wechat.TenpayV3;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5.Controllers
{
    [ApiController]
    [Route("refund")]
    public class WxpayRefundController : ControllerBase
    {
        private readonly ILogger _logger;

        private readonly Options.WxpayOptions _wxpayOptions;

        private readonly Services.HttpClients.IWechatTenpayHttpClientFactory _wechatTenpayHttpClientFactory;

        public WxpayRefundController(
            ILoggerFactory loggerFactory,
            IOptions<Options.WxpayOptions> wxpayOptions,
            Services.HttpClients.IWechatTenpayHttpClientFactory wechatTenpayHttpClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _wxpayOptions = wxpayOptions.Value;
            _wechatTenpayHttpClientFactory = wechatTenpayHttpClientFactory;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateRefund([FromBody] Models.CreateRefundRequest requestModel)
        {
            // 申请退款
            // 文档：https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_9.shtml

            var client = _wechatTenpayHttpClientFactory.Create(requestModel.MerchantId);
            var request = new CreateRefundDomesticRefundRequest()
            {
                TransactionId = requestModel.TransactionId,
                OutRefundNumber = "SAMPLE_ORN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                Amount = new CreateRefundDomesticRefundRequest.Types.Amount()
                {
                    Total = requestModel.OrderAmount,
                    Refund = requestModel.RefundAmount
                },
                Reason = "示例退款",
                NotifyUrl = _wxpayOptions.CallbackUrl
            };
            var response = await client.ExecuteCreateRefundDomesticRefundAsync(request, cancellationToken: HttpContext.RequestAborted);
            if (!response.IsSuccessful())
            {
                _logger.LogWarning(
                    "申请退款失败（状态码：{0}，错误代码：{1}，错误描述：{2}）。",
                    response.RawStatus, response.ErrorCode, response.ErrorMessage
                );
            }

            return new JsonResult(response);
        }
    }
}
