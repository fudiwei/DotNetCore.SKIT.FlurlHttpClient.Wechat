## 如何解密回调通知事件中的敏感数据？

---

### 解密流程

对于回调通知事件的敏感信息，微信商户平台使用了商户密钥基于 AES 算法加密。

开发者可利用本库提供的 `AESUtility` 工具类自行解密相关字段。

此外，本库还封装了直接解密事件的扩展方法，下面给出一个示例代码：

```csharp
/* 微信商户平台发来的通知内容 */
string webhookXml = "<xml> ... </xml>";
/* 将 XML 反序列化得到通知对象 */
var webhookModel = client.DeserializeEvent(webhookXml);
/* 解密得到支付通知敏感数据（以退款结果通知为例） */
var webhookEventInfo = client.DecryptEventRequestInfo<Events.RefundEventRequestInfo>(webhookModel);
string outRefundNumber = webhookEventInfo.OutRefundNumber;
string refundId = webhookEventInfo.RefundId;
```

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.TenpayV2/Events_ 目录。
