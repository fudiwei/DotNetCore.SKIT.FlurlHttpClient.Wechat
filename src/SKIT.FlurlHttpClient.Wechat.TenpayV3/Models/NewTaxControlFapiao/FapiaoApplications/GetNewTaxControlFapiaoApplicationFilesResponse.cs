namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/fapiao-files 接口的响应。</para>
    /// </summary>
    public class GetNewTaxControlFapiaoApplicationFilesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class FapiaoFile
            {
                /// <summary>
                /// 获取或设置商户发票单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fapiao_id")]
                [System.Text.Json.Serialization.JsonPropertyName("fapiao_id")]
                public string FapiaoId { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string FapiaoStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票文件下载地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("download_url")]
                [System.Text.Json.Serialization.JsonPropertyName("download_url")]
                public string? DownloadUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发票文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fapiao_download_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fapiao_download_info_list")]
        public Types.FapiaoFile[] FapiaoFile { get; set; } = default!;
    }
}
