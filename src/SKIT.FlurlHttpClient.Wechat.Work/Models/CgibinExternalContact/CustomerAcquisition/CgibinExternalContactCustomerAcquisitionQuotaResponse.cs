namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_acquisition_quota 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionQuotaResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Quota
            {
                /// <summary>
                /// 获取或设置即将过期额度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance")]
                [System.Text.Json.Serialization.JsonPropertyName("balance")]
                public int Balance { get; set; }

                /// <summary>
                /// 获取或设置额度过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_date")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_date")]
                public long ExpireTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置累计使用量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置剩余使用量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// 获取或设置即将过期额度列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quota_list")]
        [System.Text.Json.Serialization.JsonPropertyName("quota_list")]
        public Types.Quota[]? QuotaList { get; set; }
    }
}
