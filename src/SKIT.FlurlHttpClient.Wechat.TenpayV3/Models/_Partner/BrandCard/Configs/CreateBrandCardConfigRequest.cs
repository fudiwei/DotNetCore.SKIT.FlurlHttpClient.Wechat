using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /brand/card/card-configs 接口的请求。</para>
    /// </summary>
    public class CreateBrandCardConfigRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class MiniProgram
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序默认跳转路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_jump_path")]
                [System.Text.Json.Serialization.JsonPropertyName("default_jump_path")]
                public string? DefaultJumpPagePath { get; set; }

                /// <summary>
                /// 获取或设置小程序跳转按钮文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("button_text")]
                [System.Text.Json.Serialization.JsonPropertyName("button_text")]
                public string? ButtonText { get; set; }
            }

            public class CustomerService
            {
                /// <summary>
                /// 获取或设置客服类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customer_service_type")]
                [System.Text.Json.Serialization.JsonPropertyName("customer_service_type")]
                public string CustomerServiceType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置客服电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customer_service_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("customer_service_phone")]
                public string? PhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置客服小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置客服页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customer_service_path")]
                [System.Text.Json.Serialization.JsonPropertyName("customer_service_path")]
                public string? PagePath { get; set; }
            }

            public class Service
            {
                /// <summary>
                /// 获取或设置服务分类名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_classify_name")]
                [System.Text.Json.Serialization.JsonPropertyName("service_classify_name")]
                public string ServiceClassifyName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置服务名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_name")]
                [System.Text.Json.Serialization.JsonPropertyName("service_name")]
                public string ServiceName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置服务跳转类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_jump_type")]
                [System.Text.Json.Serialization.JsonPropertyName("service_jump_type")]
                public string JumpType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置服务小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置服务跳转路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_jump_path")]
                [System.Text.Json.Serialization.JsonPropertyName("service_jump_path")]
                public string? PagePath { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_code")]
        [System.Text.Json.Serialization.JsonPropertyName("business_code")]
        public string BusinessCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌小程序信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_mini_program_info")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_mini_program_info")]
        public Types.MiniProgram MiniProgram { get; set; } = new Types.MiniProgram();

        /// <summary>
        /// 获取或设置品牌客服信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_customer_service")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_customer_service")]
        public Types.CustomerService CustomerService { get; set; } = new Types.CustomerService();

        /// <summary>
        /// 获取或设置服务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_list")]
        [System.Text.Json.Serialization.JsonPropertyName("service_list")]
        public IList<Types.Service>? ServiceList { get; set; }
    }
}
