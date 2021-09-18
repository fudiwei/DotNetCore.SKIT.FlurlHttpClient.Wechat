## 如何验证响应签名？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 开发指南：签名验证》](https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml)
>
> [《微信支付开发者文档 - 平台证书：更新指引》](https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay5_0.shtml)

验签过程中需要使用的微信商户平台证书，开发者可通过本库封装的 `QueryCertificatesAsync()` 方法来获取。

每个响应对象均包含名为 `WechatpayTimestamp`、`WechatpayNonce`、`WechatpaySignature` 的几个公共字段，你可根据官方文档的规则利用本库提供的 `RSAUtility` 工具类自行进行签名验证。

具体用法可以参考项目目录下的 _test/SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests/WechatTenpayResponseVerificationTests.cs_ 文件给出的测试用例。

---

### 密钥文件格式说明：

需要注意的是，微信商户平台提供的是 PEM 格式的密钥文件，分为以下几种：

-   以 `-----BEGIN PRIVATE KEY-----` 开头、 `-----END PRIVATE KEY-----` 结尾的是 **PKCS#8 私钥**文件。

-   以 `-----BEGIN PUBLIC KEY-----` 开头、 `-----END PUBLIC KEY-----` 结尾的是 **PKCS#8 公钥**文件。

-   以 `-----BEGIN CERTIFICATE--- --` 开头、 `-----END CERTIFICATE-----` 结尾的是 **CER 证书**文件。

谨记，`QueryCertificatesAsync()` 方法返回的结果是 CER 证书，需要先通过 `RSAUtility` 工具类导出 PKCS#8 公钥，再进行签名验证；当然，`RSAUtility` 也封装了直接通过 CER 证书验证签名的方法。

下面给出一个示例代码：

```csharp
string data = "待验签的数据";
string sign = "待验证的签名";
string certificate = "CER 证书内容";
/* 通过证书验证签名 */
bool ret = RSAUtility.VerifyWithSHA256ByCertificate(certificate, data, sign);
/* 通过公钥验证签名 */
string publicKey = RSAUtility.ExportPublicKey(certificate);
bool ret = RSAUtility.VerifyWithSHA256(publicKey, data, sign);
```

---

### 通过 `CertificateManager` 管理平台证书信息：

微信商户平台证书需要通过 API 的方式获取、且可能同时存在多个有效证书，本库提供了一个 `CertificateManager` 类型可用于管理证书信息。

你可以在构造得到 `WechatApiClient` 对象时指定证书管理器：

```csharp
var certManager = new InMemoryCertificateManager(); // 为便于后续使用，该对象可使用全局单例的方式声明
var options = new WechatTenpayClientOptions() { CertificateManager = certManager };
var client = new WechatTenpayClient(options);
```

> 注：`InMemoryCertificateManager` 是本库内置的基于内存实现的证书管理器；你也可自行继承并实现一个 `CertificateManager`，例如利用数据库或 Redis 等方式存取证书信息。

你应在后台周期性地调用 `QueryCertificatesAsync()` 方法，并在解密得到证书内容后，记录到证书管理器中：

```csharp
/* 注意：QueryCertificatesAsync() 接口返回值需解密后再存入 */
/* 强调：存入的证书式请参考上一小节给出的 CER 证书文件示例 */
certManager.SetCertificate("CER 证书序列号", "CER 证书内容");
```

当然，现在的平台证书离过期还有很久，你也可以选择“偷懒”：提前下载好平台证书，在程序启动时记录一次即可。

每个响应对象会包含一个名为 `WechatpayCertSerialNumber` 的公共字段，本库会根据该字段的值自动尝试在证书管理器中读取证书内容，并完成响应签名的验证：

```csharp
bool ret = client.VerifyResponseSignature(response);
```
