namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /new-tax-control-fapiao/card-template 接口的请求。</para>
    /// </summary>
    public class CreateNewTaxControlFapiaoCardTemplateRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class CartTemplate
            {
                public static class Types
                {
                    public class CustomCell
                    {
                        /// <summary>
                        /// 获取或设置文字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("words")]
                        [System.Text.Json.Serialization.JsonPropertyName("words")]
                        public string Words { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string Description { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置跳转链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("jump_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("jump_url")]
                        public string? JumpUrl { get; set; }

                        /// <summary>
                        /// 获取或设置跳转小程序的用户名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("miniprogram_user_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_user_name")]
                        public string? MiniProgramUsername { get; set; }

                        /// <summary>
                        /// 获取或设置跳转小程序的页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("miniprogram_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_path")]
                        public string? MiniProgramPagePath { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置收款方名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payee_name")]
                [System.Text.Json.Serialization.JsonPropertyName("payee_name")]
                public string? PayeeName { get; set; }

                /// <summary>
                /// 获取或设置卡券 Logo 地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logo_url")]
                [System.Text.Json.Serialization.JsonPropertyName("logo_url")]
                public string? LogoUrl { get; set; }

                /// <summary>
                /// 获取或设置卡券自定义信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_cell")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_cell")]
                public Types.CustomCell? CustomCell { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("card_appid")]
        public string CardAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡券模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_template_information")]
        [System.Text.Json.Serialization.JsonPropertyName("card_template_information")]
        public Types.CartTemplate CartTemplate { get; set; } = new Types.CartTemplate();
    }
}
