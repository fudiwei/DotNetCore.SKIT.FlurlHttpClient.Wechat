namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample.Models
{
    public class CreateOrderByJsapiRequest
    {
        public string MerchantId { get; set; }

        public string AppId { get; set; }

        public string OpenId { get; set; }

        // NOTICE:
        //   单机演示时金额来源于客户端请求，生产项目请改为服务端计算生成，切勿依赖客户端提供的金额结果。
        public int Amount { get; set; }
    }
}
