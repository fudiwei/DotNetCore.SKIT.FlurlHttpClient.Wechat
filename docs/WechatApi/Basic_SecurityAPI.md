## 如何接入安全鉴权模式？

---

> 请先自行阅读：
>
> [《微信官方文档 - 开发前必读：安全鉴权模式介绍》](https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/getting_started/signature-verify.html)

自 v3.2.0 版本起，本库支持接入微信安全鉴权模式。

---

### 接入指引

在微信公众平台或微信开放平台启用 API 加密及签名校验后，你需要在原有的项目代码基础上做出如下两点调整。

首先，构造得到 `WechatApiClient` 对象的方式与原有方式基本一致，只需额外指定与安全鉴权模式相关的参数：

```csharp
var options = new WechatApiClientOptions()
{
    // 其他配置项略
    SecurityApiEnabled = true,
    SecurityApiSymmetricAlgorithm = Constants.SecurityApiSymmetricAlgorithms.AES,
    SecurityApiSymmetricNumber = "AES/SM4 对称加密密钥编号",
    SecurityApiSymmetricKey = "AES/SM4 对称加密密钥",
    SecurityApiAsymmetricAlgorithm = Constants.SecurityApiAsymmetricAlgorithms.RSA,
    SecurityApiAsymmetricNumber = "RSA/SM2 非对称加密私钥编号",
    SecurityApiAsymmetricPrivateKey = "RSA/SM2 非对称加密私钥"
};
var client = WechatApiClientBuilder.Create(options).Build();
```

这样，就已经完成了接入安全鉴权模式的全部流程。相关 API 的调用方式与原有方式完全一致。

---

### 全部 API 加密及签名

默认情况下，启用安全鉴权模式后本库也只会对部分关键 API 自动加密及签名。

完整的关键 API 清单可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.Api/Interceptors/WechatApiSecurityApiInterceptor_ 文件的 `SIGN_REQUIRED_URLS` 的常量。

如果你需要开启全部 API 加密及签名，请在上文的基础上额外设置：

```csharp
var options = new WechatApiClientOptions()
{
    // 其他配置项略
    SecurityApiCustomRequestPathMatcher = (url) =>
    {
        if (url == "/sns/auth")
            return true;
        else if (url == "/sns/userinfo")
            return true;

        return false;
    }
};
var client = WechatApiClientBuilder.Create(options).Build();
```
