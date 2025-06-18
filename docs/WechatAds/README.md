# SKIT.FlurlHttpClient.Wechat.Ads

基于 `Flurl.Http` 的[微信广告平台](https://ad.weixin.qq.com/) HTTP API SDK。

需要注意的是，微信广告平台是腾讯广点通的独立业务，请开发者阅读相关文档时注意与广点通本身的 API 区分。

---

## 功能

-   基于微信广告平台 API 封装。
-   请求时自动生成服务商身份令牌，无需开发者手动干预。
-   提供了微信广告平台所需的 MD5 等算法工具类。

---

## 快速入门

> [!IMPORTANT]
> 此目录下的文档适用于 v3.x 版本的模块。如果你正在使用 2.x 版本，请移步至 GitHub/Gitee 的已归档分支。

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Wechat.Ads

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Wechat.Ads
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Wechat;
using SKIT.FlurlHttpClient.Wechat.Ads;

var options = new WechatAdsClientOptions()
{
    AgencyId = "广告服务商 ID",
    AgencyAppId = "广告服务商 AppId",
    AgencyApiKey = "广告服务商 ApiKey"
};
var client = WechatAdsClientBuilder.Create(options).Build();
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.Ads;
using SKIT.FlurlHttpClient.Wechat.Ads.Models;

/* 以创建推广计划接口为例 */
var request = new CampaignsAddRequest()
{
    AccessToken = "广告主的 AccessToken",
    CampaignType = "CAMPAIGN_TYPE_WECHAT_OFFICIAL_ACCOUNTS",
    ProductType = "PRODUCT_TYPE_LINK_WECHAT"
};
var response = await client.ExecuteCampaignsAddAsync(request);
```

---

## 基础用法

-   ⭐ [如何快速找到需要调用的 API 模型类名 / 方法名？](./Basic_ModelDefinition.md)

-   [如何获取接口调用凭据（即 AccessToken）？](./Basic_AccessToken.md)

---

## 高级技巧

-   [配置 JSON 序列化器](./Advanced_JsonSerializer.md)

-   [配置 HttpClient](./Advanced_HttpClient.md)

-   [使用拦截器](./Advanced_Interceptor.md)

-   [避免内存泄漏](./Advanced_Dispose.md)

-   [与 `IHttpClientFactory` 集成](./Advanced_HttpClientFactory.md)
