## 如何使用拦截器？

---

拦截器在本库下的用法与在 [SKIT.FlurlHttpClient.Wechat.Api](../WechatApi/README.md) 模块下的用法类似，请参阅[相关文档](../WechatApi/Advanced_Interceptor.md)。

本库内置了一个用于请求时自动生成签名的拦截器。

你也可以自行实现一个响应拦截器，自动在响应时验证签名。