namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/media/get 接口的响应。</para>
    /// </summary>
    public class CgibinMediaGetResponse : WechatWorkResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes?.Length > 0;
        }
    }
}
