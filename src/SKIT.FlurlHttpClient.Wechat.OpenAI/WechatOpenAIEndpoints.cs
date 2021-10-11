using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// <para>微信智能对话 API 接口域名。</para>
    /// </summary>
    public static class WechatOpenAIEndpoints
    {
        /// <summary>
        /// 平台接入（默认）。
        /// </summary>
        public const string PLATFORM = "https://openai.weixin.qq.com";

        /// <summary>
        /// 第三方接入。
        /// </summary>
        public const string THIRDPARTY = "https://openaiapi.weixin.qq.com";
    }
}
