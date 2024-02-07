## 如何验证回调通知事件签名？

---

> 请先自行阅读：
>
> [《微信官方文档 - 开始开发：接入指南》](https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Access_Overview.html)

同样地，你既可以利用本库提供的 `SHA1Utility` 工具类自行进行签名验证，也可以通过扩展方法实现：

```csharp
/* 在初始化客户端时需指定服务器推送的相关参数 */
var options = new WechatApiClientOptions()
{
    // 其他配置项略
    PushToken = "Token",
    PushEncodingAESKey = "EncodingAESKey"
};
var client = WechatApiClientBuilder.Create(options).Build();

/* 验证微信服务器 */
bool ret = client.VerifyEventSignatureForEcho(
    webhookTimestamp: "微信回调通知中的 timestamp 字段",
    webhookNonce: "微信回调通知中的 nonce 字段",
    webhookSignature: "微信回调通知中的 signature 字段"
);

/* 验证安全模式下 XML 消息的签名 */
bool ret = client.VerifyEventSignatureFromXml(
    webhookXml: "微信公众平台发来的通知内容，形如：<xml><Encrypt>...</Encrypt></xml>"
);

/* 验证安全模式下 JSON 消息的签名 */
bool ret = client.VerifyEventSignatureFromJson(
    webhookJson: "微信公众平台发来的通知内容，形如：{\"Encrypt\":\"...\"}"
);
```
