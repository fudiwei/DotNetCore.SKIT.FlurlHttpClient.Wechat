using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/account/update_info 接口的请求。</para>
    /// </summary>
    public class ShopAccountUpdateInfoRequest : WechatApiRequest, IInferable<ShopAccountUpdateInfoRequest, ShopAccountUpdateInfoResponse>
    {
        public static class Types
        {
            public class Address
            {
                /// <summary>
                /// 获取或设置收件人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_name")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_name")]
                public string ReceiverName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置国家。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country")]
                [System.Text.Json.Serialization.JsonPropertyName("country")]
                public string? Country { get; set; }

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string? Province { get; set; }

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string? City { get; set; }

                /// <summary>
                /// 获取或设置区县。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("town")]
                [System.Text.Json.Serialization.JsonPropertyName("town")]
                public string? District { get; set; }

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detailed_address")]
                [System.Text.Json.Serialization.JsonPropertyName("detailed_address")]
                public string Detail { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tel_number")]
                [System.Text.Json.Serialization.JsonPropertyName("tel_number")]
                public string TeleNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置客服页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_agent_path")]
        [System.Text.Json.Serialization.JsonPropertyName("service_agent_path")]
        public string? ServiceAgentPagePath { get; set; }

        /// <summary>
        /// 获取或设置客服联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_agent_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("service_agent_phone")]
        public string? ServiceAgentPhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置客服类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_agent_type")]
        [System.Text.Json.Serialization.JsonPropertyName("service_agent_type")]
        public IList<int>? ServiceAgentTypeList { get; set; }

        /// <summary>
        /// 获取或设置默认退货地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_receiving_address")]
        [System.Text.Json.Serialization.JsonPropertyName("default_receiving_address")]
        public Types.Address? DefaultReceivingAddress { get; set; }
    }
}
