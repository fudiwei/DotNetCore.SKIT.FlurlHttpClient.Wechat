namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/menu/trymatch 接口的响应。</para>
    /// </summary>
    public class CgibinMenuTryMatchResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Button : CgibinMenuCreateRequest.Types.__zz__Button
            {
                /// <summary>
                /// 获取或设置子菜单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_button")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_button")]
                public List<Button>? SubButtonList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置匹配的菜单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button")]
        [System.Text.Json.Serialization.JsonPropertyName("button")]
        public List<Types.Button>? ButtonList { get; set; }
    }
}
