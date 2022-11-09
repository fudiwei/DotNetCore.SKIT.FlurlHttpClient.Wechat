## 如何解密响应中的敏感数据？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 证书/密钥/签名介绍：API v3 密钥》](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay3_2.shtml)
>
> [《微信支付开发者文档 - 开发指南：敏感信息加解密》](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml)

---

### 解密流程

对于部分接口响应返回的敏感信息，微信商户平台可能会需要使用以下方式进行解密：

-   使用商户私钥基于 RSA 算法解密。

-   使用商户 API v3 密钥基于 AES-GCM 算法解密。

开发者利用本库提供的 `RSAUtility`、`AESUtility` 工具类自行解密相关字段。下面给出一个使用 `RSAUtility` 工具类解密数据的示例代码：

```csharp
string cipherText = "待解密的数据";
string privateKey = "PKCS#8 私钥内容";
/* 通过私钥解密数据 */
string plainText = RSAUtility.DecryptWithECB(privateKey, cipherText);
```

此外，本库还封装了直接解密响应中敏感信息字段的扩展方法，下面给出一个示例代码：

```csharp
var request = new Models.QueryCertificatesRequest();
var response = await client.ExecuteQueryCertificatesAsync(request);

Console.WriteLine("before: {0}", response.CertificateList.First().EncryptCertificate.CipherText); // 此时仍是密文
client.DecryptResponseSensitiveProperty(response);
Console.WriteLine("after: {0}", response.CertificateList.First().EncryptCertificate.CipherText); // 此时已是明文
```

如果你希望本库在响应后能自动完成这项操作，你可以在构造得到 `WechatTenpayClient` 对象时指定自动化参数：

```csharp
var options = new WechatTenpayClientOptions()
{
    AutoDecryptResponseSensitiveProperty = true
};
var client = new WechatTenpayClient(options);
```

这样，本库会在实际收到响应后自动为你调用 `DecryptResponseSensitiveProperty()` 方法。

此外，该扩展方法使用反射、并依赖 `WechatTenpaySensitiveAttribute`、`WechatTenpaySensitivePropertyAttribute` 特性，相比较手动解密，可能会存在一定的性能开销。
