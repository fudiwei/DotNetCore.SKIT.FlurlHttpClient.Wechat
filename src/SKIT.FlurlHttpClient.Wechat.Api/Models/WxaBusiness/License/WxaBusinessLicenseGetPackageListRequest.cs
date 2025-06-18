namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/license/getpkglist 接口的请求。</para>
    /// </summary>
    public class WxaBusinessLicenseGetPackageListRequest : WechatApiRequest, IInferable<WxaBusinessLicenseGetPackageListRequest, WxaBusinessLicenseGetPackageListResponse>
    {
        /// <summary>
        /// 获取或设置资源包类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pkg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("pkg_type")]
        public int PackageType { get; set; }
    }
}
