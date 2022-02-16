# SKIT.FlurlHttpClient.Wechat.Work

基于 `Flurl.Http` 的[企业微信](https://work.weixin.qq.com/) API 客户端。

---

## 功能

-   基于企业微信 API 封装。

-   支持企业内部开发、第三方应用开发（即服务商）、智慧硬件开发（即硬件接入）三种模式。

-   提供了企业微信 API 所需的 SHA-1、AES 等算法工具类。

-   提供了 JS-SDK 签名、解析回调通知事件等扩展方法。

---

## 基础用法

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
    AgentSecret = "企业微信应用的 AgentId"
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

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何解析回调通知事件？](./Advanced_EventDataDeserialization.md)

-   [如何生成 JS-SDK 初始化时所需的参数及签名？](./Advanced_Parameters.md)

-   [如何扩展额外的 API？](./Advanced_Extensions.md)
