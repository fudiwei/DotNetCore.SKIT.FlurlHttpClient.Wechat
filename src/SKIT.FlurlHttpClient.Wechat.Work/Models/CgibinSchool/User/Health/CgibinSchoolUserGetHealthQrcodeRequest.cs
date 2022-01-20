using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/get_health_qrcode 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolUserGetHealthQrcodeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置 ID 类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int IdType { get; set; }

        /// <summary>
        /// 获取或设置用户 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userids")]
        [System.Text.Json.Serialization.JsonPropertyName("userids")]
        public IList<string> UserIdList { get; set; } = new List<string>();
    }
}
