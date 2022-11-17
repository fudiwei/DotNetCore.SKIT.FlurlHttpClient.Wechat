using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/express/getbyid 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantExpressGetByIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Template
            {
                public static class Types
                {
                    public class Charging
                    {
                        /// <summary>
                        /// 获取或设置快递类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Type")]
                        [System.Text.Json.Serialization.JsonPropertyName("Type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置默认邮费计算方法。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Normal")]
                        [System.Text.Json.Serialization.JsonPropertyName("Normal")]
                        public NormalCharging Normal { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置指定地区邮费计算方法。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Custom")]
                        [System.Text.Json.Serialization.JsonPropertyName("Custom")]
                        public CustomCharging[] CustomList { get; set; } = default!;
                    }

                    public class NormalCharging : MerchantExpressAddRequest.Types.Template.Types.NormalCharging
                    {
                    }

                    public class CustomCharging : MerchantExpressAddRequest.Types.Template.Types.CustomCharging
                    {
                    }
                }

                /// <summary>
                /// 获取或设置邮费模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Id")]
                [System.Text.Json.Serialization.JsonPropertyName("Id")]
                public long TemplateId { get; set; }

                /// <summary>
                /// 获取或设置模板名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Name")]
                [System.Text.Json.Serialization.JsonPropertyName("Name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Assumer")]
                [System.Text.Json.Serialization.JsonPropertyName("Assumer")]
                public int Assumer { get; set; }

                /// <summary>
                /// 获取或设置计费方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Valuation")]
                [System.Text.Json.Serialization.JsonPropertyName("Valuation")]
                public int Valuation { get; set; }

                /// <summary>
                /// 获取或设置运费计算列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("TopFee")]
                [System.Text.Json.Serialization.JsonPropertyName("TopFee")]
                public Types.Charging[] ChargingList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置邮费模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_info")]
        [System.Text.Json.Serialization.JsonPropertyName("template_info")]
        public Types.Template Template { get; set; } = default!;
    }
}
