using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/limiteddiscount/add 接口的响应。</para>
    /// </summary>
    public class ProductLimitedDiscountAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置抢购任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int TaskId { get; set; }
    }
}
