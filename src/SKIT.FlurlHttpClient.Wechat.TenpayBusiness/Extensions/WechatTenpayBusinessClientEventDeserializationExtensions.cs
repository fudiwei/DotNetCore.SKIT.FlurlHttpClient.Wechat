using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientEventDeserializationExtensions
    {
        /// <summary>
        /// <para>反序列化得到 <see cref="WechatTenpayBusinessEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static WechatTenpayBusinessEvent DeserializeEvent(this WechatTenpayBusinessClient client, string callbackJson)
        {
            return DeserializeEvent<WechatTenpayBusinessEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>反序列化得到 <see cref="WechatTenpayBusinessEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEvent<TEvent>(this WechatTenpayBusinessClient client, string callbackJson)
            where TEvent : WechatTenpayBusinessEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
        }
    }
}
