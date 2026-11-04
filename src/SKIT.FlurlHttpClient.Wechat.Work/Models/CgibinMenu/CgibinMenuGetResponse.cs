namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/menu/get 接口的响应。</para>
    /// </summary>
    public class CgibinMenuGetResponse : WechatWorkResponse
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
        /// 获取或设置菜单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button")]
        [System.Text.Json.Serialization.JsonPropertyName("button")]
        public List<Types.Button>? ButtonList { get; set; }
    }
}
