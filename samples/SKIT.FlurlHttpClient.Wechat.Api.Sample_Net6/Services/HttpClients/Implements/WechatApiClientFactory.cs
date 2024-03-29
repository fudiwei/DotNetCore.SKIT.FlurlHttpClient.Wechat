using System;
using System.Linq;
using System.Net.Http;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Services.HttpClients.Implements
{
    internal partial class WechatApiClientFactory : IWechatApiClientFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Options.WechatOptions _wechatOptions;

        public WechatApiClientFactory(
            IHttpClientFactory httpClientFactory,
            IOptions<Options.WechatOptions> wechatOptions)
        {
            _httpClientFactory = httpClientFactory;
            _wechatOptions = wechatOptions.Value;
        }

        public WechatApiClient Create(string appId)
        {
            // NOTICE:
            //   这里的工厂方法是为了演示多租户而存在的，可根据 AppId 生成不同的 API 客户端。
            //   如果你的项目只存在唯一一个租户，那么直接注入 `WechatApiClient` 即可。

            var wechatAccountOptions = _wechatOptions.Accounts?.FirstOrDefault(e => string.Equals(appId, e.AppId));
            if (wechatAccountOptions == null)
                throw new Exception("未在配置项中找到该 AppId 对应的微信账号。");

            var wechatApiClientOptions = new WechatApiClientOptions()
            {
                AppId = wechatAccountOptions.AppId,
                AppSecret = wechatAccountOptions.AppSecret,
                PushEncodingAESKey = _wechatOptions.CallbackEncodingAESKey,
                PushToken = _wechatOptions.CallbackToken
            };
            var wechatApiClient = WechatApiClientBuilder.Create(wechatApiClientOptions)
                .UseHttpClient(_httpClientFactory.CreateClient(), disposeClient: false)
                .Build();
            return wechatApiClient;
        }
    }
}
