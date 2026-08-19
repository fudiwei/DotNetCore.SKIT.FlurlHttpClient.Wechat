using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/promoter/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeaguePromoterListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Talent
            {
                /// <summary>
                /// 获取或设置带货达人 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("talent_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
                public string TalentAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置带货达人昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置视频号 ID 列表。
        /// </summary>
        [Obsolete("相关接口或字段于 2026-03-30 下线。")]
        [Newtonsoft.Json.JsonProperty("finder_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_ids")]
        public string[] FinderIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置带货达人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Talent[] TalentList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("continue_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("continue_flag")]
        public bool HasMore { get; set; }
    }
}
