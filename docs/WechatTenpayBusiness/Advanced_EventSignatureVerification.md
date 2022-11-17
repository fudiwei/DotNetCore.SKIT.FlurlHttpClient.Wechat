﻿## 如何验证回调通知事件签名？

---

### 验签流程

验证回调通知事件签名的方法与验证响应签名的类似，请参阅本文档[《高级技巧 - 如何验证响应签名？》](./Advanced_ResponseSignatureVerification.md)的有关章节。

同样地，你既可以利用本库提供的 `RSAUtility` 工具类自行进行签名验证，也可以通过封装好的扩展方法完成签名验证：

```csharp
bool ret = client.VerifyEventSignature(
    callbackAuthorization: "微企付回调通知中的 TBEP-Authorization 标头",
    callbackBody: "微企付回调通知中请求正文"
);
```

---

### 调试验签错误：

由于 `VerifyEventSignature()` 方法内部会 `try-catch` 掉所有异常情况，并直接返回 `false`。为方便开发者在调试阶段排查验签的错误信息，你可以在验证回调通知事件签名时指定接收最后一个 `out` 返回参数，该参数中包含了一些异常的原因和相关堆栈信息。

```csharp
bool ret = client.VerifyEventSignature(authorization, signature, out Exception error);
if (!ret)
{
    Console.WriteLine(error);
    Console.WriteLine(error?.InnerException);
}
```
