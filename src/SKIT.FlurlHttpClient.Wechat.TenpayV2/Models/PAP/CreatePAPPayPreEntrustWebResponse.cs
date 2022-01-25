using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/preentrustweb 接口的响应。</para>
    /// </summary>
    public class CreatePAPPayPreEntrustWebResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置预签约 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_entrustweb_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_entrustweb_id")]
        public string PreEntrustWebId { get; set; } = default!;
    }
}
