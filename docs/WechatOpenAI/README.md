# SKIT.FlurlHttpClient.Wechat.OpenAI

基于 `Flurl.Http` 的[微信对话开放平台](https://openai.weixin.qq.com/) API 客户端。

---

## 功能

-   基于微信对话开放平台 API 封装。

-   支持平台接入、第三方接入两种模式。

-   对于第三方接入，请求时自动生成加密参数，无需开发者手动干预。

-   对于平台接入，请求时自动生成请求唯一标识，无需开发者手动干预。

-   提供了解析回调通知事件等扩展方法。

---

## 基础用法

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
    ClientId = "微信智能对话 ClientId，仅第三方接入需要",
    ClientKey = "微信智能对话 ClientKey，仅第三方接入需要",
    AppId = "微信智能对话 AppId，仅平台接入需要",
    PushToken = "微信智能对话 Token，仅平台接入需要",
    PushEncodingAESKey = "微信智能对话 EncodingAESKey，仅平台接入需要"
};
var client = new WechatOpenAIClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.OpenAI;
using SKIT.FlurlHttpClient.Wechat.OpenAI.Models;

/* 以创建机器人接口为例 */
var request = new BotSaveRequest()
{
    AccessToken = "微信智能对话 X-OPENAI-TOKEN",
    ChineseName = "机器人中文名",
    EnglishName = "机器人英文名",
    Nickname = "机器人昵称",
    BotType = 0,
    IndustryId = 0
};
var response = await client.ExecuteBotSaveAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("机器人 ID：" + response.Data.BotId);
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
