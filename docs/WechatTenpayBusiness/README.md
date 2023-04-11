# SKIT.FlurlHttpClient.Wechat.TenpayBusiness

基于 `Flurl.Http` 的[微企付](https://businesspay.qq.com/p/mse-pay/) HTTP API SDK。

---

## 功能

-   基于微企付 API 封装。
-   请求时自动生成签名，无需开发者手动干预。
-   提供了微企付所需的 RSA、SM3、SM4、SHA-256 等算法工具类。
-   提供了解析回调通知事件等扩展方法。

---

## 快速入门

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
    PlatformId = "微企付平台账号",
    PlatformCertificateSerialNumber = "微企付平台 API 证书序列号",
    PlatformCertificatePrivateKey = "-----BEGIN PRIVATE KEY-----微企付平台 API 证书私钥-----END PRIVATE KEY-----",
    EnterpriseId = "微企付企业商户 ID（非必填）",
    EnterpriseCertificateSerialNumber = "微企付企业商户 API 证书序列号（非必填）",
    EnterpriseCertificatePrivateKey = "-----BEGIN PRIVATE KEY-----微企付企业商户 API 证书私钥（非必填）-----END PRIVATE KEY-----",
    TBEPCertificateSerialNumber = "微企付证书序列号",
    TBEPCertificatePublicKey = "-----BEGIN PUBLIC KEY-----微企付证书公钥-----END PUBLIC KEY-----"
};
var client = new WechatTenpayBusinessClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.TenpayBusiness;
using SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models;

/* 以根据交易订单查询付款结果接口为例 */
var request = new GetPaymentByPaymentIdRequest()
{
    OutPaymentId = "平台支付单号"
};
var response = await client.ExecuteGetPaymentByOutPaymentIdAsync(request);
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

## 基础用法

-   [如何快速找到需要调用的 API 模型类名 / 方法名（附完整 API 对照表）？](./Basic_ModelDefinition.md)

-   [如何加密请求中的敏感数据？](./Basic_RequestSensitiveDataEncryption.md)

-   [如何解密响应中的敏感数据？](./Basic_ResponseSensitiveDataDecryption.md)

-   [如何验证响应签名？](./Basic_ResponseSignatureVerification.md)

-   [如何验证回调通知事件签名？](./Basic_EventSignatureVerification.md)

---

## 高级技巧

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)
