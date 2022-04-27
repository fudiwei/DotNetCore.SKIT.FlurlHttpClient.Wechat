namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /{download_url} 接口的响应。</para>
    /// </summary>
    public class DownloadMSEPayAccountBillResponse : WechatTenpayBusinessResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes?.Length > 0;
        }
    }
}
