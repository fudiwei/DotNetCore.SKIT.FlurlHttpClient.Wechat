# SKIT.FlurlHttpClient.Wechat

基于 `Flurl.Http` 的微信 API HTTP 客户端，支持公众平台、开放平台、商户平台、企业微信、广告平台等模块。

> [`Flurl.Http`](https://flurl.dev/) 是一个轻量级 HTTP 库，是 .NET 中最受欢迎扩展库之一，在 NuGet 上的累计下载量超过 1700 万、日均下载量超过 6 千、GitHub 2.6k Stars（数据统计截至 2021-06-01）。
>
> 与另一个流行的 HTTP 库 [`RestSharp`](https://restsharp.dev/) 相比，`Flurl.Http` 底层基于 `System.Net.Http.HttpClient`，而 `RestSharp` 底层则基于 `System.Net.HttpWebRequest`，前者在多核多线程环境下的性能基准测试中表现要远优于后者，同时也是微软官方目前推荐的 HTTP 客户端方案。
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

-   提供拦截器功能。

-   完整、完善、完全的微信 API 封装。

---

## 模块

|                   名称                    |                                                                                     NuGet                                                                                      |                  其他                   |
| :---------------------------------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :-------------------------------------: |
| 公众平台（公众号、小程序） & 开放平台模块 |      [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.Api.svg?sanitize=true)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Api)      |   [文档](./docs/WechatApi/README.md)    |
|         商户平台（微信支付）模块          | [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.TenpayV3.svg?sanitize=true)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV3) | [文档](./docs/WechatTenpayV3/README.md) |
|          企业微信（企业号）模块           |     [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.Work.svg?sanitize=true)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Work)     |   [文档](./docs/WechatWork/README.md)   |
|          广告平台（广点通）模块           |      [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.Ads.svg?sanitize=true)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Ads)      |   [文档](./docs/WechatAds/README.md)    |

---

## 常见问题

### 1. 为什么要“造轮子”？

这都 2021 年了，官方本身提供的示例代码还只能运行在 .NET Framework on Windows 上；就连 RSA 签名这么基础的东西都没有人封装（确切的说是因为 RSA 有很多种分块模式和填充模式，网上能找到的往往只封装了其中一种，但却未必符合微信的要求）。

于是萌生了自己封装一个库的想法，打算解决这几个痛点，同时也是推广一下微软官方的 `System.Text.Json`。

### 2. 本库与[盛派微信 SDK（Senparc.Weixin）](https://github.com/JeffreySu/WeiXinMPSDK)有什么区别？

-   本库专注于 API 本身的封装，捎带提供了一些用于加解密、序列化的工具类；盛派微信 SDK 提供了大而全的功能，可与 MVC / WebAPI 深度集成。

-   本库的接口模型遵循的是微软官方推荐的 C# 属性命名方式（大驼峰命名法）；盛派微信 SDK 提供的是微信接口本身的命名方式（蛇形命名法和小驼峰命名法混杂）。

-   本库封装了**目前微信官方提供的所有 API**（部分不支持的已在各模块文档中列出具体原因）；盛派微信 SDK 只提供了常用的 API。

-   本库只支持微信支付 v3 版 API；盛派微信 SDK 只支持微信支付 v2 版 API（年前作者开了新坑似乎是想提供 v3 版支持，不过目前只封装了部分接口，进展比较缓慢）。原则上官方已经停止更新 v2 版 API，现在接口只做日常维护，所以有条件的话还是应该尽快升级。如果你有使用 v2 版 API 的需求（比如企业提现、红包等几个尚未提供 v3 版 API 的接口），建议使用盛派微信 SDK。

### 3. 看了源码，发现模型定义里很多同样的代码是复制粘贴的，为什么不继承？

关于这点得吐槽微信提供的 API 了，很显然微信内部也是很多个 Team 在共同开发，每个 Team、甚至每个人的字段命名风格、约束条件、接口规则都大相径庭。就连微信支付虽然 v3 版 API 号称是 “RESTful” 的，却也没个统一标准。

举个例子，以分页查询为例，看似字段相同，都由 _offset_、_cursor_、_page_、_limit_ + _data_、_total_count_、_next_cursor_ 这几个字段构成，但某些接口的 _offset_、_cursor_、_page_、_limit_ 字段是可选参数，某些却是必填项；某些 _page_ 值从 `0` 起始，某些却是从 `1` 起始；某些接口的 _data_、_total_count_、_next_cursor_ 字段一定会返回，某些却是一定不返回，某些只在特定条件下返回。一共十几个分页查询的接口，却有七八种分页的数据结构，这种情况下很难抽象出一个公共的基类出来。

同样一个东西在不同接口里竟然拼法不一样；同样是表示数组有的是 JSON、有的却是字符串；诸如此类“奇葩”的情况很多很多。本库已经尽可能在条件允许的范围内抽象出了一些公共基类、并封装了各种奇怪场景下的 JsonConverter，聊胜于无。

### 4. 为什么不支持 .NET Framework 4.0 / .NET Framework 4.5？

直接原因是本库的依赖库最低支持到 .NET Framework 4.6.1。

间接原因是为了支持跨平台的 .NET Standard 2.0，只能兼容到 .NET Framework 4.6.1。

根本原因是微软官方已于 2016 年 1 月 12 日终止了对 .NET Framework 4.6.1 以下版本的技术支持（详情请阅读[官方公告](https://docs.microsoft.com/zh-cn/lifecycle/faq/dotnet-framework)）。也就是说，微软已经不再为此提供安全更新，在大部分技术合规要求中这一点都是扣分项，所以建议各位开发者目标框架能升级就升级。

---

## 贡献代码

-   GitHub：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat

-   Gitee：https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat

以上仓库地址同步更新，均可接受 Issue 或 Pull Request。

---

## 更新日志

[CHANGELOG](./CHANGELOG.md)
