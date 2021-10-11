using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 表示微信智能对话平台接入 API 请求的基类。
    /// </summary>
    public abstract class WechatOpenAIPlatformRequest : IWechatRequest
    {
        public static class Serialization
        {
            public interface IEncryptedXmlable
            { 
            }

            public interface IEncryptedUrlEncoded
            {
            }
        }

        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="WechatOpenAIPlatformClient"/> 时的 <see cref="WechatOpenAIPlatformClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [System.Xml.Serialization.XmlIgnore]
        [System.Xml.Serialization.SoapIgnore]
        public virtual int? Timeout { get; set; }
    }
}
