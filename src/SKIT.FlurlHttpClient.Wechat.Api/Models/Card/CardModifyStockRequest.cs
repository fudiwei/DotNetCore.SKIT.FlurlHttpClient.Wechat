using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/modifystock 接口的请求。</para>
    /// </summary>
    public class CardModifyStockRequest : WechatApiRequest, IMapResponse<CardModifyStockRequest, CardModifyStockResponse>
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置增加库存数量。与字段 <see cref="ReduceStockValue"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("increase_stock_value")]
        [System.Text.Json.Serialization.JsonPropertyName("increase_stock_value")]
        public int? IncreaseStockValue { get; set; }

        /// <summary>
        /// 获取或设置减少库存数量。与字段 <see cref="IncreaseStockValue"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reduce_stock_value")]
        [System.Text.Json.Serialization.JsonPropertyName("reduce_stock_value")]
        public int? ReduceStockValue { get; set; }
    }
}
