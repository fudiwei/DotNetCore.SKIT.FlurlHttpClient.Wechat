# SKIT.FlurlHttpClient.Wechat

[![Gitee Stars](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/badge/star.svg?title=Stars)](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat)
[![Gitee Forks](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/badge/fork.svg?title=Forks)](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat)
[![GitHub Stars](https://img.shields.io/github/stars/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat?logo=github&label=Stars)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat)
[![GitHub Forks](https://img.shields.io/github/forks/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat?logo=github&label=Forks)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat)
[![Visitors](https://visitor-badge.laobi.icu/badge?page_id=fudiwei.DotNetCore.SKIT.FlurlHttpClient.Wechat&title=Visitors)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat)
[![License](https://img.shields.io/github/license/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat?label=License)](https://mit-license.org/)

基于 `Flurl.Http` 的微信 HTTP API SDK，目前已包含公众平台、开放平台、商户平台、企业微信、广告平台、对话开放平台等模块。

> 更多 SKIT.FlurlHttpClient 系列开发工具包请[点此查看](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient)。

---

## 特性

-   基于 `Flurl.Http`，可与 `IHttpClientFactory` 集成。
-   支持 .NET Framework 4.6.1+、.NET Standard 2.0+、.NET Core 2.0+、.NET 5+。
-   支持 Windows / Linux / macOS 多平台部署。
-   支持 `System.Text.Json`（默认）和 `Newtonsoft.Json` 两种序列化方式。
-   强类型接口模型。
-   全异步式编程。
-   提供 SourceLink 调试符号文件。
-   完整、完善、完全的微信 HTTP API 封装。

---

## 模块

|                          名称                          |                                                                                                                                                                                                   NuGet                                                                                                                                                                                                    |                                           其他                                           |
| :----------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------: |
| 公众平台（公众号、小程序、视频号） <br> + 开放平台模块 |                       [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.Api.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Api) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.Api.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Api)                       |      [开发文档](./docs/WechatApi/README.md)｜[示例项目](./docs/WechatApi/Sample.md)      |
|    商户平台（微信支付）模块 <br> （针对 v3 版接口）    |             [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.TenpayV3.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV3) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.TenpayV3.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV3)             | [开发文档](./docs/WechatTenpayV3/README.md)｜[示例项目](./docs/WechatTenpayV3/Sample.md) |
|    商户平台（微信支付）模块 <br> （针对 v2 版接口）    |             [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.TenpayV2.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV2) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.TenpayV2.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV2)             |                       [开发文档](./docs/WechatTenpayV2/README.md)                        |
|                 企业微信（企业号）模块                 |                     [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.Work.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Work) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.Work.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Work)                     |                         [开发文档](./docs/WechatWork/README.md)                          |
|                 广告平台（广点通）模块                 |                       [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.Ads.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Ads) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.Ads.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Ads)                       |                          [开发文档](./docs/WechatAds/README.md)                          |
|            对话开放平台（微信智能对话）模块            |                 [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.OpenAI.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.OpenAI) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.OpenAI.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.OpenAI)                 |                        [开发文档](./docs/WechatOpenAI/README.md)                         |
|                     腾讯微企付模块                     | [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.TenpayBusiness.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayBusiness) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.TenpayBusiness.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayBusiness) |                    [开发文档](./docs/WechatTenpayBusiness/README.md)                     |

---

## Q & A

### 1. 为什么要“造轮子”？

这都 2021 年了，官方本身提供的示例代码还只能运行在 .NET Framework on Windows 上；就连 RSA 签名这么基础的东西都没有人封装（确切地说是因为 RSA 有很多种分块模式和填充模式，网上能找到的往往只封装了其中一种，但却未必符合微信的要求）；全网很难找到一个封装微信 API 尽可能全的 .NET SDK，开源的项目有不少，但作者能坚持下去的不多。

于是萌生了自己封装一个库的想法，打算解决这几个痛点，同时也是推广一下微软官方的 `System.Text.Json`。

### 2. `Flurl.Http` 是什么？

[`Flurl.Http`](https://flurl.dev/) 是一个轻量级 HTTP 库，是 .NET 中最受欢迎扩展库之一，在 NuGet 上的累计下载量超过 1700 万、日均下载量超过 6 千、GitHub 2.6k Stars（数据统计截至 2021-06-01）。

与另一个流行的 HTTP 库 [`RestSharp`](https://restsharp.dev/) 相比，`Flurl.Http` 底层基于 `System.Net.Http.HttpClient`，而 `RestSharp` 底层则基于 `System.Net.HttpWebRequest`，前者在多核多线程环境下的性能基准测试中表现要远优于后者，同时也是微软官方目前推荐的 HTTP 客户端方案。

> 注：微软官方关于 `System.Net.HttpWebRequest` 与 `System.Net.Http.HttpClient` 的说明：
>
> -   [《Microsoft Docs - HttpWebRequest 类（Systen.Net）》](https://docs.microsoft.com/zh-cn/dotnet/api/system.net.httpwebrequest#remarks)
> -   [《Microsoft Docs - HttpClient 类（Systen.Net.Http）》](https://docs.microsoft.com/zh-cn/dotnet/api/system.net.http.httpclient#httpclient-and-net-core)

### 3. 本库与盛派微信 SDK（Senparc.Weixin）有什么区别？

> 注：[盛派微信 SDK](https://github.com/JeffreySu/WeiXinMPSDK) 是由苏震巍先生发起的国内知名的 .NET 开源项目。

-   本库专注于 API 本身的封装，捎带提供了一些用于加解密、序列化的工具类，使用起来更加灵活，不限任何框架或项目类型；盛派微信 SDK 提供了大而全的功能，与 MVC / WebAPI 深度集成。

-   本库的接口模型遵循的是微软官方推荐的 C# 属性命名方式（帕斯卡命名法）；盛派微信 SDK 提供的是微信接口本身的命名方式（蛇形命名法和驼峰命名法混杂）。

-   本库封装了目前微信官方提供的几乎所有 API（极个别不支持的已在各模块文档中列出具体原因）；盛派微信 SDK 只提供了常用的 API。

### 4. 为什么不支持 .NET Framework 4.0 / .NET Framework 4.5？

直接原因是本项目的依赖库最低支持到 .NET Framework 4.6.1。

间接原因是为了支持跨平台的 .NET Standard 2.0，只能兼容到 .NET Framework 4.6.1。

根本原因是微软官方已于 2016 年 1 月 12 日终止了对 .NET Framework 4.6.1 以下版本的技术支持（详情请阅读[官方公告](https://docs.microsoft.com/zh-cn/lifecycle/faq/dotnet-framework)）。也就是说，微软已经不再为此提供安全更新，在大部分技术合规要求中这一点都是扣分项，所以建议各位开发者目标框架能升级就升级。

### 5. 看了源码，发现模型定义里很多同样的代码是复制粘贴的，为什么不使用面向对象中的继承？

关于这点得吐槽微信提供的 API 了，很显然微信内部也是很多个 Team 在共同开发，每个 Team、甚至每个人的字段命名风格、约束条件、接口规则都大相径庭。就连微信支付虽然 v3 版 API 号称是 “RESTful” 的，却也没个统一标准。

举个例子，以分页查询为例，看似字段相同，都由 _offset_、_cursor_、_page_、_limit_ + _data_、_total_count_、_next_cursor_ 这几个字段构成，但某些接口的 _offset_、_cursor_、_page_、_limit_ 字段是可选参数，某些却是必填项；某些 _page_ 值从 `0` 起始，某些却是从 `1` 起始；某些接口的 _data_、_total_count_、_next_cursor_ 字段一定会返回，某些却是一定不返回，某些只在特定条件下返回。一共十几个分页查询的接口，却有七八种分页的数据结构，这种情况下很难抽象出一个公共的基类出来。

除此之外，同样一个东西在不同接口里竟然拼法不一样；同样是表示数组有的是 JSON、有的却是字符串；诸如此类“奇葩”的情况很多很多。

本项目已经尽可能在条件允许的范围内抽象出了一些公共基类、并封装了各种奇怪场景下的自定义 JsonConverter。

### 6. 所有 API 都经过了测试吗？

由于微信的产品业务线众多，很多业务也需要前置条件才能继续，截至目前本项目已封装超过 2300 余个 API，虽然同时也编写了若干单元测试用例，但与数量庞大的 API 相比仍远远不够。

本项目严格按照微信官方提供的开发文档进行封装，并利用自动化工具保证封装结果的正确。但微信的文档本身质量比较低，所以存在错误在所难免。

因为微信更新 API 很频繁，对于微信支付或企业微信这种有提供官方更新日志的，本项目会定期查阅更新；其他平台经常会悄悄地更新一波、让所有人懵逼。如果你在使用中遇到了因接口或模型定义错误而产生的问题，欢迎提出 Issue。

---

## 使用案例

| 项目名称  |                                项目简介                                |                                                          项目地址                                                           |
| :-------: | :--------------------------------------------------------------------: | :-------------------------------------------------------------------------------------------------------------------------: |
| CoreShop  |             核心商城系统：支持可视化布局的 .NET 商城系统。             |   [![Gitee Stars](https://gitee.com/CoreUnion/CoreShop/badge/star.svg?title=Stars)](https://gitee.com/CoreUnion/CoreShop)   |
| Admin.NET | 通用权限开发框架：整合最新技术，模块插件式开发，前后端分离，开箱即用。 | [![Gitee Stars](https://gitee.com/zuohuaijun/Admin.NET/badge/star.svg?title=Stars)](https://gitee.com/zuohuaijun/Admin.NET) |

注：以上案例均来自第三方，本项目不对其项目做任何保证，仅作列举展示。如果你有项目也使用了本库、希望加到案例列表中，可以在 Issue 中提出。

---

## 参与贡献

-   GitHub Repo：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat.git
-   Gitee Repo：https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat.git

以上仓库地址同步更新，均可接受 Issue 或 Pull Request。

如何参与贡献请参阅 [CONTRIBUTING](./CONTRIBUTING.md)。

---

## 更新日志

详细更新说明请参阅 [CHANGELOG](./CHANGELOG.md)。
