using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/idconvert/convert_tmp_external_userid 接口的请求。</para>
    /// </summary>
    public class CgibinIdConvertConvertTempExternalUserIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public int BusinessType { get; set; }

        /// <summary>
        /// 获取或设置目标用户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_type")]
        [System.Text.Json.Serialization.JsonPropertyName("user_type")]
        public int UserType { get; set; }

        /// <summary>
        /// 获取或设置外部联系人临时 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tmp_external_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("tmp_external_userid_list")]
        public IList<string> TempExternalUserIdList { get; set; } = new List<string>();
    }
}
