## 如何验证回调通知事件签名？

---

> 请先自行阅读：
>
> [《微信官方文档 - 开始开发：接入指南》](https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Access_Overview.html)

同样的，你既然可以利用本库提供的 `SHA1Utility` 工具类自行进行签名验证，也可以通过扩展方法实现：

```csharp
bool ret = client.VerifyEventSignature(
    callbackTimestamp: "微信回调通知中的 timestamp 字段",
    callbackNonce: "微信回调通知中的 nonce 字段",
    callbackSignature: "微信回调通知中的 signature 字段"
);
```
