using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/add 接口的请求。</para>
    /// </summary>
    public class CgibinReportGridAddRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置网格名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grid_name")]
        [System.Text.Json.Serialization.JsonPropertyName("grid_name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上级网格 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grid_parent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("grid_parent_id")]
        public string? ParentGridId { get; set; }

        /// <summary>
        /// 获取或设置管理员 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grid_admin")]
        [System.Text.Json.Serialization.JsonPropertyName("grid_admin")]
        public IList<string> AdministratorUserIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置网格成员 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grid_member")]
        [System.Text.Json.Serialization.JsonPropertyName("grid_member")]
        public IList<string>? MemberUserIdList { get; set; }
    }
}
