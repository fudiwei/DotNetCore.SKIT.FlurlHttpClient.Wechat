using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/info/batchget 接口的响应。</para>
    /// </summary>
    public class CgibinUserInfoBatchGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户全局标识。只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string? UnionId { get; set; }

                /// <summary>
                /// 获取或设置用户的昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户的性别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sex")]
                [System.Text.Json.Serialization.JsonPropertyName("sex")]
                public int Sex { get; set; }

                /// <summary>
                /// 获取或设置用户所在城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string City { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户所在省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string Province { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户所在国家。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country")]
                [System.Text.Json.Serialization.JsonPropertyName("country")]
                public string Country { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户的语言。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("language")]
                [System.Text.Json.Serialization.JsonPropertyName("language")]
                public string Language { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户的头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headimgurl")]
                [System.Text.Json.Serialization.JsonPropertyName("headimgurl")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户是否订阅该公众号标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscribe")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("subscribe")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsSubscribed { get; set; }

                /// <summary>
                /// 获取或设置用户关注的时间戳。如果用户曾多次关注，则取最后关注时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscribe_time")]
                [System.Text.Json.Serialization.JsonPropertyName("subscribe_time")]
                public long? SubscribeTimestamp { get; set; }

                /// <summary>
                /// 获取或设置用户关注的渠道来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscribe_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("subscribe_scene")]
                public string? SubscribeScene { get; set; }

                /// <summary>
                /// 获取或设置公众号运营者对粉丝的备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置用户所在的分组 ID（兼容旧的用户分组接口）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupid")]
                [System.Text.Json.Serialization.JsonPropertyName("groupid")]
                public int GroupId { get; set; }

                /// <summary>
                /// 获取或设置用户被打上的标签 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tagid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("tagid_list")]
                public int[]? TagIdList { get; set; }

                /// <summary>
                /// 获取或设置二维码扫码场景值 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qr_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("qr_scene")]
                public long? QrcodeSceneId { get; set; }

                /// <summary>
                /// 获取或设置二维码扫码场景描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qr_scene_str")]
                [System.Text.Json.Serialization.JsonPropertyName("qr_scene_str")]
                public string? QrcodeSceneString { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置批量获取的用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_info_list")]
        public Types.User[] UserList { get; set; } = default!;
    }
}
