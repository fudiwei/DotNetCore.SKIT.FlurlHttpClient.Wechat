using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.PushEncodingAESKey"/> 的副本。
        /// </summary>
        public string? PushEncodingAESKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.PushToken"/> 的副本。
        /// </summary>
        public string? PushToken { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.ImmeDeliveryAppKey"/> 的副本。
        /// </summary>
        public string? ImmeDeliveryAppKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.ImmeDeliveryAppSecret"/> 的副本。
        /// </summary>
        public string? ImmeDeliveryAppSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.VirtualPaymentAppKey"/> 的副本。
        /// </summary>
        public string? VirtualPaymentAppKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.MidasAppKey"/> 的副本。
        /// </summary>
        public string? MidasAppKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.MidasOfferId"/> 的副本。
        /// </summary>
        public string? MidasOfferId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.MidasAppKeyV2"/> 的副本。
        /// </summary>
        public string? MidasAppKeyV2 { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatApiClientOptions.MidasOfferIdV2"/> 的副本。
        /// </summary>
        public string? MidasOfferIdV2 { get; }

        internal Credentials(WechatApiClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppSecret = options.AppSecret;
            PushEncodingAESKey = options.PushEncodingAESKey;
            PushToken = options.PushToken;
            ImmeDeliveryAppKey = options.ImmeDeliveryAppKey;
            ImmeDeliveryAppSecret = options.ImmeDeliveryAppSecret;
            VirtualPaymentAppKey = options.VirtualPaymentAppKey;
            MidasAppKey = options.MidasAppKey;
            MidasOfferId = options.MidasOfferId;
            MidasAppKeyV2 = options.MidasAppKeyV2;
            MidasOfferIdV2 = options.MidasOfferIdV2;
        }
    }
}
