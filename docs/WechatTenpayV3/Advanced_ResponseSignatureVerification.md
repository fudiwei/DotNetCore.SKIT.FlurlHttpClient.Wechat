### 如何验证微信响应签名？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 开发指南：签名验证》](https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml)
>
> [《微信支付开发者文档 - 平台证书：更新指引》](https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay5_0.shtml)

本库已经封装了 `QueryCertificatesAsync()` 方法，供开发者获取微信支付平台证书。

每个响应对象均包含 `WechatpayTimestamp`、`WechatpayNonce`、`WechatpaySignature`、`WechatpaySerial` 等几个公共字段，你可根据官方文档的规则利用本库提供的 `RsaUtil` 工具类自行进行签名验证。

同时，本库也内置了验证签名的的方法，具体用法可以参考项目目录下的 _test/SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests/WechatTenpayResponseVerificationTests.cs_ 文件给出的测试用例。

需要注意的是，微信支付平台提供的是 PEM 格式的密钥文件，分为以下几种：

-   以 `-----BEGIN PRIVATE KEY-----` 开头、 `-----END PRIVATE KEY-----` 结尾的是 **PKCS#8 私钥**文件。

-   以 `-----BEGIN PUBLIC KEY-----` 开头、 `-----END PUBLIC KEY-----` 结尾的是 **PKCS#8 公钥**文件。

-   以 `-----BEGIN CERTIFICATE-----` 开头、 `-----END CERTIFICATE-----` 结尾的是 **CER 证书**文件。

`QueryCertificatesAsync()` 方法返回的结果是 CER 证书，验证签名时需要先通过 `RsaUtil` 工具类导出 PKCS#8 公钥，再进行签名验证；当然，`RsaUtil` 也封装了直接通过 CER 证书验证签名的方法。
