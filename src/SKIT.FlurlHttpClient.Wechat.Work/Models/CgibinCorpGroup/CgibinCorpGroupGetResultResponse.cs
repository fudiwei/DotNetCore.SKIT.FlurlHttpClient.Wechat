namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/corpgroup/getresult 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupGetResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                public static class Types
                {
                    public class ChainContact
                    {
                        public static class Types
                        {
                            public class Contact
                            {
                                /// <summary>
                                /// 获取或设置错误码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("errcode")]
                                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                                public int ErrorCode { get; set; }

                                /// <summary>
                                /// 获取或设置错误描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("errmsg")]
                                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                                public string? ErrorMessage { get; set; }

                                /// <summary>
                                /// 获取或设置联系人手机号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mobile")]
                                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                                public string? MobileNumber { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("errcode")]
                        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("errmsg")]
                        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                        public string? ErrorMessage { get; set; }

                        /// <summary>
                        /// 获取或设置企业名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("corp_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("corp_name")]
                        public string CorpName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置自定义 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_id")]
                        public string? CustomId { get; set; }

                        /// <summary>
                        /// 获取或设置联系人列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_info_list")]
                        public Types.Contact[]? ContactList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置上下游 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chain_id")]
                [System.Text.Json.Serialization.JsonPropertyName("chain_id")]
                public string ChainId { get; set; } = default!;

                /// <summary>
                /// 获取或设置导入状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("import_status")]
                [System.Text.Json.Serialization.JsonPropertyName("import_status")]
                public int ImportStatus { get; set; }

                /// <summary>
                /// 获取或设置导入失败的联系人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
                public Types.ChainContact[]? FailedChainContactList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result? Result { get; set; }
    }
}
