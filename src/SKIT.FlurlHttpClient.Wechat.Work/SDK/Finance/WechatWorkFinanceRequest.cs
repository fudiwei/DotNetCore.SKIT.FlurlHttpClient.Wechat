using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance
{
    /// <summary>
    /// 表示企业微信会话内容存档 API 请求的基类。
    /// </summary>
    public abstract class WechatWorkFinanceRequest : ICommonRequest
    {
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        internal TimeSpan? _InternalTimeout;

        /// <inheritdoc/>
        public void WithTimeout(TimeSpan? timeout)
        {
            _InternalTimeout = timeout;
        }
    }
}
