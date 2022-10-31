using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/express/add 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantExpressAddRequest : WechatApiRequest, IInferable<MerchantExpressAddRequest, MerchantExpressAddResponse>
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
                        public NormalCharging Normal { get; set; } = new NormalCharging();

                        /// <summary>
                        /// 获取或设置指定地区邮费计算方法。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Custom")]
                        [System.Text.Json.Serialization.JsonPropertyName("Custom")]
                        public IList<CustomCharging> CustomList { get; set; } = new List<CustomCharging>();
                    }

                    public class NormalCharging
                    {
                        /// <summary>
                        /// 获取或设置起始计费数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("StartStandards")]
                        [System.Text.Json.Serialization.JsonPropertyName("StartStandards")]
                        public int StartStandards { get; set; }

                        /// <summary>
                        /// 获取或设置起始计费金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("StartFees")]
                        [System.Text.Json.Serialization.JsonPropertyName("StartFees")]
                        public int StartFee { get; set; }

                        /// <summary>
                        /// 获取或设置递增计费数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("AddStandards")]
                        [System.Text.Json.Serialization.JsonPropertyName("AddStandards")]
                        public int AddStandards { get; set; }

                        /// <summary>
                        /// 获取或设置递增计费金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("AddFees")]
                        [System.Text.Json.Serialization.JsonPropertyName("AddFees")]
                        public int AddFee { get; set; }
                    }

                    public class CustomCharging : NormalCharging
                    {
                        /// <summary>
                        /// 获取或设置目的地国家。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("DestCountry")]
                        [System.Text.Json.Serialization.JsonPropertyName("DestCountry")]
                        public string DestinationCountry { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置目的地省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("DestProvince")]
                        [System.Text.Json.Serialization.JsonPropertyName("DestProvince")]
                        public string DestinationProvince { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置目的地城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("DestCity")]
                        [System.Text.Json.Serialization.JsonPropertyName("DestCity")]
                        public string DestinationCity { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置模板名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Name")]
                [System.Text.Json.Serialization.JsonPropertyName("Name")]
                public string Name { get; set; } = string.Empty;

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
                public IList<Types.Charging> ChargingList { get; set; } = new List<Types.Charging>();
            }
        }

        /// <summary>
        /// 获取或设置邮费模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_template")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_template")]
        public Types.Template Template { get; set; } = new Types.Template();
    }
}
