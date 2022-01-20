namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getopendata 接口的响应。</para>
    /// </summary>
    public class TcbGetOpenDataResponse : WechatApiResponse
    {
        public static class Types
        {
            public class OpenData
            {
                /// <summary>
                /// 获取或设置 CloudId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cloud_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cloud_id")]
                public string CloudId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开放数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("json")]
                [System.Text.Json.Serialization.JsonPropertyName("json")]
                public object Data { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置开放数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_list")]
        [System.Text.Json.Serialization.JsonPropertyName("data_list")]
        public Types.OpenData[] OpenDataList { get; set; } = default!;
    }
}
