using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/account/cancel-applications 接口的请求。</para>
    /// </summary>
    public class CreateEcommerceAccountCancelApplicationRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class ApplicationMaterial
            {
                /// <summary>
                /// 获取或设置申请材料类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("application_type")]
                [System.Text.Json.Serialization.JsonPropertyName("application_type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置申请材料 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("application_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("application_media_id")]
                public string MediaId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户注销申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_apply_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_apply_no")]
        public string OutApplyNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置注销申请材料列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_info")]
        [System.Text.Json.Serialization.JsonPropertyName("application_info")]
        public IList<Types.ApplicationMaterial> ApplicationMaterialList { get; set; } = new List<Types.ApplicationMaterial>();
    }
}
