﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/limiteddiscounttask/delete 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductLimitedDiscountTaskDeleteRequest : WechatApiRequest, IInferable<ChannelsECProductLimitedDiscountTaskDeleteRequest, ChannelsECProductLimitedDiscountTaskDeleteResponse>
    {
        /// <summary>
        /// 获取或设置抢购任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long TaskId { get; set; }
    }
}
