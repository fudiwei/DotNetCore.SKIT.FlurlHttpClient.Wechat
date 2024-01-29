namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/getbalance 接口的响应。</para>
    /// </summary>
    public class CgibinMidasGetBalanceResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置游戏币个数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// 获取或设置赠送游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gen_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("gen_balance")]
        public int GenBalance { get; set; }

        /// <summary>
        /// 获取或设置是否满足历史首次充值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_save")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("first_save")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsFirstSave { get; set; }

        /// <summary>
        /// 获取或设置累计充值金额的游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("save_amt")]
        [System.Text.Json.Serialization.JsonPropertyName("save_amt")]
        public int SaveAmount { get; set; }

        /// <summary>
        /// 获取或设置历史总游戏币金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("save_sum")]
        [System.Text.Json.Serialization.JsonPropertyName("save_sum")]
        public int SaveSum { get; set; }

        /// <summary>
        /// 获取或设置历史总消费游戏币金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cost_sum")]
        [System.Text.Json.Serialization.JsonPropertyName("cost_sum")]
        public int CostSum { get; set; }

        /// <summary>
        /// 获取或设置历史累计收到赠送金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_sum")]
        [System.Text.Json.Serialization.JsonPropertyName("present_sum")]
        public int PresentSum { get; set; }
    }
}
