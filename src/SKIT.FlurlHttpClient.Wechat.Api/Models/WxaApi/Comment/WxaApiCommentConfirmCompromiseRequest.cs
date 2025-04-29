using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/comment/confirmcompromise 接口的请求。</para>
    /// </summary>
    public class WxaApiCommentConfirmCompromiseRequest : WechatApiRequest, IInferable<WxaApiCommentConfirmCompromiseRequest, WxaApiCommentConfirmCompromiseResponse>
    {
        /// <summary>
        /// 获取或设置评价 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commentId")]
        [System.Text.Json.Serialization.JsonPropertyName("commentId")]
        public string CommentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置和解的图片 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("picList")]
        [System.Text.Json.Serialization.JsonPropertyName("picList")]
        public IList<string>? PictureMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置和解的文本内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }
    }
}
