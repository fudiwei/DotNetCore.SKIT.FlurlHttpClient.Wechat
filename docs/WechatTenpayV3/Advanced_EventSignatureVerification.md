## 如何验证回调通知事件签名？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 开发指南：签名验证》](https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml)

---

### 重要须知：

请在开发过程中注意区分**商户证书**和**平台证书**：

-   **商户证书**用于生成请求的签名，需要通过微信商户后台申请并下载，并在构建客户端配置项时指定（即 `WechatTenpayClientOptions` 对象中的商户证书序列号和商户公钥两个参数）；
-   **平台证书**用于验证响应或回调的签名，需要在程序运行时实时通过接口动态获取（即 `QueryCertificatesAsync` 方法，注意证书内容需要解密）。

如果你在开发过程出现验签不通过的情况，请先检查是否混淆了这两个证书。

关于证书的更多注意事项，请参阅[《微信支付开发者文档 - 常见问题：证书相关》](https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay7_0.shtml)

---

### 密钥文件格式说明：

需要注意的是，平台为商户提供的是 PEM 格式的密钥文件，需注意文件格式之间的不同。

有关密钥文件格式的更多介绍，请参阅本文档[《高级技巧 - 如何加密请求中的敏感数据？》](./Advanced_RequestSensitiveDataEncryption.md)的有关章节。

---

### 验签流程

验证回调通知事件签名的方法与验证响应签名的类似，请参阅本文档[《高级技巧 - 如何验证响应签名？》](./Advanced_ResponseSignatureVerification.md)的有关章节。

同样地，你既可以利用本库提供的 `RSAUtility` 工具类自行进行签名验证，也可以通过 `CertificateManager` 尝试自动完成签名验证：

```csharp
bool ret = client.VerifyEventSignature(
    callbackTimestamp: "微信回调通知中的 Wechatpay-Timestamp 字段",
    callbackNonce: "微信回调通知中的 Wechatpay-Nonce 字段",
    callbackBody: "微信回调通知中请求正文",
    callbackSignature: "微信回调通知中的 Wechatpay-Signature 字段",
    callbackSerialNumber: "微信回调通知中的 Wechatpay-Serial 字段"
);
```

需要注意的是，使用该扩展方法前需先下载好平台证书，并存入全局的 `CertificateManager`。有关 `CertificateManager` 的更多介绍，请阅读下方有关章节。

---

### 调试验签错误：

由于 `VerifyEventSignature()` 方法内部会 `try-catch` 掉所有异常情况，并直接返回 `false`。为方便开发者在调试阶段排查验签的错误信息，你可以在验证回调通知事件签名时指定接收最后一个 `out` 返回参数，该参数中包含了一些异常的原因和相关堆栈信息。

```csharp
bool ret = client.VerifyEventSignature(timestamp, nonce, body, signature, serialNumber, out Exception error);
if (!ret) 
{
    Console.WriteLine(error);
    Console.WriteLine(error.InnerException);
}
```

---

### 通过 `CertificateManager` 管理平台证书信息：

请参阅本文档[《高级技巧 - 如何加密请求中的敏感数据？》](./Advanced_RequestSensitiveDataEncryption.md)下的同名章节。