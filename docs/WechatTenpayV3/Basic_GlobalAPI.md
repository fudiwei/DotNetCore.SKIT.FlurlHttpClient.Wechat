## 如何接入境外支付 API？

微信支付境外支付 API 的接入点、接口模型公共参数等配置项与基础 API 完全不同，需要使用独立的扩展客户端。

```csharp
using SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global;
using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

var manager = new InMemoryCertificateManager();
var options = new WechatTenpayGlobalClientOptions()
{
    MerchantId = "微信商户号",
    MerchantV3Secret = "微信商户 v3 API 密钥",
    MerchantCertificateSerialNumber = "微信商户证书序列号",
    MerchantCertificatePrivateKey = System.IO.File.ReadAllText("/微信商户证书私钥文件路径/apiclient_key.pem"),
    PlatformCertificateManager = manager
};
var client = WechatTenpayGlobalClientBuilder.Create(options).Build();
```

该扩展客户端在用法上基础客户端完全相同，只需引入相应的命名空间即可。

---

### 切换接入点

默认情况下，微信支付境外支付 API 客户端的接入点为 `https://apihk.mch.weixin.qq.com/v3/global`。

如果你要切换为 `https://api.mch.weixin.qq.com/hk/v3` 或其他入口点，可以在构造客户端时指定：

```csharp

var options = new WechatTenpayGlobalClientOptions()
{
    // 其他配置项略
    Endpoint = "https://api.mch.weixin.qq.com/hk/v3" // 注意结尾不要带 "/"
};
var client = WechatTenpayGlobalClientBuilder.Create(options).Build();
```
