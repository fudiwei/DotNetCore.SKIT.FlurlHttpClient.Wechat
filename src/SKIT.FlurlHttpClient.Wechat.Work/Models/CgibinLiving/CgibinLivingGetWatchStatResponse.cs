using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/living/get_watch_stat 接口的响应。</para>
    /// </summary>
    public class CgibinLivingGetWatchStatResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Statistics
            {
                public static class Types
                {
                    public class User
                    {
                        /// <summary>
                        /// 获取或设置成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置观看时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("watch_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("watch_time")]
                        public int WatchTime { get; set; }

                        /// <summary>
                        /// 获取或设置是否评论。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_comment")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_comment")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
                        public bool IsComment { get; set; }

                        /// <summary>
                        /// 获取或设置是否连麦。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_mic")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_mic")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
                        public bool IsMic { get; set; }
                    }

                    public class ExternalUser
                    {
                        /// <summary>
                        /// 获取或设置外部联系人账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                        public string ExternalUserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置外部成员类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置外部成员名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置观看时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("watch_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("watch_time")]
                        public int WatchTime { get; set; }

                        /// <summary>
                        /// 获取或设置是否评论。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_comment")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_comment")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
                        public bool IsComment { get; set; }

                        /// <summary>
                        /// 获取或设置是否连麦。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_mic")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_mic")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
                        public bool IsMic { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置成员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("users")]
                [System.Text.Json.Serialization.JsonPropertyName("users")]
                public Types.User[] UserList { get; set; } = default!;

                /// <summary>
                /// 获取或设置外部联系人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_users")]
                [System.Text.Json.Serialization.JsonPropertyName("external_users")]
                public Types.ExternalUser[] ExternalUserList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置统计信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stat_info")]
        [System.Text.Json.Serialization.JsonPropertyName("stat_info")]
        public Types.Statistics Statistics { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页是否结束。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ending")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("ending")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
        public bool IsEnding { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextKey { get; set; }
    }
}
