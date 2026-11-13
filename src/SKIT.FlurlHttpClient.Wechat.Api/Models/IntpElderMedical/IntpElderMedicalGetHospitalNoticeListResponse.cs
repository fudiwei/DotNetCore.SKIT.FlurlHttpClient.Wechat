namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/eldermedical/gethospnoticelist 接口的响应。</para>
    /// </summary>
    public class IntpElderMedicalGetHospitalNoticeListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Notice
            {
                /// <summary>
                /// 获取或设置公告 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notice_id")]
                [System.Text.Json.Serialization.JsonPropertyName("notice_id")]
                public int NoticeId { get; set; }

                /// <summary>
                /// 获取或设置公告内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// 获取或设置公告状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string? Status { get; set; }

                /// <summary>
                /// 获取或设置可预览的用户 OpenId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("preview_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("preview_openid")]
                public List<string>? PreviewOpenIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置公告列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notice_list")]
        [System.Text.Json.Serialization.JsonPropertyName("notice_list")]
        public List<Types.Notice>? NoticeList { get; set; }
    }
}
