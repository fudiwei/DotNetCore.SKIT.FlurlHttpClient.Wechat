using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /funds/get 接口的请求。</para>
    /// </summary>
    public class FundsGetRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置微信广告平台的版本号。
        /// <para>默认值：v1.1</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? Version { get; set; } = "v1.1";
    }
}
