namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /statements 接口的响应。</para>
    /// </summary>
    public class DownloadHKStatementsResponse : WechatTenpayResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes.Length > 0;
        }
    }
}
