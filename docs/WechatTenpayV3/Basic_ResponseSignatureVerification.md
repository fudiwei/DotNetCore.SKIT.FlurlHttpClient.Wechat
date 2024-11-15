## 如何验证响应签名？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 开发指南：签名验证》](https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml)
>
> [《微信支付官方公告 - 关于新商户调用接口验签方式变更通知》](https://developers.weixin.qq.com/community/pay/doc/0002c6a7cf438818df52145b863c01)

---

### 重要须知：

请在开发过程中注意区分**商户证书**和**平台证书**：

-   **商户证书**用于生成请求的签名，需要通过微信商户后台申请并下载，并在构建客户端配置项时指定（即 `WechatTenpayClientOptions` 对象中的商户证书序列号和商户公钥两个参数）；
-   **平台证书**用于验证响应或回调的签名，需要在程序运行时实时通过接口动态获取（即 `QueryCertificatesAsync` 方法，注意证书内容需要解密）。

如果你在开发过程出现验签不通过的情况，请先检查是否混淆了这两个证书。

🔥 另，2024 年 10 月后新注册的微信商户已不再提供平台证书，取而代之的是平台公钥。但二者的验签流程基本相同。更多内容请见本章的《适配微信支付新商户的平台公钥认证方式》一节。

关于证书的更多注意事项，请参阅[《微信支付开发者文档 - 常见问题：证书相关》](https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay7_0.shtml)

需要注意的是，平台为商户提供的是 PEM 格式的密钥文件，需注意文件格式之间的不同。

有关密钥文件格式的更多介绍，请参阅本文档[《基础用法 - 如何加密请求中的敏感数据？》](./Basic_RequestSensitiveDataEncryption.md)的有关章节。

---

### 验签流程

每个响应对象均包含名为 `WechatpayTimestamp`、`WechatpayNonce`、`WechatpaySignature` 的几个公共字段，你可根据官方文档的规则利用本库提供的 `RSAUtility` 工具类自行进行签名验证。

具体用法可以参考项目目录下的 _test/SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests/WechatTenpayResponseVerificationTests.cs_ 文件给出的测试用例。

下面给出一个使用 `RSAUtility` 工具类验证签名的示例代码：

```csharp
string data = "拼接好的验签数据";
string sign = "待验证的签名";
string certificate = "CRT/CER 证书内容";
/* 通过证书验证签名 */
bool ret = RSAUtility.VerifyWithSHA256ByCertificate(certificate, data, sign);
/* 通过公钥验证签名 */
string publicKey = RSAUtility.ExportPublicKey(certificate);
bool ret = RSAUtility.VerifyWithSHA256(publicKey, data, sign);
```

此外，本库还封装了直接验证响应签名的扩展方法，下面给出一个示例代码：

```csharp
bool ret = client.VerifyResponseSignature(response);
```

> ⚠️ 【重要说明】使用该扩展方法前需先下载好平台证书，并存入全局的 `CertificateManager`。有关 `CertificateManager` 的更多介绍，请阅读下方《通过 `CertificateManager` 管理平台证书信息》这一小节。

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

---

### 通过 `CertificateManager` 管理平台证书信息：

请参阅本文档[《基础用法 - 如何加密请求中的敏感数据？》](./Basic_RequestSensitiveDataEncryption.md)下的同名章节。

### 适配微信支付新商户的平台公钥认证方式

请参阅本文档[《基础用法 - 如何加密请求中的敏感数据？》](./Basic_RequestSensitiveDataEncryption.md)下的同名章节。
