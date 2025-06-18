namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/report/patrol/get_grid_info 接口的响应。</para>
    /// </summary>
    public class CgibinReportPatrolGetGridInfoResponse : WechatWorkResponse
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
                /// 获取或设置管理员 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grid_admin")]
                [System.Text.Json.Serialization.JsonPropertyName("grid_admin")]
                public string[] AdministratorUserIdList { get; set; } = default!;
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
