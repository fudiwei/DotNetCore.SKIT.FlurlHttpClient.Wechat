namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/agent/get_workbench_template 接口的响应。</para>
    /// </summary>
    public class CgibinAgentGetWorkbenchTemplateResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class KeyDataTemplate
            {
                public static class Types
                {
                    public class KeyDataItem
                    {
                        /// <summary>
                        /// 获取或设置关键数据名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string? Key { get; set; }

                        /// <summary>
                        /// 获取或设置关键数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("data")]
                        [System.Text.Json.Serialization.JsonPropertyName("data")]
                        public string Data { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置点击跳转链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("jump_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("jump_url")]
                        public string? JumpUrl { get; set; }

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pagepath")]
                        [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                        public string? MiniProgramPagePath { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置关键数据项。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public Types.KeyDataItem[] Items { get; set; } = default!;
            }

            public class ImageTemplate
            {
                /// <summary>
                /// 获取或设置图片 Url。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// 获取或设置点击跳转链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jump_url")]
                [System.Text.Json.Serialization.JsonPropertyName("jump_url")]
                public string? JumpUrl { get; set; }

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pagepath")]
                [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                public string? MiniProgramPagePath { get; set; }
            }

            public class WebviewTemplate
            {
                /// <summary>
                /// 获取或设置渲染展示 Url。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// 获取或设置点击跳转链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jump_url")]
                [System.Text.Json.Serialization.JsonPropertyName("jump_url")]
                public string? JumpUrl { get; set; }

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pagepath")]
                [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                public string? MiniProgramPagePath { get; set; }
            }

            public class ListTemplate
            {
                public static class Types
                {
                    public class ListItem
                    {
                        /// <summary>
                        /// 获取或设置列表显示文字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置点击跳转链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("jump_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("jump_url")]
                        public string? JumpUrl { get; set; }

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pagepath")]
                        [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                        public string? MiniProgramPagePath { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置列表项。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public Types.ListItem[] Items { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置模版类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置关键数据型模版数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keydata")]
        [System.Text.Json.Serialization.JsonPropertyName("keydata")]
        public Types.KeyDataTemplate? KeyDataTemplate { get; set; }

        /// <summary>
        /// 获取或设置图片型模版数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.ImageTemplate? ImageTemplate { get; set; }

        /// <summary>
        /// 获取或设置列表型模版数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.ListTemplate? ListTemplate { get; set; }

        /// <summary>
        /// 获取或设置网页型模版数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webview")]
        [System.Text.Json.Serialization.JsonPropertyName("webview")]
        public Types.WebviewTemplate? WebviewTemplate { get; set; }

        /// <summary>
        /// 获取或设置是否覆盖用户工作台的数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("replace_user_data")]
        [System.Text.Json.Serialization.JsonPropertyName("replace_user_data")]
        public bool IsReplaceUserData { get; set; }
    }
}
