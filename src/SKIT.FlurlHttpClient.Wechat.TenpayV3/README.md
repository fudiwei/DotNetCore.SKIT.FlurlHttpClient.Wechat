# SKIT.FlurlHttpClient.Wechat.TenpayV3

基于 Flurl.Http 的微信商户平台（微信支付）API v3 客户端 SDK。

## 功能特性

- 封装微信支付 v3 版 API。
- 支持普通商户（直连）、合作伙伴（服务商、渠道商、机构、银行）两种接入模式。
- 请求时自动生成签名（支持国际 RSA 算法或国密 SM 算法），无需开发者手动干预。
- 提供了微信支付所需的 AES、RSA、SM2/SM3/SM4、SHA-256 等算法工具类。
- 提供了调起支付签名、解析响应敏感数据、解析回调通知事件敏感数据等扩展方法。

## 开发文档

请前往[项目主页](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat)查看。
