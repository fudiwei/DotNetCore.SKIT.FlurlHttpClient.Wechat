using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/register/finish_access_info 接口的请求。</para>
    /// </summary>
    public class ShopRegisterFinishAccessInformationRequest : WechatApiRequest, IMapResponse<ShopRegisterFinishAccessInformationRequest, ShopRegisterFinishAccessInformationResponse>
    {
        /// <summary>
        /// 获取或设置接入任务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_info_item")]
        [System.Text.Json.Serialization.JsonPropertyName("access_info_item")]
        public int AccessInformationItem { get; set; }
    }
}
