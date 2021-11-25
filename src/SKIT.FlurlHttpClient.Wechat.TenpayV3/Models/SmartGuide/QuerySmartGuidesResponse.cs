using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /smartguide/guides 接口的响应。</para>
    /// </summary>
    public class QuerySmartGuidesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Guide
            {
                /// <summary>
                /// 获取或设置服务人员 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guide_id")]
                [System.Text.Json.Serialization.JsonPropertyName("guide_id")]
                public string GuideId { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_id")]
                [System.Text.Json.Serialization.JsonPropertyName("store_id")]
                public int StoreId { get; set; }

                /// <summary>
                /// 获取或设置企业微信的员工 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业微信的员工姓名（需使用商户私钥解密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string UserName { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业微信的员工手机号码（需使用商户私钥解密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
                public string UserMobile { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业微信的员工工号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("work_id")]
                [System.Text.Json.Serialization.JsonPropertyName("work_id")]
                public string UserWorkId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置服务人员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Guide[] GuideList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置服务人员总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

    }
}
