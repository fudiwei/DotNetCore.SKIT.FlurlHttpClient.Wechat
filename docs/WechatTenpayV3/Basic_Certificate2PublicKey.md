## 如何从平台证书切换成公钥？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 安全工具 - 如何从平台证书切换成微信支付公钥？》](https://pay.weixin.qq.com/doc/v3/merchant/4012154180)

---

### 基于平台公钥的 API 认证方式

自 v3.9.0 版本起，本库支持接入微信支付平台基于微信支付公钥的验证身份方式。

你只需要在原有的构造得到 `WechatTenpayClient` 对象的项目代码上做出调整，设置平台认证方案为“使用平台公钥认证”，并使用 `PlatformPublicKeyManager` 属性替代 `PlatformCertificateManager` 属性：

```csharp
var manager = new Settings.InMemoryPublicKeyManager();
manager.AddEntry(new PublicKeyEntry("公钥算法，目前仅支持 RSA 这一种类型", "公钥序列号（即 PubKeyID）", "PKCS#8 公钥内容"));

var options = new WechatTenpayClientOptions()
{
    // 其他配置项略
    PlatformAuthScheme = Settings.PlatformAuthScheme.PublicKey,
    PlatformPublicKeyManager = manager
};
var client = WechatTenpayClientBuilder.Create(options).Build();
```

后续加密或验签流程与原有方式完全一致。

> 延伸阅读：
> - [如何加密请求中的敏感数据？](./Basic_RequestSensitiveDataEncryption.md)
> - [如何验证响应签名？](./Basic_ResponseSignatureVerification.md)
> - [如何验证回调通知事件签名？](./Basic_EventSignatureVerification.md)

---

### 平滑切换灰度兼容处理

在平滑切换灰度过程中，你需要同时兼容平台证书与平台公钥：

- 发送请求前，需要指定请求的 `WechatpaySerialNumber` 字段（即使该请求不包含敏感数据字段）。该操作会影响灰度进度中的“应答使用公钥比例”；
- 验证签名时，需要根据响应或回调中的 `Wechatpay-Serial` 标头来判断是使用平台证书还是平台公钥。该操作受灰度进度中的“回调使用公钥比例”影响。

本库提供了简化处理方式，你只需要在构造得到 `WechatTenpayClient` 对象时：

```csharp
var options = new WechatTenpayClientOptions()
{
    // 其他配置项略
    PlatformAuthFallbackSwitch = true,
    PlatformAuthScheme = Settings.PlatformAuthScheme.PublicKey,
    PlatformCertificateManager = <your-manager>, // 需要同时设置 `CertificateManager` 并存入至少一个平台证书
    PlatformPublicKeyManager = <your-manager>,   // 需要同时设置 `PublicKeyManager` 并存入至少一个平台公钥
};
var client = WechatTenpayClientBuilder.Create(options).Build();
```

这样一来，你无需在业务代码中增加额外的判断逻辑，本库会自动处理前面提到的兼容流程。

但需要注意的是，开启此特性后会带来一定的性能损失，因此建议仅在灰度切换期间时开启，待切换进度为百分之百后请关闭。
