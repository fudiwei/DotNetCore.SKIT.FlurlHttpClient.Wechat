namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/v3/wxa/info/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVipWxaInfoGetV3Response : WechatApiResponse
    {
        public static class Types
        {
            public class MiniProgramInfo
            {
                public static class Types
                {
                    public class PathInfo
                    {
                        /// <summary>
                        /// 获取或设置会员注册页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("register_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("register_path")]
                        public string RegisterPathPath { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置会员权益页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rights_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("rights_path")]
                        public string RightsPagePath { get; set; } = default!;
                    }

                    public class DisplayInfo
                    {
                        /// <summary>
                        /// 获取或设置下单页权益展示开关。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_page_display")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_page_display")]
                        public int OrderPageDisplayMode { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置页面路径信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paths")]
                [System.Text.Json.Serialization.JsonPropertyName("paths")]
                public Types.PathInfo PathInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置测试白名单用户 OpenId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("whitelist_openids")]
                [System.Text.Json.Serialization.JsonPropertyName("whitelist_openids")]
                public string[] WhiteListOpenIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置展示信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("display_info")]
                [System.Text.Json.Serialization.JsonPropertyName("display_info")]
                public Types.DisplayInfo DisplayInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_appid")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.MiniProgramInfo MiniProgramInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public int State { get; set; }
    }
}
