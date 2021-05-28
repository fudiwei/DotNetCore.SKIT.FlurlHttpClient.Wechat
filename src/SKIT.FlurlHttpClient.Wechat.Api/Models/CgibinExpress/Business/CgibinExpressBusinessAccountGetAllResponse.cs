using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/express/business/account/getall 接口的响应。</para>
    /// </summary>
    public class CgibinExpressBusinessAccountGetAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Account
            {
                public static class Types
                {
                    public class Service : CgibinExpressBusinessDeliveryGetAllResponse.Types.DeliveryCompany.Types.Service
                    {
                    }
                }

                /// <summary>
                /// 获取或设置快递公司客户编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_id")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_id")]
                public string BusinessId { get; set; } = default!;

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置绑定状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status_code")]
                [System.Text.Json.Serialization.JsonPropertyName("status_code")]
                public int StatusCode { get; set; }

                /// <summary>
                /// 获取或设置账号别名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("alias")]
                [System.Text.Json.Serialization.JsonPropertyName("alias")]
                public string Alias { get; set; } = default!;

                /// <summary>
                /// 获取或设置账号绑定失败的错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark_wrong_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("remark_wrong_msg")]
                public string? RemarkWrongMessage { get; set; }

                /// <summary>
                /// 获取或设置账号绑定时的备注内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark_content")]
                [System.Text.Json.Serialization.JsonPropertyName("remark_content")]
                public string? RemarkContent { get; set; }

                /// <summary>
                /// 获取或设置电子面单余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quota_num")]
                [System.Text.Json.Serialization.JsonPropertyName("quota_num")]
                public int? QuotaNumber { get; set; }

                /// <summary>
                /// 获取或设置电子面单余额更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quota_update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("quota_update_time")]
                public long? QuotaUpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置该账号支持的服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_type")]
                [System.Text.Json.Serialization.JsonPropertyName("service_type")]
                public Types.Service[]? ServiceList { get; set; }

                /// <summary>
                /// 获取或设置账号更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置账号绑定时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Account[] AccountList { get; set; } = default!;

        /// <summary>
        /// 获取或设置账号数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
