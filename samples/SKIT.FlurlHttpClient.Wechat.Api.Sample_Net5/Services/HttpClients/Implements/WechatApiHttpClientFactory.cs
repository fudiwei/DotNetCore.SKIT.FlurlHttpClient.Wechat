using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Options;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Services.HttpClients.Implements
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
        }

        public WechatApiClient Create(string appId)
        {
            var wechatAccount = _wechatOptions.Accounts?.FirstOrDefault(e => string.Equals(appId, e.AppId));
            if (wechatAccount == null)
                throw new Exception("未在配置项中找到该 AppId 对应的微信账号。");

            FlurlHttp.GlobalSettings.FlurlClientFactory = new DelegatingFlurlClientFactory(_httpClientFactory);

            return new WechatApiClient(new WechatApiClientOptions()
            {
                AppId = wechatAccount.AppId,
                AppSecret = wechatAccount.AppSecret
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
