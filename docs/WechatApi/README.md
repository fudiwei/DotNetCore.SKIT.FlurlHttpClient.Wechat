# SKIT.FlurlHttpClient.Wechat.Api

基于 `Flurl.Http` 的[微信公众平台](<(https://mp.weixin.qq.com/)>) & [微信开放平台](<(https://open.weixin.qq.com/)>) API 客户端。

---

## 功能

-   基于微信公众平台 & 微信开放平台 API 封装。

-   提供了微信公众平台 & 微信开放平台 API 所需的 SHA-1、HMAC-SHA-256、AES 等算法工具类。

-   提供了 JS-SDK 签名、解析回调通知事件等扩展方法。

---

## 基础用法

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Wechat.Api

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Wechat.Api
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Wechat;
using SKIT.FlurlHttpClient.Wechat.Api;

var options = new WechatApiClientOptions()
{
    AppId = "微信 AppId",
    AppSecret = "微信 AppSecret",
    MidasAppKey = "米大师相关服务 AppKey，不用则不填",
    ImmeDeliveryAppKey = "即时配送相关服务 AppKey，不用则不填",
    ImmeDeliveryAppSecret = "即时配送相关服务 AppSecret，不用则不填"
};
var client = new WechatApiClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.Api;
using SKIT.FlurlHttpClient.Wechat.Api.Models;

/* 以公众号获取用户信息接口为例 */
var request = new CgibinUserInfoRequest()
{
    AccessToken = "微信 AccessToken",
    OpenId = "微信 OpenId"
};
var response = await client.ExecuteCgibinUserInfoAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("昵称：" + response.Nickname);
    Console.WriteLine("头像：" + response.HeadImageUrl);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何解析回调通知事件？](./Advanced_EventDataDeserialization.md)

-   [如何验证回调通知事件签名？](./Advanced_EventDataSignatureVerification.md)

-   [如何解密经过加密处理的开放数据？](./Advanced_OpenDataDecryption.md)

-   [如何生成 JS-SDK 初始化时所需的参数及签名？](./Advanced_JSSDK.md)

-   [如何扩展额外的 API？](./Advanced_Extensions.md)

---

## 示例项目

为方便开发者快速掌握本库的使用方法，这里提供一个示例项目以供参考。

请阅读[《示例项目说明》](./Sample.md)。
