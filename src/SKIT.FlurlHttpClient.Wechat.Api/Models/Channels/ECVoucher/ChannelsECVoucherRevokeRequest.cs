using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/revoke 接口的请求。</para>
    /// </summary>
    public class ChannelsECVoucherRevokeRequest : WechatApiRequest, IInferable<ChannelsECVoucherRevokeRequest, ChannelsECVoucherRevokeResponse>
    {
        public static class Types
        {
            public class RevokeVoucher
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
            }
        }

        /// <summary>
        /// 获取或设置商户撤销单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("revoke_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("revoke_request_no")]
        public string RevokeRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户核销单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consume_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("consume_request_no")]
        public string? ConsumeRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置撤销券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reovke_vouchers")]
        [System.Text.Json.Serialization.JsonPropertyName("reovke_vouchers")]
        public IList<Types.RevokeVoucher> RevokeVoucherList { get; set; } = new List<Types.RevokeVoucher>();
    }
}
