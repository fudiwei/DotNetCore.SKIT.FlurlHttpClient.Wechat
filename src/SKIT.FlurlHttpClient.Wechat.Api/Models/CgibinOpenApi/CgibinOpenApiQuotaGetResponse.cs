using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openapi/quota/get 接口的响应。</para>
    /// </summary>
    public class CgibinOpenApiQuotaGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Quota
            {
                /// <summary>
                /// 获取或设置当天该账号可调用该接口的次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("daily_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("daily_limit")]
                public int DailyLimit { get; set; }

                /// <summary>
                /// 获取或设置当天已经调用的次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("used")]
                [System.Text.Json.Serialization.JsonPropertyName("used")]
                public int UsedCount { get; set; }

                /// <summary>
                /// 获取或设置当天剩余调用次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remain")]
                [System.Text.Json.Serialization.JsonPropertyName("remain")]
                public int RemainCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置额度信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quota")]
        [System.Text.Json.Serialization.JsonPropertyName("quota")]
        public Types.Quota Quota { get; set; } = default!;
    }
}
