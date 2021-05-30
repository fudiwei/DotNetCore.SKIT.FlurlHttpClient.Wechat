using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/add_contact_way 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactAddContactWayRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Conclusion
            {
                public static class Types
                {
                    public class Text
                    {
                        /// <summary>
                        /// 获取或设置文本内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = string.Empty;
                    }

                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string MediaId { get; set; } = string.Empty;
                    }

                    public class Link
                    {
                        /// <summary>
                        /// 获取或设置图文消息 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图文消息标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置图文消息描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置图文消息封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("picurl")]
                        [System.Text.Json.Serialization.JsonPropertyName("picurl")]
                        public string? PictureUrl { get; set; }
                    }

                    public class MiniProgram
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page")]
                        [System.Text.Json.Serialization.JsonPropertyName("page")]
                        public string PagePath { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置小程序缩略图 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pic_media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic_media_id")]
                        public string? PictureMediaId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置文本类型结束语。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public Types.Text? Text { get; set; }

                /// <summary>
                /// 获取或设置图片类型结束语。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public Types.Image? Image { get; set; }

                /// <summary>
                /// 获取或设置链接类型结束语。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link")]
                [System.Text.Json.Serialization.JsonPropertyName("link")]
                public Types.Link? Link { get; set; }

                /// <summary>
                /// 获取或设置小程序类型结束语。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("miniprogram")]
                [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                public Types.MiniProgram? MiniProgram { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置联系方式类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public int Scene { get; set; }

        /// <summary>
        /// 获取或设置控件样式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("style")]
        [System.Text.Json.Serialization.JsonPropertyName("style")]
        public int? Style { get; set; }

        /// <summary>
        /// 获取或设置备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置是否无需验证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skip_verify")]
        [System.Text.Json.Serialization.JsonPropertyName("skip_verify")]
        public bool? IsSkipVerify { get; set; }

        /// <summary>
        /// 获取或设置企业自定义的渠道参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置使用该联系方式的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user")]
        [System.Text.Json.Serialization.JsonPropertyName("user")]
        public IList<string>? UserIdList { get; set; }

        /// <summary>
        /// 获取或设置使用该联系方式的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("party")]
        [System.Text.Json.Serialization.JsonPropertyName("party")]
        public IList<int>? DepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置是否临时会话模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_temp")]
        [System.Text.Json.Serialization.JsonPropertyName("is_temp")]
        public bool? IsTemp { get; set; }

        /// <summary>
        /// 获取或设置临时会话二维码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int? TempQrcodeExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置临时会话有效期有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_expires_in")]
        public int? TempChatExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置可进行临时会话的客户 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

        /// <summary>
        /// 获取或设置结束语信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conclusions")]
        [System.Text.Json.Serialization.JsonPropertyName("conclusions")]
        public Types.Conclusion? Conclusions { get; set; }
    }
}
