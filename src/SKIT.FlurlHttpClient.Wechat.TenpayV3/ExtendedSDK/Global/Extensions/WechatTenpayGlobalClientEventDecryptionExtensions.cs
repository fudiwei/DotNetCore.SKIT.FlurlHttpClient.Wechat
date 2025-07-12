using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static class WechatTenpayGlobalClientEventDecryptionExtensions
    {
        /// <summary>
        /// <para>反序列化得到 <see cref="WechatTenpayGlobalEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static WechatTenpayGlobalEvent DeserializeEvent(this WechatTenpayGlobalClient client, string webhookJson)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookJson is null) throw new ArgumentNullException(webhookJson);

            return client.JsonSerializer.Deserialize<WechatTenpayGlobalEvent>(webhookJson);
        }

        /// <summary>
        /// 返回序列化并解密事件数据中被加密的通知数据。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookEvent"></param>
        /// <returns></returns>
        public static T DecryptEventResource<T>(this WechatTenpayGlobalClient client, WechatTenpayGlobalEvent webhookEvent)
            where T : WechatTenpayGlobalEvent.Types.IDecryptedResource, new()
        {
            return WechatTenpayClientEventDecryptionExtensions.DecryptEventResource<T>(client.ProxyClient, webhookEvent.Resource);
        }

        /// <summary>
        /// 返回序列化并解密事件数据中被加密的通知数据。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookEventResource"></param>
        /// <returns></returns>
        public static T DecryptEventResource<T>(this WechatTenpayGlobalClient client, WechatTenpayGlobalEvent.Types.Resource webhookEventResource)
            where T : WechatTenpayGlobalEvent.Types.IDecryptedResource, new()
        {
            return WechatTenpayClientEventDecryptionExtensions.DecryptEventResource<T>(client.ProxyClient, webhookEventResource);
        }
    }
}
