namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/batch/replaceuser 接口的请求。</para>
    /// </summary>
    public class CgibinBatchReplaceUserRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Callback : CgibinBatchSyncUserRequest.Types.Callback
            {
            }
        }

        /// <summary>
        /// 获取或设置 CSV 文件 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string? MediaId { get; set; }

        /// <summary>
        /// 获取或设置是否邀请成员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_invite")]
        [System.Text.Json.Serialization.JsonPropertyName("to_invite")]
        public bool? RequireInvite { get; set; }

        /// <summary>
        /// 获取或设置回调信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback")]
        [System.Text.Json.Serialization.JsonPropertyName("callback")]
        public Types.Callback? Callback { get; set; }
    }
}
