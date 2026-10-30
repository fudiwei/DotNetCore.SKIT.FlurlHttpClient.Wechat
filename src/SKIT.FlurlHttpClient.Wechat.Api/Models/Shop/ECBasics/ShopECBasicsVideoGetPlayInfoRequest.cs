namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /shop/ec/basics/video/getplayinfo 接口的请求。</para>
    /// </summary>
    public class ShopECBasicsVideoGetPlayInfoRequest : WechatApiRequest, IInferable<ShopECBasicsVideoGetPlayInfoRequest, ShopECBasicsVideoGetPlayInfoResponse>
    {
        /// <summary>
        /// 获取或设置文件上传标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? VideoUploadKey { get; set; }
    }
}
