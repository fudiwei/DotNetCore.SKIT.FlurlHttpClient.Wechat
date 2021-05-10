### 如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？

---

> 请先自行阅读：
>
> [《Microsoft Docs - 使用 IHttpClientFactory 实现复原 HTTP 请求》](https://docs.microsoft.com/zh-cn/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests)
>
> [《Microsoft Docs - 在 ASP.NET Core 中使用 IHttpClientFactory 发出 HTTP 请求》](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/http-requests#httpclient-and-lifetime-management)

你可以在构造得到 `WechatTenpayClient` 对象后：

```csharp
client.Configure(settings =>
{
    settings.HttpClientFactory = HttpClientFactory; // 赋值为依赖注入的 `IHttpClientFactory` 对象
});
```

下面给出一个使用了依赖注入的完整例子：

```csharp
using System.Net.Http;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Options;
using SKIT.FlurlHttpClient.Wechat.TenpayV3;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;

public class MyWechatClientFactory
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IOptions<WechatTenpayClientOptions> _wechatTenpayClientOptions;

    public MyWechatClient(
        IHttpClientFactory httpClientFactory,
        IOptions<WechatTenpayClientOptions> wechatTenpayClientOptions)
    {
        _httpClientFactory = httpClientFactory;
        _wechatTenpayClientOptions = wechatTenpayClientOptions;
    }

    public WechatTenpayClient CreateClient()
    {
        var client = new WechatTenpayClient(_wechatTenpayClientOptions.Value);
        client.Configure(settings => settings.HttpClientFactory = _httpClientFactory);

        return client;
    }
}
```
