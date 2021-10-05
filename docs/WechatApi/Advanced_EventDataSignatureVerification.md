## 如何验证回调通知事件签名？

---

> 请先自行阅读：
>
> [《微信官方文档 - 开始开发：接入指南》](https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Access_Overview.html)

同样的，你既可以利用本库提供的 `SHA1Utility`、`WxBizMsgCryptor` 工具类自行进行签名验证，也可以通过扩展方法实现：

```csharp
/* 验证微信服务器 */
bool ret = client.VerifyEventSignatureForEcho(
    callbackTimestamp: "微信回调通知中的 timestamp 字段",
    callbackNonce: "微信回调通知中的 nonce 字段",
    callbackSignature: "微信回调通知中的 signature 字段"
);

/* 验证安全模式下 XML 消息的签名 */
bool ret = client.VerifyEventSignatureFromXml(
    callbackXml: "微信公众平台发来的通知内容，形如：<xml> <Encrypt>...</Encrypt> </xml>"
);
```
