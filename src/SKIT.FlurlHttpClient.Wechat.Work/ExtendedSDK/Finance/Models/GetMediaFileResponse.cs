using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.Models
{
    /// <summary>
    /// <para>表示会话内容存档之获取媒体文件接口的响应。</para>
    /// </summary>
    public class GetMediaFileResponse : WechatWorkFinanceResponse
    {
        /// <summary>
        /// 获取文件二进制数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes
        {
            get { return GetRawBytes(); }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && FileBytes.Any();
        }
    }
}
