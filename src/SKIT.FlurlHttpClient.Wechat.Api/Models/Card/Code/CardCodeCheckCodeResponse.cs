using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/code/checkcode 接口的响应。</para>
    /// </summary>
    public class CardCodeCheckCodeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置已经成功存入的卡券 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exist_code")]
        [System.Text.Json.Serialization.JsonPropertyName("exist_code")]
        public string[] ExistingCodeList { get; set; } = default!;

        /// <summary>
        /// 获取或设置没有存入的卡券 Code 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("not_exist_code")]
        [System.Text.Json.Serialization.JsonPropertyName("not_exist_code")]
        public string[] NonExistingCodeList { get; set; } = default!;
    }
}
