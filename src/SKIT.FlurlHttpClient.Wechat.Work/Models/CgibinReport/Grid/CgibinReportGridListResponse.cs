namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/list 接口的响应。</para>
    /// </summary>
    public class CgibinReportGridListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Grid
            {
                /// <summary>
                /// 获取或设置网格 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grid_id")]
                [System.Text.Json.Serialization.JsonPropertyName("grid_id")]
                public string GridId { get; set; } = default!;

                /// <summary>
                /// 获取或设置网格名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grid_name")]
                [System.Text.Json.Serialization.JsonPropertyName("grid_name")]
                public string Name { get; set; } = default!;

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
                public string[] AdministratorUserIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置网格成员 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grid_member")]
                [System.Text.Json.Serialization.JsonPropertyName("grid_member")]
                public string[] MemberUserIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置网格列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("grid_list")]
        public Types.Grid[] GridList { get; set; } = default!;
    }
}
