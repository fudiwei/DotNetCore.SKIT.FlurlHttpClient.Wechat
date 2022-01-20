﻿## 如何生成客户端调起支付时所需的参数及签名？

---

> 请先自行阅读：
>
> [《微信支付开发者文档 - 基础支付：JSAPI 调起支付 API》](https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_4.shtml)
>
> [《微信支付开发者文档 - 基础支付：APP 调起支付 API》](https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_4.shtml)
>
> [《微信支付开发者文档 - 基础支付：小程序调起支付 API》](https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_4.shtml)

你可根据官方文档的规则利用本库提供的 `RSAUtility` 工具类自行进行签名生成。

此外，本库还封装了直接生成参数及签名的扩展方法，下面给出一个示例代码：

```csharp
/* 以生成 JSAPI 调起支付所需参数为例 */
var request = new Models.CreatePayTransactionJsapiRequest()
{
    OutTradeNumber = "商户订单号",
    AppId = "公众号 AppId",
    Description = "描述",
    NotifyUrl = "回调地址",
    Amount = new Models.CreatePayTransactionJsapiRequest.Types.Amount()
    {
        Total = 0
    },
    Payer = new Models.CreatePayTransactionJsapiRequest.Types.Payer()
    {
        OpenId = "用户 OpenId"
    }
};
var response = await client.ExecuteQueryCertificatesAsync(request);
var paramMap = client.GenerateParametersForJsapiPayRequest(request.AppId, response.PrepayId);
```

---

### 【附】生成参数相关扩展方法速查表：

-   生成客户端 JSAPI / 小程序调起支付所需的参数字典：`GenerateParametersForJsapiPayRequest`

-   生成 APP 调起支付所需的参数字典：`GenerateParametersForAppPayRequest`
