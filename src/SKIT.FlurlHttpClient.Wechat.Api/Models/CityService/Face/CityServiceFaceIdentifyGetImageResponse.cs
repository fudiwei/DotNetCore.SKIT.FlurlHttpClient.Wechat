namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/face/identify/getimage 接口的响应。</para>
    /// </summary>
    public class CityServiceFaceIdentifyGetImageResponse : WechatApiResponse
    {
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && RawBytes?.Length > 0 && RawHeaders.ContainsKey("Content-Disposition");
        }
    }
}
