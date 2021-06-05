using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/batch_to_external_userid 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactBatchToExternalUserIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }

                /// <summary>
                /// 获取或设置外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string? ExternalUserId { get; set; }

                /// <summary>
                /// 获取或设置由企业或服务商在导入家长时指定的关键字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("foreign_key")]
                [System.Text.Json.Serialization.JsonPropertyName("foreign_key")]
                public string? ForergnKey { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string? MobileNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置转换成功结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_list")]
        [System.Text.Json.Serialization.JsonPropertyName("success_list")]
        public Types.Result[] SuccessResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置转换失败结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
        public Types.Result[] FailResultList { get; set; } = default!;
    }
}
