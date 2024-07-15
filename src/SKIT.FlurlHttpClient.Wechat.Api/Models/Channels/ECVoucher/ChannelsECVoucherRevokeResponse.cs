namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/revoke 接口的响应。</para>
    /// </summary>
    public class ChannelsECVoucherRevokeResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Voucher : ChannelsECVoucherConsumeResponse.Types.Voucher
            {
            }

            public class FailedVoucher : ChannelsECVoucherConsumeResponse.Types.FailedVoucher
            {
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
