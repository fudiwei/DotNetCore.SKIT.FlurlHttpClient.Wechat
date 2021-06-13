namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/get_store_list 接口的响应。</para>
    /// </summary>
    public class WxaGetStoreListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class POI
            {
                public static class Types
                {
                    public class Base : WxaGetStoreInfoResponse.Types.POI.Types.Base
                    {
                    }
                }

                /// <summary>
                /// 获取或设置门店基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_list")]
        [System.Text.Json.Serialization.JsonPropertyName("business_list")]
        public Types.POI[] POIList { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int Total { get; set; }
    }
}
