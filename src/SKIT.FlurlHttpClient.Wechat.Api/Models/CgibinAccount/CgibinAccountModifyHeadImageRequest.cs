namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/account/modifyheadimage 接口的请求。</para>
    /// </summary>
    public class CgibinAccountModifyHeadImageRequest : WechatApiRequest, IInferable<CgibinAccountModifyHeadImageRequest, CgibinAccountModifyHeadImageResponse>
    {
        /// <summary>
        /// 获取或设置头像的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_img_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("head_img_media_id")]
        public string HeadImageMediaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置裁剪框左上角 X 坐标（范围：0～1）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("x1")]
        [System.Text.Json.Serialization.JsonPropertyName("x1")]
        public double X1 { get; set; }

        /// <summary>
        /// 获取或设置裁剪框左上角 Y 坐标（范围：0～1）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("y1")]
        [System.Text.Json.Serialization.JsonPropertyName("y1")]
        public double Y1 { get; set; }

        /// <summary>
        /// 获取或设置裁剪框右下角 X 坐标（范围：0～1）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("x2")]
        [System.Text.Json.Serialization.JsonPropertyName("x2")]
        public double X2 { get; set; }

        /// <summary>
        /// 获取或设置裁剪框右下角 Y 坐标（范围：0～1）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("y2")]
        [System.Text.Json.Serialization.JsonPropertyName("y2")]
        public double Y2 { get; set; }
    }
}
