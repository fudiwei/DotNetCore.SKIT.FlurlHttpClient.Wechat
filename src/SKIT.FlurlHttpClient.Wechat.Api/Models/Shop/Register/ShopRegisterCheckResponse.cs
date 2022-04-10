namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/register/check 接口的响应。</para>
    /// </summary>
    public class ShopRegisterCheckResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Access
                    {
                        /// <summary>
                        /// 获取或设置商品接口调试完成是否完成。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_audit_finished")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_audit_finished")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsSPUAuditFinished { get; set; }

                        /// <summary>
                        /// 获取或设置上传商品并审核是否成功。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_audit_success")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_audit_success")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsSPUAuditSuccessful { get; set; }

                        /// <summary>
                        /// 获取或设置物流接口调用是否完成。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_delivery_finished")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("send_delivery_finished")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsSendDeliveryFinished { get; set; }

                        /// <summary>
                        /// 获取或设置物流接口调用是否成功。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_delivery_success")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("send_delivery_success")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsSendDeliverySuccessful { get; set; }

                        /// <summary>
                        /// 获取或设置发起一笔订单并支付是否完成。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ec_order_finished")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("ec_order_finished")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsECOrderFinished { get; set; }

                        /// <summary>
                        /// 获取或设置发起一笔订单并支付是否成功。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ec_order_success")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("ec_order_success")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsECOrderSuccessful { get; set; }

                        /// <summary>
                        /// 获取或设置售后接口调用是否完成。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ec_after_sale_finished")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("ec_after_sale_finished")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsECAftersaleFinished { get; set; }

                        /// <summary>
                        /// 获取或设置售后接口调用是否成功。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ec_after_sale_success")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("ec_after_sale_success")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsECAftersaleSuccessful { get; set; }

                        /// <summary>
                        /// 获取或设置是否测试完成。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("test_api_finished")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("test_api_finished")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsTestApiFinished { get; set; }

                        /// <summary>
                        /// 获取或设置是否发版完成。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deploy_wxa_finished")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("deploy_wxa_finished")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsDepolyWxaFinished { get; set; }

                        /// <summary>
                        /// 获取或设置是否完成自定义组件全部任务。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_product_task_finished")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("open_product_task_finished")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsOpenProductTaskFinished { get; set; }
                    }

                    public class SceneGroup
                    {
                        public static class Types
                        {
                            public class SceneGroupExtra
                            {
                                /// <summary>
                                /// 获取或设置审核项目 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ext_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("ext_id")]
                                public int ExtraId { get; set; }

                                /// <summary>
                                /// 获取或设置审核项目状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置场景 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("group_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                        public int SceneGroupId { get; set; }

                        /// <summary>
                        /// 获取或设置场景名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置审核文案。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? Reason { get; set; }

                        /// <summary>
                        /// 获取或设置场景审核结果列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_group_ext_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_group_ext_list")]
                        public Types.SceneGroupExtra[] SceneGroupExtraList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置接入相关信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_info")]
                [System.Text.Json.Serialization.JsonPropertyName("access_info")]
                public Types.Access? Access { get; set; }

                /// <summary>
                /// 获取或设置场景接入相关信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_group_list")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_group_list")]
                public Types.SceneGroup[]? SceneGroupList { get; set; }
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
