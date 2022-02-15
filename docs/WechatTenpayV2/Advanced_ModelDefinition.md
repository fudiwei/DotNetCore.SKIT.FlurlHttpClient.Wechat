﻿## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，发起退款的请求是 `CreatePayRefundRequest`，响应是 `CreatePayRefundResponse`，接口是 `ExecuteCreatePayRefundAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的发起退款，它的接口地址是 `[POST] /secapi/pay/refund`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

另外，以 `Query` 开头的一般表示列表查询；以 `Get` 开头的一般表示获取详情；以 `Create` 开头的一般表示发起或新建操作。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.TenpayV2/Models_ 目录。

---

### 微信支付 API 支持情况：

<details>

<summary>[展开查看]</summary>

|     |               微信 API                |             商户类型             |         备注         |
| :-: | :-----------------------------------: | :------------------------------: | :------------------: |
|  √  |         支付产品：付款码支付          |      普通商户 & 境内服务商       |                      |
|  √  |         支付产品：JSAPI 支付          |      普通商户 & 境内服务商       |                      |
|  √  |         支付产品：Native 支付         |      普通商户 & 境内服务商       |                      |
|  √  |          支付产品：APP 支付           |      普通商户 & 境内服务商       |                      |
|  √  |           支付产品：H5 支付           |      普通商户 & 境内服务商       |                      |
|  √  |         支付产品：小程序支付          |      普通商户 & 境内服务商       |                      |
|  ×  |     <del>支付产品：刷脸支付</del>     | <del>普通商户 & 境内服务商</del> | 异构协议，需独立模块 |
|  ×  | <del>支付工具：代金券或立减优惠</del> | <del>普通商户 & 境内服务商</del> |   请升级至 v3 API    |
|  √  |          支付工具：现金红包           |      普通商户 & 境内服务商       |                      |
|  √  |         支付工具：小程序红包          |      普通商户 & 境内服务商       |                      |
|  √  |         支付工具：付款到零钱          |             普通商户             |                      |
|  √  |        支付工具：付款到银行卡         |             普通商户             |                      |
|  ×  |       <del>支付工具：分账</del>       |   普通商户 & 境内服务商</del>    |   请升级至 v3 API    |
|  √  |   支付工具：扣款服务（原委托代扣）    |      普通商户 & 境内服务商       |                      |
|  √  |          支付工具：酒店押金           |            境内服务商            |                      |
|  √  |          支付工具：车主服务           |            境内服务商            |                      |
|  √  |               清关报关                |             普通商户             |                      |
|  ×  |        <del>特约商户进件</del>        |         境内服务商</del>         |   请升级至 v3 API    |
|  √  |             特约商户配置              |            银行服务商            |                      |
|  ×  |        <del>风控数据同步</del>        |         银行服务商</del>         |   请升级至 v3 API    |
|  ×  |      <del>事中风险服务接口</del>      |         银行服务商</del>         |   请升级至 v3 API    |

</details>

---

### 【附】普通商户模式 API 模型命名速查表：

注：树形结构与[微信支付开发文档](https://pay.weixin.qq.com/wiki/doc/api/index.html)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   支付工具

    -   付款码支付：

        -   付款码支付：`CreatePayMicroPay`

        -   查询订单：`GetPayOrder`

        -   撤销订单：`ReversePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

        -   付款码查询 OpenID：`ToolsAuthCodeToOpenId`

    -   JSAPI 支付：

        -   统一下单：`CreatePayUnifiedOrder`

        -   查询订单：`GetPayOrder`

        -   关闭订单：`ClosePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

    -   Native 支付：

        -   统一下单：`CreatePayUnifiedOrder`

        -   查询订单：`GetPayOrder`

        -   关闭订单：`ClosePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

        -   转换短链接：`ToolsShortUrl`

    -   APP 支付：

        -   统一下单：`CreatePayUnifiedOrder`

        -   查询订单：`GetPayOrder`

        -   关闭订单：`ClosePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

    -   H5 支付：

        -   统一下单：`CreatePayUnifiedOrder`

        -   查询订单：`GetPayOrder`

        -   关闭订单：`ClosePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

    -   小程序支付：

        -   统一下单：`CreatePayUnifiedOrder`

        -   查询订单：`GetPayOrder`

        -   关闭订单：`ClosePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

-   支付工具：

    -   现金红包：

        -   发放红包：`SendPayMarketingTransfersRedPack`

        -   发放裂变红包：`SendPayMarketingTransfersGroupRedPack`

        -   查询红包记录：`GetPayMarketingTransfersRedPackInfo`

    -   小程序红包：

        -   发放红包：`SendPayMarketingTransfersMiniProgramRedPack`

        -   查询红包记录：`GetPayMarketingTransfersRedPackInfo`

    -   付款到零钱：

        -   付款：`CreatePayMarketingTransfersPromotionTransfer`

        -   查询付款：`GetPayMarketingTransfersTransferInfo`

    -   付款到银行卡：

        -   付款到银行卡：`CreatePayServicePartnerTransfersPayToBank`

        -   查询付款银行卡：`GetPayServicePartnerTransfersPayToBankInfo`

        -   获取 RSA 加密公钥：`GetRiskPublicKey`

    -   扣款服务：

        -   APP 纯签约：`CreatePAPPayPreEntrustWeb`

        -   H5 纯签约：`CreatePAPPayH5EntrustWeb`

        -   支付中签约：`CreateContractOrder`

        -   申请扣款：`ApplyPAPPay`

        -   申请解约：`DeletePAPPayContract`

        -   查询订单：`GetPayOrder`

        -   查询签约关系：`GetPAPPayContract`

-   清关报关：

    -   订单附加信息提交接口：`CreateMerchantCustomsCustomDeclaration`

    -   订单附加信息查询接口：`QueryMerchantCustomsCustomDeclaration`

    -   订单附加信息重推接口：`RedeclareMerchantCustomsCustomDeclaration`

</details>

---

### 【附】境内服务商模式 API 模型命名速查表：

注：树形结构与[微信支付开发文档](https://pay.weixin.qq.com/wiki/doc/api/sl.html)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   支付工具

    -   付款码支付：

        -   付款码支付：`CreatePayMicroPay`

        -   查询订单：`GetPayOrder`

        -   撤销订单：`ReversePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

        -   付款码查询 OpenID：`ToolsAuthCodeToOpenId`

    -   JSAPI 支付：

        -   统一下单：`CreatePayUnifiedOrder`

        -   查询订单：`GetPayOrder`

        -   关闭订单：`ClosePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

    -   Native 支付：

        -   统一下单：`CreatePayUnifiedOrder`

        -   查询订单：`GetPayOrder`

        -   关闭订单：`ClosePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

        -   转换短链接：`ToolsShortUrl`

    -   APP 支付：

        -   统一下单：`CreatePayUnifiedOrder`

        -   查询订单：`GetPayOrder`

        -   关闭订单：`ClosePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

    -   H5 支付：

        -   统一下单：`CreatePayUnifiedOrder`

        -   查询订单：`GetPayOrder`

        -   关闭订单：`ClosePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

    -   小程序支付：

        -   统一下单：`CreatePayUnifiedOrder`

        -   查询订单：`GetPayOrder`

        -   关闭订单：`ClosePayOrder`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   下载交易账单：`DownloadPayBill`

        -   下载资金账单：`DownloadPayFundFlow`

        -   交易保障：`SubmitPayITILReport`

    -   扣款服务：

        -   APP 纯签约：`CreatePAPPayPartnerPreEntrustWeb`

        -   H5 纯签约：`CreatePAPPayPartnerH5EntrustWeb`

        -   申请扣款：`ApplyPAPPayPartner`

        -   申请解约：`DeletePAPPayContract`

        -   查询订单：`GetPayOrder`

        -   查询签约关系：`GetPAPPayPartnerContract`

    -   酒店押金：

        -   支付押金（JSAPI / APP）：`CreateDepositUnifiedOrder`

        -   支付押金（人脸）：`CreateDepositFacePay`

        -   支付押金（付款码）：`CreateDepositMicroPay`

        -   查询订单：`GetDepositOrder`

        -   撤销订单：`ReverseDepositOrder`

        -   消费押金：`ConsumeDeposit`

        -   申请退款：`CreateDepositRefund`

        -   查询退款：`GetDepositRefund`

    -   车主平台：

        -   用户入场通知：`NotifyVehiclePartnerPay`

        -   申请扣款：`ApplyVehiclePartnerPay`

        -   下载交易账单：`DownloadPayBill`

        -   申请退款：`CreatePayRefund`

        -   查询退款：`GetPayRefund`

        -   用户状态查询：`GetVehiclePartnerPayState`

-   支付工具：

    -   现金红包：

        -   发放红包：`SendPayMarketingTransfersRedPack`

        -   发放裂变红包：`SendPayMarketingTransfersGroupRedPack`

        -   查询红包记录：`GetPayMarketingTransfersRedPackInfo`

    -   小程序红包：

        -   发放红包：`SendPayMarketingTransfersMiniProgramRedPack`

        -   查询红包记录：`GetPayMarketingTransfersRedPackInfo`

</details>

---

### 【附】银行服务商模式 API 模型命名速查表：

注：树形结构与[微信支付开发文档](https://pay.weixin.qq.com/wiki/doc/api/bank.html)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   特约商户配置：

    -   支付目录配置：`AddSubMerchantDevelopConfig`

    -   绑定 AppID 配置：`AddSubMerchantDevelopConfig`

    -   配置查询：`GetSubMerchantDevelopConfig`

-   风控数据同步：

    -   违规记录查询：`QueryRiskViolation`

</details>
