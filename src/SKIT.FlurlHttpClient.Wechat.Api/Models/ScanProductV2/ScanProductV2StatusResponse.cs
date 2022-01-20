namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /scan/product/v2/status 接口的响应。</para>
    /// </summary>
    public class ScanProductV2StatusResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                public static class Types
                {
                    public class Product
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pid")]
                        [System.Text.Json.Serialization.JsonPropertyName("pid")]
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误状态码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ret")]
                        [System.Text.Json.Serialization.JsonPropertyName("ret")]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
                        public string? ErrorMessage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置总共导入的数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("total_cnt")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置成功导入的数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("succ_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("succ_cnt")]
                public int SuccessCount { get; set; }

                /// <summary>
                /// 获取或设置导入失败的数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_cnt")]
                public int FailCount { get; set; }

                /// <summary>
                /// 获取或设置整体导入的进度字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("progress")]
                [System.Text.Json.Serialization.JsonPropertyName("progress")]
                public string ProgressString { get; set; } = default!;

                /// <summary>
                /// 获取或设置导入商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("statuses")]
                [System.Text.Json.Serialization.JsonPropertyName("statuses")]
                public Types.Product[] ProductList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置导入结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result Result { get; set; } = default!;
    }
}
