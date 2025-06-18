﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/account/componentrebindadmin 接口的请求。</para>
    /// </summary>
    public class CgibinAccountComponentRebindAdminRequest : WechatApiRequest, IInferable<CgibinAccountComponentRebindAdminRequest, CgibinAccountComponentRebindAdminResponse>
    {
        /// <summary>
        /// 获取或设置换绑管理员任务序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("taskid")]
        public string TaskId { get; set; } = string.Empty;
    }
}
