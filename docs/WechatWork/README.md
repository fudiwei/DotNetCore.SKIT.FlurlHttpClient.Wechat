# SKIT.FlurlHttpClient.Wechat.Work

基于 `Flurl.Http` 的[企业微信](https://work.weixin.qq.com/) HTTP API SDK。

---

## 功能

-   基于企业微信 API 封装。
-   支持企业内部开发、第三方应用开发、服务商代开发、智慧硬件开发四种模式。
-   提供了企业微信 API 所需的 AES、RSA、SHA-1 等算法工具类。
-   提供了企业微信会话内容存档 C SDK 的相关功能封装。
-   提供了 JS-SDK 签名、解析回调通知事件等扩展方法。

---

## 快速入门

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Wechat.Work

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Wechat.Work
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Wechat;
using SKIT.FlurlHttpClient.Wechat.Work;

var options = new WechatWorkClientOptions()
{
    CorpId = "企业微信 CorpId",
    AgentId = "企业微信应用的 AgentId",
    AgentSecret = "企业微信应用的 Secret"
};
var client = new WechatWorkClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.Work;
using SKIT.FlurlHttpClient.Wechat.Work.Models;

/* 以获取用户信息接口为例 */
var request = new CgibinUserGetRequest()
{
    AccessToken = "企业微信应用的 AccessToken",
    UserId = "企业成员账号"
};
var response = await client.ExecuteCgibinUserGetAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("名称：" + response.Name);
    Console.WriteLine("头像：" + response.AvatarUrl);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 基础用法

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Basic_ModelDefinition.md)

-   [如何解析回调通知事件？](./Basic_EventDeserialization.md)

-   [如何生成 JS-SDK 所需的参数及签名？](./Basic_Parameters.md)

-   [如何接入会话内容存档 C SDK？](./Basic_FinanceSDK.md)

-   [如何自定义额外的 API 接口？](./Basic_Extensions.md)

---

## 高级技巧

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)
