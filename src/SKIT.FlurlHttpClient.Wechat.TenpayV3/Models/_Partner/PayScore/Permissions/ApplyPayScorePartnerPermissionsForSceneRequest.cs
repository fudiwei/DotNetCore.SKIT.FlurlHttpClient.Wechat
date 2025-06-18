namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/partner/permissions/apply-for-scene 接口的请求。</para>
    /// </summary>
    public class ApplyPayScorePartnerPermissionsForSceneRequest : ApplyPayScorePartnerPermissionsRequest
    {
        public static class Types
        {
            public class TransactionSceneInfo
            {
                /// <summary>
                /// 获取或设置微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置子商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string SubMerchantId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置授权场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string Scene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信支付交易中授权附带的参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_scene_info")]
        public Types.TransactionSceneInfo? TransactionSceneInfo { get; set; }
    }
}
