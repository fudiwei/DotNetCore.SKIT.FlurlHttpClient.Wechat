namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECBrandUpdateRequest : WechatApiRequest, IInferable<ChannelsECBrandUpdateRequest, ChannelsECBrandUpdateResponse>
    {
        public static class Types
        {
            public class Brand : ShopECBrandAddRequest.Types.__zz__Brand
            {
                public static class Types
                {
                    public class RegisterDetail : ShopECBrandAddRequest.Types.Brand.Types.RegisterDetail
                    {
                    }

                    public class ApplicationDetail : ShopECBrandAddRequest.Types.Brand.Types.ApplicationDetail
                    {
                    }

                    public class GrantDetail : ShopECBrandAddRequest.Types.Brand.Types.GrantDetail
                    {
                    }
                }

                /// <summary>
                /// 获取或设置商标注册详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("register_details")]
                [System.Text.Json.Serialization.JsonPropertyName("register_details")]
                public Types.RegisterDetail? RegisterDetail { get; set; }

                /// <summary>
                /// 获取或设置商标申请详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("application_details")]
                [System.Text.Json.Serialization.JsonPropertyName("application_details")]
                public Types.ApplicationDetail? ApplicationDetail { get; set; }

                /// <summary>
                /// 获取或设置商标授权详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grant_details")]
                [System.Text.Json.Serialization.JsonPropertyName("grant_details")]
                public Types.GrantDetail? GrantDetail { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置品牌信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand")]
        [System.Text.Json.Serialization.JsonPropertyName("brand")]
        public Types.Brand? Brand { get; set; }
    }
}
