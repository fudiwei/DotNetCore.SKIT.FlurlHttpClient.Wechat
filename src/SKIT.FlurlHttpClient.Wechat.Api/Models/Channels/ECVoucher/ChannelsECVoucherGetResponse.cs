namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVoucherGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Voucher : ChannelsECVoucherGetListResponse.Types.Voucher
            {
                public static class Types
                {
                    public class TimeCard
                    {
                        /// <summary>
                        /// 获取或设置可用总次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                        public int TotalCount { get; set; }

                        /// <summary>
                        /// 获取或设置剩余可用次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_count")]
                        public int AvailableCount { get; set; }

                        /// <summary>
                        /// 获取或设置已核销次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consumed_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("consumed_count")]
                        public int ConsumedCount { get; set; }

                        /// <summary>
                        /// 获取或设置已退券次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refunded_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("refunded_count")]
                        public int RefundedCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置次卡信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_card")]
                [System.Text.Json.Serialization.JsonPropertyName("time_card")]
                public Types.TimeCard? TimeCard { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置团购优惠券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher")]
        [System.Text.Json.Serialization.JsonPropertyName("voucher")]
        public Types.Voucher Voucher { get; set; } = default!;
    }
}
