namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /daily_reports/get 接口的请求。</para>
    /// </summary>
    public class DailyReportsGetRequest : WechatAdsRequest
    {
        public static class Types
        {
            public class DateRange : Abstractions.CommonDateRange
            {
            }
        }

        /// <summary>
        /// 获取或设置时间范围。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Types.DateRange DateRange { get; set; } = new Types.DateRange();

        /// <summary>
        /// 获取或设置报表类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ReportType { get; set; }

        /// <summary>
        /// 获取或设置报表层级。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ReportLevel { get; set; }

        /// <summary>
        /// 获取或设置页大小。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? PageSize { get; set; }

        /// <summary>
        /// 获取或设置页码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Page { get; set; }
    }
}
