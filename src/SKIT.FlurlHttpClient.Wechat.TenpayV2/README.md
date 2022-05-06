## SKIT.FlurlHttpClient.Wechat.TenpayV2

[![GitHub Stars](https://img.shields.io/github/stars/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat?logo=github&label=Stars)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat) [![GitHub Forks](https://img.shields.io/github/forks/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat?logo=github&label=Forks)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat) [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.TenpayV2.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV2) [![License](https://img.shields.io/github/license/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat?label=License)](https://mit-license.org/)

基于 `Flurl.Http` 的微信商户平台 API v2 版客户端。

**注意**：本库仅仅包含微信支付未提供 v3 版 API 的部分功能，如需微信支付 v3 版 API 客户端，欢迎使用 [`SKIT.FlurlHttpClient.Wechat.TenpayV3`](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV3)。

---

### 【功能特性】

-   基于微信支付 v2 版 API 封装。
-   支持普通商户、境内服务商、银行服务商、跨境支付四种模式。
-   请求时自动生成签名，无需开发者手动干预。
-   提供了微信支付所需的 AES、MD5、HMAC-SHA-256 等算法工具类。
-   提供了调起支付签名、解析回调通知事件敏感数据等扩展方法。

---

### 【开发文档】

[点此查看](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat)。

---

### 【更新日志】

[点此查看](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/blob/main/CHANGELOG.md)。
