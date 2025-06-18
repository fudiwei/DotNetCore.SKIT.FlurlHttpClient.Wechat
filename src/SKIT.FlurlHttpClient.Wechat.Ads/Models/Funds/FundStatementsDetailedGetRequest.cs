namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /fund_statements_detailed/get 接口的请求。</para>
    /// </summary>
    public class FundStatementsDetailedGetRequest : WechatAdsRequest
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
        /// 获取或设置交易类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? TradeType { get; set; }

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

        /// <summary>
        /// 获取或设置微信广告平台的版本号。
        /// <para>默认值："v1.1"</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string Version { get; set; } = "v1.1";
    }
}
