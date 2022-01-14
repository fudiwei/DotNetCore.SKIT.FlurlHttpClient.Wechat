using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/wxopen/updatablemsg/send 接口的请求。</para>
    /// </summary>
    public class CgibinMessageWxopenUpdatableMessageSendRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Template
            {
                public static class Types
                {
                    public class Parameter
                    {
                        /// <summary>
                        /// 获取或设置要修改的参数名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置修改后的参数值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置模板中需要修改的参数列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parameter_list")]
                [System.Text.Json.Serialization.JsonPropertyName("parameter_list")]
                public IList<Types.Parameter> ParameterList { get; set; } = new List<Types.Parameter>();
            }
        }

        /// <summary>
        /// 获取或设置动态消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置动态消息修改后的状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_state")]
        [System.Text.Json.Serialization.JsonPropertyName("target_state")]
        public int TargetState { get; set; }

        /// <summary>
        /// 获取或设置动态消息对应的模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_info")]
        [System.Text.Json.Serialization.JsonPropertyName("template_info")]
        public Types.Template Template { get; set; } = new Types.Template();
    }
}
