# SKIT.FlurlHttpClient.Wechat

基于 `Flurl.Http` 的微信 API HTTP 客户端，支持公众平台、开放平台、商户平台等模块。

> [`Flurl.Http`](https://flurl.dev/) 是一个轻量级 HTTP 库，是 .NET 中最受欢迎扩展库之一，在 NuGet 上的累计下载量超过 1200 万、日均下载量超过 5 千、GitHub 2.6k Stars（数据统计截至 2021-05-01）。
> 
> 与另一个目前更加流行的 HTTP 库 [`RestSharp`](https://restsharp.dev/) 相比，`Flurl.Http` 底层基于 `System.Net.Http.HttpClient`，而 `RestSharp` 底层则基于 `System.Net.HttpWebRequest`，前者在多核多线程环境下的性能基准测试中表现要远由优于后者，同时也是微软官方目前推荐的 HTTP 客户端方案。
> 
> 
> 【附】微软官方关于 `System.Net.HttpWebRequest` 与 `System.Net.Http.HttpClient` 的说明：
> 
> -   https://docs.microsoft.com/zh-cn/dotnet/api/system.net.httpwebrequest#remarks
> -   https://docs.microsoft.com/zh-cn/dotnet/api/system.net.http.httpclient#httpclient-and-net-core）。

---

## 特性

-   基于 `Flurl.Http`，可与 `IHttpClientFactory` 集成。

-   支持 .NET Framework 4.6.1+、.NET Standard 2.0+、.NET Core 2.0+、.NET 5。

-   支持 Windows / Linux / macOS 多平台部署。

-   支持 `System.Text.Json`（默认）和 `Newtonsoft.Json` 两种序列化方式。

-   异步式编程。

-   强类型接口模型。

-   完善的微信 API 封装。

---

## 模块

-   [《微信公众平台（公众号、小程序） & 开放平台 API 模块》文档](./docs/WechatApi/README.md)

-   [《微信商户平台（微信支付） API 模块》文档](./docs/WechatTenpayV3/README.md)
