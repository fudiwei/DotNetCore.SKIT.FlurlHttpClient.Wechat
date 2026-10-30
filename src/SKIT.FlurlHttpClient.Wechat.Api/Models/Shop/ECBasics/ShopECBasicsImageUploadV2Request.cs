namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ec/basics/img/uploadv2 接口的请求。</para>
    /// </summary>
    public class ShopECBasicsImageUploadV2Request : WechatApiRequest, IInferable<ShopECBasicsImageUploadV2Request, ShopECBasicsImageUploadV2Response>
    {
        /// <summary>
        /// 获取或设置场景类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int SceneType { get; set; }

        /// <summary>
        /// 获取或设置图片文件字节数组。与字段 <see cref="ImageUrl"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[]? ImageFileBytes { get; set; }

        /// <summary>
        /// 获取或设置图片文件 URL。与字段 <see cref="ImageFileBytes"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_url")]
        [System.Text.Json.Serialization.JsonPropertyName("img_url")]
        public string? ImageUrl { get; set; }
    }
}
