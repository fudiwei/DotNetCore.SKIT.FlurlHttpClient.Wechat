using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/open_kfid 接口的请求。</para>
    /// </summary>
    public class CgibinIdConvertOpenKfIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置客服账号 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_kfid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("open_kfid_list")]
        public IList<string> OpenKfIdList { get; set; } = new List<string>();
    }
}
