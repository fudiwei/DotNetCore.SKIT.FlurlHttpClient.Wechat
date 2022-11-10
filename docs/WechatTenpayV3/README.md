# SKIT.FlurlHttpClient.Wechat.TenpayV3

基于 `Flurl.Http` 的[微信商户平台](https://pay.weixin.qq.com/) API v3 版客户端。

如需微信支付 v2 版 API 客户端，请移步 [`SKIT.FlurlHttpClient.WechantTenpayV2`](../WechatTenpayV2/README.md) 模块。

---

## 功能

-   基于微信支付 v3 版 API 封装。

-   支持直连商户、服务商两种模式。

-   请求时自动生成签名，无需开发者手动干预。

-   提供了微信支付所需的 RSA、AES、SHA-256 等算法工具类。

-   提供了生成调起支付签名、加密请求中敏感数据、解密响应中敏感数据、解析回调通知事件敏感数据等扩展方法。

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
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

var manager = new InMemoryCertificateManager();
var options = new WechatTenpayClientOptions()
{
    MerchantId = "微信商户号",
    MerchantV3Secret = "微信商户 v3 API 密钥",
    MerchantCertificateSerialNumber = "微信商户证书序列号",
    MerchantCertificatePrivateKey = "-----BEGIN PRIVATE KEY-----微信商户证书私钥，即 `apiclient_key.pem` 文件内容-----END PRIVATE KEY-----",
    PlatformCertificateManager = manager // 证书管理器的具体用法请参阅下文的高级技巧与加密、验签有关的章节
};
var client = new WechatTenpayClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.TenpayV3;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;

/* 以 JSAPI 统一下单接口为例 */
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

-   [如何快速找到需要调用的 API 模型类名 / 方法名（附完整 API 对照表）？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何查看商户证书序列号？](./Advanced_CertificateSerialNumber.md)

-   [如何加密请求中的敏感数据？](./Advanced_RequestSensitiveDataEncryption.md)

-   [如何解密响应中的敏感数据？](./Advanced_ResponseSensitiveDataDecryption.md)

-   [如何验证响应签名？](./Advanced_ResponseSignatureVerification.md)

-   [如何解密回调通知事件中的敏感数据？](./Advanced_EventResourceDecryption.md)

-   [如何验证回调通知事件签名？](./Advanced_EventSignatureVerification.md)

-   [如何生成客户端调起支付时所需的参数及签名？](./Advanced_Parameters.md)

-   [如何扩展额外的 API？](./Advanced_Extensions.md)

---

## 示例项目

为方便开发者快速掌握本库的使用方法，这里提供一个示例项目以供参考。

请阅读[《示例项目说明》](./Sample.md)。
