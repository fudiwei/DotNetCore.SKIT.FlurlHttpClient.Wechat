# SKIT.FlurlHttpClient.Wechat.TenpayV2

基于 `Flurl.Http` 的[微信商户平台](https://pay.weixin.qq.com/) HTTP API SDK。

本模块仅支持微信支付 v2 版 API，如需接入微信支付 v3 版 API，请移步 [`SKIT.FlurlHttpClient.WechantTenpayV3`](../WechatTenpayV3/README.md) 模块。

---

## 功能

-   基于微信支付 v2 版 API 封装。
-   支持普通商户、境内服务商、银行服务商、跨境支付四种模式，同时支持企业微信的企业支付相关功能。
-   请求时自动生成签名，无需开发者手动干预。
-   提供了微信支付所需的 AES、MD5、HMAC-SHA-256 等算法工具类。
-   提供了调起支付签名、解析回调通知事件敏感数据等扩展方法。

---

## 快速入门

> [!IMPORTANT]
> 此目录下的文档适用于 v3.x 版本的模块。如果你正在使用 2.x 版本，请移步至 GitHub/Gitee 的已归档分支。

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Wechat.TenpayV2

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Wechat.TenpayV2
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Wechat.TenpayV2;

var options = new WechatTenpayClientOptions()
{
    MerchantId = "微信商户号",
    MerchantSecret = "微信商户 API 密钥",
    MerchantCertificateBytes = File.ReadAllBytes("/微信商户证书文件路径/apiclient_cert.p12"),
    MerchantCertificatePassword = "微信商户证书密码，通常是商户号"
};
var client = WechatTenpayClientBuilder.Create(options).Build();
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.TenpayV2;
using SKIT.FlurlHttpClient.Wechat.TenpayV2.Models;

/* 以付款码付款接口为例 */
var request = new CreatePayMicroPayRequestRequest()
{
    OutTradeNumber = "商户订单号",
    AppId = "微信 AppId",
    Body = "订单详情",
    ExpireTime = DateTimeOffset.Now.AddMinutes(15),
    TotalFee = 1,
    AuthCode = "付款码"
};
var response = await client.ExecuteCreatePayMicroPayRequestAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("微信支付订单号：" + response.TransactionId);
}
else
{
    Console.WriteLine("状态代码：" + response.ReturnCode);
    Console.WriteLine("状态描述：" + response.ReturnMessage);
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorCodeDescription);
    Console.WriteLine("业务结果代码：" + response.ResultCode);
    Console.WriteLine("业务结果描述：" + response.ResultMessage);
}
```

---

## 基础用法

-   ⭐ [如何快速找到需要调用的 API 模型类名 / 方法名（附完整 API 对照表）？](./Basic_ModelDefinition.md)

-   [如何解密回调通知事件中的敏感数据？](./Basic_EventInfoDecryption.md)

-   [如何验证回调通知事件签名？](./Basic_EventSignatureVerification.md)

-   [如何生成客户端（JSAPI、App、小程序等）所需的参数及签名？](./Basic_Parameters.md)

---

## 高级技巧

-   [如何与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

---

## 迁移指南

-   [v3.x 迁移指南](./Migration_V3.md)
