## 与 `IHttpClientFactory` 集成

---

本功能来自于公共组件，请参阅公共组件下的相关文档：

> [《SKIT.FlurlHttpClient 最佳实践：与 `IHttpClientFactory` 集成》](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/blob/main/docs/README.md)

---

### 微信证书

需要注意的是，由于部分微信支付接口需要显式地在构造 `System.Net.Http.HttpMessageHandler` 时指定双向认证的 SSL 证书，按照上文提供的方式与 `IHttpClientFactory` 集成时，也就必须重写此部分逻辑。

本库已封装实现了双向证书的 `WechatpayHttpHandler` 类型，它继承自 `HttpMessageHandler`，你可以直接使用它。

你可以阅读 [Microsoft Docs 的有关章节](https://learn.microsoft.com/zh-cn/dotnet/core/extensions/httpclient-factory#configure-the-httpmessagehandler)来了解如何在使用 `IHttpClientFactory` 时配置 `HttpMessageHandler`。

---

### 镜像站点

国内用户如访问 GitHub 网络状况不佳，可在打开上述链接后，手动将域名部分的 **github.com** 替换为 **gitee.com**、剩余路径部分保持不变，即可访问。
