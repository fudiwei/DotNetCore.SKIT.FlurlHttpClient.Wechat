using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_set_black_list 接口的请求。</para>
    /// </summary>
    public class WxaOperationAMSAgencySetBlackListRequest : WechatApiRequest, IInferable<WxaOperationAMSAgencySetBlackListRequest, WxaOperationAMSAgencySetBlackListResponse>
    {
        public static class Types
        {
            public class Advertiser
            {
                /// <summary>
                /// 获取或设置屏蔽类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置广告主 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string Id { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op")]
        [System.Text.Json.Serialization.JsonPropertyName("op")]
        public int OperateType { get; set; }

        /// <summary>
        /// 获取或设置屏蔽的广告主列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public IList<Types.Advertiser> BlackList { get; set; } = new List<Types.Advertiser>();
    }
}
