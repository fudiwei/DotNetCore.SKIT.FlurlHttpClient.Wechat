## 如何验证回调通知事件签名？

---

### 验签流程

你可根据官方文档的规则利用本库提供的 `MD5Utility`、`HMACUtility` 工具类自行进行签名验证。

此外，本库还封装了直接解密事件的扩展方法，下面给出一个示例代码：

```csharp
bool ret = client.VerifyEventSignature(
    callbackBody: "<xml> 微信回调通知中请求正文 XML 内容 </xml>"
);
```