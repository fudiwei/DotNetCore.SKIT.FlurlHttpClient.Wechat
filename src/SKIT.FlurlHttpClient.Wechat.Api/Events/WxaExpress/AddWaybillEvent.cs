using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.add_waybill 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-provider/logistics.onAddOrder.html </para>
    /// </summary>
    public class AddWaybillEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class Sender
            {
                /// <summary>
                /// 获取或设置姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Name")]
                [System.Text.Json.Serialization.JsonPropertyName("Name")]
                [System.Xml.Serialization.XmlElement("Name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置座机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Tel")]
                [System.Text.Json.Serialization.JsonPropertyName("Tel")]
                [System.Xml.Serialization.XmlElement("Tel", IsNullable = true)]
                public string? TeleNumber { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("Mobile")]
                [System.Xml.Serialization.XmlElement("Mobile", IsNullable = true)]
                public string? MobileNumber { get; set; }

                /// <summary>
                /// 获取或设置公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Company")]
                [System.Text.Json.Serialization.JsonPropertyName("Company")]
                [System.Xml.Serialization.XmlElement("Company", IsNullable = true)]
                public string? Company { get; set; }

                /// <summary>
                /// 获取或设置邮编。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("PostCode")]
                [System.Text.Json.Serialization.JsonPropertyName("PostCode")]
                [System.Xml.Serialization.XmlElement("PostCode", IsNullable = true)]
                public string? PostCode { get; set; }

                /// <summary>
                /// 获取或设置国家。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Country")]
                [System.Text.Json.Serialization.JsonPropertyName("Country")]
                [System.Xml.Serialization.XmlElement("Country", IsNullable = true)]
                public string? Country { get; set; }

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Province")]
                [System.Text.Json.Serialization.JsonPropertyName("Province")]
                [System.Xml.Serialization.XmlElement("Province")]
                public string Province { get; set; } = default!;

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("City")]
                [System.Text.Json.Serialization.JsonPropertyName("City")]
                [System.Xml.Serialization.XmlElement("City")]
                public string City { get; set; } = default!;

                /// <summary>
                /// 获取或设置区县。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Area")]
                [System.Text.Json.Serialization.JsonPropertyName("Area")]
                [System.Xml.Serialization.XmlElement("Area")]
                public string District { get; set; } = default!;

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Address")]
                [System.Text.Json.Serialization.JsonPropertyName("Address")]
                [System.Xml.Serialization.XmlElement("Address")]
                public string Address { get; set; } = default!;
            }

            public class Receiver : Sender
            {
            }

            public class Cargo
            {
                public static class Types
                {
                    public class GoodsDetail
                    {
                        /// <summary>
                        /// 获取或设置商品名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Name")]
                        [System.Text.Json.Serialization.JsonPropertyName("Name")]
                        [System.Xml.Serialization.XmlElement("Name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Count")]
                        [System.Text.Json.Serialization.JsonPropertyName("Count")]
                        [System.Xml.Serialization.XmlElement("Count")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置包裹数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Count")]
                [System.Text.Json.Serialization.JsonPropertyName("Count")]
                [System.Xml.Serialization.XmlElement("Count")]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置包裹长度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Space_X")]
                [System.Text.Json.Serialization.JsonPropertyName("Space_X")]
                [System.Xml.Serialization.XmlElement("Space_X", IsNullable = true)]
                public double? Length { get; set; }

                /// <summary>
                /// 获取或设置包裹宽度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Space_Y")]
                [System.Text.Json.Serialization.JsonPropertyName("Space_Y")]
                [System.Xml.Serialization.XmlElement("Space_Y", IsNullable = true)]
                public double? Width { get; set; }

                /// <summary>
                /// 获取或设置包裹高度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("space_z")]
                [System.Text.Json.Serialization.JsonPropertyName("space_z")]
                [System.Xml.Serialization.XmlElement("Space_Z", IsNullable = true)]
                public double? Height { get; set; }

                /// <summary>
                /// 获取或设置包裹重量（单位：千克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                [System.Xml.Serialization.XmlElement("Weight", IsNullable = true)]
                public double? Weight { get; set; }

                /// <summary>
                /// 获取或设置商品详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("DetailList")]
                [System.Text.Json.Serialization.JsonPropertyName("DetailList")]
                [System.Xml.Serialization.XmlElement("DetailList", Type = typeof(Types.GoodsDetail))]
                public Types.GoodsDetail[]? GoodsDetailList { get; set; }
            }

            public class Insurance
            {
                /// <summary>
                /// 获取或设置是否保价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("UseInsured")]
                [System.Text.Json.Serialization.JsonPropertyName("UseInsured")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
                [System.Xml.Serialization.XmlElement("UseInsured")]
                public bool UseInsured { get; set; }

                /// <summary>
                /// 获取或设置保价金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("InsuredValue")]
                [System.Text.Json.Serialization.JsonPropertyName("InsuredValue")]
                [System.Xml.Serialization.XmlElement("InsuredValue")]
                public int InsuredValue { get; set; }
            }

            public class Service
            {
                /// <summary>
                /// 获取或设置服务类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ServiceType")]
                [System.Text.Json.Serialization.JsonPropertyName("ServiceType")]
                [System.Xml.Serialization.XmlElement("ServiceType")]
                public int ServiceType { get; set; }

                /// <summary>
                /// 获取或设置服务类型名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ServiceName")]
                [System.Text.Json.Serialization.JsonPropertyName("ServiceName")]
                [System.Xml.Serialization.XmlElement("ServiceName")]
                public string ServiceName { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Token")]
        [System.Text.Json.Serialization.JsonPropertyName("Token")]
        [System.Xml.Serialization.XmlElement("Token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 获取或设置快递公司客户编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BizID")]
        [System.Text.Json.Serialization.JsonPropertyName("BizID")]
        [System.Xml.Serialization.XmlElement("BizID")]
        public string BusinessId { get; set; } = default!;

        /// <summary>
        /// 获取或设置快递公司客户密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BizPwd")]
        [System.Text.Json.Serialization.JsonPropertyName("BizPwd")]
        [System.Xml.Serialization.XmlElement("BizPwd", IsNullable = true)]
        public string? BusinessPassword { get; set; }

        /// <summary>
        /// 获取或设置商户的小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ShopAppID")]
        [System.Text.Json.Serialization.JsonPropertyName("ShopAppID")]
        [System.Xml.Serialization.XmlElement("ShopAppID", IsNullable = true)]
        public string? ShopAppId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderId")]
        [System.Xml.Serialization.XmlElement("OrderId")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WayBillID")]
        [System.Text.Json.Serialization.JsonPropertyName("WayBillID")]
        [System.Xml.Serialization.XmlElement("WayBillID")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置快递备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Remark")]
        [System.Text.Json.Serialization.JsonPropertyName("Remark")]
        [System.Xml.Serialization.XmlElement("Remark", IsNullable = true)]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置发件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Sender")]
        [System.Text.Json.Serialization.JsonPropertyName("Sender")]
        [System.Xml.Serialization.XmlElement("Sender")]
        public Types.Sender Sender { get; set; } = default!;

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("Receiver")]
        [System.Xml.Serialization.XmlElement("Receiver")]
        public Types.Receiver Receiver { get; set; } = default!;

        /// <summary>
        /// 获取或设置包裹信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Cargo")]
        [System.Text.Json.Serialization.JsonPropertyName("Cargo")]
        [System.Xml.Serialization.XmlElement("Cargo", IsNullable = true)]
        public Types.Cargo? Cargo { get; set; }

        /// <summary>
        /// 获取或设置保价信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Insured")]
        [System.Text.Json.Serialization.JsonPropertyName("Insured")]
        [System.Xml.Serialization.XmlElement("Insured", IsNullable = true)]
        public Types.Insurance? Insurance { get; set; }

        /// <summary>
        /// 获取或设置服务类型信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Service")]
        [System.Text.Json.Serialization.JsonPropertyName("Service")]
        [System.Xml.Serialization.XmlElement("Service", IsNullable = true)]
        public Types.Service? Service { get; set; }
    }
}
