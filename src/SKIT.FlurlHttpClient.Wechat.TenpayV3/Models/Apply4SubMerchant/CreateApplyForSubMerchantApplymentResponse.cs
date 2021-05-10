using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /applyment4sub/applyment 接口的响应。</para>
    /// </summary>
    public class CreateApplyForSubMerchantApplymentResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置申请单编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public long ApplymentId { get; set; }
    }
}
