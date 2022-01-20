using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/remark 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactRemarkRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string ExternalUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置该成员对外部联系人的备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置该成员对外部联系人的备注企业名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark_company")]
        [System.Text.Json.Serialization.JsonPropertyName("remark_company")]
        public string? RemarkCompany { get; set; }

        /// <summary>
        /// 获取或设置该成员对外部联系人的备注手机号码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark_mobiles")]
        [System.Text.Json.Serialization.JsonPropertyName("remark_mobiles")]
        public IList<string>? RemarkMobileNumberList { get; set; }

        /// <summary>
        /// 获取或设置该成员对外部联系人的备注图片的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark_pic_mediaid")]
        [System.Text.Json.Serialization.JsonPropertyName("remark_pic_mediaid")]
        public string? RemarkPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置该成员对外部联系人的描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
