# SKIT.FlurlHttpClient.Wechat.TenpayV3

[![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.TenpayV3.svg?sanitize=true)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV3)
[![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.TenpayV3.svg?sanitize=true)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.TenpayV3)
[![GitHub License](https://img.shields.io/github/license/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/blob/main/LICENSE)

基于 `Flurl.Http` 的[微信商户平台](https://pay.weixin.qq.com/) API v3 版客户端。

---

## 功能

-   基于微信支付 v3 版 API 封装。

-   支持直连商户、服务商两种模式。

-   请求时自动生成签名，无需开发者手动干预。

-   提供了微信支付所需的 RSA、AES、SHA-256 等算法工具类。

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
    |  ×  | <del>基础支付：付款码支付</del> | <del>直连商户 & 服务商</del> | 官方未提供 v3 API |
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
    |  ×  |  <del>营销工具：现金红包</del>  | <del>直连商户 & 服务商</del> | 官方未提供 v3 API |
    |  ×  |  <del>资金应用：企业付款</del>  |     <del>直连商户</del>      | 官方未提供 v3 API |
    |  √  |         资金应用：分账          |      直连商户 & 服务商       |                   |
    |  √  |     资金应用：连锁品牌分账      |            服务商            |                   |
    |  √  |   风险合规：商户开户意愿确认    |            服务商            |                   |
    |  √  |    风险合规：消费者投诉 2.0     |      直连商户 & 服务商       |                   |
    |  ×  |  <del>其他能力：清关上报</del>  |     <del>直连商户</del>      | 官方未提供 v3 API |
    |  √  |       其他能力：图片上传        |      直连商户 & 服务商       |                   |
    |  √  |       其他能力：视频上传        |      直连商户 & 服务商       |                   |

---

## 基础用法

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

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
        OpenId = "微信 OpenId"
    }
};
var response = await client.ExecuteCreatePayTransactionJsapiAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("PrepayId：" + response.PrepayId);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 高级技巧

-   [如何查看商户证书序列号？](./Advanced_MerchantCertSerialNumber.md)

-   [如何验证微信响应签名？](./Advanced_ResponseSignatureVerification.md)

-   [如何快速找到需要调用的 API 模型类名 / 方法名（附完整 API 对照表）？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何解密响应中的敏感数据？](./Advanced_ResponseDataDecryption.md)

-   [如何解密回调通知事件中的敏感数据？](./Advanced_EventDataDecryption.md)

-   [如何生成客户端调起支付时所需的参数及签名？](./Advanced_Payment.md)
