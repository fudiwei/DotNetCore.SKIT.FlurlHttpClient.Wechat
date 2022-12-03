using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/batch/external_userid_to_pending_id 接口的请求。</para>
    /// </summary>
    public class CgibinIdConvertBatchExternalUserIdToPendingIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置群聊 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// 获取或设置外部联系人账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public IList<string> ExternalUserIdList { get; set; } = new List<string>();
    }
}
