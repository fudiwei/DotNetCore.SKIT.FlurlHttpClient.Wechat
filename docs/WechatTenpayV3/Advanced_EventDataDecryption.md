### 如何解密回调通知事件中的敏感数据？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 开发指南：证书和回调报文解密》](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_2.shtml)

对于回调通知事件的敏感信息，微信支付平台使用了商户公钥基于 RSA 算法加密。

开发者利用本库提供的 `RSAUtility` 工具类自行解密相关字段。

此外，本库还封装了直接解密事件的扩展方法，下面给出一个示例：

```csharp
string callbackJson = "{ ... }"; // 微信支付平台发来的通知内容

var callbackModel = client.DeserializeEvent(callbackJson); // 得到通知对象
if ("TRANSACTION.SUCCESS".Equals(callbackModel.EventType))
{
    var callbackResource = client.DecryptEventResource<Events.TransactionResource>(callbackModel); // 得到支付通知敏感数据
    string outTradeNumber = callbackResource.OutTradeNumber;
    string transactionId = callbackResource.TransactionId;
}
```

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.TenpayV3/Events_ 目录。
