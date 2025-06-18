namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 表示微信智能对话 API 请求的基类。
    /// </summary>
    public abstract class WechatChatbotRequest : CommonRequestBase, ICommonRequest
    {
        public static class Serialization
        {
            public interface IEncryptedXmlable
            {
            }
        }
    }
}
