using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /sp_entrustment/get 接口的响应。</para>
    /// </summary>
    public class SpEntrustmentGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置是否有授权关系。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entrusted")]
                [System.Text.Json.Serialization.JsonPropertyName("entrusted")]
                public bool IsEntrusted { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
