using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/hr/get_staff_info 接口的请求。</para>
    /// </summary>
    public class CgibinHrGetStaffInfoRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Field
            {
                /// <summary>
                /// 获取或设置字段 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fieldid")]
                [System.Text.Json.Serialization.JsonPropertyName("fieldid")]
                public int FieldId { get; set; }

                /// <summary>
                /// 获取或设置需要获取的字段下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_idx")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_idx")]
                public int? SubIndex { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否获取全部字段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("get_all")]
        [System.Text.Json.Serialization.JsonPropertyName("get_all")]
        public bool? RequireAll { get; set; }

        /// <summary>
        /// 获取或设置需要获取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fieldids")]
        [System.Text.Json.Serialization.JsonPropertyName("fieldids")]
        public IList<Types.Field>? FieldList { get; set; }
    }
}
