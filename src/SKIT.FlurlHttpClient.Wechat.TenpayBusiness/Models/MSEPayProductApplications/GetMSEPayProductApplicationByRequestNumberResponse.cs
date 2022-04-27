namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/product-applications/{request_no} 接口的响应。</para>
    /// </summary>
    public class GetMSEPayProductApplicationByRequestNumberResponse : WechatTenpayBusinessResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class Account
                    {
                        /// <summary>
                        /// 获取或设置企业账户 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ent_acct_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ent_acct_id")]
                        public string EnterpriseAccountId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置产品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string ProductName { get; set; } = default!;

                /// <summary>
                /// 获取或设置开通状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置账户列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("accounts")]
                [System.Text.Json.Serialization.JsonPropertyName("accounts")]
                public Types.Account[]? AccountList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付开户申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("request_no")]
        public string RequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
        public string EnterpriseId { get; set; } = default!;

        /// <summary>
        /// 获取或设置开通状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置开通产品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_details")]
        [System.Text.Json.Serialization.JsonPropertyName("product_details")]
        public Types.Product[] ProductList { get; set; } = default!;
    }
}
