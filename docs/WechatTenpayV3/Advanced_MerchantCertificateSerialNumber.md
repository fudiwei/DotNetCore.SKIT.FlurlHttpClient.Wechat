## 如何查看商户证书序列号？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 证书/密钥/签名介绍：私钥和证书 - 声明所使用的证书》](https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay3_1.shtml#part-3)
>
> [《微信支付开发者文档 - 常见问题：证书相关 - 如何查看证书序列号？》](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay7_0.shtml#part-5)

请开发者按上面参考阅读给出的方法自行查看证书序列号。

如果你已有 CER/CRT 格式的证书文件，你也可以利用本库提供的提供的 `RSAUtility` 工具类导出证书序列号：

```csharp
string certificate = "CRT/CER 证书内容";
string serialNumber = RSAUtility.ExportSerialNumber(certificate);
```
