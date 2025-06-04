# SKIT.FlurlHttpClient.Wechat.TenpayV3

基于 `Flurl.Http` 的[微信商户平台](https://pay.weixin.qq.com/) HTTP API SDK。

本模块仅支持微信支付 v3 版 API，如需接入微信支付 v2 版 API，请移步 [`SKIT.FlurlHttpClient.Wechant.TenpayV2`](../WechatTenpayV2/README.md) 模块。

---

## 功能

-   基于微信支付 v3 版 API 封装。
-   支持商户（直连模式）、合作伙伴（服务商、渠道商、机构、银行模式）两种角色模式。
-   请求时自动生成签名（支持国际 RSA 算法或国密 SM 算法），无需开发者手动干预。
-   提供了微信支付所需的 AES、RSA、SM2/SM3/SM4、SHA-256 等算法工具类。
-   提供了调起支付签名、解析响应敏感数据、解析回调通知事件敏感数据等扩展方法。

---

## 快速入门

> [!IMPORTANT]
> 此目录下的文档适用于 v3.x 版本的模块。如果你正在使用 2.x 版本，请移步至 GitHub/Gitee 的已归档分支。

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
using SKIT.FlurlHttpClient.Wechat.TenpayV3;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

var options = new WechatTenpayClientOptions()
{
    MerchantId = "微信商户号",
    MerchantV3Secret = "微信商户 v3 API 密钥",
    MerchantCertificateSerialNumber = "微信商户证书序列号",
    MerchantCertificatePrivateKey = System.IO.File.ReadAllText("/微信商户证书私钥文件路径/apiclient_key.pem"),

    // 基于平台证书的认证方式还需设置以下参数：
    PlatformAuthScheme = Settings.PlatformAuthScheme.Certificate,
    PlatformCertificateManager = new InMemoryCertificateManager()

    // 基于平台公钥的认证方式还需设置以下参数：
    PlatformAuthScheme = Settings.PlatformAuthScheme.PublicKey,
    PlatformPublicKeyManager = new InMemoryPublicKeyManager()
};
var client = WechatTenpayClientBuilder.Create(options).Build();
```

🔥 平台证书管理器、平台公钥管理器的具体用法请参阅下文的基础用法与加密、验签有关的章节。

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
    Amount = new CreatePayTransactionJsapiRequest.Types.Amount()
    {
        Total = 1
    },
    Payer = new CreatePayTransactionJsapiRequest.Types.Payer()
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

## 基础用法

-   ⭐ [如何快速找到需要调用的 API 模型类名 / 方法名（附完整 API 对照表）？](./Basic_ModelDefinition.md)

-   [如何查看商户证书序列号？](./Basic_CertificateSerialNumber.md)

-   [如何加密请求中的敏感数据？](./Basic_RequestSensitiveDataEncryption.md)

-   [如何解密响应中的敏感数据？](./Basic_ResponseSensitiveDataDecryption.md)

-   [如何验证响应签名？](./Basic_ResponseSignatureVerification.md)

-   [如何解密回调通知事件中的敏感数据？](./Basic_EventResourceDecryption.md)

-   [如何验证回调通知事件签名？](./Basic_EventSignatureVerification.md)

-   ⭐ [如何生成客户端（JSAPI、App、小程序等）所需的参数及二次签名？](./Basic_Parameters.md)

-   [如何自定义额外的 API 接口？](./Basic_Extensions.md)

-   [如何接入国密算法？](./Basic_SMAlgorithm.md)

-   [如何接入境外支付 API？](./Basic_GlobalAPI.md)

---

## 高级技巧

-   [配置 JSON 序列化器](./Advanced_JsonSerializer.md)

-   [配置 HttpClient](./Advanced_HttpClient.md)

-   [使用拦截器](./Advanced_Interceptor.md)

-   [避免内存泄漏](./Advanced_Dispose.md)

-   [与 `IHttpClientFactory` 集成](./Advanced_HttpClientFactory.md)

---

## 常见问题

-   [本地开发时正常，发布到 IIS 后请求抛出异常？](./FAQ_IISProblem.md)

---

## 示例项目

为方便开发者快速掌握本库的使用方法，这里提供一个示例项目以供参考。

请阅读[《示例项目说明》](./Sample.md)。

---

## 迁移指南

-   [v3.x 迁移指南](./Migration_V3.md)
