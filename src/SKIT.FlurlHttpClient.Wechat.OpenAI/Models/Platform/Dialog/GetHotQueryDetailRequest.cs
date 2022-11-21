using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /gethotquerydetail/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class GetHotQueryDetailRequest : WechatOpenAIPlatformRequest, WechatOpenAIPlatformRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [XmlElement("pageNo")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [XmlElement("pageSize")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置命中类型。
        /// </summary>
        [XmlElement("matchType", IsNullable = true)]
        public int? MatchType { get; set; }

        /// <summary>
        /// 获取或设置问题类型。
        /// </summary>
        [XmlElement("cluesType", IsNullable = true)]
        public int? ClueType { get; set; }

        /// <summary>
        /// 获取或设置报告类型。
        /// </summary>
        [XmlElement("reportType", IsNullable = true)]
        public int? ReportType { get; set; }

        /// <summary>
        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [XmlElement("date")]
        public string DateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者的 OpenId。
        /// </summary>
        [XmlElement("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置聚类结果类别 ID。
        /// </summary>
        [XmlElement("clusterId")]
        public string ClusterId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置聚类结果。
        /// </summary>
        [XmlElement("hotQuesCluster", IsNullable = true)]
        public string? HotQuestionCluster { get; set; }
    }
}
