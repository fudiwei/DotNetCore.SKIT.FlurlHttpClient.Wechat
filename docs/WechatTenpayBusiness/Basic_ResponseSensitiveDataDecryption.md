## 如何解密响应中的敏感数据？

---

### 解密流程

对于部分接口响应返回的敏感信息，腾讯微企付可能会需要使用以下方式进行解密：

-   使用平台私钥基于 RSAES-OAEP + SM4 算法解密。

开发者利用本库提供的 `RSAUtility`、`SM4Utility` 工具类自行解密相关字段。下面给出一个使用 `RSAUtility`、`SM4Utility` 工具类解密数据的示例代码：

```csharp
// 先通过平台私钥基于 RSAES-OAEP 得到解密后的 SM4 密钥
string sm4EncryptedKey = response.TBEPEncryption.EncryptedKey;
string sm4Key = RSAUtility.DecryptWithECB(platformPrivateKey, sm4EncryptedKey);
string sm4IV = response.TBEPEncryption.IV;
// 再通过 SM4 得到敏感信息明文
string cipherText = "待解密的数据";
string plainText = SM4Utility.DecryptWithCBC(sm4Key, sm4IV, cipherText);
```

此外，本库还封装了直接解密响应中敏感信息字段的扩展方法，下面给出一个示例代码：

```csharp
var request = new Models.GetMSEPayPaymentByPaymentIdRequest();
var response = await client.ExecuteGetMSEPayPaymentByPaymentIdAsync(request);

Console.WriteLine("before: {0}", response.Payee.EnterpriseName); // 此时仍是密文
client.DecryptResponseSensitiveProperty(response);
Console.WriteLine("after: {0}", response.Payee.EnterpriseName); // 此时已是明文
```

如果你希望本库在响应后能自动完成这项操作，你可以在构造得到 `WechatTenpayBusinessClient` 对象时指定自动化参数：

```csharp
var options = new WechatTenpayBusinessClientOptions()
{
    AutoDecryptResponseSensitiveProperty = true
};
var client = new WechatTenpayBusinessClient(options);
```

这样，本库会在实际收到响应后自动为你调用 `DecryptResponseSensitiveProperty()` 方法。

此外，该扩展方法使用反射、并依赖 `WechatTenpayBusinessSensitiveAttribute`、`WechatTenpayBusinessSensitivePropertyAttribute` 特性，相比较手动解密，可能会存在一定的性能开销。
