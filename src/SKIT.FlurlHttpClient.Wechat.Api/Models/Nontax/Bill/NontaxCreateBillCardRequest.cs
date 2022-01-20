namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/createbillcard 接口的请求。</para>
    /// </summary>
    public class NontaxCreateBillCardRequest : WechatApiRequest
    {
        public static class Types
        {
            public class BillTemplate
            {
                public static class Types
                {
                    public class Base
                    {
                        /// <summary>
                        /// 获取或设置商家 Logo URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logo_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("logo_url")]
                        public string LogoUrl { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置非税票据基础信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置开票方全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payee")]
                [System.Text.Json.Serialization.JsonPropertyName("payee")]
                public string Payee { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置非税票据模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_info")]
        [System.Text.Json.Serialization.JsonPropertyName("invoice_info")]
        public Types.BillTemplate BillTemplate { get; set; } = new Types.BillTemplate();
    }
}
