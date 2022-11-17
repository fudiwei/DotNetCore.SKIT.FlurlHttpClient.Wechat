namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/get_new_external_userid 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatGetNewExternalUserIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result : CgibinExternalContactGetNewExternalUserIdResponse.Types.Result
            {
            }
        }

        /// <summary>
        /// 获取或设置转换结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
