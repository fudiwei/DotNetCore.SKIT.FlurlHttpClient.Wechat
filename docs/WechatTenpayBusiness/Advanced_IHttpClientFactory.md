## 如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？

---

本功能来自于公共组件，请参阅公共组件下的相关文档：

> [《SKIT.FlurlHttpClient FAQ：如何在 ASP.NET Core 中与 IHttpClientFactory 集成？》](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/blob/main/docs/FAQ_IHttpClientFactory.md)

需要注意的是，由于部分微信支付接口需要显式地在构造 `System.Net.Http.HttpMessageHandler` 时指定双向认证的 SSL 证书，按照上文提供的方式自定义 `Flurl.Http.Configuration.DefaultHttpClientFactory` 时，也就必须重写此部分逻辑。

关于这点可以参考本库内置的一个类型，完整的代码请参阅项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.TenpayV2/Settings/HttpClientFactory_ 文件。

---

### 镜像站点

国内用户如访问 GitHub 网络状况不佳，可在打开上述链接后，手动将域名部分的 **github.com** 替换为 **gitee.com**、剩余路径部分保持不变，即可访问。
