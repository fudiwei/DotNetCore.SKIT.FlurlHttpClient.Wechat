namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/consume 接口的响应。</para>
    /// </summary>
    public class ChannelsECVoucherConsumeResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Voucher : ChannelsECVoucherGetListResponse.Types.Voucher
            {
            }

            public class FailedVoucher
            {
                /// <summary>
                /// 获取或设置加密的券码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypted_code")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypted_code")]
                public string? EncryptedCode { get; set; }

                /// <summary>
                /// 获取或设置券码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                public long? SKUId { get; set; }

                /// <summary>
                /// 获取或设置操作结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ret_code")]
                [System.Text.Json.Serialization.JsonPropertyName("ret_code")]
                public int ReturnCode { get; set; }

                /// <summary>
                /// 获取或设置操作结果说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ret_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("ret_msg")]
                public string? ReturnMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置团购优惠券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voucher_list")]
        [System.Text.Json.Serialization.JsonPropertyName("voucher_list")]
        public Types.Voucher[]? VoucherList { get; set; }

        /// <summary>
        /// 获取或设置核销失败的券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_voucher_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_voucher_list")]
        public Types.FailedVoucher[]? FailedVoucherList { get; set; }
    }
}
