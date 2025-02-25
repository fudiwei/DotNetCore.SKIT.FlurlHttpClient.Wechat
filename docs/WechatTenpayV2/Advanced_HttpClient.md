## 配置 HttpClient

---

本功能来自于公共组件，请参阅公共组件下的相关文档：

> [《SKIT.FlurlHttpClient 高级用法：配置 HttpClient》](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/blob/main/docs/README.md)

---

### 微信证书

需要注意的是，由于部分微信支付接口需要显式地在构造 `System.Net.Http.HttpMessageHandler` 时指定双向认证的 SSL 证书，按照上文提供的方式自定义 `System.Net.Http.HttpClient` 时，也就必须重写此部分逻辑。

本库已封装实现了双向证书的 `WechatpayHttpHandler` 类型，它继承自 `HttpMessageHandler`，你可以直接使用它：

```csharp
using SKIT.FlurlHttpClient.Wechat.TenpayV2.Settings;

var httpClientHandler = new WechatpayHttpHandler(options.MerchantCertificateBytes, options.MerchantCertificatePassword);
var httpClient = new HttpClient(httpClientHandler);

builder.UseHttpClient(httpClient);
```

---

### 镜像站点

国内用户如访问 GitHub 网络状况不佳，可在打开上述链接后，手动将浏览器地址栏中的域名部分 **github.com** 替换为 **gitee.com**、剩余路径部分保持不变即可。
