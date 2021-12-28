namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Models
{
    public class CreateRefundRequest
    {
        public string MerchantId { get; set; }

        public string TransactionId { get; set; }

        // NOTICE:
        //   单机演示时金额来源于客户端请求，生产项目请改为服务端计算生成，切勿依赖客户端提供的金额结果。
        public int OrderAmount { get; set; }

        public int RefundAmount { get; set; }
    }
}
