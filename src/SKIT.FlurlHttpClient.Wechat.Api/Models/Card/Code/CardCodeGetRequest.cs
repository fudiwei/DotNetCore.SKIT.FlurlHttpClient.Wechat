using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/code/get 接口的请求。</para>
    /// </summary>
    public class CardCodeGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string CardCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否校验核销状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_consume")]
        [System.Text.Json.Serialization.JsonPropertyName("check_consume")]
        public bool? RequireCheckConsume { get; set; }
    }
}
