namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/externalcontact/customer_acquisition/statistic 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionStatisticResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置点击链接客户数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("click_link_customer_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("click_link_customer_cnt")]
        public int ClickLinkCustomerCount { get; set; }

        /// <summary>
        /// 获取或设置新增客户数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_customer_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("new_customer_cnt")]
        public int NewCustomerCount { get; set; }
    }
}
