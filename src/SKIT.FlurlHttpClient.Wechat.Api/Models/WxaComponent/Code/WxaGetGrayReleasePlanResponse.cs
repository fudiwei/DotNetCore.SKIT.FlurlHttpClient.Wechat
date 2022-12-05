namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getgrayreleaseplan 接口的响应。</para>
    /// </summary>
    public class WxaGetGrayReleasePlanResponse : WechatApiResponse
    {
        public static class Types
        {
            public class GrayRelease
            {
                /// <summary>
                /// 获取或设置发布状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置当前灰度百分比。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gray_percentage")]
                [System.Text.Json.Serialization.JsonPropertyName("gray_percentage")]
                public int GrayPercentage { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("create_timestamp")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置是否支持按项目成员灰度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("support_debuger_first")]
                [System.Text.Json.Serialization.JsonPropertyName("support_debuger_first")]
                public bool? IsSupportDebuggerFirst { get; set; }

                /// <summary>
                /// 获取或设置是否支持按体验成员灰度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("support_experiencer_first")]
                [System.Text.Json.Serialization.JsonPropertyName("support_experiencer_first")]
                public bool? IsSupportExperiencerFirst { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分阶段发布计划信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gray_release_plan")]
        [System.Text.Json.Serialization.JsonPropertyName("gray_release_plan")]
        public Types.GrayRelease GrayRelease { get; set; } = default!;
    }
}
