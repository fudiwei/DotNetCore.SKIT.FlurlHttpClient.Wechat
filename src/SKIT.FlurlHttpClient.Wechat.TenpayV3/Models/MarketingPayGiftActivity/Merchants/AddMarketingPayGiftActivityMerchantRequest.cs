﻿using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/paygiftactivity/activities/{activity_id}/merchants/add 接口的请求。</para>
    /// </summary>
    public class AddMarketingPayGiftActivityMerchantRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发券商户号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id_list")]
        public IList<string> MerchantIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("add_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;
    }
}
