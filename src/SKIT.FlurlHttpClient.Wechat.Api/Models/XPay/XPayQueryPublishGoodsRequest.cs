namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_publish_goods 接口的请求。</para>
    /// </summary>
    public class XPayQueryPublishGoodsRequest : XPayRequestBase, IInferable<XPayQueryPublishGoodsRequest, XPayQueryPublishGoodsResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/xpay/query_publish_goods";
        }
    }
}
