# SKIT.FlurlHttpClient.Wechat.TenpayV3

[![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.TenpayV3.svg?sanitize=true)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV3)
[![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.TenpayV3.svg?sanitize=true)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV3)
[![GitHub License](https://img.shields.io/github/license/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/blob/main/LICENSE)

基于 `Flurl.Http` 的微信支付 API v3 版客户端。

---

## 功能

-   基于微信支付 v3 版 API 封装。

-   支持直连商户、服务商两种模式。

-   请求时自动生成签名，无需开发者手动干预。

-   提供了微信支付所需的 RSA、AES-GCM、SHA-256 等算法工具类。

-   提供了调起支付签名、解析响应敏感数据、解析回调通知事件敏感数据等扩展方法。

-   完整微信支付 API 一览：

    |     |            微信 API             |           商户类型           |       备注        |
    | :-: | :-----------------------------: | :--------------------------: | :---------------: |
    |  √  |     商户进件：特约商户进件      |            服务商            |                   |
    |  √  |      基础支付：JSAPI 支付       |      直连商户 & 服务商       |                   |
    |  √  |       基础支付：APP 支付        |      直连商户 & 服务商       |                   |
    |  √  |        基础支付：H5 支付        |      直连商户 & 服务商       |                   |
    |  √  |      基础支付：Native 支付      |      直连商户 & 服务商       |                   |
    |  √  |      基础支付：小程序支付       |      直连商户 & 服务商       |                   |
    |  √  |       基础支付：合单支付        |      直连商户 & 服务商       |                   |
    |  ×  | <del>基础支付：付款码支付</del> | <del>直连商户 & 服务商</del> | 微信未提供 v3 API |
    |  √  |      经营能力：微信支付分       |      直连商户 & 服务商       |                   |
    |  √  |      经营能力：微信先享卡       |           直连商户           |                   |
    |  √  |      经营能力：支付即服务       |      直连商户 & 服务商       |                   |
    |  √  |       经营能力：点金计划        |            服务商            |                   |
    |  √  |      行业方案：电商收付通       |            服务商            |                   |
    |  √  |       行业方案：智慧商圈        |      直连商户 & 服务商       |                   |
    |  √  |        营销工具：代金券         |      直连商户 & 服务商       |                   |
    |  √  |        营销工具：商家券         |      直连商户 & 服务商       |                   |
    |  √  |       营销工具：委托营销        |      直连商户 & 服务商       |                   |
    |  √  |        营销工具：消费卡         |      直连商户 & 服务商       |                   |
    |  √  |       营销工具：支付有礼        |      直连商户 & 服务商       |                   |
    |  √  | 营销工具：图片上传（营销专用）  |      直连商户 & 服务商       |                   |
    |  ×  |  <del>营销工具：现金红包</del>  | <del>直连商户 & 服务商</del> | 微信未提供 v3 API |
    |  ×  |  <del>资金应用：企业付款</del>  |     <del>直连商户</del>      | 微信未提供 v3 API |
    |  ×  |    <del>资金应用：分账</del>    |     <del>直连商户</del>      | 微信未提供 v3 API |
    |  √  |     资金应用：连锁品牌分账      |            服务商            |                   |
    |  ×  | <del>资金应用：服务商分账</del> |      <del>服务商</del>       | 微信未提供 v3 API |
    |  √  |   风险合规：商户开户意愿确认    |            服务商            |                   |
    |  √  |    风险合规：消费者投诉 2.0     |      直连商户 & 服务商       |                   |
    |  ×  |  <del>其他能力：清关上报</del>  |     <del>直连商户</del>      | 微信未提供 v3 API |
    |  √  |       其他能力：图片上传        |      直连商户 & 服务商       |                   |
    |  √  |       其他能力：视频上传        |      直连商户 & 服务商       |                   |

---

## 基础用法

### 安装：

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Wechat.TenpayV3

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Wechat.TenpayV3
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Wechat;
using SKIT.FlurlHttpClient.Wechat.TenpayV3;

var options = new WechatTenpayClientOptions()
{
    MerchantId = "微信商户号",
    MerchantV3Secret = "微信商户 v3 API 密钥",
    MerchantCertSerialNumber = "微信商户证书序列号",
    MerchantCertPrivateKey = "-----BEGIN PRIVATE KEY-----微信商户证书私钥-----END PRIVATE KEY-----"
};
var client = new WechatTenpayClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.TenpayV3;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;

/* 示例：JSAPI 统一下单 */
var request = new CreatePayTransactionJsapiRequest()
{
    OutTradeNumber = "商户订单号",
    AppId = "微信 AppId",
    Description = "订单描述",
    ExpireTime = DateTimeOffset.Now.AddMinutes(15),
    NotifyUrl = "https://example.com",
    Amount = new Models.CreatePayTransactionJsapiRequest.Types.Amount()
    {
        Total = 1
    },
    Payer = new Models.CreatePayTransactionJsapiRequest.Types.Payer()
    {
        OpenId = TestConfigs.WechatOpenId
    }
};
var response = await TestClients.Instance.ExecuteCreatePayTransactionJsapiAsync(request);
```

---

## 高级技巧

-   [如何查看商户证书序列号？](./Advanced_MerchantCertSerialNumber.md)

-   [如何验证微信响应签名？](./Advanced_ResponseSignatureVerification.md)

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何解密响应中的敏感数据？](./Advanced_ResponseDataDecryption.md)

-   [如何解密回调通知事件中的敏感数据？](./Advanced_CallbackDataDecryption.md)

-   [如何生成客户端调起支付时所需的参数及签名？](./Advanced_Payment.md)

---

## 常见问题

### 1. 为什么要“造轮子”？

目前网络上还没有基于微信支付 v3 版 API 封装的 .NET 客户端，遑论开源了；这都 2021 年了，官方本身提供的示例代码还只能运行在 .NET Framework on Windows 上；就连 RSA 签名这么基础的东西都没有人封装（确切的说是因为 RSA 有很多种分块模式和填充模式，网上能找到的往往只封装了其中一种，但却未必符合微信支付的要求）。

于是萌生了自己封装一个库的想法，打算解决这几个痛点，同时也是推广一下微软官方的 `System.Text.Json`。

### 2. 本库与[盛派微信 SDK（Senparc.Weixin）](https://github.com/JeffreySu/WeiXinMPSDK)有什么区别？

-   本库只支持微信支付 v3 版 API；盛派微信 SDK 只支持微信支付 v2 版 API（年前作者开了新坑似乎是想提供 v3 版支持，不过目前只封装了部分接口，进展比较缓慢）。原则上官方已经停止更新 v2 版 API，现在接口只做日常维护，所以有条件的话还是应该尽快升级。

-   本库封装了目前微信支付官方提供的所有 API，包括直连商户和服务商两种模式；盛派微信 SDK 只提供了常用的 API，只完整支持直连商户模式、部分支持服务商模式。

-   本库的接口模型遵循的是微软官方推荐的 C# 属性命名方式（大驼峰命名法）；盛派微信 SDK 提供的是微信支付接口本身的命名方式（蛇形命名法和小驼峰命名法混杂）。

-   本库专注于 API 本身的封装；盛派微信 SDK 提供了大而全的功能，与 ASP.NET / ASP.NET Core 深度集成。

### 3. 为什么不支持企业付款、现金红包等功能？

请注意前文所描述的微信支付 API 一览表，有部分功能并非封装遗漏，而是官方尚未提供支持。

如果你确实需要这部分功能，可以考虑使用上面提到过的[盛派微信 SDK（Senparc.Weixin）](https://github.com/JeffreySu/WeiXinMPSDK)，也很不错。

当官方更新相关的 API 后，本库也会在第一时间保持跟进。

### 4. 看了源码，发现模型定义里很多同样的代码是复制粘贴的，为什么不继承？

关于这点得吐槽微信支付提供的 API 了，很显然微信内部也是很多个 Team 在共同开发，每个 Team、甚至每个人的字段命名风格、约束条件、接口规则都大相径庭，虽然号称 v3 版 API 是 “RESTful” 的，却没一个统一标准。

举个例子，以分页查询为例，看似字段相同，都由 `offset`、`limit` + `total_count`、`data` 这几个字段构成，但某些接口的 `offset`、`limit` 字段是可选参数，某些却是必填项；某些值从 `0` 起始，某些却是从 `1` 起始；某些接口的 `total_count`、`data` 字段一定会返回，某些却是一定不返回，某些只在特定条件下返回。一共七八个分页查询的接口，却有四五种分页的数据结构，这种情况下很难抽象出一个公共的基类出来。

同样一个东西在不同接口里竟然拼法不一样；同样是表示数组有的是 JSON、有的却是字符串；诸如此类“奇葩”的情况很多很多。本库已经尽可能在条件允许的范围内抽象出了一些公共基类，聊胜于无。
