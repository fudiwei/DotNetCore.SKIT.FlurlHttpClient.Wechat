## 如何接入智能机器人？

企业微信智能机器人 API 的接口模型参数等与基础 API 不同，需要使用独立的扩展客户端。

```csharp
using SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot;

var options = new WechatWorkAIBotClientOptions()
{
    PushToken = "Token",
    PushEncodingAESKey = "EncodingAESKey"
};
var client = WechatWorkAIBotClientBuilder.Create(options).Build();
```

该扩展客户端在用法上基础客户端完全相同，只需引入相应的命名空间即可。
