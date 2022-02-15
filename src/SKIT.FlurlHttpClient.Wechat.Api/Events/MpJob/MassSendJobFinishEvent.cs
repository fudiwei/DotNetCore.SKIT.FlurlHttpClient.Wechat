namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.MASSSENDJOBFINISH 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Batch_Sends_and_Originality_Checks.html#7 </para>
    /// </summary>
    public class MassSendJobFinishEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class CopyrightCheckResult
            {
                public static class Types
                {
                    public class CopyrightCheckResultItem
                    {
                        /// <summary>
                        /// 获取或设置文章在图文消息中的位置（从 0 开始）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ArticleIdx")]
                        [System.Text.Json.Serialization.JsonPropertyName("ArticleIdx")]
                        [System.Xml.Serialization.XmlElement("ArticleIdx")]
                        public int ArticleIndex { get; set; }

                        /// <summary>
                        /// 获取或设置用户声明文章的状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("UserDeclareState")]
                        [System.Text.Json.Serialization.JsonPropertyName("UserDeclareState")]
                        [System.Xml.Serialization.XmlElement("UserDeclareState")]
                        public int UserDeclareState { get; set; }

                        /// <summary>
                        /// 获取或设置系统校验的状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("AuditState")]
                        [System.Text.Json.Serialization.JsonPropertyName("AuditState")]
                        [System.Xml.Serialization.XmlElement("AuditState")]
                        public int AuditState { get; set; }

                        /// <summary>
                        /// 获取或设置相似原创文的链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("OriginalArticleUrl")]
                        [System.Text.Json.Serialization.JsonPropertyName("OriginalArticleUrl")]
                        [System.Xml.Serialization.XmlElement("OriginalArticleUrl")]
                        public string OriginalArticleUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置相似原创文的类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("OriginalArticleType")]
                        [System.Text.Json.Serialization.JsonPropertyName("OriginalArticleType")]
                        [System.Xml.Serialization.XmlElement("OriginalArticleType")]
                        public int OriginalArticleType { get; set; }

                        /// <summary>
                        /// 获取或设置是否能转载。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CanReprint")]
                        [System.Text.Json.Serialization.JsonPropertyName("CanReprint")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        [System.Xml.Serialization.XmlElement("CanReprint")]
                        public bool CanReprint { get; set; }

                        /// <summary>
                        /// 获取或设置是否需要替换成原创文内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("NeedReplaceContent")]
                        [System.Text.Json.Serialization.JsonPropertyName("NeedReplaceContent")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        [System.Xml.Serialization.XmlElement("NeedReplaceContent")]
                        public bool RequireReplaceContent { get; set; }

                        /// <summary>
                        /// 获取或设置是否需要注明转载来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("NeedShowReprintSource")]
                        [System.Text.Json.Serialization.JsonPropertyName("NeedShowReprintSource")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        [System.Xml.Serialization.XmlElement("NeedShowReprintSource")]
                        public bool RequireShowReprintSource { get; set; }
                    }

                    public class CopyrightCheckResultList
                    {
                        /// <summary>
                        /// 获取或设置校验结果列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item")]
                        [System.Text.Json.Serialization.JsonPropertyName("item")]
                        [System.Xml.Serialization.XmlArrayItem("item", Type = typeof(CopyrightCheckResultItem))]
                        public CopyrightCheckResultItem[] Items { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置校验数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Count")]
                [System.Text.Json.Serialization.JsonPropertyName("Count")]
                [System.Xml.Serialization.XmlElement("Count")]
                public int CheckCount { get; set; }

                /// <summary>
                /// 获取或设置整体校验结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("CheckState")]
                [System.Text.Json.Serialization.JsonPropertyName("CheckState")]
                [System.Xml.Serialization.XmlElement("CheckState")]
                public int CheckState { get; set; }

                /// <summary>
                /// 获取或设置校验结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ResultList")]
                [System.Text.Json.Serialization.JsonPropertyName("ResultList")]
                [System.Xml.Serialization.XmlElement("ResultList", Type = typeof(Types.CopyrightCheckResultList))]
                public Types.CopyrightCheckResultList ResultList { get; set; } = default!;
            }

            public class ArticleUrlResult
            {
                public static class Types
                {
                    public class ArticleUrlResultItem
                    {
                        /// <summary>
                        /// 获取或设置文章在图文消息中的位置（从 0 开始）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ArticleIdx")]
                        [System.Text.Json.Serialization.JsonPropertyName("ArticleIdx")]
                        [System.Xml.Serialization.XmlElement("ArticleIdx")]
                        public int ArticleIndex { get; set; }

                        /// <summary>
                        /// 获取或设置文章链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ArticleUrl")]
                        [System.Text.Json.Serialization.JsonPropertyName("ArticleUrl")]
                        [System.Xml.Serialization.XmlElement("ArticleUrl")]
                        public string ArticleUrl { get; set; } = default!;
                    }

                    public class ArticleUrlResultList
                    {
                        /// <summary>
                        /// 获取或设置校验结果列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item")]
                        [System.Text.Json.Serialization.JsonPropertyName("item")]
                        [System.Xml.Serialization.XmlArrayItem("item", Type = typeof(ArticleUrlResultItem))]
                        public ArticleUrlResultItem[] Items { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置文章数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Count")]
                [System.Text.Json.Serialization.JsonPropertyName("Count")]
                [System.Xml.Serialization.XmlElement("Count")]
                public int ArticleCount { get; set; }

                /// <summary>
                /// 获取或设置发送结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ResultList")]
                [System.Text.Json.Serialization.JsonPropertyName("ResultList")]
                [System.Xml.Serialization.XmlElement("ResultList", Type = typeof(Types.ArticleUrlResultList))]
                public Types.ArticleUrlResultList ResultList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgID")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgID")]
        [System.Xml.Serialization.XmlElement("MsgID")]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置发送状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Status")]
        [System.Text.Json.Serialization.JsonPropertyName("Status")]
        [System.Xml.Serialization.XmlElement("Status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置总人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TotalCount")]
        [System.Text.Json.Serialization.JsonPropertyName("TotalCount")]
        [System.Xml.Serialization.XmlElement("TotalCount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置过滤人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FilterCount")]
        [System.Text.Json.Serialization.JsonPropertyName("FilterCount")]
        [System.Xml.Serialization.XmlElement("FilterCount")]
        public int FilterCount { get; set; }

        /// <summary>
        /// 获取或设置发送成功人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SentCount")]
        [System.Text.Json.Serialization.JsonPropertyName("SentCount")]
        [System.Xml.Serialization.XmlElement("SentCount")]
        public int SentCount { get; set; }

        /// <summary>
        /// 获取或设置发送失败人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ErrorCount")]
        [System.Text.Json.Serialization.JsonPropertyName("ErrorCount")]
        [System.Xml.Serialization.XmlElement("ErrorCount")]
        public int ErrorCount { get; set; }

        /// <summary>
        /// 获取或设置版权校验结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CopyrightCheckResult")]
        [System.Text.Json.Serialization.JsonPropertyName("CopyrightCheckResult")]
        [System.Xml.Serialization.XmlElement("CopyrightCheckResult", IsNullable = true)]
        public Types.CopyrightCheckResult? CopyrightCheckResult { get; set; }

        /// <summary>
        /// 获取或设置文章发送结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ArticleUrlResult")]
        [System.Text.Json.Serialization.JsonPropertyName("ArticleUrlResult")]
        [System.Xml.Serialization.XmlElement("ArticleUrlResult", IsNullable = true)]
        public Types.ArticleUrlResult? ArticleUrlResult { get; set; }
    }
}
