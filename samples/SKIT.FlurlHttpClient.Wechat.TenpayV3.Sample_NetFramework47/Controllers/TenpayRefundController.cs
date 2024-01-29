namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Controllers
{
    [RoutePrefix("api/refund")]
    public class TenpayRefundController : ApiController
    {
        private readonly Services.HttpClients.IWechatTenpayClientFactory _wechatTenpayClientFactory;

        public TenpayRefundController(
            Services.HttpClients.IWechatTenpayClientFactory wechatTenpayClientFactory)
        {
            _wechatTenpayClientFactory = wechatTenpayClientFactory;
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> CreateRefund([FromBody] Models.CreateRefundRequest requestModel, CancellationToken cancellationToken)
        {
            if (requestModel == null)
                return BadRequest();

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
                NotifyUrl = Options.TenpayOptions.Instance.Value.NotifyUrl
            };
            var response = await client.ExecuteCreateRefundDomesticRefundAsync(request, cancellationToken);
            if (!response.IsSuccessful())
            {
                Debug.WriteLine(
                    "申请退款失败（状态码：{0}，错误代码：{1}，错误描述：{2}）。",
                    response.GetRawStatus(), response.ErrorCode, response.ErrorMessage
                );
            }

            return Json(response);
        }
    }
}
