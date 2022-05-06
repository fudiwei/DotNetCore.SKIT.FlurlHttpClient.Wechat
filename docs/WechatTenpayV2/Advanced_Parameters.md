## 如何生成客户端调起支付时所需的参数及签名？

---

> 请先自行阅读：
>
> [《微信支付开发文档 - JSAPI 支付：JSAPI 调起支付》](https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=7_7&index=6)
>
> [《微信支付开发文档 - APP 支付：调起支付接口》](https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_12&index=2)
>
> [《微信支付开发文档 - 小程序支付：小程序调起支付 API》](https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=7_7&index=5)

你可根据官方文档的规则利用本库提供的 `MD5Utility`、`HMACUtility` 工具类自行进行签名生成。

此外，本库还封装了直接生成参数及签名的扩展方法，下面给出一个示例代码：

```csharp
/* 以生成 JSAPI 调起支付所需参数为例 */
var request = new Models.CreatePayUnifiedOrderRequest()
{
    OutTradeNumber = "商户订单号",
    AppId = "公众号 AppId",
    Body = "描述",
    TotalFee = 0,
    OpenId = "用户 OpenId",
    TradeType = "JSAPI",
    SignType = "HMAC-SHA256"
};
var response = await client.ExecuteCreatePayUnifiedOrderAsync(request);
var paramMap = client.GenerateParametersForJsapiGetBrandPayRequest(request.AppId, response.PrepayId, request.SignType);
```

---

### 【附】生成参数相关扩展方法速查表：

-   生成客户端 JSAPI 调起支付所需的参数字典：`GenerateParametersForJsapiGetBrandPayRequest`

-   生成客户端 APP 调起支付所需的参数字典：`GenerateParametersForAppGetBrandPayRequest`

-   生成客户端小程序调起支付所需的参数字典：`GenerateParametersForMiniProgramRequestPayment`

-   生成客户端小程序调起领取红包所需的参数字典：`GenerateParametersForJsapiSendBusinessRedPack`

-   生成客户端公众号唤起微信委托代扣的 URL：`GenerateParameterizedUrlForMediaPlatformPAPPayEntrustWeb` / `GenerateParameterizedUrlForMediaPlatformPAPPayPartnerEntrustWeb`

-   生成客户端小程序唤起微信委托代扣页面所需的参数字典：`GenerateParametersForMiniProgramPAPPayEntrust` / `GenerateParametersForMiniProgramPAPPayPartnerEntrust`

-   生成客户端 APP 唤起开通车主服务页面所需的参数字典：`GenerateParametersForAppVehiclePAPPayPartnerAuth`

-   生成客户端小程序唤起开通车主服务页面所需的参数字典：`GenerateParametersForMiniProgramVehiclePAPPayPartnerAuth`

-   生成客户端 App 唤起免密支付升级无感支付页面所需的参数字典：`GenerateParametersForAppVehiclePAPPayPartnerNoSensePayment`

-   生成客户端小程序唤起免密支付升级无感支付页面所需的参数字典：`GenerateParametersForMiniProgramVehiclePAPPayPartnerNoSensePayment`
