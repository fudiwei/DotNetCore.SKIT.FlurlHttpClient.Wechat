namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/batchcreateretail 接口的响应。</para>
    /// </summary>
    public class WxaBusinessBatchCreateRetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Failure
            {
                /// <summary>
                /// 获取或设置门店负责人的手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
                public string Mobilephone { get; set; } = default!;

                /// <summary>
                /// 获取或设置营业执照注册号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("registration_number")]
                [System.Text.Json.Serialization.JsonPropertyName("registration_number")]
                public string? RegistrationNumber { get; set; }

                /// <summary>
                /// 获取或设置失败原因编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failure_code")]
                [System.Text.Json.Serialization.JsonPropertyName("failure_code")]
                public int FailureCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成功数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("num_success")]
        [System.Text.Json.Serialization.JsonPropertyName("num_success")]
        public int SuccessfulCount { get; set; }

        /// <summary>
        /// 获取或设置失败数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("num_failure")]
        [System.Text.Json.Serialization.JsonPropertyName("num_failure")]
        public int FailedCount { get; set; }

        /// <summary>
        /// 获取或设置失败信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failure_record_list")]
        [System.Text.Json.Serialization.JsonPropertyName("failure_record_list")]
        public Types.Failure[]? FailureList { get; set; }
    }
}
