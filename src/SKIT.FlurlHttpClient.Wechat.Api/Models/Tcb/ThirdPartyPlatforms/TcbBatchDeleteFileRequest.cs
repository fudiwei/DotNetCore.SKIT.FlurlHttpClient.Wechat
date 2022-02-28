using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/batchdeletefile 接口的请求。</para>
    /// </summary>
    public class TcbBatchDeleteFileRequest : WechatApiRequest, IInferable<TcbBatchDeleteFileRequest, TcbBatchDeleteFileResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid_list")]
        public IList<string> FileIdList { get; set; } = new List<string>();
    }
}
