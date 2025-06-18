using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/addguidemassendjob 接口的请求。</para>
    /// </summary>
    public class CgibinGuideAddGuideMassSendJobRequest : WechatApiRequest, IInferable<CgibinGuideAddGuideMassSendJobRequest, CgibinGuideAddGuideMassSendJobResponse>
    {
        public static class Types
        {
            public class Material
            {
                /// <summary>
                /// 获取或设置素材类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置图片素材或小程序卡片素材封面媒体文件标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string? MediaId { get; set; }

                /// <summary>
                /// 获取或设置文字素材内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("word")]
                [System.Text.Json.Serialization.JsonPropertyName("word")]
                public string? Word { get; set; }

                /// <summary>
                /// 获取或设置小程序卡片素材 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置小程序卡片素材名字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置小程序卡片素材路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string? Path { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置顾问微信号。与字段 <see cref="GuideOpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_account")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_account")]
        public string? GuideAccount { get; set; }

        /// <summary>
        /// 获取或设置顾问 OpenId。与字段 <see cref="GuideAccount"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_openid")]
        public string? GuideOpenId { get; set; }

        /// <summary>
        /// 获取或设置群发任务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_name")]
        [System.Text.Json.Serialization.JsonPropertyName("task_name")]
        public string TaskName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群发任务备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("task_remark")]
        public string? TaskRemark { get; set; }

        /// <summary>
        /// 获取或设置任务下发时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("push_time")]
        [System.Text.Json.Serialization.JsonPropertyName("push_time")]
        public long PushTimestamp { get; set; }

        /// <summary>
        /// 获取或设置客户 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public IList<string> BuyerOpenIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material")]
        [System.Text.Json.Serialization.JsonPropertyName("material")]
        public IList<Types.Material> MaterialList { get; set; } = new List<Types.Material>();
    }
}
