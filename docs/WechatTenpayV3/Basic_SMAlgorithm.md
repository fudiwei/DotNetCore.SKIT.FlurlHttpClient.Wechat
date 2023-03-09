## 如何接入国密算法？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 国密接入指引》](https://pay.weixin.qq.com/docs/merchant/development/shangmi/introduction.html)

自 v2.14.0 版本起，本库支持接入微信支付平台基于国密证书和使用 SM2/SM3/SM4 算法的 API v3 接口。

---

### 接入指引

在微信商户平台开通国密接入权限后，你需要在原有的项目代码基础上做出如下两点调整。

首先，构造得到 `WechatTenpayClient` 对象的方式与原有方式基本一致，只需将 `MerchantCertificateSerialNumber`、`MerchantCertificatePrivateKey` 替换为相应的国密证书内容即可，并指定签名认证方式：

```csharp
var options = new WechatTenpayClientOptions()
{
    // 其他配置项略
    SignScheme = Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3
};
var client = new WechatTenpayClient(options);
```

接着，在获取平台证书时，需指定证书的算法类型：

```csharp
var request = new QueryCertificatesRequest()
{
    AlgorithmType = "SM2"
};
var response = await client.ExecuteQueryCertificatesAsync(request);
```

与此同时，在存入平台证书管理器 `PlatformCertificateManager` 时，同样需指定证书的算法类型：

```csharp
// 如果是 RSA 证书
manager.AddEntry(new CertificateEntry("RSA", "RSA 证书序列号", "RSA 证书内容", "RSA 证书生效时间", "RSA 证书过期时间"));
// 如果是 SM2 证书
manager.AddEntry(new CertificateEntry("SM2", "SM2 证书序列号", "SM2 证书内容", "SM2 证书生效时间", "SM2 证书过期时间"));
```

这样，就已经完成了接入国密算法的全部流程。请求自动签名、响应验证签名、加解密敏感数据字段、解析回调通知事件模型等相关的扩展方法调用方式与原有方式完全一致。
