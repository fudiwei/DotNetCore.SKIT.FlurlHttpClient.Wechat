namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/downloadbill 接口的响应。</para>
    /// </summary>
    public class NontaxDownloadBillResponse : WechatApiResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes?.Length > 0;
        }
    }
}
