using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/accounts/mse-pay/{platform_id}/bill 接口的响应。</para>
    /// </summary>
    public class GetMSEPayAccountBillResponse : WechatTenpayBusinessResponse
    {
        /// <summary>
        /// 获取或设置文件下载链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置过期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置账单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_status")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_status")]
        public string BillStatus { get; set; } = default!;
    }
}
