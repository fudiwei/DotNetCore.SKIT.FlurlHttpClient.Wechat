## 如何加密请求中的敏感数据？

---

### 加密流程

对于部分接口请求传递的敏感信息，微企付可能会需要使用以下方式进行加密：

-   使用微企付公钥基于 RSAES-OAEP + SM4 算法加密。

开发者利用本库提供的 `RSAUtility`、`SM4Utility` 工具类自行加密相关字段。下面给出一个使用 `RSAUtility`、`SM4Utility` 工具类加密数据的示例代码：

```csharp
// 先通过微企付公钥基于 RSAES-OAEP 得到加密后的 SM4 密钥
string sm4IV = "SM4 偏移量";
string sm4Key = "SM4 密钥";
string sm4EncryptedKey = RSAUtility.EncryptWithECB(tbepPublicKey, sm4Key);
// 再通过 SM4 得到敏感信息密文
string plainText = "待加密的数据";
string cipherText = SM4Utility.EncryptWithCBC(sm4Key, sm4IV, plainText);
// 最后在请求模型中指定加密参数
request.TBEPEncryption = new WechatTenpayBusinessRequestTBEPEncryption()
{
    Algorithm = Constants.EncryptionAlgorithms.RSA_OAEP_WITH_SM4_128_CBC,
    CertificateSerialNumber = tbepCertificateSerialNumber,
    EncryptedKey = sm4EncryptedKey,
    IV = sm4Key
};
```

此外，本库还封装了直接加密请求中敏感信息字段的扩展方法。下面给出一个手动调用的示例：

```csharp
var request = new CreateProductApplicationRequest()
{
    BusinessLicense = new CreateProductApplicationRequest.Types.BusinessLicense()
    {
        BusinessRegisterType = "TYPE",
        MerchantName = "商户",
        LegalPersonName = "法人姓名明文"
    }
};

Console.WriteLine("before: {0}", request.BusinessLicense.Name); // 此时仍是明文
client.EncryptRequestSensitiveProperty(request);
Console.WriteLine("after: {0}", request.BusinessLicense.Name); // 此时已是密文

var response = await client.ExecuteCreateProductApplicationAsync(request);
```

如果你希望本库在请求前能自动完成这项操作，你可以在构造得到 `WechatTenpayBusinessClient` 对象时指定自动化参数：

```csharp
var options = new WechatTenpayBusinessOptions()
{
    // 其他配置项略
    AutoEncryptRequestSensitiveProperty = true,
    SensitivePropertyEncryptionSM4Key = "SM4 密钥",
    SensitivePropertyEncryptionSM4IV = "SM4 偏移量"
};
var client = new WechatTenpayBusinessClient(options);
```

这样，本库会在实际发出请求前自动为你调用 `EncryptRequestSensitiveProperty()` 方法。

此外，该扩展方法使用反射、并依赖 `WechatTenpayBusinessSensitiveAttribute`、`WechatTenpayBusinessSensitivePropertyAttribute` 特性，相比较手动加密，可能会存在一定的性能开销。
