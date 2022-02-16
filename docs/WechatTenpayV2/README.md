# SKIT.FlurlHttpClient.Wechat.TenpayV2

基于 `Flurl.Http` 的[微信商户平台](https://pay.weixin.qq.com/) API v2 版客户端。

如需微信支付 v3 版 API 客户端，请移步 [`SKIT.FlurlHttpClient.WechantTenpayV3`](../WechatTenpayV3/README.md) 模块。

---

## 功能

-   基于微信支付 v2 版 API 封装。

-   支持普通商户、境内服务商、银行服务商三种模式。

-   请求时自动生成签名，无需开发者手动干预。

-   提供了微信支付所需的 AES、MD5、HMAC-SHA-256 等算法工具类。

-   提供了生成调起支付签名、解析回调通知事件等扩展方法。

> **注意**：本库仅仅包含微信支付未提供 v3 版 API 的部分功能，如需微信支付 v3 版 API 客户端，欢迎使用 [`SKIT.FlurlHttpClient.WechantTenpayV3`](../WechatTenpayV3/README.md) 模块。

---

## 基础用法

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
using SKIT.FlurlHttpClient.Wechat;
using SKIT.FlurlHttpClient.Wechat.TenpayV2;

var options = new WechatTenpayClientOptions()
{
    MerchantId = "微信商户号",
    MerchantSecret = "微信商户 API 密钥",
    MerchantCertificateBytes = Convert.FromBase64String("微信商户证书内容，即 `apiclient_cert.p12` 文件内容的 Base64 编码结果"),
    MerchantCertificatePassword = "微信商户证书密码，通常是商户号"
};
var client = new WechatTenpayClient(options);
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

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名（附完整 API 对照表）？](./Advanced_ModelDefinition.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何解密回调通知事件中的敏感数据？](./Advanced_EventResourceDecryption.md)

-   [如何验证回调通知事件签名？](./Advanced_EventSignatureVerification.md)

-   [如何生成客户端调起支付时所需的参数及签名？](./Advanced_Parameters.md)
