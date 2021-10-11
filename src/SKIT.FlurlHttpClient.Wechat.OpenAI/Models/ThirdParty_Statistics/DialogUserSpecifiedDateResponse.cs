using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/dialog_user_specified_date 接口的响应。</para>
    /// </summary>
    public class DialogUserSpecifiedDateResponse : WechatOpenAIThirdPartyResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date")]
                [System.Text.Json.Serialization.JsonPropertyName("date")]
                public string DateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置对话数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("q_a_count")]
        [System.Text.Json.Serialization.JsonPropertyName("q_a_count")]
        public Types.Data[] DialogDataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_count")]
        [System.Text.Json.Serialization.JsonPropertyName("user_count")]
        public Types.Data[] UserDataList { get; set; } = default!;
    }
}
