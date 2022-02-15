using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/rebindguideacctforbuyer 接口的请求。</para>
    /// </summary>
    public class CgibinGuideRebindGuideAccountForBuyerRequest : WechatApiRequest, IMapResponse<CgibinGuideRebindGuideAccountForBuyerRequest, CgibinGuideRebindGuideAccountForBuyerResponse>
    {
        /// <summary>
        /// 获取或设置原顾问微信号。与字段 <see cref="OldGuideOpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("old_guide_account")]
        [System.Text.Json.Serialization.JsonPropertyName("old_guide_account")]
        public string? OldGuideAccount { get; set; }

        /// <summary>
        /// 获取或设置原顾问 OpenId。与字段 <see cref="OldGuideAccount"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("old_guide_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("old_guide_openid")]
        public string? OldGuideOpenId { get; set; }

        /// <summary>
        /// 获取或设置新顾问微信号。与字段 <see cref="NewGuideOpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_guide_account")]
        [System.Text.Json.Serialization.JsonPropertyName("new_guide_account")]
        public string? NewGuideAccount { get; set; }

        /// <summary>
        /// 获取或设置新顾问 OpenId。与字段 <see cref="NewGuideAccount"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_guide_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("new_guide_openid")]
        public string? NewGuideOpenId { get; set; }

        /// <summary>
        /// 获取或设置客户 OpenId。与字段 <see cref="BuyerOpenIdList"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? BuyerOpenId { get; set; }

        /// <summary>
        /// 获取或设置客户 OpenId 列表。与字段 <see cref="BuyerOpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("openid_list")]
        public IList<string>? BuyerOpenIdList { get; set; }
    }
}
