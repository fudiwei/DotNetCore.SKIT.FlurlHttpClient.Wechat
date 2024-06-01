using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_auth_info 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetAuthInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class DealerCorp
            {
                /// <summary>
                /// 获取或设置企业 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string CorpId { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_name")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_name")]
                public string Name { get; set; } = default!;
            }

            public class AuthorizerCorp : DealerCorp
            {
                public static class Types
                {
                    public class CorpExtraName
                    {
                        /// <summary>
                        /// 获取或设置企业简称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("name_list")]
                        public string Names { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置企业类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_type")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业方形头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_square_logo_url")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_square_logo_url")]
                public string? SquareLogoUrl { get; set; }

                /// <summary>
                /// 获取或设置用户数上限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_user_max")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_user_max")]
                public int MaxUsers { get; set; }

                /// <summary>
                /// 获取或设置应用数上限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_agent_max")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_agent_max")]
                public int MaxAgents { get; set; }

                /// <summary>
                /// 获取或设置主体名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_full_name")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_full_name")]
                public string? SubjectFullName { get; set; }

                /// <summary>
                /// 获取或设置主体类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject_type")]
                [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
                public int? SubjectType { get; set; }

                /// <summary>
                /// 获取或设置认证到期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verified_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("verified_end_time")]
                public long? VerifyExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置企业微工作台二维码 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_wxqrcode")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_wxqrcode")]
                public string? QrcodeUrl { get; set; }

                /// <summary>
                /// 获取或设置企业规模。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_scale")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_scale")]
                public string? Scale { get; set; }

                /// <summary>
                /// 获取或设置企业所属行业。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_industry")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_industry")]
                public string? Industry { get; set; }

                /// <summary>
                /// 获取或设置企业所属子行业。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_sub_industry")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_sub_industry")]
                public string? SubIndustry { get; set; }

                /// <summary>
                /// 获取或设置企业所在地。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public string? Location { get; set; }

                /// <summary>
                /// 获取或设置企业其他简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_ex_name")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_ex_name")]
                public Types.CorpExtraName? CorpExtraName { get; set; } = default!;
            }

            public class Authorization
            {
                public static class Types
                {
                    public class Agent
                    {
                        public static class Types
                        {
                            public class Privilege
                            {
                                /// <summary>
                                /// 获取或设置权限等级。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("level")]
                                [System.Text.Json.Serialization.JsonPropertyName("level")]
                                public int Level { get; set; }

                                /// <summary>
                                /// 获取或设置可见成员账号列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("allow_user")]
                                [System.Text.Json.Serialization.JsonPropertyName("allow_user")]
                                public string[]? AllowedUserIdList { get; set; }

                                /// <summary>
                                /// 获取或设置可见部门 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("allow_party")]
                                [System.Text.Json.Serialization.JsonPropertyName("allow_party")]
                                public long[]? AllowedDepartmentIdList { get; set; }

                                /// <summary>
                                /// 获取或设置可见标签 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("allow_tag")]
                                [System.Text.Json.Serialization.JsonPropertyName("allow_tag")]
                                public int[]? AllowedTagIdList { get; set; }

                                /// <summary>
                                /// 获取或设置额外成员账号列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("extra_user")]
                                [System.Text.Json.Serialization.JsonPropertyName("extra_user")]
                                public string[]? ExtraUserIdList { get; set; }

                                /// <summary>
                                /// 获取或设置额外部门 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("extra_party")]
                                [System.Text.Json.Serialization.JsonPropertyName("extra_party")]
                                public long[]? ExtraDepartmentIdList { get; set; }

                                /// <summary>
                                /// 获取或设置额外标签 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("extra_tag")]
                                [System.Text.Json.Serialization.JsonPropertyName("extra_tag")]
                                public int[]? ExtraTagIdList { get; set; }
                            }

                            public class SharedFrom
                            {
                                /// <summary>
                                /// 获取或设置企业 CorpId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("corpid")]
                                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                                public string? CorpId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置应用 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("agentid")]
                        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
                        public int AgentId { get; set; }

                        /// <summary>
                        /// 获取或设置应用名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置应用方形头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("square_logo_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("square_logo_url")]
                        public string SquareLogoUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置应用圆形头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("round_logo_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("round_logo_url")]
                        public string RoundLogoUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置第三方套件应用 AppId。
                        /// </summary>
                        [Obsolete("相关接口或字段于 2020-01-13 下线。")]
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public int? AppId { get; set; }

                        /// <summary>
                        /// 获取或设置授权模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auth_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("auth_mode")]
                        public int AuthMode { get; set; }

                        /// <summary>
                        /// 获取或设置应用权限信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("privilege")]
                        [System.Text.Json.Serialization.JsonPropertyName("privilege")]
                        public Types.Privilege Privilege { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置共享了应用的互联企业信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shared_from")]
                        [System.Text.Json.Serialization.JsonPropertyName("shared_from")]
                        public Types.SharedFrom? SharedFrom { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置授权的应用列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agent")]
                [System.Text.Json.Serialization.JsonPropertyName("agent")]
                public Types.Agent[] AgentList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置代理服务商企业信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dealer_corp_info")]
        [System.Text.Json.Serialization.JsonPropertyName("dealer_corp_info")]
        public Types.DealerCorp? DealerCorp { get; set; }

        /// <summary>
        /// 获取或设置授权方企业信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_corp_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_corp_info")]
        public Types.AuthorizerCorp? AuthorizerCorp { get; set; }

        /// <summary>
        /// 获取或设置授权信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
        public Types.Authorization? Authorization { get; set; }
    }
}
