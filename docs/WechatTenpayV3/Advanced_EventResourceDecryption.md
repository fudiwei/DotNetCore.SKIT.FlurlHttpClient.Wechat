## 如何解密回调通知事件中的敏感数据？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 开发指南：证书和回调报文解密》](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_2.shtml)

---

### 密钥文件格式说明：

需要注意的是，平台为商户提供的是 PEM 格式的密钥文件，需区分文件格式之间的不同。

有关密钥文件格式的更多介绍，请参阅本文档[《高级技巧 - 如何加密请求中的敏感数据？》](./Advanced_RequestSensitiveDataEncryption.md)的有关章节。

---



对于回调通知事件的敏感信息，微信商户平台使用了商户公钥基于 RSA 算法加密。

开发者可利用本库提供的 `RSAUtility` 工具类自行解密相关字段。

此外，本库还封装了直接解密事件的扩展方法，下面给出一个示例代码：

```csharp
/* 微信商户平台发来的通知内容 */
string callbackJson = "{ ... }";
/* 将 JSON 反序列化得到通知对象 */
/* 你也可以将 WechatTenpayEvent 类型直接绑定到 MVC 模型上，这样就不再需要手动反序列化 */
var callbackModel = client.DeserializeEvent(callbackJson);
if ("TRANSACTION.SUCCESS".Equals(callbackModel.EventType))
{
    /* 根据事件类型，解密得到支付通知敏感数据 */
    var callbackResource = client.DecryptEventResource<Events.TransactionResource>(callbackModel);
    string outTradeNumber = callbackResource.OutTradeNumber;
    string transactionId = callbackResource.TransactionId;
}
```

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.TenpayV3/Events_ 目录。
