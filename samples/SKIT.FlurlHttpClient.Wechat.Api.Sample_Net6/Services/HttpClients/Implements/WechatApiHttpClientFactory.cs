using System;
using System.Linq;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample.Services.HttpClients.Implements
{
    partial class WechatApiHttpClientFactory : IWechatApiHttpClientFactory
    {
        private readonly System.Net.Http.IHttpClientFactory _httpClientFactory;
        private readonly Options.WechatOptions _wechatOptions;

        public WechatApiHttpClientFactory(
            System.Net.Http.IHttpClientFactory httpClientFactory,
            IOptions<Options.WechatOptions> wechatOptions)
        {
            _httpClientFactory = httpClientFactory;
            _wechatOptions = wechatOptions.Value;

            FlurlHttp.GlobalSettings.FlurlClientFactory = new DelegatingFlurlClientFactory(_httpClientFactory);
        }

        public WechatApiClient Create(string appId)
        {
            // NOTICE:
            //   这里的工厂方法是为了演示多租户而存在的，可根据 AppId 生成不同的 API 客户端。
            //   如果你的项目只存在唯一一个租户，那么直接注入 `WechatApiClient` 即可。

            var wechatAccountOptions = _wechatOptions.Accounts?.FirstOrDefault(e => string.Equals(appId, e.AppId));
            if (wechatAccountOptions == null)
                throw new Exception("未在配置项中找到该 AppId 对应的微信账号。");

            return new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = wechatAccountOptions.AppId,
                AppSecret = wechatAccountOptions.AppSecret
            });
        }
    }

    partial class WechatApiHttpClientFactory
    {
        internal class DelegatingFlurlClientFactory : IFlurlClientFactory
        {
            private readonly System.Net.Http.IHttpClientFactory _httpClientFactory;

            public DelegatingFlurlClientFactory(System.Net.Http.IHttpClientFactory httpClientFactory)
            {
                _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
            }

            public IFlurlClient Get(Url url)
            {
                return new FlurlClient(_httpClientFactory.CreateClient(url.ToUri().Host));
            }

            public void Dispose()
            {
                // Do Nothing
            }
        }
    }
}
