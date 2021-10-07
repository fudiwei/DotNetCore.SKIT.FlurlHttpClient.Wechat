using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/qrcode/check 接口的响应。</para>
    /// </summary>
    public class ProductQrcodeCheckResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置自检业务返回错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("self_check_err_code")]
        [System.Text.Json.Serialization.JsonPropertyName("self_check_err_code")]
        public int SelfCheckErrorCode { get; set; }

        /// <summary>
        /// 获取或设置自检业务返回错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("self_check_err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("self_check_err_msg")]
        public string? SelfCheckErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置扫码状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置扫码者身份。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scan_user_type")]
        [System.Text.Json.Serialization.JsonPropertyName("scan_user_type")]
        public int? ScanUserType { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && SelfCheckErrorCode == 0;
        }
    }
}
