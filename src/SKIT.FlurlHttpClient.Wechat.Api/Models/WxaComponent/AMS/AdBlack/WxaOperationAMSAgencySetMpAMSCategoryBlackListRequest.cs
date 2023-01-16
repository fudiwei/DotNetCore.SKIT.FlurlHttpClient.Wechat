using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_set_mp_amscategory_blacklist 接口的请求。</para>
    /// </summary>
    public class WxaOperationAMSAgencySetMpAMSCategoryBlackListRequest : WechatApiRequest, IInferable<WxaOperationAMSAgencySetMpAMSCategoryBlackListRequest, WxaOperationAMSAgencySetMpAMSCategoryBlackListResponse>
    {
        /// <summary>
        /// 获取或设置屏蔽的行业类别列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ams_category")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("ams_category")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithPipeSplitConverter))]
        public IList<string> AMSCategoryList { get; set; } = new List<string>();
    }
}
