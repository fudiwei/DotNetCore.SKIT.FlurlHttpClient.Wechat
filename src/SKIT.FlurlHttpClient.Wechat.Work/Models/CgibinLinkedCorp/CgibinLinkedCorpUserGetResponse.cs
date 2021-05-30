using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/user/get 接口的响应。</para>
    /// </summary>
    public class CgibinLinkedCorpUserGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class CorpUser : CgibinLinkedCorpUserListResponse.Types.CorpUser
            {
            }
        }

        /// <summary>
        /// 获取或设置互联企业成员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("user_info")]
        public Types.CorpUser CorpUser { get; set; } = default!;
    }
}
