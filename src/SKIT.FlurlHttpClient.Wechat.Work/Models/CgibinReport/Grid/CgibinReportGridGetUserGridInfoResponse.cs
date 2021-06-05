using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/get_user_grid_info 接口的响应。</para>
    /// </summary>
    public class CgibinReportGridGetUserGridInfoResponse : WechatWorkResponse
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
            }
        }

        /// <summary>
        /// 获取或设置管理的网格列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manage_grids")]
        [System.Text.Json.Serialization.JsonPropertyName("manage_grids")]
        public Types.Grid[] ManagedGridList { get; set; } = default!;

        /// <summary>
        /// 获取或设置加入的网格列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("joined_grids")]
        [System.Text.Json.Serialization.JsonPropertyName("joined_grids")]
        public Types.Grid[] JoinedGridList { get; set; } = default!;
    }
}
