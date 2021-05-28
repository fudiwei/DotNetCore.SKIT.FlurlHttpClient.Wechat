using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/updateuser 接口的响应。</para>
    /// </summary>
    public class CardMemberCardUpdateUserResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置当前用户积分。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_bonus")]
        [System.Text.Json.Serialization.JsonPropertyName("result_bonus")]
        public int ResultBounus { get; set; }

        /// <summary>
        /// 获取或设置当前用户余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("result_balance")]
        public int ResultBalance { get; set; }
    }
}
