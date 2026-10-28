namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_get_mp_amscategory_blacklist 接口的响应。</para>
    /// </summary>
    public class WxaOperationAMSAgencyGetMpAMSCategoryBlackListResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置返回错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ret")]
        [System.Text.Json.Serialization.JsonPropertyName("ret")]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 获取或设置返回错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取或设置屏蔽的行业类别列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ams_category")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedStringListWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("ams_category")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedStringListWithPipeSplitConverter))]
        public List<string>? AMSCategoryList { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ReturnCode == 0;
        }
    }
}
