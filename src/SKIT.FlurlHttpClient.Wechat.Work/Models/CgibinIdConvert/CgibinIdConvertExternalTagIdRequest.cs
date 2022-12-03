using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/external_tagid 接口的请求。</para>
    /// </summary>
    public class CgibinIdConvertExternalTagIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置客户标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_tagid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("external_tagid_list")]
        public IList<string> ExternalTagIdList { get; set; } = new List<string>();
    }
}
