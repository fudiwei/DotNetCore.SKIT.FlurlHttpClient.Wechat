namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/wxamptrade/get_penalty_list 接口的请求。</para>
    /// </summary>
    public class WxaApiWxaMpTradeGetPenaltyListRequest : WechatApiRequest, IInferable<WxaApiWxaMpTradeGetPenaltyListRequest, WxaApiWxaMpTradeGetPenaltyListResponse>
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Limit { get; set; } = 10;
    }
}
