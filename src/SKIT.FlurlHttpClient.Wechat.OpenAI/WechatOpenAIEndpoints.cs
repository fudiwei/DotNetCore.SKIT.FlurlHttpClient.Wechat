namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// <para>微信智能对话 API 接口域名。</para>
    /// </summary>
    public static class WechatOpenAIEndpoints
    {
        /// <summary>
        /// 主域名（默认）。
        /// </summary>
        public const string DEFAULT = "https://chatbot.weixin.qq.com/openapi";

        /// <summary>
        /// 备用域名。
        /// </summary>
        public const string BACKUP = "https://openai.weixin.qq.com/openapi";
    }
}
