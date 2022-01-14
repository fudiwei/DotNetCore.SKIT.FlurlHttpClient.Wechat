namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/menu/addconditional 接口的响应。</para>
    /// </summary>
    public class CgibinMenuAddConditionalResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置菜单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("menuid")]
        [System.Text.Json.Serialization.JsonPropertyName("menuid")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int MenuId { get; set; }
    }
}
