# SKIT.FlurlHttpClient.Wechat.OpenAI

基于 `Flurl.Http` 的[微信对话开放平台](https://chatbot.weixin.qq.com/) HTTP API SDK。

---

## 功能

-   基于微信对话开放平台 API 封装。
-   针对 v2 版接口，请求时自动生成签名，无需开发者手动干预。
-   提供了微信对话开放平台所需的 AES、MD5、SHA-1 等算法工具类。
-   提供了解析回调通知事件等扩展方法。

---

## 快速入门

> [!IMPORTANT]
> 此目录下的文档适用于 v3.x 版本的模块。如果你正在使用 2.x 版本，请移步至 GitHub/Gitee 的已归档分支。

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

var options = new WechatChatbotClientOptions()
{
    AppId = "微信智能对话 AppId",
    Token = "微信智能对话 Token",
    EncodingAESKey = "微信智能对话 EncodingAESKey"
};
var client = WechatChatbotClientBuilder.Create(options).Build();
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
    Console.WriteLine("错误描述：" + response.ErrorMessage);
    Console.WriteLine("返回代码：" + response.ReturnCode);
    Console.WriteLine("返回错误：" + response.ReturnError);
}
```

---

## 基础用法

-   ⭐ [如何快速找到需要调用的 API 模型类名 / 方法名？](./Basic_ModelDefinition.md)

---

## 高级技巧

-   [配置 JSON 序列化器](./Advanced_JsonSerializer.md)

-   [配置 HttpClient](./Advanced_HttpClient.md)

-   [使用拦截器](./Advanced_Interceptor.md)

-   [避免内存泄漏](./Advanced_Dispose.md)

-   [与 `IHttpClientFactory` 集成](./Advanced_HttpClientFactory.md)
