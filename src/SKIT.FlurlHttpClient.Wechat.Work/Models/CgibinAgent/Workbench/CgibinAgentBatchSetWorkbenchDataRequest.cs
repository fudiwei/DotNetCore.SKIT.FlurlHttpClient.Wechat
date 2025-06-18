using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/agent/batch_set_workbench_data 接口的请求。</para>
    /// </summary>
    public class CgibinAgentBatchSetWorkbenchDataRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class KeyDataTemplate : CgibinAgentSetWorkbenchDataRequest.Types.KeyDataTemplate
                    {
                    }

                    public class ImageTemplate : CgibinAgentSetWorkbenchDataRequest.Types.ImageTemplate
                    {
                    }

                    public class WebviewTemplate : CgibinAgentSetWorkbenchDataRequest.Types.WebviewTemplate
                    {
                    }

                    public class ListTemplate : CgibinAgentSetWorkbenchDataRequest.Types.ListTemplate
                    {
                    }
                }

                /// <summary>
                /// 获取或设置模版类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;

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
            }
        }

        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("userid_list")]
        public IList<string> UserIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置用户设置的数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = new Types.Data();
    }
}
