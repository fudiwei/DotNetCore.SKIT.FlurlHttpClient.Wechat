using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 为 <see cref="WechatApiClient"/> 提供回调通知事件验证相关的扩展方法。
    /// </summary>
    public static class WechatApiClientEventVerificationExtensions
    {
        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Access_Overview.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 timestamp 字段。</param>
        /// <param name="callbackNonce">微信回调通知中的 nonce 字段。</param>
        /// <param name="callbackSignature">微信回调通知中的 signature 字段。</param>
        /// <returns></returns>
        public static bool VerifyEventSignature(
            this WechatApiClient client,
            string callbackTimestamp,
            string callbackNonce,
            string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackTimestamp == null) throw new ArgumentNullException(nameof(callbackTimestamp));
            if (callbackNonce == null) throw new ArgumentNullException(nameof(callbackNonce));
            if (callbackSignature == null) throw new ArgumentNullException(nameof(callbackSignature));

            ISet<string> set = new SortedSet<string>() { client.Credentials.PushToken!, callbackTimestamp, callbackNonce };
            string sign = Security.SHA1Utility.Hash(string.Concat(set));
            return string.Equals(sign, callbackSignature, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
