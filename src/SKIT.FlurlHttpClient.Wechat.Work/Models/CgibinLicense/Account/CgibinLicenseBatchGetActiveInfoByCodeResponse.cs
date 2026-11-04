namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/batch_get_active_info_by_code 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseBatchGetActiveInfoByCodeResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ActiveInfo : CgibinLicenseGetActiveInfoByCodeResponse.Types.__zz__ActiveInfo
            {
                public static class Types
                {
                    public class MergeInfo : CgibinLicenseGetActiveInfoByCodeResponse.Types.ActiveInfo.Types.MergeInfo
                    {
                    }

                    public class ShareInfo : CgibinLicenseGetActiveInfoByCodeResponse.Types.ActiveInfo.Types.ShareInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置合并信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merge_info")]
                [System.Text.Json.Serialization.JsonPropertyName("merge_info")]
                public Types.MergeInfo? MergeInfo { get; set; }

                /// <summary>
                /// 获取或设置分享信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_info")]
                [System.Text.Json.Serialization.JsonPropertyName("share_info")]
                public Types.ShareInfo? ShareInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置账号激活列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("active_info_list")]
        public List<Types.ActiveInfo>? ActiveList { get; set; }

        /// <summary>
        /// 获取或设置无效的激活码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_active_code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_active_code_list")]
        public List<string>? InvalidActiveCodeList { get; set; }
    }
}
