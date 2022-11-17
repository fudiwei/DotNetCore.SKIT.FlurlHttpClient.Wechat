# SKIT.FlurlHttpClient.Wechat.TenpayBusiness

基于 `Flurl.Http` 的[腾讯微企付](https://business.tenpay.com/p/gateway-pay/) API 客户端。

---

## 功能

-   基于腾讯微企付 API 封装。

-   请求时自动生成签名，无需开发者手动干预。

-   提供了腾讯微企付所需的 RSA、SHA-256、SM3、SM4 等算法工具类。

-   提供了解析回调通知事件等扩展方法。

---

## 基础用法

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Wechat.TenpayBusiness

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Wechat.TenpayBusiness
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Wechat;
using SKIT.FlurlHttpClient.Wechat.TenpayBusiness;

var options = new WechatTenpayBusinessClientOptions()
{
    PlatformId = "腾讯微企付平台账号",
    PlatformCertificateSerialNumber = "腾讯微企付平台 API 证书序列号",
    PlatformCertificatePrivateKey = "-----BEGIN PRIVATE KEY-----腾讯微企付平台 API 证书私钥-----END PRIVATE KEY-----",
    TBEPCertificateSerialNumber = "腾讯微企付证书序列号",
    TBEPCertificatePublicKey = "-----BEGIN PUBLIC KEY-----腾讯微企付证书公钥-----END PUBLIC KEY-----"
};
var client = new WechatTenpayBusinessClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.TenpayBusiness;
using SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models;

/* 以根据交易订单查询付款结果接口为例 */
var request = new GetMSEPayPaymentByPaymentIdRequest()
{
    OutPaymentId = "平台支付单号"
};
var response = await client.ExecuteGetMSEPayPaymentByOutPaymentIdAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("微企付支付单号：" + response.PaymentId);
}
else
{
    Console.WriteLine("错误代码：" + response.Error.Code);
    Console.WriteLine("错误描述：" + response.Error.Description);
}
```

---

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名（附完整 API 对照表）？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何加密请求中的敏感数据？](./Advanced_RequestSensitiveDataEncryption.md)

-   [如何解密响应中的敏感数据？](./Advanced_ResponseSensitiveDataDecryption.md)

-   [如何验证响应签名？](./Advanced_ResponseSignatureVerification.md)

-   [如何验证回调通知事件签名？](./Advanced_EventSignatureVerification.md)
