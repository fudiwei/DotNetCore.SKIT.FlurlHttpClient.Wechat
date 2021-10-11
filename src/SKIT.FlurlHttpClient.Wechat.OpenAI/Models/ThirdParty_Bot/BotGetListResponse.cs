using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/get_list 接口的响应。</para>
    /// </summary>
    public class BotGetListResponse : WechatOpenAIThirdPartyResponse<BotGetListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Bot
                    {
                        /// <summary>
                        /// 获取或设置机器人 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string BotId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置机器人中文名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name_ch")]
                        [System.Text.Json.Serialization.JsonPropertyName("name_ch")]
                        public string ChineseName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置机器人英文名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name_en")]
                        [System.Text.Json.Serialization.JsonPropertyName("name_en")]
                        public string? EnglishName { get; set; }

                        /// <summary>
                        /// 获取或设置机器人类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bot_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("bot_type")]
                        public int BotType { get; set; }

                        /// <summary>
                        /// 获取或设置操作权限类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auth")]
                        [System.Text.Json.Serialization.JsonPropertyName("auth")]
                        public int AuthType { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置机器人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Bot[] BotList { get; set; } = default!;

                /// <summary>
                /// 获取或设置机器人总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置默认机器人数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_bot_count")]
                [System.Text.Json.Serialization.JsonPropertyName("default_bot_count")]
                public int DefaultBotCount { get; set; }

                /// <summary>
                /// 获取或设置直播机器人数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_bot_count")]
                [System.Text.Json.Serialization.JsonPropertyName("live_bot_count")]
                public int LiveBotCount { get; set; }
            }
        }
    }
}
