using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Controllers
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;

    [RoutePrefix("api/order")]
    public class TenpayOrderController : ApiController
    {
        private readonly Services.HttpClients.IWechatTenpayClientFactory _wechatTenpayClientFactory;

        public TenpayOrderController(
            Services.HttpClients.IWechatTenpayClientFactory wechatTenpayClientFactory)
        {
            _wechatTenpayClientFactory = wechatTenpayClientFactory;
        }

        [HttpPost]
        [Route("jsapi")]
        public async Task<IHttpActionResult> CreateOrderByJsapi([FromBody] Models.CreateOrderByJsapiRequest requestModel, CancellationToken cancellationToken)
        {
            if (requestModel == null)
                return BadRequest();

            using (var client = _wechatTenpayClientFactory.Create(requestModel.MerchantId))
            {
                var request = new CreatePayTransactionJsapiRequest()
                {
                    OutTradeNumber = "SAMPLE_OTN_" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssfff"),
                    AppId = requestModel.AppId,
                    Description = "演示订单",
                    NotifyUrl = Options.TenpayOptions.Instance.Value.NotifyUrl,
                    Amount = new CreatePayTransactionJsapiRequest.Types.Amount() { Total = requestModel.Amount },
                    Payer = new CreatePayTransactionJsapiRequest.Types.Payer() { OpenId = requestModel.OpenId }
                };
                var response = await client.ExecuteCreatePayTransactionJsapiAsync(request, cancellationToken);
                if (!response.IsSuccessful())
                {
                    Debug.WriteLine(
                        "JSAPI 下单失败（状态码：{0}，错误代码：{1}，错误描述：{2}）。",
                        response.GetRawStatus(), response.ErrorCode, response.ErrorMessage
                    );
                }

                return Json(response);
            }
        }
    }
}
