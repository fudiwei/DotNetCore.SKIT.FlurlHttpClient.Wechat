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
    public class TenpayRefundController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly Options.TenpayOptions _tenpayOptions;
        private readonly Services.HttpClients.IWechatTenpayHttpClientFactory _tenpayHttpClientFactory;

        public TenpayRefundController(
            ILoggerFactory loggerFactory,
            IOptions<Options.TenpayOptions> tenpayOptions,
            Services.HttpClients.IWechatTenpayHttpClientFactory tenpayHttpClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _tenpayOptions = tenpayOptions.Value;
            _tenpayHttpClientFactory = tenpayHttpClientFactory;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateRefund([FromBody] Models.CreateRefundRequest requestModel)
        {
            // 申请退款
            // 文档：https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_9.shtml

            var client = _tenpayHttpClientFactory.Create(requestModel.MerchantId);
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
                NotifyUrl = _tenpayOptions.NotifyUrl
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
