namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/externalcontact/customer_acquisition/statistic 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionStatisticRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置获客链接 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string LinkId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置统计起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置统计结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long EndTimestamp { get; set; }
    }
}
