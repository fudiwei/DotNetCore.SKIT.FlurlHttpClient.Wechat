namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /capital/capitallhh/banks/{bank_alias_code}/branches 接口的请求。</para>
    /// </summary>
    public class QueryCapitalBanksBranchesRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置银行别名编码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? BankAliasCode { get; set; }

        /// <summary>
        /// 获取或设置城市编码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int CityCode { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; }
    }
}
