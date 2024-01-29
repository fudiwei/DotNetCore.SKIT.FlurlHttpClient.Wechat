using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Controllers
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;

    [ApiController]
    [Route("api/refund")]
    public class TenpayRefundController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly Options.TenpayOptions _tenpayOptions;
        private readonly Services.HttpClients.IWechatTenpayClientFactory _wechatTenpayClientFactory;

        public TenpayRefundController(
            ILoggerFactory loggerFactory,
            IOptions<Options.TenpayOptions> tenpayOptions,
            Services.HttpClients.IWechatTenpayClientFactory wechatTenpayClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _tenpayOptions = tenpayOptions.Value;
            _wechatTenpayClientFactory = wechatTenpayClientFactory;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateRefund([FromBody] Models.CreateRefundRequest requestModel)
        {
            using var client = _wechatTenpayClientFactory.Create(requestModel.MerchantId);
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
                    response.GetRawStatus(), response.ErrorCode, response.ErrorMessage
                );
            }

            return new JsonResult(response);
        }
    }
}
