### 如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？

---

> 请先自行阅读：
>
> [《Microsoft Docs - 使用 IHttpClientFactory 实现复原 HTTP 请求》](https://docs.microsoft.com/zh-cn/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests)
>
> [《Microsoft Docs - 在 ASP.NET Core 中使用 IHttpClientFactory 发出 HTTP 请求》](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/http-requests#httpclient-and-lifetime-management)
>
> [《Microsoft Docs - .NET Core 2.1 的新增功能：套接字改进》](https://docs.microsoft.com/zh-CN/dotnet/core/whats-new/dotnet-core-2-1#sockets-improvements)

当你的项目是运行在 ASP.NET Core 2.1 或更高版本的平台时，CLR 已经提供了全新的底层套接字实现，无需你手动干预 `HttpClient` 的生命周期。

如果你想手动管理 `HttpClient`，那么可以参考下面基于 DI/IoC 的代码实现：

```csharp
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Options;
using SKIT.FlurlHttpClient.Wechat.TenpayV3;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;

public class WechatTenpayClientFactory
{
    internal class DelegatingFlurlClientFactory : IFlurlClientFactory
    {
        private readonly System.Net.Http.IHttpClientFactory _httpClientFactory;

        public DelegatingFlurlClientFactory(System.Net.Http.IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public Flurl.Http.IFlurlClient Get(Flurl.Url url)
        {
            return new FlurlClient(_httpClientFactory.CreateClient(url));
        }

        public void Dispose()
        {
            // Do Nothing
        }
    }

    private readonly System.Net.Http.IHttpClientFactory _httpClientFactory;
    private readonly IOptions<WechatTenpayClientOptions> _wechatTenpayClientOptions;

    public WechatTenpayClientFactory(
        System.Net.Http.IHttpClientFactory httpClientFactory,
        IOptions<WechatTenpayClientOptions> wechatTenpayClientOptions)
    {
        _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        _wechatTenpayClientOptions = wechatTenpayClientOptions ?? throw new ArgumentNullException(nameof(wechatTenpayClientOptions));

        FlurlHttp.Configure(settings => settings.FlurlClientFactory = new DelegatingFlurlClientFactory(_httpClientFactory));
    }

    public WechatTenpayClient CreateClient()
    {
        return new WechatTenpayClient(_wechatTenpayClientOptions.Value);
    }
}
```

需要强调的是，虽然 `WechatTenpayClient` 实现了 `System.IDisposable` 接口，但你不应该在 DI/IoC 中手动释放它，而是应该交给 IoC 容器自动管理它。

此外你应注意，`System.Net.Http.IHttpClientFactory` 与 `Flurl.Http.Configuration.IHttpClientFactory` 是两个不同的类型，[使用时请加以区分](https://flurl.dev/docs/configuration/#httpclientfactory)。
