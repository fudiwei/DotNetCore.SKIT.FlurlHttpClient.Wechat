## 如何验证回调通知事件签名？

---

### 验签流程

验证回调通知事件签名的方法与验证响应签名的类似，请参阅本文档[《基础用法 - 如何验证响应签名？》](./Basic_ResponseSignatureVerification.md)的有关章节。

同样地，你既可以利用本库提供的 `RSAUtility` 工具类自行进行签名验证，也可以通过封装好的扩展方法完成签名验证：

```csharp
bool ret = client.VerifyEventSignature(
    webhookAuthorization: "微企付回调通知中的 TBEP-Authorization 标头",
    webhookBody: "微企付回调通知中请求正文"
);
```

---

### 调试验签错误：

由于 `VerifyEventSignature()` 方法内部会 `try-catch` 掉所有异常情况，并直接返回 `false`。为方便开发者在调试阶段排查验签的错误信息，你可以在验证回调通知事件签名时指定返回值类型为 `ErroredResult` 而非 `Boolean`，该返回值中包含了一些异常的原因和相关堆栈信息。

```csharp
ErroredResult res = client.VerifyEventSignature(authorization, signature);
if (!res.Result)
{
    Console.WriteLine(res.Error);
}
```
