## 如何验证回调通知事件签名？

---

验证回调通知事件签名的方法与验证响应签名的类似，请参阅[相关文档](./Advanced_ResponseSignatureVerification.md)。

同样的，你既可以利用本库提供的 `RSAUtility` 工具类自行进行签名验证，也可以通过 `CertificateManager` 尝试自动完成签名验证：

请注意，有关 `CertificateManager` 的具体用法、及相关证书或公钥格式的说明，请务必先阅读上方给出的相关文档。

```csharp
bool ret = client.VerifyEventSignature(
    callbackTimestamp: "微信回调通知中的 Wechatpay-Timestamp 字段",
    callbackNonce: "微信回调通知中的 Wechatpay-Nonce 字段",
    callbackBody: "微信回调通知中请求正文",
    callbackSignature: "微信回调通知中的 Wechatpay-Signature 字段",
    callbackSerialNumber: "微信回调通知中的 Wechatpay-Serial 字段"
);
```
