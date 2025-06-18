namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidecardmaterial 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideCardMaterialResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CardMaterial
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序卡片名字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string Path { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序封面 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("picurl")]
                [System.Text.Json.Serialization.JsonPropertyName("picurl")]
                public string PictureUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("master_id")]
                [System.Text.Json.Serialization.JsonPropertyName("master_id")]
                public long? MasterId { get; set; }

                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("slave_id")]
                [System.Text.Json.Serialization.JsonPropertyName("slave_id")]
                public long? SlaveId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小程序卡片素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_list")]
        [System.Text.Json.Serialization.JsonPropertyName("card_list")]
        public Types.CardMaterial[] CardList { get; set; } = default!;
    }
}
