## 如何验证响应签名？

---

### 验签流程

每个响应对象均包含键为 `TBEP-Authorization` 的响应标头，你可根据官方文档的规则利用本库提供的 `RSAUtility` 工具类自行进行签名验证。

下面给出一个使用 `RSAUtility` 工具类验证签名的示例代码：

```csharp
string data = "拼接好的验签数据";
string sign = "待验证的签名";
string tbepPublicKey = "微企付公钥";
bool ret = RSAUtility.VerifyWithSHA256(tbepPublicKey, data, sign);
```

此外，本库还封装了直接验证响应签名的扩展方法，下面给出一个示例代码：

```csharp
bool ret = client.VerifyResponseSignature(response);
```

---

### 调试验签错误：

由于 `VerifyResponseSignature()` 方法内部会 `try-catch` 捕获所有异常，并直接返回 `false`。为方便开发者在调试阶段排查验签的错误信息，你可以在验证响应签名时指定返回值类型为 `ErroredResult` 而非 `Boolean`，该返回值中包含了一些异常的原因和相关堆栈信息。

```csharp
ErroredResult res = client.VerifyResponseSignature(response);
if (!res.Result)
{
    Console.WriteLine(res.Error);
}
```
