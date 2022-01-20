namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/broadcast/goods/getapproved 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsGetApprovedRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int AuditStatus { get; set; }
    }
}
