## 如何查看商户证书序列号？

---

> 请先自行阅读：
>
> [《微信支付文档中心 - 开发须知 / 开发参数申请和配置 / 申请商户 API 证书》](https://pay.weixin.qq.com/doc/v3/merchant/4012072428)

请开发者按上面参考阅读给出的方法自行查看证书序列号。

如果你已有 CER/CRT 格式的证书文件，你也可以利用本库提供的提供的 `RSAUtility` 工具类导出证书序列号：

```csharp
string certificate = "-----BEGIN CERTIFICATE-----微信商户证书，即 `apiclient_cert.pem` 文件内容-----END CERTIFICATE-----";
string serialNumber = RSAUtility.ExportSerialNumberFromCertificate(certificate);
```
