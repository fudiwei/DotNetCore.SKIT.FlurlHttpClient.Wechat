## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，发起退款的请求是 `CreateRefundDomesticRefundRequest`，响应是 `CreateRefundDomesticRefundResponse`，接口是 `ExecuteCreateRefundDomesticRefundAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的发起退款，它的接口地址是 `[POST] /refund/domestic/refunds`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

另外，以 `Query` 开头的一般表示列表查询；以 `Get` 开头的一般表示获取详情；以 `Create` 开头的一般表示发起或新建操作；以 `Update`、`Modify` 开头的一般表示修改操作；以 `Set` 开头的一般表示设置操作。

需注意部分接口在直连商户与服务商在两种接入模式下会显式区分为独立的接口模型，具体对照关系请参考附录。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.TenpayV3/Models_ 目录。

---

### 找不到所需要的接口或字段？

本库会定期随微信官方更新接口或模型，但也会偶有疏漏。如果你在使用中遇到了因接口或模型定义而产生的问题，欢迎提出 Issue。

在 Issue 被处理之前，你也可以选择自行扩展 API。详细方式请参阅本文档[《基础用法 - 如何扩展额外的 API？》](./Basic_Extensions.md)。

---

### 微信支付 API 支持情况：

<details>

<summary>[展开查看]</summary>

|     |             微信 API              |      商户类型       |       备注        |
| :-: | :-------------------------------: | :-----------------: | :---------------: |
|  √  |       支付产品：JSAPI 支付        | 直连商户 & 合作伙伴 |                   |
|  √  |        支付产品：APP 支付         | 直连商户 & 合作伙伴 |                   |
|  √  |         支付产品：H5 支付         | 直连商户 & 合作伙伴 |                   |
|  √  |       支付产品：Native 支付       | 直连商户 & 合作伙伴 |                   |
|  √  |       支付产品：小程序支付        | 直连商户 & 合作伙伴 |                   |
|  √  |       支付产品：付款码支付        | 直连商户 & 合作伙伴 |                   |
|  √  |        支付产品：合单支付         | 直连商户 & 合作伙伴 |                   |
|  √  |      支付产品：资金/交易账单      | 直连商户 & 合作伙伴 |                   |
|  √  |          支付产品：退款           | 直连商户 & 合作伙伴 |                   |
|  √  |       运营工具：转账到零钱        | 直连商户 & 合作伙伴 |                   |
|  ×  | <del>运营工具：转账到银行卡</del> | 直连商户 & 合作伙伴 | 官方未提供 v3 API |
|  √  |       经营能力：微信支付分        | 直连商户 & 合作伙伴 |                   |
|  √  |     经营能力：微信支付分停车      | 直连商户 & 合作伙伴 |                   |
|  √  |   经营能力：微信支付分签约计划    | 直连商户 & 合作伙伴 |                   |
|  √  |       经营能力：平台收付通        |      合作伙伴       |                   |
|  √  |       经营能力：平台保证金        |      合作伙伴       |                   |
|  √  |         运营工具：代金券          | 直连商户 & 合作伙伴 |                   |
|  √  |         运营工具：商家券          | 直连商户 & 合作伙伴 |                   |
|  √  |         运营工具：消费金          |      直连商户       |                   |
|  √  |        运营工具：委托营销         | 直连商户 & 合作伙伴 |                   |
|  √  |        运营工具：支付有礼         | 直连商户 & 合作伙伴 |                   |
|  √  |        运营工具：智慧商圈         | 直连商户 & 合作伙伴 |                   |
|  √  |       运营工具：支付即服务        | 直连商户 & 合作伙伴 |                   |
|  √  |        运营工具：电子发票         | 直连商户 & 合作伙伴 |                   |
|  √  |        运营工具：点金计划         |      合作伙伴       |                   |
|  ×  |   <del>运营工具：现金红包</del>   | 直连商户 & 合作伙伴 | 官方未提供 v3 API |
|  √  |        运营工具：品牌红包         |      直连商户       |                   |
|  √  |          扩展工具：分账           | 直连商户 & 合作伙伴 |                   |
|  √  |      扩展工具：连锁品牌分账       |      合作伙伴       |                   |
|  √  |     扩展工具：消费者投诉 2.0      | 直连商户 & 合作伙伴 |                   |
|  √  |        安全工具：平台证书         | 直连商户 & 合作伙伴 |                   |
|  √  |      商户管理：特约商户进件       |      合作伙伴       |                   |
|  √  |    商户管理：商户开户意愿确认     |      合作伙伴       |                   |
|  √  |    商户管理：商户平台处置通知     |      合作伙伴       |                   |
|  √  |   商户管理：不活跃商户身份核实    |      合作伙伴       |                   |
|  √  |           其他：消费卡            | 直连商户 & 合作伙伴 |                   |
|  √  |      其他：代扣服务切卡组件       | 直连商户 & 合作伙伴 |                   |
|  √  |    其他：图片上传（营销专用）     | 直连商户 & 合作伙伴 |                   |
|  √  |         其他：微信先享卡          |      直连商户       |                   |
|  √  |        其他：连锁品牌门店         |      合作伙伴       |                   |
|  √  |        其他：品牌小店营销         |      合作伙伴       |                   |
|  √  |     其他：租用充电宝隔夜归还      |      直连商户       |                   |
|  √  |          其他：ETC 扣费           |      合作伙伴       |                   |
|  √  |          其他：电子小票           |      合作伙伴       |                   |
|  √  |       其他：出租车电子发票        |      合作伙伴       |                   |
|  √  |         其他：教育续费通          | 直连商户 & 合作伙伴 |                   |
|  √  |         其他：校园轻松付          |      合作伙伴       |                   |
|  √  |        其他：微信点餐订单         |      合作伙伴       |                   |
|  √  |         其他：微信寄快递          |      合作伙伴       |                   |
|  √  |        其他：品牌小店营销         |      合作伙伴       |                   |
|  √  |        其他：银行定向促活         | 直连商户 & 合作伙伴 |                   |
|  √  |       其他：银行提现免费券        |      合作伙伴       |                   |
|  √  |         其他：银行周周惠          |      合作伙伴       |                   |
|  √  |           其他：微工卡            |      合作伙伴       |                   |
|  √  |        其他：优惠费率活动         |      合作伙伴       |                   |
|  √  |           其他：爱心餐            |      直连商户       |                   |
|  ×  |     <del>其他：清关报关</del>     |      直连商户       | 官方未提供 v3 API |
|  √  |       境外支付：子商户进件        |      合作伙伴       |                   |
|  √  |        境外支付：融合钱包         |      合作伙伴       |                   |
|  √  |        境外支付：委托代扣         | 直连商户 & 合作伙伴 |                   |
|  √  |          境外支付：报关           |      合作伙伴       |                   |

</details>

---

### 【附】商户（直连模式）API 模型命名速查表：

注：树形结构与[微信支付开发者文档](https://pay.weixin.qq.com/docs/merchant/development/interface-rules/introduction.html)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   支付产品

    -   JSAPI 支付

        -   JSAPI 下单：`CreatePayTransactionJsapi`

        -   查询订单：`GetPayTransactionById` / `GetPayTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayTransaction`

    -   APP 支付

        -   APP 下单：`CreatePayTransactionApp`

        -   查询订单：`GetPayTransactionById` / `GetPayTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayTransaction`

    -   H5 支付

        -   H5 下单：`CreatePayTransactionH5`

        -   查询订单：`GetPayTransactionById` / `GetPayTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayTransaction`

    -   Native 支付

        -   Native 下单：`CreatePayTransactionNative`

        -   查询订单：`GetPayTransactionById` / `GetPayTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayTransaction`

    -   小程序支付

        -   小程序下单：`CreatePayTransactionJsapi`

        -   查询订单：`GetPayTransactionById` / `GetPayTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayTransaction`

    -   付款码支付

        -   付款码支付：`CreatePayTransactionCodePay`

        -   撤销订单：`ReversePayTransaction`

    -   合单支付

        -   合单 APP 下单：`CreateCombineTransactionApp`

        -   合单 JSAPI 下单：`CreateCombineTransactionJsapi`

        -   合单 H5 下单：`CreateCombineTransactionH5`

        -   合单 Native 下单：`CreateCombineTransactionNative`

        -   合单小程序下单：`CreateCombineTransactionJsapi`

        -   合单查询订单：`GetCombineTransactionByCombineOutTradeNumber`

        -   合单关闭订单：`CloseCombineTransaction`

    -   资金/交易账单

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   退款

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   发起异常退款：`CreateRefundDomesticAbnormalRefundApply`

-   运营工具

    -   商家转账

        -   发起转账

            -   发起转账：`CreateFundAppMerchantTransferBill`

            -   撤销转账：`CancelFundAppMerchantTransferBill`

            -   商户单号查询转账单：`GetFundAppMerchantTransferBillByOutBillNumber`

            -   微信单号查询转账单：`GetFundAppMerchantTransferBillByTransferBillNumber`

        -   获取电子回单

            -   商户单号申请电子回单：`CreateFundAppMerchantTransferElecsignByOutBillNumber`

            -   商户单号查询电子回单：`GetFundAppMerchantTransferElecsignByOutBillNumber`

            -   微信单号申请电子回单：`CreateFundAppMerchantTransferElecsignByTransferBillNumber`

            -   微信单号查询电子回单：`GetFundAppMerchantTransferElecsignByTransferBillNumber`

    -   商家转账到 QQ 钱包

        -   发起转账到 QQ 钱包：`CreateFundAppMerchantTransferToQQWalletBill`

        -   撤销转账到 QQ 钱包：`CancelFundAppMerchantTransferToQQWalletBill`

        -   查询转账到 QQ 钱包的结果：`GetFundAppMerchantTransferToQQWalletBillByOutBillNumber`

    -   商家转账到零钱

        -   发起批量转账：`CreateTransferBatch`

        -   微信批次单号查询批次单：`GetTransferBatchByBatchId`

        -   微信明细单号查询明细单：`GetTransferBatchDetailByDetailId`

        -   商家批次单号查询批次单：`GetTransferBatchByOutBatchNumber`

        -   商家明细单号查询明细单：`GetTransferBatchDetailByOutDetailNumber`

        -   转账电子回单申请受理：`CreateTransferBillReceipt`

        -   查询转账电子回单：`GetTransferBillReceiptByOutBatchNumber`

        -   转账明细电子回单受理：`CreateTransferDetailElectronicReceipt`

        -   查询转账明细电子回单受理结果：`GetTransferDetailElectronicReceiptByOutDetailNumber`

        -   下载电子回单：`DownloadBillFile`

        -   查询账户实时余额：`GetMerchantFundBalance`

        -   查询账户日终余额：`GetMerchantFundDayendBalance`

    -   微信支付分

        -   服务订单

            -   创建支付分订单：`CreatePayScoreServiceOrder`

            -   查询支付分订单：`GetPayScoreServiceOrderByQueryId` / `GetPayScoreServiceOrderByOutOrderNumber`

            -   取消支付分订单：`CancelPayScoreServiceOrder`

            -   修改订单金额：`ModifyPayScoreServiceOrder`

            -   完结支付分订单：`SetPayScoreServiceOrderComplete`

            -   商户发起催收扣款：`SetPayScoreServiceOrderPay`

            -   同步服务订单信息：`SetPayScoreServiceOrderSync`

            -   申请退款：`CreateRefundDomesticRefund`

            -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

            -   下发服务费用待处理消息：`SendPayScoreServiceOrderPendingMessage`

            -   下发服务预扣费消息：`SendPayScoreServiceOrderPrepaidMessage`

        -   微信支付分（免确认模式）

            -   创单结单合并：`CreatePayScoreServiceOrderDirectComplete`

        -   微信支付分（免确认预授权模式）

            -   商户预授权：`ApplyPayScorePermissions`

            -   查询用户授权记录（授权协议号）：`GetPayScorePermissionsByAuthorizationCode`

            -   解除用户授权关系（授权协议号）：`TerminatePayScorePermissionsByAuthorizationCode`

            -   查询用户授权记录（OpenId）：`GetPayScorePermissionsByOpenId`

            -   解除用户授权关系（OpenId）：`TerminatePayScorePermissionsByOpenId`

        -   用户分层

            -   评估用户分层：`AssessPayScorePermissionsUserRiskLevel`

    -   微信支付分停车

        -   创建停车入场：`CreateVehicleParking`

        -   查询车牌服务开通信息：`GetVehicleParkingService`

        -   扣费受理：`CreateVehicleTransactionParking`

        -   查询订单：`GetVehicleTransactionByOutTradeNumber`

    -   微信支付分签约计划

        -   支付分计划操作

            -   创建支付分计划：`CreatePayScorePlan`

            -   查询支付分计划：`GetPayScorePlanByOutPlanNumber`

            -   停止支付分计划：`StopPayScorePlan`

        -   签约计划详情对应的服务订单

            -   创建用户的签约计划详情对应的服务订单：`CreatePayScoreSignPlanServiceOrder`

        -   管理签约计划

            -   创建用户的签约计划：`CreatePayScoreSignPlanUserSignPlan`

            -   查询用户的签约计划：`GetPayScoreSignPlanUserSignPlanByOutSignPlanNumber`

            -   停止用户的签约计划：`StopPayScoreSignPlanUserSignPlan`

    -   代金券

        -   创建代金券批次：`CreateMarketingFavorStock`

        -   激活代金券批次：`StartMarketingFavorStock`

        -   发放代金券批次：`SendMarketingFavorUserCoupon`

        -   暂停代金券批次：`PauseMarketingFavorStock`

        -   重启代金券批次：`RestartMarketingFavorStock`

        -   条件查询批次列表：`QueryMarketingFavorStocks`

        -   查询批次详情：`GetMarketingFavorStockByStockId`

        -   查询代金券详情：`GetMarketingFavorUserCouponByCouponId`

        -   查询代金券可用商户：`QueryMarketingFavorStockMerchants`

        -   查询代金券可用单品：`QueryMarketingFavorStockItems`

        -   根据商户号查用户的券：`QueryMarketingFavorUserCoupons`

        -   下载批次核销明细：`GetMarketingFavorStockUseFlow`

        -   下载批次退款明细：`GetMarketingFavorStockRefundFlow`

        -   设置消息通知地址：`UpdateMarketingFavorCallback`

        -   图片上传：`UploadMerchantMediaImage`

    -   商家券

        -   创建商家券：`CreateMarketingBusifavorStock`

        -   查询商家券详情：`GetMarketingBusifavorStockByStockId`

        -   核销用户券：`SetMarketingBusifavorCouponUsed`

        -   根据过滤条件查询用户券：`QueryMarketingBusifavorUserCoupons`

        -   查询用户单张券详情：`GetMarketingBusifavorUserCouponByCouponCode`

        -   上传预存 Code：`UploadMarketingBusifavorStockCouponCodes`

        -   设置商家券事件通知地址：`UpdateMarketingBusifavorCallback`

        -   查询商家券事件通知地址：`GetMarketingBusifavorCallback`

        -   关联订单信息：`AssociateMarketingBusifavorCoupon`

        -   取消关联订单信息：`DisassociateMarketingBusifavorCoupon`

        -   修改批次预算：`UpdateMarketingBusifavorStockBudget`

        -   修改商家券基本信息：`UpdateMarketingBusifavorStock`

        -   申请退券：`CreateMarketingBusifavorCouponReturn`

        -   使券失效：`DeactivateMarketingBusifavorCoupon`

        -   营销补差付款：`CreateMarketingBusifavorSubsidyPayReceipt`

        -   营销补差回退：`CreateMarketingBusifavorSubsidyReturnReceipt`

        -   查询营销补差付款单列表：`QueryMarketingBusifavorSubsidyPayReceipts`

        -   查询营销补差付款单详情：`GetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptId`

        -   图片上传：`UploadMerchantMediaImage`

    -   消费金

        -   下载批次退款明细：`GetMultiuseStockRefundFlow`

        -   下载批次发放明细：`GetMultiuseStockSendFlow`

        -   下载核销明细：`GetMultiuseStockUseFlow`

        -   发放指定批次的消费金：`SendMultiuseUserCoupon`

    -   委托营销

        -   建立合作关系：`BuildMarketingPartnership`

        -   终止合作关系：`TerminateMarketingPartnership`

        -   查询合作关系列表：`QueryMarketingPartnerships`

    -   支付有礼

        -   创建全场满额送活动：`CreateMarketingPayGiftActivityUniqueThresholdActivity`

        -   查询活动详情接口：`GetMarketingPayGiftActivityByActivityId`

        -   查询活动发券商户号：`QueryMarketingPayGiftActivityMerchants`

        -   查询活动指定商品列表：`QueryMarketingPayGiftActivityGoods`

        -   终止活动：`TerminateMarketingPayGiftActivity`

        -   新增活动发券商户号：`AddMarketingPayGiftActivityMerchant`

        -   获取支付有礼活动列表：`QueryMarketingPayGiftActivities`

        -   删除活动发券商户号：`DeleteMarketingPayGiftActivityMerchant`

        -   图片上传：`UploadMerchantMediaImage`

    -   智慧商圈

        -   商圈积分同步：`NotifyBusinessCirclePoints`

        -   商圈积分授权查询：`GetBusinessCircleUserAuthorizationByOpenId`

        -   商圈会员待积分状态查询：`GetBusinessCircleUserPointsCommitStatusByOpenId`

        -   商圈会员停车状态同步：`NotifyBusinessCircleParkings`

    -   支付即服务

        -   服务人员注册：`CreateSmartGuide`

        -   服务人员分配：`AssignSmartGuide`

        -   服务人员查询：`QuerySmartGuides`

        -   服务人员信息更新：`UpdateSmartGuide`

    -   电子发票

        -   公共 API

            -   创建电子发票卡券模板：`CreateNewTaxControlFapiaoCardTemplate`

            -   配置开发选项：`ModifyNewTaxControlFapiaoMerchantDevelopmentConfig`

            -   查询商户配置的开发选项：`GetNewTaxControlFapiaoMerchantDevelopmentConfig`

            -   查询电子发票：`GetNewTaxControlFapiaoApplicationByFapiaoApplyId`

            -   获取抬头填写链接：`GetNewTaxControlFapiaoUserTitleUrl`

            -   获取用户填写的抬头：`GetNewTaxControlFapiaoUserTitle`

        -   区块链电子发票 API

            -   获取商户开票基础信息：`GetNewTaxControlFapiaoMerchantBaseInformation`

            -   获取商品和服务税收分类对照表：`QueryNewTaxControlFapiaoMerchantTaxCodes`

            -   开具电子发票：`CreateNewTaxControlFapiaoApplication`

            -   冲红电子发票：`ReverseNewTaxControlFapiaoApplication`

            -   获取发票下载信息：`GetNewTaxControlFapiaoApplicationFiles`

            -   下载发票文件：`DownloadNewTaxControlFapiaoApplicationFile`

        -   电子发票商户信息

            -   上传电子发票文件：`UploadNewTaxControlFapiaoApplicationFapiaoFile`

            -   将电子发票插入微信用户卡包：`CreateNewTaxControlFapiaoApplicationCard`

    -   品牌红包

        -   品牌商户发放红包：`CreateFundAppBrandRedPacketBrandMerchantBatch`

        -   商家批次单号查询批次单：`GetFundAppBrandRedPacketBrandMerchantBatchByOutBatchNumber`

        -   商家明细单号查询明细单：`GetFundAppBrandRedPacketBrandMerchantBatchDetailByOutDetailNumber`

        -   微信支付批次单号查询批次单：`GetFundAppBrandRedPacketBrandMerchantBatchByBatchNumber`

        -   微信支付明细单号查询明细单：`GetFundAppBrandRedPacketBrandMerchantBatchDetailByDetailNumber`

    -   商家充值

        -   申请银行转账充值：`ApplyBankTransferRecharge`

        -   查询银行转账充值结果：`GetBankTransferRechargeByOutRechargeNumber`

-   扩展工具

    -   分账

        -   请求分账：`CreateProfitSharingOrder`

        -   查询分账结果：`GetProfitSharingOrderByOutOrderNu`

        -   请求分账回退：`CreateProfitSharingReturnOrder`

        -   查询分账回退结果：`GetProfitSharingReturnOrderByOutOrderNumber`

        -   解冻剩余资金：`SetProfitSharingOrderUnfrozen`

        -   查询剩余待分金额：`GetProfitSharingTransactionAmounts`

        -   添加分账接收方：`AddProfitSharingReceiver`

        -   删除分账接收方：`DeleteProfitSharingReceiver`

        -   申请分账账单：`GetProfitSharingBill`

        -   下载账单：`DownloadBillFile`

    -   消费者投诉 2.0

        -   主动查询投诉信息

            -   查询投诉单列表：`QueryMerchantServiceComplaints`

            -   查询投诉单详情：`GetMerchantServiceComplaintByComplaintId`

            -   查询投诉协商历史：`QueryMerchantServiceComplaintNegotiationHistories`

        -   实时获取投诉信息

            -   创建投诉通知回调地址：`CreateMerchantServiceComplaintNotification`

            -   查询投诉通知回调地址：`GetMerchantServiceComplaintNotification`

            -   更新投诉通知回调地址：`UpdateMerchantServiceComplaintNotification`

            -   删除投诉通知回调地址：`DeleteMerchantServiceComplaintNotification`

        -   商户处理用户投诉

            -   回复用户：`CreateMerchantServiceComplaintResponse`

            -   反馈处理完成：`SetMerchantServiceComplaintComplete`

        -   商户反馈图片

            -   图片上传接口：`UploadMerchantServiceImage`

            -   图片请求接口：`DownloadMerchantServiceImage`

-   安全工具

    -   平台证书

        -   获取平台证书列表：`QueryCertificates`

-   其他

    -   消费卡

        -   发放消费卡：`SendMarketingBusifavorCoupon`

    -   银行定向促活

        -   导入定向用户协议号：`UploadMarketingBankPackagesTasks`

    -   银行提现免费券

        -   为用户发银行提现免费券：`SendMarketingWithdrawFavorUserCoupon`

        -   查询批次下用户银行提现免费券列表：`QueryMarketingWithdrawFavorUserCoupons`

    -   银行周周惠

        -   报名周周惠活动：`ApplyMarketingWeeklyDiscountActivity`

        -   查询周周惠活动列表：`QueryApplyMarketingWeeklyDiscountActivities`

        -   查询周周惠活动详情：`GetApplyMarketingWeeklyDiscountActivityByActivityId`

    -   银行组件：

        -   获取对私银行卡号开户银行：`QueryCapitalBanksByBankAccount`

        -   查询支持个人业务的银行列表：`QueryCapitalBanksPersonalBanking`

        -   查询支持对公业务的银行列表：`QueryCapitalBanksCorporateBanking`

        -   查询省份列表：`QueryCapitalAreasProvinces`

        -   查询城市列表：`QueryCapitalAreasCities`

        -   查询支行列表：`QueryCapitalBanksBranches`

    -   微信先享卡

        -   预受理领卡请求：`PrepareDiscountCard`

        -   增加用户记录：`AddDiscountCardUserRecord`

        -   查询先享卡订单：`GetDiscountCardByOutCardCode`

    -   来账识别

        -   商户银行来账查询：`QueryMerchantFundMerchantIncomeRecords`

    -   扣款服务

        -   预扣费通知：`CreatePAPayContractNotification`

        -   重试扣费通知：`CreatePAPayContractFailedNotification`

    -   代扣服务切卡组件

        -   出行券切卡组件预下单：`CreateIndustryCouponToken`

    -   教育续费通：

        -   预签约：`PresignEducationPAPayContract`

        -   通过协议号查询签约：`GetEducationPAPayContractByContractId`

        -   通过用户标识查询签约：`QueryEducationPAPayUserContracts`

        -   解约：`TerminateEducationPAPayContract`

        -   发送扣款预通知：`SendEducationPAPayContractNotification`

        -   教育通扣款受理：`CreateEducationPAPayTransaction`

        -   微信订单号查单：`GetEducationPAPayTransactionById`

        -   商户订单号查单：`GetEducationPAPayTransactionByOutTradeNumber`

    -   租用充电宝隔夜归还

        -   保险订单

            -   创建保险订单：`CreateHirePowerBankInsuranceOrder`

            -   查询保险订单详情：`GetHirePowerBankInsuranceOrderByOutOrderNumber`

            -   查询用户保险订单领取资格：`GetHirePowerBankUserQualificationByOpenId`

    -   爱心餐

        -   查询爱心餐品牌信息：`GetLovefeastBrandByBrandId`

</details>

---

### 【附】合作伙伴（服务商、渠道商、机构、银行模式）API 模型命名速查表：

注：树形结构与[微信支付开发者文档](https://pay.weixin.qq.com/docs/partner/development/interface-rules/introduction.html)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   支付产品

    -   JSAPI 支付

        -   JSAPI 下单：`CreatePayPartnerTransactionJsapi`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

    -   APP 支付

        -   APP 下单：`CreatePayPartnerTransactionApp`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

    -   H5 支付

        -   H5 下单：`CreatePayPartnerTransactionH5`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

    -   Native 支付

        -   Native 下单：`CreatePayPartnerTransactionNative`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   申请单个子商户资金账单：`GetBillSubMerchantFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   小程序支付

        -   小程序下单：`CreatePayPartnerTransactionJsapi`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

    -   付款码支付

        -   付款码支付：`CreatePayPartnerTransactionCodePay`

        -   撤销订单：`ReversePayPartnerTransaction`

    -   合单支付

        -   合单 APP 下单：`CreateCombineTransactionApp`

        -   合单 JSAPI 下单：`CreateCombineTransactionJsapi`

        -   合单 H5 下单：`CreateCombineTransactionH5`

        -   合单 Native 下单：`CreateCombineTransactionNative`

        -   合单小程序下单：`CreateCombineTransactionJsapi`

        -   合单查询订单：`GetCombineTransactionByCombineOutTradeNumber`

        -   合单关闭订单：`CloseCombineTransaction`

    -   资金/交易账单

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

        -   申请单个子商户资金账单：`GetBillSubMerchantFundflowBill`

        -   申请二级商户资金账单：`GetEcommerceBillFundflowBill`

        -   下载单个子商户/二级商户资金账单：`DownloadBillFile`

    -   退款

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   发起异常退款：`CreateRefundDomesticAbnormalRefundApply`

-   运营工具

    -   转账到零钱

        -   发起批量转账：`CreatePartnerTransferBatch`

        -   微信批次单号查询批次单：`GetPartnerTransferBatchByBatchId`

        -   微信明细单号查询明细单：`GetPartnerTransferBatchDetailByDetailId`

        -   商家批次单号查询批次单：`GetPartnerTransferBatchByOutBatchNumber`

        -   商家明细单号查询明细单：`GetPartnerTransferBatchDetailByOutDetailNumber`

        -   转账电子回单申请受理：`CreateTransferBillReceipt`

        -   查询转账电子回单：`GetTransferBillReceiptByOutBatchNumber`

        -   转账明细电子回单受理：`CreateTransferDetailElectronicReceipt`

        -   查询转账明细电子回单受理结果：`GetTransferDetailElectronicReceiptByOutDetailNumber`

        -   下载电子回单：`DownloadBillFile`

        -   查询特约商户账户实时余额：`GetEcommerceFundBalance`

        -   查询账户实时余额：`GetMerchantFundBalance`

        -   查询账户日终余额：`GetMerchantFundDayendBalance`

    -   微信支付分

        -   服务订单

            -   创建支付分订单：`CreatePayScorePartnerServiceOrder`

            -   查询支付分订单：`GetPayScorePartnerServiceOrderByQueryId` / `GetPayScoreServiceOrderByOutOrderNumber`

            -   取消支付分订单：`CancelPayScorePartnerServiceOrder`

            -   修改订单金额：`ModifyPayPartnerScoreServiceOrder`

            -   完结支付分订单：`SetPayScorePartnerServiceOrderComplete`

            -   商户发起催收扣款：`SetPayScorePartnerServiceOrderPay`

            -   同步服务订单信息：`SetPayScorePartnerServiceOrderSync`

            -   商户申请获取对账单：`GetPayScoreMerchantBill`

            -   下发服务费用待处理消息：`SendPayScorePartnerServiceOrderPendingMessage`

            -   下发服务预扣费消息：`SendPayScorePartnerServiceOrderPrepaidMessage`

        -   微信支付分（免确认预授权模式）

            -   商户预授权：`ApplyPayScorePartnerPermissions`

            -   场景中预授权：`ApplyPayScorePartnerPermissionsForScene`

            -   查询用户授权记录（授权协议号）：`GetPayScorePartnerPermissionsByAuthorizationCode`

            -   解除用户授权关系（授权协议号）：`TerminatePayScorePartnerPermissionsByAuthorizationCode`

            -   查询用户授权记录（OpenId）：`GetPayScorePartnerPermissionsByOpenId`

            -   解除用户授权关系（OpenId）：`TerminatePayScorePartnerPermissionsByOpenId`

        -   用户分层

            -   服务商评估用户分层：`AssessPayScorePartnerPermissionsUserRiskLevel`

    -   微信支付分停车

        -   查询车牌服务开通信息：`GetVehicleParkingService`

        -   创建停车入场：`CreateVehicleParking`

        -   扣费受理：`CreateVehicleTransactionParking`

        -   查询订单：`GetVehicleTransactionByOutTradeNumber`

    -   微信支付分签约计划

        -   支付分计划操作

            -   创建支付分计划：`CreatePayScorePartnerPlan`

            -   查询支付分计划：`GetPayScorePartnerPlanByOutPlanNumber`

            -   停止支付分计划：`StopPayScorePartnerPlan`

        -   签约计划详情对应的服务订单

            -   创建用户的签约计划详情对应的服务订单：`CreatePayScorePartnerSignPlanServiceOrder`

        -   管理签约计划

            -   创建用户的签约计划：`CreatePayScorePartnerSignPlanUserSignPlan`

            -   查询用户的签约计划：`GetPayScorePartnerSignPlanUserSignPlanByOutSignPlanNumber`

            -   停止用户的签约计划：`StopPayScorePartnerSignPlanUserSignPlan`

    -   平台收付通（商户进件）

        -   二级商户进件：`CreateEcommerceApplyment`

        -   查询申请状态：`GetEcommerceApplymentByApplymentId` / `GetEcommerceApplymentByOutRequestNumber`

        -   下载平台证书：`QueryCertificates`

        -   修改结算帐号：`ModifyApplyForSubMerchantSettlement`

        -   查询结算账户：`GetApplyForSubMerchantSettlement`

        -   查询结算账户修改申请状态：`GetApplyForSubMerchantSettlementByApplicationNumber`

    -   平台收付通（普通支付）

        -   APP 下单：`CreatePayPartnerTransactionApp`

        -   JSAPI 下单：`CreatePayPartnerTransactionJsapi`

        -   小程序下单：`CreatePayPartnerTransactionJsapi`

        -   H5 下单：`CreatePayPartnerTransactionH5`

        -   Navive 下单：`CreatePayPartnerTransactionNavive`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

    -   平台收付通（合单支付）

        -   合单 APP 下单：`CreateCombineTransactionApp`

        -   合单 JSAPI 下单：`CreateCombineTransactionJsapi`

        -   合单 H5 下单：`CreateCombineTransactionH5`

        -   合单 Native 下单：`CreateCombineTransactionNative`

        -   合单小程序下单：`CreateCombineTransactionJsapi`

        -   合单查询订单：`GetCombineTransactionByCombineOutTradeNumber`

        -   合单关闭订单：`CloseCombineTransaction`

    -   平台收付通（合单代扣）

        -   APP 方式预签约：`PresignEcommerceCombinePAPayContractEntrustApp`

        -   查询协议：`GetEcommerceCombinePAPayContractByOutContractCode`

        -   解约协议：`TerminatEcommerceCombinePAPayContract`

        -   支付：`CreateEcommerceCombinePAPayTransaction`

        -   撤销订单：`ReverseEcommerceCombinePAPayTransaction`

        -   查询订单：`GetEcommerceCombinePAPayTransactionByCombineOutTradeNumber`

    -   平台收付通（分账）

        -   请求分账：`CreateEcommerceProfitSharingOrder`

        -   查询分账结果：`GetEcommerceProfitSharingOrderByOutOrderNumber`

        -   请求分账回退：`CreateEcommerceProfitSharingReturnOrder`

        -   查询分账回退结果：`GetEcommerceProfitSharingReturnOrderByOrderId` / `GetEcommerceProfitSharingReturnOrderByOutOrderNumber`

        -   完结分账：`SetEcommerceProfitSharingOrderFinish`

        -   查询订单剩余待分金额：`GetEcommerceProfitSharingOrderAmounts`

        -   添加分账接收方：`AddEcommerceProfitSharingReceiver`

        -   删除分账接收方：`DeleteEcommerceProfitSharingReceiver`

    -   平台收付通（补差）

        -   请求补差：`CreateEcommerceSubsidy`

        -   请求补差回退：`CreateEcommerceSubsidyReturn`

        -   取消补差：`CancelEcommerceSubsidy`

    -   平台收付通（退款）

        -   申请退款：`CreateEcommerceRefund`

        -   查询退款：`GetEcommerceRefundByRefundId` / `GetEcommerceRefundByOutRefundNumber`

        -   垫付退款回补：`CreateEcommerceRefundReturnAdvance`

        -   查询垫付回补结果：`GetEcommerceRefundReturnAdvance`

        -   发起异常退款：`CreateEcommerceAbnormalRefundApply`

    -   平台收付通（余额查询）

        -   查询二级商户账户实时余额：`GetEcommerceFundBalance`

        -   查询二级商户账户日终余额：`GetEcommerceFundDayendBalance`

        -   查询电商平台账户实时余额：`GetMerchantFundBalance`

        -   查询电商平台账户日终余额：`GetMerchantFundDayendBalance`

    -   平台收付通（商户提现）

        -   二级商户余额提现：`CreateEcommerceFundWithdraw`

        -   二级商户查询提现状态：`GetEcommerceFundWithdrawByWithdrawId` / `GetEcommerceFundWithdrawByOutRequestNumber`

        -   电商平台提现：`CreateMerchantFundWithdraw`

        -   电商平台查询提现状态：`GetMerchantFundWithdrawByWithdrawId` / `GetMerchantFundWithdrawByOutRequestNumber`

        -   按日下载提现异常文件：`GetMerchantFundWithdrawBill`

    -   平台收付通（注销申请）

        -   提交注销申请单：`CreateEcommerceAccountCancelApplication`

        -   查询注销单状态：`GetEcommerceAccountCancelApplicationByOutApplyNumber`

        -   图片上传：`UploadEcommerceAccountCancelApplicationMedia`

    -   平台收付通（注销后提现）

        -   商户提现申请单号查询提现申请单状态：`GetMerchantOperateRiskWithdrawlApplyByOutRequestNumber`

        -   微信支付提现申请单号查询提现申请单状态：`GetMerchantOperateRiskWithdrawlApplyByApplymentId`

        -   提交已注销商户号可用余额提现申请单：`CreateMerchantOperateRiskWithdrawlApply`

    -   平台收付通（跨境付款）

        -   查询订单剩余可出境余额：`GetFundsToOverseaTransactionAvailableAbroadAmountByTransactionId`

        -   申请资金出境：`CreateFundsToOverseaOrder`

        -   查询出境结果：`GetFundsToOverseaOrderByOutOrderId`

        -   获取购付汇账单文件下载链接：`GetFundsToOverseaBillDownloadUrl`

        -   申请资金出境退回：`CreateFundsToOverseaReturnOrder`

        -   查询出境退回结果：`GetFundsToOverseaReturnOrderByOutReturnNumber`

    -   平台收付通（下载账单）

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   获取分账账单文件下载地址：`GetProfitSharingBill`

        -   申请二级商户资金账单：`GetEcommerceBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   平台收付通（商家转账）

        -   批量商家转账

            -   受理商家转账：`ApplyPlatformSolutionInsuranceMerchantTransferBatch`

            -   微信支付转账批次单号查询批次单：`GetPlatformSolutionInsuranceMerchantTransferBatchByBatchId`

            -   微信支付转账明细单号查询明细单：`GetPlatformSolutionInsuranceMerchantTransferBatchDetailByDetailId`

            -   商户转账批次单号查询批次单：`GetPlatformSolutionInsuranceMerchantTransferBatchByOutBatchNumber`

            -   商户明细单号查询明细单：`GetPlatformSolutionInsuranceMerchantTransferBatchDetailByOutDetailNumber`

        -   预约商家转账

            -   受理单次预约商家转账：`ApplyPlatformSolutionInsuranceMerchantTransferReservation`

            -   商户预约单号查询预约商家转账记录：`GetPlatformSolutionInsuranceMerchantTransferReservationByOutReservationNumber`

            -   关闭预约商家转账记录：`ClosePlatformSolutionInsuranceMerchantTransferReservation`

            -   微信支付预约单号查询预约商家转账记录：`GetPlatformSolutionInsuranceMerchantTransferReservationByReservationId`

    -   平台收付通（商家充值）

            -   申请充值：`ApplyPlatformSolutionEcommerceRecharge`

            -   查询充值结果：`GetPlatformSolutionEcommerceRechargeByOutRechargeNumber`

            -   关闭充值：`ClosePlatformSolutionEcommerceRecharge`

            -   申请银行转账充值：`ApplyPlatformSolutionEcommerceBankTransferRecharge`

            -   查询银行转账充值结果：`GetPlatformSolutionEcommerceBankTransferRechargeByOutRechargeNumber`

            -   添加二级商户可扫码充值员工：`AddPlatformSolutionEcommerceRechargeEmployee`

            -   删除二级商户可扫码充值员工：`DeletePlatformSolutionEcommerceRechargeEmployee`

            -   查询二级商户可扫码充值员工列表：`QueryPlatformSolutionEcommerceRechargeEmployees`

    -   平台收付通（平台保险理赔）

            -   开通保险理赔功能：`ApplyPlatformSolutionEcommerceInsuranceCompensationContract`

            -   查询保险理赔功能开通状态：`GetPlatformSolutionEcommerceInsuranceCompensationContractBySubMerchantId`

            -   请求保险理赔：`CreatePlatformSolutionEcommerceMerchantTransferInsuranceClaimBill`

            -   请求保险理赔预下单：`CreatePlatformSolutionEcommerceMerchantTransferInsuranceClaimBillPreTransfer`

            -   请求撤销保险理赔：`CancelPlatformSolutionEcommerceMerchantTransferInsuranceClaimBill`

            -   查询保险理赔结果：`GetPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillByOutBillNumber` / `GetPlatformSolutionEcommerceMerchantTransferInsuranceClaimBillByBillId`

    -   平台收付通（平台售后赔付）

            -   请求赔付：`CreatePlatformSolutionEcommerceMerchantTransferCompensationBill`

            -   请求赔付预下单：`CreatePlatformSolutionEcommerceMerchantTransferCompensationBillPreTransfer`

            -   请求撤销赔付：`CancelPlatformSolutionEcommerceMerchantTransferCompensationBill`

            -   查询赔付结果：`GetPlatformSolutionEcommerceMerchantTransferCompensationBillByOutBillNumber` / `GetPlatformSolutionEcommerceMerchantTransferCompensationBillByBillId`

    -   代金券

        -   创建代金券批次：`CreateMarketingFavorStock`

        -   激活代金券批次：`StartMarketingFavorStock`

        -   发放代金券批次：`SendMarketingFavorUserCoupon`

        -   暂停代金券批次：`PauseMarketingFavorStock`

        -   重启代金券批次：`RestartMarketingFavorStock`

        -   条件查询批次列表：`QueryMarketingFavorStocks`

        -   查询批次详情：`GetMarketingFavorStockByStockId`

        -   查询代金券详情：`GetMarketingFavorUserCouponByCouponId`

        -   查询代金券可用商户：`QueryMarketingFavorStockMerchants`

        -   查询代金券可用单品：`QueryMarketingFavorStockItems`

        -   根据商户号查用户的券：`QueryMarketingFavorUserCoupons`

        -   下载批次核销明细：`GetMarketingFavorStockUseFlow`

        -   下载批次退款明细：`GetMarketingFavorStockRefundFlow`

        -   设置消息通知地址：`UpdateMarketingFavorCallback`

        -   图片上传：`UploadMarketingMediaImage`

    -   商家券

        -   创建商家券：`CreateMarketingBusifavorStock`

        -   查询商家券详情：`GetMarketingBusifavorStockByStockId`

        -   核销用户券：`SetMarketingBusifavorCouponUsed`

        -   根据过滤条件查询用户券：`QueryMarketingBusifavorUserCoupons`

        -   查询用户单张券详情：`GetMarketingBusifavorUserCouponByCouponCode`

        -   上传预存 Code：`UploadMarketingBusifavorStockCouponCodes`

        -   设置商家券事件通知地址：`UpdateMarketingBusifavorCallback`

        -   查询商家券事件通知地址：`GetMarketingBusifavorCallback`

        -   关联订单信息：`AssociateMarketingBusifavorCoupon`

        -   取消关联订单信息：`DisassociateMarketingBusifavorCoupon`

        -   修改批次预算：`UpdateMarketingBusifavorStockBudget`

        -   修改商家券基本信息：`UpdateMarketingBusifavorStock`

        -   申请退券：`CreateMarketingBusifavorCouponReturn`

        -   使券失效：`DeactivateMarketingBusifavorCoupon`

        -   营销补差付款：`CreateMarketingBusifavorSubsidyPayReceipt`

        -   营销补差回退：`CreateMarketingBusifavorSubsidyReturnReceipt`

        -   查询营销补差付款单列表：`QueryMarketingBusifavorSubsidyPayReceipts`

        -   查询营销补差付款单详情：`GetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptId`

        -   图片上传：`UploadMarketingMediaImage`

    -   委托营销

        -   建立合作关系：`BuildMarketingPartnership`

        -   终止合作关系：`TerminateMarketingPartnership`

        -   查询合作关系列表：`QueryMarketingPartnerships`

    -   支付有礼

        -   创建全场满额送活动：`CreateMarketingPayGiftActivityUniqueThresholdActivity`

        -   查询活动详情接口：`GetMarketingPayGiftActivityByActivityId`

        -   查询活动发券商户号：`QueryMarketingPayGiftActivityMerchants`

        -   查询活动指定商品列表：`QueryMarketingPayGiftActivityGoods`

        -   终止活动：`TerminateMarketingPayGiftActivity`

        -   新增活动发券商户号：`AddMarketingPayGiftActivityMerchant`

        -   获取支付有礼活动列表：`QueryMarketingPayGiftActivities`

        -   删除活动发券商户号：`DeleteMarketingPayGiftActivityMerchant`

        -   图片上传：`UploadMarketingMediaImage`

    -   智慧商圈

        -   商圈积分同步：`NotifyBusinessCirclePoints`

        -   商圈积分授权查询：`GetBusinessCircleUserAuthorizationByOpenId`

        -   商圈会员待积分状态查询：`GetBusinessCircleUserPointsCommitStatusByOpenId`

        -   商圈会员停车状态同步：`NotifyBusinessCircleParkings`

    -   支付即服务

        -   服务人员注册：`CreateSmartGuide`

        -   服务人员分配：`AssignSmartGuide`

        -   服务人员查询：`QuerySmartGuides`

        -   服务人员信息更新：`UpdateSmartGuide`

    -   电子发票

        -   电子发票卡券模板

            -   创建电子发票卡券模板：`CreateNewTaxControlFapiaoCardTemplate`

        -   电子发票

            -   开具电子发票：`CreateNewTaxControlFapiaoApplication`

            -   上传电子发票文件：`UploadNewTaxControlFapiaoApplicationFapiaoFile`

            -   查询电子发票：`GetNewTaxControlFapiaoApplicationByFapiaoApplyId`

            -   获取发票下载信息：`GetNewTaxControlFapiaoApplicationFiles`

            -   将电子发票插入微信用户卡包：`CreateNewTaxControlFapiaoApplicationCard`

            -   冲红电子发票：`ReverseNewTaxControlFapiaoApplication`

            -   下载发票文件：`DownloadNewTaxControlFapiaoApplicationFile`

        -   电子发票商户信息

            -   获取商户开票基础信息：`GetNewTaxControlFapiaoMerchantBaseInformation`

            -   查询商户配置的开发选项：`GetNewTaxControlFapiaoMerchantDevelopmentConfig`

            -   配置开发选项：`ModifyNewTaxControlFapiaoMerchantDevelopmentConfig`

            -   获取商品和服务税收分类对照表：`QueryNewTaxControlFapiaoMerchantTaxCodes`

            -   检查子商户开票功能状态：`CheckNewTaxControlFapiaoMerchant`

        -   用户抬头

            -   获取用户填写的抬头：`GetNewTaxControlFapiaoUserTitle`

            -   获取抬头填写链接：`GetNewTaxControlFapiaoUserTitleUrl`

    -   点金计划

        -   点金计划管理：`ChangeGoldPlanStatus`

        -   商家小票管理：`ChangeGoldPlanCustomPageStatus`

        -   同业过滤标签管理：`SetGoldPlanAdvertisingIndustryFilter`

        -   开通广告展示：`OpenGoldPlanAdvertisingShow`

        -   关闭广告展示：`CloseGoldPlanAdvertisingShow`

-   扩展工具

    -   分账

        -   请求分账：`CreateProfitSharingOrder`

        -   查询分账结果：`GetProfitSharingOrderByOutOrderNu`

        -   请求分账回退：`CreateProfitSharingReturnOrder`

        -   查询分账回退结果：`GetProfitSharingReturnOrderByOutOrderNumber`

        -   解冻剩余资金：`SetProfitSharingOrderUnfrozen`

        -   查询剩余待分金额：`GetProfitSharingTransactionAmounts`

        -   查询最大分账比例：`GetProfitSharingMerchantConfigs`

        -   添加分账接收方：`AddProfitSharingReceiver`

        -   删除分账接收方：`DeleteProfitSharingReceiver`

        -   申请分账账单：`GetProfitSharingBill`

        -   下载账单：`DownloadBillFile`

    -   连锁品牌分账

        -   请求分账：`CreateBrandProfitSharingOrder`

        -   查询分账结果：`GetBrandProfitSharingOrderByOutOrderNumber`

        -   请求分账回退：`CreateBrandProfitSharingReturnOrder`

        -   查询分账回退结果：`GetBrandProfitSharingReturnOrderByOrderId` / `GetBrandProfitSharingReturnOrderByOutOrderNumber`

        -   完结分账：`SetBrandProfitSharingOrderFinish`

        -   查询订单剩余待分金额：`GetBrandProfitSharingOrderAmounts`

        -   查询最大分账比例：`GetBrandProfitSharingBrandConfigs`

        -   添加分账接收方：`AddBrandProfitSharingReceiver`

        -   删除分账接收方：`DeleteBrandProfitSharingReceiver`

        -   申请分账账单：`GetProfitSharingBill`

        -   下载账单：`DownloadBillFile`

    -   消费者投诉 2.0

        -   主动查询投诉信息

            -   查询投诉单列表：`QueryMerchantServiceComplaints`

            -   查询投诉单详情：`GetMerchantServiceComplaintByComplaintId`

            -   查询投诉协商历史：`QueryMerchantServiceComplaintNegotiationHistories`

        -   实时获取投诉信息

            -   创建投诉通知回调地址：`CreateMerchantServiceComplaintNotification`

            -   查询投诉通知回调地址：`GetMerchantServiceComplaintNotification`

            -   更新投诉通知回调地址：`UpdateMerchantServiceComplaintNotification`

            -   删除投诉通知回调地址：`DeleteMerchantServiceComplaintNotification`

        -   商户处理用户投诉

            -   回复用户：`CreateMerchantServiceComplaintResponse`

            -   反馈处理完成：`SetMerchantServiceComplaintComplete`

        -   商户反馈图片

            -   图片上传接口：`UploadMerchantServiceImage`

            -   图片请求接口：`DownloadMerchantServiceImage`

-   安全工具

    -   平台证书

        -   获取平台证书列表：`QueryCertificates`

-   商户管理

    -   特约商户进件

        -   提交申请单：`CreateApplyForSubMerchantApplyment`

        -   查询申请单状态：`GetApplyForSubMerchantApplymentByApplymentId` / `GetApplyForSubMerchantApplymentByBusinessCode`

        -   修改结算帐号：`ModifyApplyForSubMerchantSettlement`

        -   查询结算账户：`GetApplyForSubMerchantSettlement`

        -   查询结算账户修改申请状态：`GetApplyForSubMerchantSettlementByApplicationNumber`

        -   图片上传：`UploadMerchantMediaImage`

        -   视频上传：`UploadMerchantMediaVideo`

    -   修改主体信息

        -   提交申请单：`CreateMerchantAlterApplyMerchantSubjectAlterApplyment`

        -   撤销申请单：`RevokeMerchantAlterApplyMerchantSubjectAlterApplyment`

        -   查询申请单状态：`GetMerchantAlterApplyMerchantSubjectAlterApplymentByApplymentId` / `GetMerchantAlterApplyMerchantSubjectAlterApplymentByOutRequestNumber`

    -   商户开户意愿确认

        -   提交申请单：`CreateApplyForSubjectApplyment`

        -   撤销申请单：`CancelApplyForSubjectApplymentByApplymentId` / `CancelApplyForSubjectApplymentByBusinessCode`

        -   查询申请单审核结果：`GetApplyForSubjectApplymentByApplymentId` / `GetApplyForSubjectApplymentByBusinessCode`

        -   获取商户开户意愿确认状态：`GetApplyForSubjectApplymentMerchantState`

        -   图片上传：`UploadMerchantMediaImage`

    -   商户平台处置通知

        -   创建商户违规通知回调地址：`CreateMerchantRiskManageViolationNotification`

        -   查询商户违规通知回调地址：`GetMerchantRiskManageViolationNotification`

        -   更新商户违规通知回调地址：`UpdateMerchantRiskManageViolationNotification`

        -   删除商户违规通知回调地址：`DeleteMerchantRiskManageViolationNotification`

    -   商户风险管理

        -   上报订单关联信息：`CreateMerchantRiskManageTradeUnionInformationReport`

        -   查询风险信息：`GetMerchantRiskManageTradeRiskInformation`

        -   处置结果回传：`CreateMerchantRiskManageTradeRiskResult`

    -   不活跃商户身份核实

        -   发起不活跃商户身份核实：`CreateComplianceInactiveMerchantIdentityVerification`

        -   查询不活跃商户身份核实结果：`GetComplianceInactiveMerchantIdentityVerificationByVerificationId`

-   扩展工具

    -   电商订单实名校验

        -   实名信息校验：`GetRealNameVerification`

    -   微信点餐订单

        -   点餐订单信息同步：`SyncCateringOrderStatus`

    -   微信寄快递

        -   用户 OpenID 转换：`TransformExpressUserOpenId`

-   其他

    -   来账识别

        -   特约商户银行来账查询：`QueryMerchantFundPartnerIncomeRecords`

        -   服务商银行来账查询：`QueryMerchantFundMerchantIncomeRecords`

    -   扣款服务

        -   预扣费通知：`CreatePartnerPAPayContractNotification`

        -   重试扣费通知：`CreatePartnerPAPayContractFailedNotification`

    -   代扣服务切卡组件

        -   出行券切卡组件预下单：`CreateIndustryCouponToken`

    -   连锁品牌门店

        -   创建门店：`CreateMerchantStore`

        -   查询门店：`GetMerchantStoreByStoreId`

        -   修改门店：`ModifyMerchantStore`

        -   绑定门店收款信息：`BindMerchantStoreRecipient`

        -   解除门店收款信息绑定：`UnbindMerchantStoreRecipient`

    -   品牌小店营销

        -   查询零售小店活动业务代理：`QueryMarketingGoodsSubsidyActivityRetailStoreRepresentatives`

        -   添加零售小店活动业务代理：`AddMarketingGoodsSubsidyActivityRetailStoreRepresentative`

        -   删除零售小店活动业务代理：`DeleteMarketingGoodsSubsidyActivityRetailStoreRepresentative`

        -   生成小店活动物料码：`CreateMarketingGoodsSubsidyActivityRetailStoreMaterial`

        -   查询小店活动门店列表：`QueryMarketingGoodsSubsidyActivityRetailStores`

        -   查询小店活动门店详情：`GetMarketingGoodsSubsidyActivityRetailStoreByStoreCode`

        -   添加小店活动门店：`AddMarketingGoodsSubsidyActivityRetailStore`

        -   删除小店活动门店：`DeleteMarketingGoodsSubsidyActivityRetailStore`

    -   电子小票

        -   自定义入口

            -   创建自定义入口：`CreateMarketingShoppingReceiptCustomEntrance`

            -   查询自定义入口：`GetMarketingShoppingReceiptCustomEntranceByBrandId`

            -   更新自定义入口：`ModifyMarketingShoppingReceiptCustomEntrance`

        -   电子小票

            -   上传电子小票：`UploadMarketingShoppingReceipt`

        -   商家电子小票跳转信息

            -   上传商家电子小票跳转信息：`SetMarketingShoppingReceiptJumpInfo`

        -   小票机

            -   小票机打印：`CreatePayDevicePrinterPrintOrder`

            -   查询订单：`GetPayDevicePrinterPrintOrderByPrintOrderNumber`

    -   ETC 扣费

        -   预开通用户 ETC 指定卡扣费：`PreopenVehicleETC`

        -   高速场景商户扣款：`CreateVehicleETCTransactionHighway`

        -   查询 ETC 签约状态：`GetVehicleETCContractByOpenId` / `GetVehicleETCContractByContractId`

        -   查询订单：`GetVehicleETCTransactionByOutTradeNumber` / `GetVehicleETCTransactionByTransactionId`

    -   出租车电子发票

        -   新增出租车公司：`CreateTaxiInvoiceTaxiCompany`

        -   获取出租车公司商户信息：`GetTaxiInvoiceTaxiCompany`

        -   更新出租车信息：`UpdateTaxiInvoiceTaxi`

        -   获取出租车信息：`GetTaxiInvoiceTaxi`

        -   更新司机信息：`UpdateTaxiInvoiceDriver`

        -   获取司机信息：`GetTaxiInvoiceDriver`

        -   签到签退：`CreateTaxiInvoicePunchAttendance`

        -   根据凭证查询乘客行程单：`GetTaxiInvoiceUserTaxiOrderByToken`

        -   上传出租车电子发票文件：`UploadTaxiInvoiceCardFile`

        -   将出租车电子发票插入微信用户卡包：`CreateTaxiInvoiceCard`

    -   教育续费通：

        -   预签约：`PresignEducationPAPayContract`

        -   通过协议号查询签约：`GetEducationPAPayContractByContractId`

        -   通过用户标识查询签约：`QueryEducationPAPayUserContracts`

        -   解约：`TerminateEducationPAPayContract`

        -   发送扣款预通知：`SendEducationPAPayContractNotification`

        -   教育通扣款受理：`CreateEducationPAPayTransaction`

        -   微信订单号查单：`GetEducationPAPayTransactionById`

        -   商户订单号查单：`GetEducationPAPayTransactionByOutTradeNumber`

    -   校园轻松付：

        -   预签约：`PresignEducationSchoolPayContract`

        -   通过协议号查询签约：`GetEducationSchoolPayContractByContractId`

        -   商户主动解约：`TerminateEducationSchoolPayContract`

        -   查询用户签约列表：`QueryEducationSchoolPayUserContracts`

        -   扣款：`CreateEducationSchoolPayTransaction`

        -   微信支付订单号查单：`GetEducationSchoolPayTransactionById`

        -   商户订单号查单：`GetEducationSchoolPayTransactionByOutTradeNumber`

        -   商户查询用户欠款状态：`GetEducationSchoolPayUserDebtState`

    -   微工卡

        -   微工卡获得用户授权

            -   生成授权 Token：`CreatePayrollCardToken`

            -   查询微工卡授权关系：`GetPayrollRelationByOpenId`

        -   微工卡用户核身份：

            -   微工卡核身预下单：`PreorderWithAuthPayrollCardAuthentication`

            -   获取核身结果：`GetPayrollCardAuthenticationByAuthenticateNumber`

            -   查询核身记录：`QueryPayrollCardAuthentications`

        -   微工卡转账：

            -   发起批量转账：`CreatePayrollCardTransferBatch`

            -   微信支付批次单号查询批次单：`GetTransferBatchByBatchId`

            -   微信支付明细单号查询明细单：`GetTransferBatchDetailByDetailId`

            -   商家批次单号查询批次单：`GetTransferBatchByOutBatchNumber`

            -   商家明细单号查询明细单：`GetTransferBatchDetailByOutDetailNumber`

            -   转账电子回单申请受理：`CreateTransferBillReceipt`

            -   查询转账电子回单：`GetTransferBillReceiptByOutBatchNumber`

            -   转账明细电子回单受理：`CreateTransferDetailElectronicReceipt`

            -   查询转账明细电子回单受理结果：`GetTransferDetailElectronicReceiptByOutDetailNumber`

            -   下载电子回单：`DownloadBillFile`

        -   微工卡余额查询：

            -   查询特约商户账户实时余额：`GetEcommerceFundBalance`

            -   查询账户实时余额：`GetMerchantFundBalance`

            -   查询账户日终余额：`GetMerchantFundDayendBalance`

        -   微工卡提现：

            -   特约商户余额提现：`CreateEcommerceFundWithdraw`

            -   查询特约商户提现状态：`GetEcommerceFundWithdrawByWithdrawId` / `GetEcommerceFundWithdrawByOutRequestNumber`

            -   按日下载提现异常文件：`GetMerchantFundWithdrawBill`

        -   微工卡账单：

            -   申请单个子商户资金账单：`GetBillSubMerchantFundflowBill`

            -   下载账单：`DownloadBillFile`

        -   微工卡来账识别：

            -   特约商户银行来账查询：`QueryMerchantFundPartnerIncomeRecords`

            -   服务商银行来账查询：`QueryMerchantFundMerchantIncomeRecords`

</details>

---

### 【附】境外支付 API 模型命名速查表：

注：树形结构与[微信支付开发者文档](https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pages/Overview.shtml)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   Payments

    -   Quick Pay

        -   Quick Pay：`CreateTransactionMicroPay` / `CreatePartnerTransactionMicroPay`

        -   Query Order：`GetTransactionByOutTradeNumber` / `GetTransactionById` / `GetPartnerTransactionByOutTradeNumber` / `GetPartnerTransactionById`

        -   Refund Application：`CreateRefund` / `CreatePartnerRefund`

        -   Query Single Refund：`GetRefundByOutRefundNumber` / `GetRefundById` / `GetPartnerRefundByOutRefundNumber` / `GetPartnerRefundById`

        -   Query All Refunds: `QueryRefunds` / `QueryPartnerRefunds`

        -   Downloading Reconciliation：`DownloadStatements`

        -   Revoke Order：`ReverseTransaction` / `ReversePartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QuerySettlements`

    -   Native Payment

        -   Order Placement：`CreateTransactionMicroPay` / `CreatePartnerTransactionMicroPay`

        -   Query Order：`GetTransactionByOutTradeNumber` / `GetTransactionById` / `GetPartnerTransactionByOutTradeNumber` / `GetPartnerTransactionById`

        -   Refund Application：`CreateRefund` / `CreatePartnerRefund`

        -   Query Single Refund：`GetRefundByOutRefundNumber` / `GetRefundById` / `GetPartnerRefundByOutRefundNumber` / `GetPartnerRefundById`

        -   Query All Refunds: `QueryRefunds` / `QueryPartnerRefunds`

        -   Downloading Reconciliation：`DownloadStatements`

        -   Close Order：`CloseTransaction` / `ClosePartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QuerySettlements`

    -   JSAPI Payment

        -   Order Placement：`CreateTransactionMicroPay` / `CreatePartnerTransactionMicroPay`

        -   Query Order：`GetTransactionByOutTradeNumber` / `GetTransactionById` / `GetPartnerTransactionByOutTradeNumber` / `GetPartnerTransactionById`

        -   Refund Application：`CreateRefund` / `CreatePartnerRefund`

        -   Query Single Refund：`GetRefundByOutRefundNumber` / `GetRefundById` / `GetPartnerRefundByOutRefundNumber` / `GetPartnerRefundById`

        -   Query All Refunds: `QueryRefunds` / `QueryPartnerRefunds`

        -   Downloading Reconciliation：`DownloadStatements`

        -   Close Order：`CloseTransaction` / `ClosePartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QuerySettlements`

    -   In-App Payment

        -   Order Placement：`CreateTransactionMicroPay` / `CreatePartnerTransactionMicroPay`

        -   Query Order：`GetTransactionByOutTradeNumber` / `GetTransactionById` / `GetPartnerTransactionByOutTradeNumber` / `GetPartnerTransactionById`

        -   Refund Application：`CreateRefund` / `CreatePartnerRefund`

        -   Query Single Refund：`GetRefundByOutRefundNumber` / `GetRefundById` / `GetPartnerRefundByOutRefundNumber` / `GetPartnerRefundById`

        -   Query All Refunds: `QueryRefunds` / `QueryPartnerRefunds`

        -   Downloading Reconciliation：`DownloadStatements`

        -   Close Order：`CloseTransaction` / `ClosePartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QuerySettlements`

    -   Mini-Program Payment

        -   Order Placement：`CreateTransactionMicroPay` / `CreatePartnerTransactionMicroPay`

        -   Query Order：`GetTransactionByOutTradeNumber` / `GetTransactionById` / `GetPartnerTransactionByOutTradeNumber` / `GetPartnerTransactionById`

        -   Refund Application：`CreateRefund` / `CreatePartnerRefund`

        -   Query Single Refund：`GetRefundByOutRefundNumber` / `GetRefundById` / `GetPartnerRefundByOutRefundNumber` / `GetPartnerRefundById`

        -   Query All Refunds: `QueryRefunds` / `QueryPartnerRefunds`

        -   Downloading Reconciliation：`DownloadStatements`

        -   Close Order：`CloseTransaction` / `ClosePartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QuerySettlements`

    -   H5 Payment

        -   Order Placement：`CreateTransactionMicroPay` / `CreatePartnerTransactionMicroPay`

        -   Query Order：`GetTransactionByOutTradeNumber` / `GetTransactionById` / `GetPartnerTransactionByOutTradeNumber` / `GetPartnerTransactionById`

        -   Query All Refunds: `QueryRefunds` / `QueryPartnerRefunds`

        -   Refund Application：`CreateRefund` / `CreatePartnerRefund`

        -   Query Single Refund：`GetRefundByOutRefundNumber` / `GetRefundById` / `GetPartnerRefundByOutRefundNumber` / `GetPartnerRefundById`

        -   Downloading Reconciliation：`DownloadStatements`

        -   Close Order：`CloseTransaction` / `ClosePartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QuerySettlements`

    -   Auto-Debit Payment

        -   Mini Program Signing: `PresignPAPayContractEntrustMiniProgram` / `PresignPartnerPAPayContractEntrustMiniProgram`

        -   H5 Signing: `PresignPAPayContractEntrustH5` / `PresignPartnerPAPayContractEntrustH5`

        -   JSAPI Signing: `PresignPAPayContractEntrustJsapi` / `PresignPartnerPAPayContractEntrustJsapi`

        -   PC WEB Signing: `PresignPAPayContractEntrustJsapi` / `PresignPartnerPAPayContractEntrustJsapi`

        -   APP Signing: `PresignPAPayContractEntrustApp` / `PresignPartnerPAPayContractEntrustApp`

        -   Querying Signing Status: `GetPAPayContractByOutContractCode` / `GetPAPayContractByContractId` / `GetPartnerPAPayContractByOutContractCode` / `GetPartnerPAPayContractByContractId`

        -   Applying for Termination: `TerminatePAPayContract` / `TerminatePartnerPAPayContract`

        -   Deduction: `CreatePAPayTransaction` / `CreatePartnerPAPayTransaction`

        -   Order Query: `GetPAPayTransactionByOutTradeNumber` / `GetPAPayTransactionById` / `GetPartnerPAPayTransactionByOutTradeNumber` / `GetPartnerPAPayTransactionById`

        -   Order Reversing: `ReversePAPayTransaction` / `ReversePartnerPAPayTransaction`

        -   Submit Refund: `CreateRefund` / `CreatePartnerRefund`

        -   Query Single Refund: `GetRefundByOutRefundNumber` / `GetRefundById` / `GetPartnerRefundByOutRefundNumber` / `GetPartnerRefundById`

        -   Query All Refunds: `QueryRefunds` / `QueryPartnerRefunds`

-   Other

    -   Merchant Onboarding

        -   Onboarding Sub-merchant：`AddSubMerchant`

        -   Query Sub-merchant：`GetSubMerchant`

        -   Sub Merchant Modifying：`ModifySubMerchant`

        -   Upload Image：`UploadMerchantMediaImage`

    -   H5 Payment Authorization Application

        -   Create Authorization Application：`CreateMerchantH5PermissionApplication`

        -   Query Authorization Application：`GetMerchantH5PermissionApplicationByApplymentId`

        -   Modify Authorization Application：`UpdateMerchantH5PermissionApplication`

        -   Create Domain Modification Application：`UpdateMerchantH5PermissionDomainApplication`

        -   Query Domain Modification Application：`GetMerchantH5PermissionDomainApplicationByApplymentId`

        -   Modify Domain Modification Application：`UpdateMerchantH5PermissionDomainAApplication`

        -   Query Authorization Status：`GetMerchantH5PermissionBySubMerchantId`

    -   Customs Declaration

        -   Customs Declaration：`CreateCustomsOrder`

        -   Identity Information Verification：`VerifyCustomsCertificate`

        -   Query Customs Declaration：`QueryCustomsOrders`

        -   Repush Customs Declaration：`RedeclareCustomsOrder`

        -   Modify Customs Declaration Info：`ModifyCustomsOrder`
