## 如何生成 JS-SDK 初始化时所需的参数及签名？

---

> 请先自行阅读：
>
> [企业微信 API - 客户端 API：JS-SDK 使用权限签名算法》](https://open.work.weixin.qq.com/api/doc/90000/90136/90506)

你可根据官方文档的规则利用本库提供的 `SHA1Utility` 工具类自行进行签名生成。

此外，本库还封装了直接生成参数及签名的扩展方法，下面给出一个示例代码：

```csharp
/* 以生成 wx.config() 所需参数为例 */
var request = new Models.CgibinGetJsapiTicketRequest()
{
    AccessToken = "企业微信应用的 AccessToken"
};
var response = await client.ExecuteCgibinGetJsapiTicketAsync(request);
var paramMap = client.GenerateParametersForJssdkConfigRequest(response.Ticket, "https://example.com");
```

需要注意的是，企业微信 JS-SDK 存在两种初始化方式，生成签名时所需要的 Ticket 获取方式并不相同，请开发者根据需要自行选择。
