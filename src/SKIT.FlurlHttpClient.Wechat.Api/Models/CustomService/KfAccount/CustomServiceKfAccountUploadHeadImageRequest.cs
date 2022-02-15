namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /customservice/kfaccount/uploadheadimg 接口的请求。</para>
    /// </summary>
    public class CustomServiceKfAccountUploadHeadImageRequest : WechatApiRequest, IMapResponse<CustomServiceKfAccountUploadHeadImageRequest, CustomServiceKfAccountUploadHeadImageResponse>
    {
        /// <summary>
        /// 获取或设置客服账号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string KfAccount { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置客服头像图片文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] HeadImageFileBytes { get; set; } = new byte[0];
    }
}
