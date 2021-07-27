## 如何解密响应中的敏感数据？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 证书/密钥/签名介绍：API v3 密钥》](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay3_2.shtml)
>
> [《微信支付开发者文档 - 开发指南：敏感信息加解密》](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml)

对于部分接口返回的敏感信息，微信商户平台可能会使用两种方式进行加密：

-   使用商户公钥基于 RSA 算法加密。

-   使用商户 API v3 密钥基于 AEAD-AES-GCM 算法加密。

开发者利用本库提供的 `RSAUtility`、`AESUtility` 工具类自行解密相关字段。

此外，本库还封装了直接解密响应的扩展方法，下面给出一个示例：

```csharp
var request = new Models.QueryCertificatesRequest();
var response = await client.ExecuteQueryCertificatesAsync(request);

string cert = response.CertificateList.First().EncryptCertificate.CipherText; // 此时仍是密文
client.DecryptResponseEncryptedData(ref response);
string cert = response.CertificateList.First().EncryptCertificate.CipherText; // 此时已是明文
```
