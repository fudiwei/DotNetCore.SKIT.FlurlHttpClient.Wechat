namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_upload_goods 接口的请求。</para>
    /// </summary>
    public class XPayQueryUploadGoodsRequest : XPayRequestBase, IInferable<XPayQueryUploadGoodsRequest, XPayQueryUploadGoodsResponse>
    {
        protected internal override string GetRequestPath()
        {
            return "/xpay/query_upload_goods";
        }
    }
}
