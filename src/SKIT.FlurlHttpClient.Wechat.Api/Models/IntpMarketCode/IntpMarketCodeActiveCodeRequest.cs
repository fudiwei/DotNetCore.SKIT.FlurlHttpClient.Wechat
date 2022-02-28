namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/marketcode/codeactive 接口的请求。</para>
    /// </summary>
    public class IntpMarketCodeActiveCodeRequest : WechatApiRequest, IMapResponse<IntpMarketCodeActiveCodeRequest, IntpMarketCodeActiveCodeResponse>
    {
        /// <summary>
        /// 获取或设置申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public long ApplicationId { get; set; }

        /// <summary>
        /// 获取或设置活动名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_name")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
        public string ActivityName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品品牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_brand")]
        [System.Text.Json.Serialization.JsonPropertyName("product_brand")]
        public string ProductBrand { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_title")]
        [System.Text.Json.Serialization.JsonPropertyName("product_title")]
        public string ProductTitle { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品条码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_code")]
        [System.Text.Json.Serialization.JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_appid")]
        public string MiniProgramAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_path")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_path")]
        public string MiniProgramPath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_type")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_type")]
        public int? MiniProgramType { get; set; }

        /// <summary>
        /// 获取或设置激活号段开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_start")]
        [System.Text.Json.Serialization.JsonPropertyName("code_start")]
        public long CodeStart { get; set; }

        /// <summary>
        /// 获取或设置激活号段结束位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_end")]
        [System.Text.Json.Serialization.JsonPropertyName("code_end")]
        public long CodeEnd { get; set; }
    }
}
