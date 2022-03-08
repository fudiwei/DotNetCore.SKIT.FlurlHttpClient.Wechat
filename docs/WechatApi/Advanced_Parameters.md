## 如何生成 JS-SDK 初始化时所需的参数及签名？

---

> 请先自行阅读：
>
> [《微信官方文档 - 微信网页开发：JS-SDK 说明文档》](https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/JS-SDK.html)

你可根据官方文档的规则利用本库提供的 `SHA1Utility` 工具类自行进行签名生成。

此外，本库还封装了直接生成参数及签名的扩展方法，下面给出一个示例代码：

```csharp
/* 以生成 wx.config() 所需参数为例 */
var request = new Models.CgibinTicketGetTicketRequest()
{
    AccessToken = "微信 AccessToken"
};
var response = await client.ExecuteCgibinTicketGetTicketAsync(request);
var paramMap = client.GenerateParametersForJSSDKConfig(response.Ticket, "https://example.com");
```

注意上述示例代码中的 JsapiTicket 与微信 AccessToken 类似，有每日获取频率限制和过期时间限制，开发者应自行实现相关持久化和更新机制。

---

### 【附】生成参数相关扩展方法速查表：

-   生成公众号 JS-SDK `wx.config` 所需的参数字典：`GenerateParametersForJSSDKConfig`

-   生成公众号 JS-SDK `wx.chooseInvoice` 所需的参数字典：`GenerateParametersForJSSDKChooseInvoice`

-   生成公众号网页授权 URL：`GenerateParameterizedUrlForConnectOAuth2Authorize`

-   生成代公众号网页授权 URL：`GenerateParameterizedUrlForComponentConnectOAuth2Authorize`
