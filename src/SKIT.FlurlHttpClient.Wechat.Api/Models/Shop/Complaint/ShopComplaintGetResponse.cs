namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/complaint/get 接口的响应。</para>
    /// </summary>
    public class ShopComplaintGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ComplaintOrder : ShopComplaintGetListResponse.Types.ComplaintOrder
            {
            }

            public class ComplaintFlowList
            {
                /// <summary>
                /// 获取或设置流程列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public ComplaintFlowItem[] Items { get; set; } = default!;
            }

            public class ComplaintFlowItem
            {
                public static class Types
                {
                    public class Material
                    {
                        /// <summary>
                        /// 获取或设置文本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_url_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_url_list")]
                        public string[] MediaUrlList { get; set; } = default!;
                    }

                    public class OpenPlatformRecord
                    {
                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("state")]
                        [System.Text.Json.Serialization.JsonPropertyName("state")]
                        public int State { get; set; }

                        /// <summary>
                        /// 获取或设置状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("state_describe")]
                        [System.Text.Json.Serialization.JsonPropertyName("state_describe")]
                        public string StateDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置处理事件。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event")]
                        [System.Text.Json.Serialization.JsonPropertyName("event")]
                        public int Event { get; set; }

                        /// <summary>
                        /// 获取或设置处理事件描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event_describe")]
                        [System.Text.Json.Serialization.JsonPropertyName("event_describe")]
                        public string EventDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time")]
                        [System.Text.Json.Serialization.JsonPropertyName("time")]
                        public long Timestamp { get; set; }

                        /// <summary>
                        /// 获取或设置凭证信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("material_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("material_info")]
                        public Material? Material { get; set; }
                    }

                    public class UserRecord : OpenPlatformRecord
                    {

                    }

                    public class MerchantRecord : OpenPlatformRecord
                    {
                        /// <summary>
                        /// 获取或设置处理人员昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operator_nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("operator_nickname")]
                        public string OperatorNickname { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置操作对象类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("object")]
                [System.Text.Json.Serialization.JsonPropertyName("object")]
                public int ObjectType { get; set; }

                /// <summary>
                /// 获取或设置平台操作记录。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("op_record")]
                [System.Text.Json.Serialization.JsonPropertyName("op_record")]
                public Types.OpenPlatformRecord? OpenPlatformRecord { get; set; }

                /// <summary>
                /// 获取或设置用户操作记录。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_record")]
                [System.Text.Json.Serialization.JsonPropertyName("user_record")]
                public Types.UserRecord? UserRecord { get; set; }

                /// <summary>
                /// 获取或设置商家操作记录。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_record")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_record")]
                public Types.MerchantRecord? MerchantRecord { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置纠纷单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.ComplaintOrder ComplaintOrder { get; set; } = default!;

        /// <summary>
        /// 获取或设置纠纷流程列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_info")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_info")]
        public Types.ComplaintFlowList ComplaintFlowList { get; set; } = default!;
    }
}
