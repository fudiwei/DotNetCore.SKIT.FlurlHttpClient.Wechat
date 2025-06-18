namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Events
{
    /// <summary>
    /// <para>表示 product.application.finish 通知的数据。</para>
    /// </summary>
    public class ProductApplicationEvent : WechatTenpayBusinessEvent<ProductApplicationEvent.Types.EventContent>
    {
        public static class Types
        {
            public class EventContent
            {
                public static class Types
                {
                    public class Product
                    {
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
    }
}
