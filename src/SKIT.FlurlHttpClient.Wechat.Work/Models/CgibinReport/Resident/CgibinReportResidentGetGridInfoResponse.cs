namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/report/resident/get_grid_info 接口的响应。</para>
    /// </summary>
    public class CgibinReportResidentGetGridInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Grid : CgibinReportPatrolGetGridInfoResponse.Types.Grid
            {
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
