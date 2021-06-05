using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/list_parent 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolUserListParentResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Parent : CgibinSchoolUserGetResponse.Types.Parent
            {
            }
        }

        /// <summary>
        /// 获取或设置家长列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parents")]
        [System.Text.Json.Serialization.JsonPropertyName("parents")]
        public Types.Parent[] ParentList { get; set; } = default!;
    }
}
