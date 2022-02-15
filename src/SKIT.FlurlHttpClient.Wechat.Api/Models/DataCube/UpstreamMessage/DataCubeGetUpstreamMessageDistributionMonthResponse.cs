namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getupstreammsgdistmonth 接口的响应。</para>
    /// </summary>
    public class DataCubeGetUpstreamMessageDistributionMonthResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data : DataCubeGetUpstreamMessageDistributionResponse.Types.Data
            {
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
