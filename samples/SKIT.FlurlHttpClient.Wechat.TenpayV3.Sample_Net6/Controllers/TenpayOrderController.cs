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
    [Route("api/order")]
    public class TenpayOrderController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly Options.TenpayOptions _tenpayOptions;
        private readonly Services.HttpClients.IWechatTenpayClientFactory _wechatTenpayClientFactory;

        public TenpayOrderController(
            ILoggerFactory loggerFactory,
            IOptions<Options.TenpayOptions> tenpayOptions,
            Services.HttpClients.IWechatTenpayClientFactory wechatTenpayClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _tenpayOptions = tenpayOptions.Value;
            _wechatTenpayClientFactory = wechatTenpayClientFactory;
        }

        [HttpPost]
        [Route("jsapi")]
        public async Task<IActionResult> CreateOrderByJsapi([FromBody] Models.CreateOrderByJsapiRequest requestModel)
        {
            using var client = _wechatTenpayClientFactory.Create(requestModel.MerchantId);
            var request = new CreatePayTransactionJsapiRequest()
            {
                OutTradeNumber = "SAMPLE_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                AppId = requestModel.AppId,
                Description = "演示订单",
                NotifyUrl = _tenpayOptions.NotifyUrl,
                Amount = new CreatePayTransactionJsapiRequest.Types.Amount() { Total = requestModel.Amount },
                Payer = new CreatePayTransactionJsapiRequest.Types.Payer() { OpenId = requestModel.OpenId }
            };
            var response = await client.ExecuteCreatePayTransactionJsapiAsync(request, cancellationToken: HttpContext.RequestAborted);
            if (!response.IsSuccessful())
            {
                _logger.LogWarning(
                    "JSAPI 下单失败（状态码：{0}，错误代码：{1}，错误描述：{2}）。",
                    response.GetRawStatus(), response.ErrorCode, response.ErrorMessage
                );
            }

            return new JsonResult(response);
        }
    }
}
