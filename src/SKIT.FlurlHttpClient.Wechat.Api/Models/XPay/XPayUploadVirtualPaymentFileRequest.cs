namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/upload_vp_file 接口的请求。</para>
    /// </summary>
    public class XPayUploadVirtualPaymentFileRequest : XPayRequestBase, IInferable<XPayUploadVirtualPaymentFileRequest, XPayUploadVirtualPaymentFileResponse>
    {
        /// <summary>
        /// 获取或设置经过 Base64 编码的图片文件内容。与字段 <seealso cref="ImageUrl"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base64_img")]
        [System.Text.Json.Serialization.JsonPropertyName("base64_img")]
        public string? EncodedImageFile { get; set; }

        /// <summary>
        /// 获取或设置图片文件 URL。与字段 <seealso cref="EncodedImageFile"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_url")]
        [System.Text.Json.Serialization.JsonPropertyName("img_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 获取或设置文件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_name")]
        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        protected internal override string GetRequestPath()
        {
            return "/xpay/upload_vp_file";
        }
    }
}
