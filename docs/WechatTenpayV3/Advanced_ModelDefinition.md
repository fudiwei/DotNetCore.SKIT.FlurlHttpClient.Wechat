## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，发起退款的请求是 `CreateRefundDomesticRefundRequest`，响应是 `CreateRefundDomesticRefundResponse`，接口是 `ExecuteCreateRefundDomesticRefundAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的发起退款，它的接口地址是 `[POST] /refund/domestic/refunds`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

另外，以 `Query` 开头的一般表示列表查询；以 `Get` 开头的一般表示获取详情；以 `Create` 开头的一般表示发起或新建操作；以 `Update`、`Modify` 开头的一般表示修改操作；以 `Set` 开头的一般表示设置操作。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.TenpayV3/Models_ 目录。

---

### 找不到所需要的接口或字段？

本库会定期随微信官方更新接口或模型，但也会偶有疏漏。如果你在使用中遇到了因接口或模型定义而产生的问题，欢迎提出 Issue。

如果你的项目来不及等待 Issue 被处理，你可以自行扩展相关 API。详细方式请参阅本文档[《高级技巧 - 如何扩展额外的 API？》](./Advanced_Extensions.md)。

---

### 微信支付 API 支持情况：

<details>

<summary>[展开查看]</summary>

|     |             微信 API              |     商户类型      |       备注        |
| :-: | :-------------------------------: | :---------------: | :---------------: |
|  √  |      商户进件：特约商户进件       |      服务商       |                   |
|  √  |       基础支付：JSAPI 支付        | 直连商户 & 服务商 |                   |
|  √  |        基础支付：APP 支付         | 直连商户 & 服务商 |                   |
|  √  |         基础支付：H5 支付         | 直连商户 & 服务商 |                   |
|  √  |       基础支付：Native 支付       | 直连商户 & 服务商 |                   |
|  √  |       基础支付：小程序支付        | 直连商户 & 服务商 |                   |
|  √  |        基础支付：合单支付         | 直连商户 & 服务商 |                   |
|  ×  |  <del>基础支付：付款码支付</del>  | 直连商户 & 服务商 | 官方未提供 v3 API |
|  √  |       经营能力：微信支付分        | 直连商户 & 服务商 |                   |
|  √  |       经营能力：微信先享卡        |     直连商户      |                   |
|  √  |       经营能力：支付即服务        | 直连商户 & 服务商 |                   |
|  √  |        经营能力：点金计划         |      服务商       |                   |
|  √  |       行业方案：电商收付通        |      服务商       |                   |
|  √  |        行业方案：智慧商圈         | 直连商户 & 服务商 |                   |
|  √  |   行业方案：微信支付分停车服务    | 直连商户 & 服务商 |                   |
|  √  |         营销工具：代金券          | 直连商户 & 服务商 |                   |
|  √  |         营销工具：商家券          | 直连商户 & 服务商 |                   |
|  √  |        营销工具：委托营销         | 直连商户 & 服务商 |                   |
|  √  |         营销工具：消费卡          | 直连商户 & 服务商 |                   |
|  √  |        营销工具：支付有礼         | 直连商户 & 服务商 |                   |
|  √  |    营销工具：代扣服务切卡组件     | 直连商户 & 服务商 |                   |
|  √  |  营销工具：图片上传（营销专用）   | 直连商户 & 服务商 |                   |
|  ×  |   <del>营销工具：现金红包</del>   | 直连商户 & 服务商 | 官方未提供 v3 API |
|  √  |      营销工具：银行定向促活       | 直连商户 & 服务商 |                   |
|  ×  | <del>资金应用：转账到银行卡</del> |     直连商户      | 官方未提供 v3 API |
|  √  |       资金应用：转账到零钱        | 直连商户 & 服务商 |                   |
|  √  |          资金应用：分账           | 直连商户 & 服务商 |                   |
|  √  |         资金应用：微工卡          |      服务商       |                   |
|  √  |      资金应用：连锁品牌分账       |      服务商       |                   |
|  √  |    风险合规：商户开户意愿确认     |      服务商       |                   |
|  √  |     风险合规：消费者投诉 2.0      | 直连商户 & 服务商 |                   |
|  ×  |   <del>其他能力：清关报关</del>   |     直连商户      | 官方未提供 v3 API |
|  √  |        其他能力：图片上传         | 直连商户 & 服务商 |                   |
|  √  |        其他能力：视频上传         | 直连商户 & 服务商 |                   |
|  √  |       境外支付：子商户进件        |      服务商       |                   |
|  √  |        境外支付：融合钱包         |      服务商       |                   |
|  √  |          境外支付：报关           |      服务商       |                   |

</details>

---

### 【附】直连商户模式 API 模型命名速查表：

注：树形结构与[微信支付开发者文档](https://pay.weixin.qq.com/wiki/doc/apiv3/apis/index.shtml)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   平台证书

    -   获取平台证书：`QueryCertificates`

-   基础支付

    -   JSAPI 支付

        -   统一下单：`CreatePayTransactionJsapi`

        -   查询订单：`GetPayTransactionById` / `GetPayTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   APP 支付

        -   统一下单：`CreatePayTransactionApp`

        -   查询订单：`GetPayTransactionById` / `GetPayTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   H5 支付

        -   统一下单：`CreatePayTransactionH5`

        -   查询订单：`GetPayTransactionById` / `GetPayTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   Native 支付

        -   统一下单：`CreatePayTransactionNative`

        -   查询订单：`GetPayTransactionById` / `GetPayTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   小程序支付

        -   统一下单：`CreatePayTransactionJsapi`

        -   查询订单：`GetPayTransactionById` / `GetPayTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   合单支付

        -   合单 APP 下单：`CreateCombineTransactionApp`

        -   合单 H5 下单：`CreateCombineTransactionH5`

        -   合单 JSAPI 下单：`CreateCombineTransactionJsapi`

        -   合单小程序下单：`CreateCombineTransactionJsapi`

        -   合单 Native 下单：`CreateCombineTransactionNative`

        -   合单查询订单：`GetCombineTransactionByCombineOutTradeNumber`

        -   合单关闭订单：`CloseCombineTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单个退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

-   经营能力

    -   微信支付分（免确认模式）

        -   创单结单合并：`CreatePayScoreServiceOrderDirectComplete`

    -   微信支付分（免确认预授权模式）

        -   商户预授权：`ApplyPayScorePermissions`

        -   查询用户授权记录（授权协议号）：`GetPayScorePermissionsByAuthorizationCode`

        -   解除用户授权关系（授权协议号）：`TerminatePayScorePermissionsByAuthorizationCode`

        -   查询用户授权记录（OpenId）：`GetPayScorePermissionsByOpenId`

        -   解除用户授权关系（OpenId）：`TerminatePayScorePermissionsByOpenId`

    -   微信支付分（公共 API）

        -   创建支付分订单：`CreatePayScoreServiceOrder`

        -   查询支付分订单：`GetPayScoreServiceOrderByQueryId` / `GetPayScoreServiceOrderByOutOrderNumber`

        -   取消支付分订单：`CancelPayScoreServiceOrder`

        -   修改订单金额：`ModifyPayScoreServiceOrder`

        -   完结支付分订单：`SetPayScoreServiceOrderComplete`

        -   商户发起催收扣款：`SetPayScoreServiceOrderPay`

        -   同步服务订单信息：`SetPayScoreServiceOrderSync`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询退款：`GetRefundDomesticRefundByOutRefundNumber`

    -   微信先享卡

        -   预受理领卡请求：`PrepareDiscountCard`

        -   增加用户记录：`AddDiscountCardUserRecord`

        -   查询先享卡订单：`GetDiscountCardByOutCardCode`

    -   支付即服务

        -   服务人员注册：`CreateSmartGuide`

        -   服务人员分配：`AssignSmartGuide`

        -   服务人员查询：`QuerySmartGuides`

        -   服务人员信息更新：`UpdateSmartGuide`

    -   扣款服务

        -   预扣费通知：`NotifyPAPPayContracts`

-   行业方案

    -   智慧商圈

        -   商圈积分同步：`NotifyBusinessCirclePoints`

        -   商圈积分授权查询：`GetBusinessCircleUserAuthorizationByOpenId`

        -   商圈会员待积分状态查询：`GetBusinessCircleUserPointsCommitStatusByOpenId`

        -   商圈会员停车状态同步：`NotifyBusinessCircleParkings`

    -   微信支付分停车服务

        -   查询车牌服务开通信息：`GetVehicleParkingService`

        -   创建停车入场：`CreateVehicleParking`

        -   扣费受理：`CreateVehicleTransactionParking`

        -   查询订单：`GetVehicleTransactionByOutTradeNumber`

-   营销工具

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

        -   查询营销补差付款单详情：`GetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptId`

    -   委托营销

        -   建立合作关系：`BuildMarketingPartnership`

        -   终止合作关系：`TerminateMarketingPartnership`

        -   查询合作关系列表：`QueryMarketingPartnerships`

    -   消费卡

        -   发放消费卡：`SendMarketingBusifavorCoupon`

    -   支付有礼

        -   创建全场满额送活动：`CreateMarketingPayGiftActivityUniqueThresholdActivity`

        -   查询活动详情接口：`GetMarketingPayGiftActivityByActivityId`

        -   查询活动发券商户号：`QueryMarketingPayGiftActivityMerchants`

        -   查询活动指定商品列表：`QueryMarketingPayGiftActivityGoods`

        -   终止活动：`TerminateMarketingPayGiftActivity`

        -   新增活动发券商户号：`AddMarketingPayGiftActivityMerchant`

        -   获取支付有礼活动列表：`QueryMarketingPayGiftActivities`

        -   删除活动发券商户号：`DeleteMarketingPayGiftActivityMerchant`

    -   代扣服务切卡组件

        -   出行券切卡组件预下单：`CreateIndustryCouponToken`

    -   图片上传（营销专用）：`UploadMarketingMediaImage`

    -   银行定向促活

        -   导入定向用户协议号：`UploadMarketingBankPackagesTasks`

-   资金应用

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

    -   批量转账到零钱

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

    -   来账识别

        -   商户银行来账查询：`QueryMerchantFundMerchantIncomeRecords`

-   风险合规

    -   消费者投诉 2.0

        -   查询投诉单列表：`QueryMerchantServiceComplaints`

        -   查询投诉单详情：`GetMerchantServiceComplaintByComplaintId`

        -   查询投诉协商历史：`QueryMerchantServiceComplaintNegotiationHistories`

        -   创建投诉通知回调地址：`CreateMerchantServiceComplaintNotification`

        -   查询投诉通知回调地址：`GetMerchantServiceComplaintNotification`

        -   更新投诉通知回调地址：`UpdateMerchantServiceComplaintNotification`

        -   删除投诉通知回调地址：`DeleteMerchantServiceComplaintNotification`

        -   提交回复：`CreateMerchantServiceComplaintResponse`

        -   反馈处理完成：`SetMerchantServiceComplaintComplete`

        -   商户上传反馈图片：`UploadMerchantServiceImage`

        -   下载图片：`DownloadMerchantServiceImage`

-   其他能力

    -   图片上传：`UploadMerchantMediaImage`

    -   视频上传：`UploadMerchantMediaVideo`

    -   银行组件：

        -   获取对私银行卡号开户银行：`QueryCapitalBanksByBankAccount`

        -   查询支持个人业务的银行列表：`QueryCapitalBanksPersonalBanking`

        -   查询支持对公业务的银行列表：`QueryCapitalBanksCorporateBanking`

        -   查询省份列表：`QueryCapitalAreasProvinces`

        -   查询城市列表：`QueryCapitalAreasCities`

        -   查询支行列表：`QueryCapitalBanksBranches`

</details>

---

### 【附】服务商、机构模式 API 模型命名速查表：

注：树形结构与[微信支付开发者文档](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/index.shtml)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   平台证书

    -   获取平台证书：`QueryCertificates`

-   商户进件

    -   特约商户进件

        -   提交申请单：`CreateApplyForSubMerchantApplyment`

        -   查询申请单状态：`GetApplyForSubMerchantApplymentByApplymentId` / `GetApplyForSubMerchantApplymentByBusinessCode`

        -   修改结算帐号：`ModifyApplyForSubMerchantSettlement`

        -   查询结算账户：`GetApplyForSubMerchantSettlement`

-   基础支付

    -   JSAPI 支付

        -   统一下单：`CreatePayPartnerTransactionJsapi`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   申请单个子商户资金账单：`GetBillSubMerchantFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   APP 支付

        -   统一下单：`CreatePayPartnerTransactionApp`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   申请单个子商户资金账单：`GetBillSubMerchantFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   H5 支付

        -   统一下单：`CreatePayPartnerTransactionH5`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   申请单个子商户资金账单：`GetBillSubMerchantFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   Native 支付

        -   统一下单：`CreatePayPartnerTransactionNative`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   申请单个子商户资金账单：`GetBillSubMerchantFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   小程序支付

        -   统一下单：`CreatePayPartnerTransactionJsapi`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   申请单个子商户资金账单：`GetBillSubMerchantFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   合单支付

        -   合单 APP 下单：`CreateCombineTransactionApp`

        -   合单 H5 下单：`CreateCombineTransactionH5`

        -   合单 JSAPI 下单：`CreateCombineTransactionJsapi`

        -   合单小程序下单：`CreateCombineTransactionJsapi`

        -   合单 Native 下单：`CreateCombineTransactionNative`

        -   合单查询订单：`GetCombineTransactionByCombineOutTradeNumber`

        -   合单关闭订单：`CloseCombineTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单个退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   申请单个子商户资金账单：`GetBillSubMerchantFundflowBill`

        -   下载账单：`DownloadBillFile`

-   经营能力

    -   微信支付分（公共 API）

        -   创建支付分订单：`CreatePayScorePartnerServiceOrder`

        -   查询支付分订单：`GetPayScorePartnerServiceOrderByQueryId` / `GetPayScoreServiceOrderByOutOrderNumber`

        -   取消支付分订单：`CancelPayScorePartnerServiceOrder`

        -   修改订单金额：`ModifyPayPartnerScoreServiceOrder`

        -   完结支付分订单：`SetPayScorePartnerServiceOrderComplete`

        -   商户发起催收扣款：`SetPayScorePartnerServiceOrderPay`

        -   同步服务订单信息：`SetPayScorePartnerServiceOrderSync`

        -   商户申请获取对账单：`GetPayScoreMerchantBill`

    -   微信支付分（免确认模式特有 API）

        -   商户预授权：`ApplyPayScorePartnerPermissions`

        -   查询用户授权记录（授权协议号）：`GetPayScorePartnerPermissionsByAuthorizationCode`

        -   解除用户授权关系（授权协议号）：`TerminatePayScorePartnerPermissionsByAuthorizationCode`

        -   查询用户授权记录（OpenId）：`GetPayScorePartnerPermissionsByOpenId`

        -   解除用户授权关系（OpenId）：`TerminatePayScorePartnerPermissionsByOpenId`

    -   支付即服务

        -   服务人员注册：`CreateSmartGuide`

        -   服务人员分配：`AssignSmartGuide`

        -   服务人员查询：`QuerySmartGuides`

        -   服务人员信息更新：`UpdateSmartGuide`

    -   点金计划

        -   点金计划管理：`ChangeGoldPlanStatus`

        -   商家小票管理：`ChangeGoldPlanCustomPageStatus`

        -   同业过滤标签管理：`SetGoldPlanAdvertisingIndustryFilter`

        -   开通广告展示：`OpenGoldPlanAdvertisingShow`

        -   关闭广告展示：`CloseGoldPlanAdvertisingShow`

    -   扣款服务

        -   预扣费通知：`NotifyPartnerPAPPayContracts`

-   行业方案

    -   电商收付通（商户进件）

        -   二级商户进件：`CreateEcommerceApplyment`

        -   查询申请状态：`GetEcommerceApplymentByApplymentId` / `GetEcommerceApplymentByOutRequestNumber`

        -   下载平台证书：`QueryCertificates`

        -   修改结算帐号：`ModifyApplyForSubMerchantSettlement`

        -   查询结算账户：`GetApplyForSubMerchantSettlement`

    -   电商收付通（普通支付）

        -   APP 下单：`CreatePayPartnerTransactionApp`

        -   JSAPI 下单：`CreatePayPartnerTransactionJsapi`

        -   小程序下单：`CreatePayPartnerTransactionJsapi`

        -   H5 下单：`CreatePayPartnerTransactionH5`

        -   H5 下单：`CreatePayPartnerTransactionH5`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

    -   电商收付通（合单支付）

        -   合单 APP 下单：`CreateCombineTransactionApp`

        -   合单 H5 下单：`CreateCombineTransactionH5`

        -   合单 JSAPI 下单：`CreateCombineTransactionJsapi`

        -   合单小程序下单：`CreateCombineTransactionJsapi`

        -   合单 Native 下单：`CreateCombineTransactionNative`

        -   合单查询订单：`GetCombineTransactionByCombineOutTradeNumber`

        -   合单关闭订单：`CloseCombineTransaction`

    -   电商收付通（分账）

        -   请求分账：`CreateEcommerceProfitSharingOrder`

        -   查询分账结果：`GetEcommerceProfitSharingOrderByOutOrderNumber`

        -   请求分账回退：`CreateEcommerceProfitSharingReturnOrder`

        -   查询分账回退结果：`GetEcommerceProfitSharingReturnOrderByOrderId` / `GetEcommerceProfitSharingReturnOrderByOutOrderNumber`

        -   完结分账：`SetEcommerceProfitSharingOrderFinish`

        -   查询订单剩余待分金额：`GetEcommerceProfitSharingOrderAmounts`

        -   添加分账接收方：`AddEcommerceProfitSharingReceiver`

        -   删除分账接收方：`DeleteEcommerceProfitSharingReceiver`

    -   电商收付通（补差）

        -   请求补差：`CreateEcommerceSubsidy`

        -   请求补差回退：`CreateEcommerceSubsidyReturn`

        -   取消补差：`CancelEcommerceSubsidy`

    -   电商收付通（退款）

        -   申请退款：`CreateEcommerceRefund`

        -   查询退款：`GetEcommerceRefundByRefundId` / `GetEcommerceRefundByOutRefundNumber`

        -   垫付退款回补：`CreateEcommerceRefundReturnAdvance`

        -   查询垫付回补结果：`GetEcommerceRefundReturnAdvance`

    -   电商收付通（余额查询）

        -   查询二级商户账户实时余额：`GetEcommerceFundBalance`

        -   查询二级商户账户日终余额：`GetEcommerceFundDayendBalance`

        -   查询电商平台账户实时余额：`GetMerchantFundBalance`

        -   查询电商平台账户日终余额：`GetMerchantFundDayendBalance`

    -   电商收付通（商户提现）

        -   二级商户余额提现：`CreateEcommerceFundWithdraw`

        -   二级商户查询提现状态：`GetEcommerceFundWithdrawByWithdrawId` / `GetEcommerceFundWithdrawByOutRequestNumber`

        -   电商平台提现：`CreateMerchantFundWithdraw`

        -   电商平台查询提现状态：`GetMerchantFundWithdrawByWithdrawId` / `GetMerchantFundWithdrawByOutRequestNumber`

        -   按日下载提现异常文件：`GetMerchantFundWithdrawBill`

    -   电商收付通（跨境支付）

        -   查询订单剩余可出境余额：`GetFundsToOverseaTransactionAvailableAbroadAmountByTransactionId`

        -   申请资金出境：`CreateFundsToOverseaOrder`

        -   查询出境结果：`GetFundsToOverseaOrderByOutOrderId`

        -   获取购付汇账单文件下载链接：`GetFundsToOverseaBillDownloadUrl`

    -   电商收付通（下载账单）

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   申请二级商户资金账单：`GetEcommerceBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   智慧商圈

        -   商圈积分同步：`NotifyBusinessCirclePoints`

        -   商圈积分授权查询：`GetBusinessCircleUserAuthorizationByOpenId`

        -   商圈会员待积分状态查询：`GetBusinessCircleUserPointsCommitStatusByOpenId`

        -   商圈会员停车状态同步：`NotifyBusinessCircleParkings`

    -   微信支付分停车服务

        -   查询车牌服务开通信息：`GetVehicleParkingService`

        -   创建停车入场：`CreateVehicleParking`

        -   扣费受理：`CreateVehicleTransactionParking`

        -   查询订单：`GetVehicleTransactionByOutTradeNumber`

-   营销工具

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

        -   查询营销补差付款单详情：`GetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptId`

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

    -   代扣服务切卡组件

        -   出行券切卡组件预下单：`CreateIndustryCouponToken`

    -   图片上传（营销专用）：`UploadMarketingMediaImage`

-   资金应用

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

    -   批量转账到零钱

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

    -   来账识别

        -   特约商户银行来账查询：`QueryMerchantFundPartnerIncomeRecords`

        -   服务商银行来账查询：`QueryMerchantFundMerchantIncomeRecords`

    -   微工卡

        -   微工卡获得用户授权

            -   生成授权 Token：`CreatePayrollCardToken`

            -   查询微工卡授权关系：`GetPayrollRelationByOpenId`

        -   微工卡用户核身份：

            -   微工卡核身预下单：`PreOrderWithAuthPayrollCardAuthentication`

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

-   风险合规

    -   消费者开户意愿确认

        -   提交申请单：`CreateApplyForSubjectApplyment`

        -   撤销申请单：`CancelApplyForSubjectApplymentByApplymentId` / `CancelApplyForSubjectApplymentByBusinessCode`

        -   查询申请单审核结果：`GetApplyForSubjectApplymentByApplymentId` / `GetApplyForSubjectApplymentByBusinessCode`

        -   获取商户开户意愿确认状态：`GetApplyForSubjectApplymentMerchantState`

    -   消费者投诉 2.0

        -   查询投诉单列表：`QueryMerchantServiceComplaints`

        -   查询投诉单详情：`GetMerchantServiceComplaintByComplaintId`

        -   查询投诉协商历史：`QueryMerchantServiceComplaintNegotiationHistories`

        -   创建投诉通知回调地址：`CreateMerchantServiceComplaintNotification`

        -   查询投诉通知回调地址：`GetMerchantServiceComplaintNotification`

        -   更新投诉通知回调地址：`UpdateMerchantServiceComplaintNotification`

        -   删除投诉通知回调地址：`DeleteMerchantServiceComplaintNotification`

        -   提交回复：`CreateMerchantServiceComplaintResponse`

        -   反馈处理完成：`SetMerchantServiceComplaintComplete`

        -   商户上传反馈图片：`UploadMerchantServiceImage`

        -   下载图片：`DownloadMerchantServiceImage`

    -   商户违规回调通知

        -   创建商户违规通知回调地址：`CreateMerchantRiskManageViolationNotification`

        -   查询商户违规通知回调地址：`GetMerchantRiskManageViolationNotification`

        -   更新商户违规通知回调地址：`UpdateMerchantRiskManageViolationNotification`

        -   删除商户违规通知回调地址：`DeleteMerchantRiskManageViolationNotification`

-   其他能力

    -   图片上传：`UploadMerchantMediaImage`

    -   视频上传：`UploadMerchantMediaVideo`

</details>

---

### 【附】境外开发 API 模型命名速查表：

注：树形结构与[微信支付开发者文档](https://pay.weixin.qq.com/wiki/doc/api/wxpay/en/pages/Overview.shtml)目录结构保持一致。

<details>

<summary>[展开查看]</summary>

-   Onboarding Sub Merchant

    -   Onboarding Sub Merchant (For HK)

        -   Onboarding Sub-merchant：`AddSubMerchant`

        -   Query Sub-merchant：`GetSubMerchant`

        -   Sub Merchant Modifying：`ModifySubMerchant`

-   Multi-Wallet (For HK)

    -   Quick Pay

        -   Quick Pay：`CreateHKTransactionMicroPay` / `CreateHKPartnerTransactionMicroPay`

        -   Query Order：`GetHKTransactionByOutTradeNumber` / `GetHKTransactionById` / `GetHKPartnerTransactionByOutTradeNumber` / `GetHKPartnerTransactionById`

        -   Refund Application：`CreateHKRefund` / `CreateHKPartnerRefund`

        -   Query Single Refund：`GetHKRefundByOutRefundNumber` / `GetHKRefundById` / `GetHKPartnerRefundByOutRefundNumber` / `GetHKPartnerRefundById`

        -   Downloading Reconciliation：`DownloadHKStatements`

        -   Revoke Order：`ReverseHKTransaction` / `ReverseHKPartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QueryHKSettlements`

    -   QR Code Payment

        -   Order Placement：`CreateHKTransactionMicroPay` / `CreateHKPartnerTransactionMicroPay`

        -   Query Order：`GetHKTransactionByOutTradeNumber` / `GetHKTransactionById` / `GetHKPartnerTransactionByOutTradeNumber` / `GetHKPartnerTransactionById`

        -   Refund Application：`CreateHKRefund` / `CreateHKPartnerRefund`

        -   Query Single Refund：`GetHKRefundByOutRefundNumber` / `GetHKRefundById` / `GetHKPartnerRefundByOutRefundNumber` / `GetHKPartnerRefundById`

        -   Downloading Reconciliation：`DownloadHKStatements`

        -   Close Order：`CloseHKTransaction` / `CloseHKPartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QueryHKSettlements`

    -   Mini-Program Payment

        -   Order Placement：`CreateHKTransactionMicroPay` / `CreateHKPartnerTransactionMicroPay`

        -   Query Order：`GetHKTransactionByOutTradeNumber` / `GetHKTransactionById` / `GetHKPartnerTransactionByOutTradeNumber` / `GetHKPartnerTransactionById`

        -   Refund Application：`CreateHKRefund` / `CreateHKPartnerRefund`

        -   Query Single Refund：`GetHKRefundByOutRefundNumber` / `GetHKRefundById` / `GetHKPartnerRefundByOutRefundNumber` / `GetHKPartnerRefundById`

        -   Downloading Reconciliation：`DownloadHKStatements`

        -   Close Order：`CloseHKTransaction` / `CloseHKPartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QueryHKSettlements`

    -   Official Account Payment

        -   Order Placement：`CreateHKTransactionMicroPay` / `CreateHKPartnerTransactionMicroPay`

        -   Query Order：`GetHKTransactionByOutTradeNumber` / `GetHKTransactionById` / `GetHKPartnerTransactionByOutTradeNumber` / `GetHKPartnerTransactionById`

        -   Refund Application：`CreateHKRefund` / `CreateHKPartnerRefund`

        -   Query Single Refund：`GetHKRefundByOutRefundNumber` / `GetHKRefundById` / `GetHKPartnerRefundByOutRefundNumber` / `GetHKPartnerRefundById`

        -   Downloading Reconciliation：`DownloadHKStatements`

        -   Close Order：`CloseHKTransaction` / `CloseHKPartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QueryHKSettlements`

    -   In-App Payment

        -   Order Placement：`CreateHKTransactionMicroPay` / `CreateHKPartnerTransactionMicroPay`

        -   Query Order：`GetHKTransactionByOutTradeNumber` / `GetHKTransactionById` / `GetHKPartnerTransactionByOutTradeNumber` / `GetHKPartnerTransactionById`

        -   Refund Application：`CreateHKRefund` / `CreateHKPartnerRefund`

        -   Query Single Refund：`GetHKRefundByOutRefundNumber` / `GetHKRefundById` / `GetHKPartnerRefundByOutRefundNumber` / `GetHKPartnerRefundById`

        -   Downloading Reconciliation：`DownloadHKStatements`

        -   Close Order：`CloseHKTransaction` / `CloseHKPartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QueryHKSettlements`

    -   H5 Payment

        -   Order Placement：`CreateHKTransactionMicroPay` / `CreateHKPartnerTransactionMicroPay`

        -   Query Order：`GetHKTransactionByOutTradeNumber` / `GetHKTransactionById` / `GetHKPartnerTransactionByOutTradeNumber` / `GetHKPartnerTransactionById`

        -   Refund Application：`CreateHKRefund` / `CreateHKPartnerRefund`

        -   Query Single Refund：`GetHKRefundByOutRefundNumber` / `GetHKRefundById` / `GetHKPartnerRefundByOutRefundNumber` / `GetHKPartnerRefundById`

        -   Downloading Reconciliation：`DownloadHKStatements`

        -   Close Order：`CloseHKTransaction` / `CloseHKPartnerTransaction`

        -   Downloading Platform Certificate：`QueryCertificates`

        -   Query Fund Settlement Details：`QueryHKSettlements`

-   Customs Declaration

    -   Customs Declaration：`CreateCustomsOrder`

    -   Identity Information Verification：`VerifyCustomsCertificate`

    -   Query Customs Declaration：`QueryCustomsOrders`

    -   Repush Customs Declaration：`RedeclareCustomsOrder`

    -   Modify Customs Declaration Info：`ModifyCustomsOrder`

-   Functional APIs

    -   Uploading Image API (For HK)：`UploadMerchantMediaImage`
