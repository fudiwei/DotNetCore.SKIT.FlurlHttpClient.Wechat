# SKIT.FlurlHttpClient.Wechat.OpenAI

基于 `Flurl.Http` 的[微信对话开放平台](https://openai.weixin.qq.com/) HTTP API SDK。

---

## 功能

-   基于微信对话开放平台 API 封装。
-   提供了解析回调通知事件等扩展方法。

---

## 快速入门

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Wechat.OpenAI

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Wechat.OpenAI
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Wechat;
using SKIT.FlurlHttpClient.Wechat.OpenAI;

var options = new WechatOpenAIClientOptions()
{
    AppId = "微信智能对话 AppId",
    Token = "微信智能对话 Token",
    EncodingAESKey = "微信智能对话 EncodingAESKey"
};
var client = new WechatOpenAIClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.OpenAI;
using SKIT.FlurlHttpClient.Wechat.OpenAI.Models;

/* 以发送客服消息接口为例 */
var request = new SendMessageRequest()
{
    AppId = "公众号或小程序的 AppId",
    OpenId = "用户的 OpenId",
    Message = "消息内容",
    Channel = 0
};
var response = await client.ExecuteSendMessageAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("错误代码：" + response.ErrorCode);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("返回代码：" + response.ReturnCode);
    Console.WriteLine("返回错误：" + response.ReturnError);
}
```

---

## 基础用法

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Basic_ModelDefinition.md)

---

## 高级技巧

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)
