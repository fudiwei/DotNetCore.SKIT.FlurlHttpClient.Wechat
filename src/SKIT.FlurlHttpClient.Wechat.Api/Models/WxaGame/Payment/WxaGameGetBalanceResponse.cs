namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/getbalance 接口的响应。</para>
    /// </summary>
    public class WxaGameGetBalanceResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置游戏币总余额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// 获取或设置赠送账户的游戏币余额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("present_balance")]
        public int PresentBalance { get; set; }

        /// <summary>
        /// 获取或设置是否满足首充活动。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_save")]
        [System.Text.Json.Serialization.JsonPropertyName("first_save")]
        public bool IsFirstSave { get; set; }

        /// <summary>
        /// 获取或设置累计现金充值获得的游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_save")]
        [System.Text.Json.Serialization.JsonPropertyName("sum_save")]
        public int SumSave { get; set; }

        /// <summary>
        /// 获取或设置累计赠送的游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_present")]
        [System.Text.Json.Serialization.JsonPropertyName("sum_present")]
        public int SumPresent { get; set; }

        /// <summary>
        /// 获取或设置累计获得的游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("sum_balance")]
        public int SumBalance { get; set; }

        /// <summary>
        /// 获取或设置累计总消耗游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum_cost")]
        [System.Text.Json.Serialization.JsonPropertyName("sum_cost")]
        public int SumCost { get; set; }
    }
}
