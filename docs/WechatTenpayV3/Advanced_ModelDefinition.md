### 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，发起退款的请求是 `CreateRefundDomesticRefundRequest`，响应是 `CreateRefundDomesticRefundResponse`，接口是 `CreateRefundDomesticRefundAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的发起退款，它的接口地址是 `[POST] /refund/domestic/refunds`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

另外，以 `Query` 开头的一般表示列表查询；以 `Get` 开头的一般表示获取详情；以 `Create` 开头的一般表示发起或新建操作；以 `Update`、`Modify` 开头的一般表示修改操作；以 `Set` 开头的一般表示设置操作。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.Wechat.TenpayV3/Models_ 目录。

---

【附 1】直连商户模式 API 模型命名速查表：

注：树形结构与[微信支付开发者文档](https://pay.weixin.qq.com/wiki/doc/apiv3/apis/index.shtml)目录结构保持一致。

<details>

<summary>展开</summary>

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

-   行业方案

    -   智慧商圈

        -   商圈积分同步：`NotifyBusinessCirclePoints`

        -   商圈积分授权查询：`GetBusinessCircleUserAuthorizationByOpenId`

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

    -   图片上传（营销专用）：`UploadMarketingMediaImage`

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

-   其他能力

    -   图片上传：`UploadMerchantMediaImage`

    -   视频上传：`UploadMerchantMediaVideo`

</details>

---

【附 2】服务商模式 API 模型命名速查表：

注：树形结构与[微信支付开发者文档](https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/index.shtml)目录结构保持一致。

<details>

<summary>展开</summary>

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

        -   下载账单：`DownloadBillFile`

    -   APP 支付

        -   统一下单：`CreatePayPartnerTransactionApp`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   H5 支付

        -   统一下单：`CreatePayPartnerTransactionH5`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   Native 支付

        -   统一下单：`CreatePayPartnerTransactionNative`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

        -   申请退款：`CreateRefundDomesticRefund`

        -   查询单笔退款：`GetRefundDomesticRefundByOutRefundNumber`

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   小程序支付

        -   统一下单：`CreatePayPartnerTransactionJsapi`

        -   查询订单：`GetPayPartnerTransactionById` / `GetPayPartnerTransactionByOutTradeNumber`

        -   关闭订单：`ClosePayPartnerTransaction`

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

    -   电商收付通（下载账单）

        -   申请交易账单：`GetBillTradeBill`

        -   申请资金账单：`GetBillFundflowBill`

        -   申请二级商户资金账单：`GetEcommerceBillFundflowBill`

        -   下载账单：`DownloadBillFile`

    -   智慧商圈

        -   商圈积分同步：`NotifyBusinessCirclePoints`

        -   商圈积分授权查询：`GetBusinessCircleUserAuthorizationByOpenId`

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

    -   图片上传（营销专用）：`UploadMarketingMediaImage`

-   资金应用

    -   连锁品牌分账

        -   请求分账：`CreateBrandProfitSharingOrder`

        -   查询分账结果：`GetBrandProfitSharingOrderByOutOrderNumber`

        -   请求分账回退：`CreateBrandProfitSharingReturnOrder`

        -   查询分账回退结果：`GetBrandProfitSharingReturnOrderByOrderId` / `GetBrandProfitSharingReturnOrderByOutOrderNumber`

        -   完结分账：`SetBrandProfitSharingOrderFinish`

        -   查询订单剩余待分金额：`GetBrandProfitSharingOrderAmounts`

        -   查询最大分账比例：`GetBrandProfitBrandConfigs`

        -   添加分账接收方：`AddBrandProfitSharingReceiver`

        -   删除分账接收方：`DeleteBrandProfitSharingReceiver`

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

-   其他能力

    -   图片上传：`UploadMerchantMediaImage`

    -   视频上传：`UploadMerchantMediaVideo`

</details>
