# SKIT.FlurlHttpClient.Wechat.Api

[![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.Wechat.Api.svg?sanitize=true)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Api)
[![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.Wechat.Api.svg?sanitize=true)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Wechat.Api)
[![GitHub License](https://img.shields.io/github/license/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/blob/main/LICENSE)

基于 `Flurl.Http` 的微信公众平台 & 开放平台 API 客户端。

---

## 功能

-   基于微信公众平台 & 开放平台 API 封装。

-   提供了微信公众平台 & 开放平台 API 所需的 SHA-1、HMAC-SHA-256、AES 等算法工具类。

-   提供了 JS-SDK 签名、解析回调通知事件等扩展方法。

-   完整微信公众平台 & 开放平台 API 一览：

    |     |           微信 API            |         所属平台         |               备注               |
    | :-: | :---------------------------: | :----------------------: | :------------------------------: |
    |  √  |           基础功能            | 公众号 & 小程序 & 小游戏 |                                  |
    |  √  |          自定义菜单           |          公众号          |                                  |
    |  √  |         基础消息能力          |          公众号          |                                  |
    |  √  |           客服消息            |          公众号          |                                  |
    |  √  |         微信网页开发          |          公众号          |                                  |
    |  √  |           素材管理            |          公众号          |                                  |
    |  √  |       图文消息留言管理        |          公众号          |                                  |
    |  √  |           用户管理            |          公众号          |                                  |
    |  √  |           账号管理            |          公众号          |                                  |
    |  √  |           数据统计            |          公众号          |                                  |
    |  √  |           微信卡券            |          公众号          |                                  |
    |  √  |           微信门店            |          公众号          |                                  |
    |  √  |           微信小店            |          公众号          |                                  |
    |  √  |           智能接口            |          公众号          |                                  |
    |  ×  |    <del>微信设备功能</del>    |    <del>公众号</del>     | 与其他协议不一致，需提供单独模块 |
    |  √  |         微信一物一码          |          公众号          |                                  |
    |  √  |           微信发票            |          公众号          |                                  |
    |  √  |         微信非税缴费          |          公众号          |                                  |
    |  √  |           订阅通知            | 公众号 & 小程序 & 小游戏 |                                  |
    |  √  |             登录              |     小程序 & 小游戏      |                                  |
    |  √  |           用户信息            |     小程序 & 小游戏      |                                  |
    |  √  |           数据分析            |     小程序 & 小游戏      |                                  |
    |  √  |           动态消息            |     小程序 & 小游戏      |                                  |
    |  √  |           客服消息            | 小程序 & 小游戏 & 小商店 |                                  |
    |  √  |           插件管理            |          小程序          |                                  |
    |  √  |         附近的小程序          |          小程序          |                                  |
    |  √  |          URL Scheme           |          小程序          |                                  |
    |  √  |           URL Link            |          小程序          |                                  |
    |  ×  |        <del>广告</del>        |    <del>小程序</del>     | 与其他协议不一致，需提供单独模块 |
    |  √  |           图像处理            |          小程序          |                                  |
    |  √  |           即时配送            |          小程序          |                                  |
    |  √  |           物流助手            |          小程序          |                                  |
    |  √  |              OCR              |          小程序          |                                  |
    |  √  |           运维中心            |          小程序          |                                  |
    |  √  |          小程序搜索           |          小程序          |                                  |
    |  √  |           服务市场            |          小程序          |                                  |
    |  √  |           生物认证            |          小程序          |                                  |
    |  ×  |   <del>行业能力乘车码</del>   |    <del>小程序</del>     |             _开发中_             |
    |  ×  |      <del>城市服务</del>      |    <del>小程序</del>     |             _开发中_             |
    |  √  |           虚拟支付            |          小游戏          |                                  |
    |  √  |           开放数据            |          小游戏          |                                  |
    |  √  |           对局匹配            |          小游戏          |                                  |
    |  √  |            帧同步             |          小游戏          |                                  |
    |  √  |           小程序码            |     小程序 & 小游戏      |                                  |
    |  √  |           内容安全            |     小程序 & 小游戏      |                                  |
    |  √  |            云开发             |     小程序 & 小游戏      |                                  |
    |  √  |           安全风控            |     小程序 & 小游戏      |                                  |
    |  √  |             直播              |     小程序 & 小商店      |                                  |
    |  √  |             开店              |          小商店          |                                  |
    |  √  |           服务市场            |          小商店          |                                  |
    |  √  |           装修服务            |          小商店          |                                  |
    |  √  |           SPU 管理            |          小商店          |                                  |
    |  √  |           SKU 管理            |          小商店          |                                  |
    |  √  |           订单管理            |          小商店          |                                  |
    |  √  |           物流管理            |          小商店          |                                  |
    |  √  |         配送方式管理          |          小商店          |                                  |
    |  √  |         运费模板管理          |          小商店          |                                  |
    |  √  |       线下配送模板管理        |          小商店          |                                  |
    |  √  |          优惠券管理           |          小商店          |                                  |
    |  √  |           店铺管理            |          小商店          |                                  |
    |  √  |         商家地址管理          |          小商店          |                                  |
    |  ×  |   <del>自定义交易组件</del>   |    <del>小商店</del>     |             _开发中_             |
    |  √  |          小程序联盟           |          小商店          |                                  |
    |  √  |         微信登录功能          |         开放平台         |                                  |
    |  √  |        一次性订阅消息         |         开放平台         |                                  |
    |  √  |        小程序硬件框架         |         开放平台         |                                  |
    |  √  |         开放平台接口          |         开放平台         |                                  |
    |  ×  |  <del>代商家注册小程序</del>  |         开放平台         |             _开发中_             |
    |  ×  |     <del>试用小程序</del>     |         开放平台         |             _开发中_             |
    |  √  |           授权相关            |         开放平台         |                                  |
    |  √  |        授权方账号管理         |         开放平台         |                                  |
    |  ×  |   <del>小程序模板管理</del>   |         开放平台         |             _开发中_             |
    |  ×  | <del>小程序基础信息管理</del> |         开放平台         |             _开发中_             |
    |  ×  |   <del>小程序类目管理</del>   |         开放平台         |             _开发中_             |
    |  ×  |   <del>小程序成员管理</del>   |         开放平台         |             _开发中_             |
    |  ×  |   <del>小程序代码管理</del>   |         开放平台         |             _开发中_             |
    |  ×  |   <del>违规和申诉管理</del>   |         开放平台         |             _开发中_             |
    |  ×  |    <del>扫码关注组件</del>    |         开放平台         |             _开发中_             |
    |  √  |   普通链接二维码与小程序码    |         开放平台         |                                  |
    |  √  |        其他小程序业务         |         开放平台         |                                  |
    |  ×  |     <del>公众号业务</del>     |         开放平台         |             _开发中_             |
    |  ×  |       <del>云开发</del>       |         开放平台         |             _开发中_             |

---

## 基础用法

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Wechat.Api

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Wechat.Api
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Wechat;
using SKIT.FlurlHttpClient.Wechat.Api;

var options = new WechatApiClientOptions()
{
    AppId = "微信 AppId",
    AppSecret = "微信 AppSecret",
    MidasAppKey = "米大师相关服务 AppKey",
    ImmeDeliveryAppKey = "即时配送相关服务 AppKey",
    ImmeDeliveryAppSecret = "即时配送相关服务 AppSecret"
};
var client = new WechatApiClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.Api;
using SKIT.FlurlHttpClient.Wechat.Api.Models;

/* 示例：获取用户信息 */
var request = new CgibinUserInfoRequest()
{
    AccessToken = "微信 AccessToken",
    OpenId = "微信 OpenId"
};
var response = await client.ExecuteCgibinUserInfoAsync(request);
```

---

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何解析回调通知事件？](./Advanced_EventDataDeserialization.md)

-   [如何生成 JS-SDK 初始化时所需的参数及签名？](./Advanced_JSSDK.md)
