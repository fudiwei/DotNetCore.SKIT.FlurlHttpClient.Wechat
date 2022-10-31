namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/batch_active_account 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseBatchActiveAccountResponse : WechatWorkResponse
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
                /// 获取或设置账号激活码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_code")]
                [System.Text.Json.Serialization.JsonPropertyName("active_code")]
                public string ActiveCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置待绑定激活的成员 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置激活结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_result")]
        [System.Text.Json.Serialization.JsonPropertyName("active_result")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
