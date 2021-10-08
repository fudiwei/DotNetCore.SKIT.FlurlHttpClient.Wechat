using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/bot/test 接口的请求。</para>
    /// </summary>
    public class BotTestRequest : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置询问语句。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string QueryString { get; set; } = string.Empty;
    }
}
