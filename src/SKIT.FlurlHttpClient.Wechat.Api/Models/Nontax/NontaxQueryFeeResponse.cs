using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/queryfee 接口的响应。</para>
    /// </summary>
    public class NontaxQueryFeeResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BillItem : NontaxUnifiedOrderRequest.Types.BillItem
            {
            }
        }

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee")]
        [System.Text.Json.Serialization.JsonPropertyName("fee")]
        public int Fee { get; set; }

        /// <summary>
        /// 获取或设置用户姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置执收单位编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_code")]
        [System.Text.Json.Serialization.JsonPropertyName("department_code")]
        public string? DepartmentCode { get; set; }

        /// <summary>
        /// 获取或设置执收单位名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_name")]
        [System.Text.Json.Serialization.JsonPropertyName("department_name")]
        public string DepartmentName { get; set; } = default!;

        /// <summary>
        /// 获取或设置缴费通知书类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_notice_type")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_notice_type")]
        public int? PaymentNoticeType { get; set; }

        /// <summary>
        /// 获取或设置缴费通知书编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_notice_no")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_notice_no")]
        public string PaymentNoticeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置缴费通知书创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_notice_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_notice_create_time")]
        public long PaymentNoticeCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置缴费通知书限缴日期（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_expire_date")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_expire_date")]
        public long PaymentNoticeExpireDateString { get; set; }

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_code")]
        [System.Text.Json.Serialization.JsonPropertyName("region_code")]
        public string RegionCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置缴费子项目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.BillItem[] BillItemList { get; set; } = default!;
    }
}
