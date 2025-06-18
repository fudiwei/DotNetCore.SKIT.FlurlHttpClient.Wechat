using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientEventDeserializationExtensions
    {
        /// <summary>
        /// <para>反序列化得到 <see cref="WechatTenpayBusinessEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static WechatTenpayBusinessEvent DeserializeEvent(this WechatTenpayBusinessClient client, string webhookJson)
        {
            return DeserializeEvent<WechatTenpayBusinessEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>反序列化得到 <see cref="WechatTenpayBusinessEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEvent<TEvent>(this WechatTenpayBusinessClient client, string webhookJson)
            where TEvent : WechatTenpayBusinessEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookJson is null) throw new ArgumentNullException(webhookJson);

            return client.JsonSerializer.Deserialize<TEvent>(webhookJson);
        }
    }
}
