# SKIT.FlurlHttpClient.Wechat.Work

基于 `Flurl.Http` 的[企业微信](https://work.weixin.qq.com/) API 客户端。

---

## 功能

-   基于企业微信 API 封装。

-   支持企业内部开发、第三方应用开发（即服务商）、智慧硬件开发（即硬件接入）三种模式。

-   提供了企业微信 API 所需的 SHA-1、AES 等算法工具类。

-   提供了 JS-SDK 签名、解析回调通知事件等扩展方法。

-   完整企业微信 API 一览：

    |     |            微信 API            |         开发模式         |         备注         |
    | :-: | :----------------------------: | :----------------------: | :------------------: |
    |  √  |            基础功能            | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |      通讯录管理：成员管理      | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |      通讯录管理：部门管理      | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |      通讯录管理：标签管理      | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |    通讯录管理：异步批量接口    | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |      通讯录管理：互联企业      |           企业           |                      |
    |  √  |     通讯录管理：通讯录搜索     |          服务商          |                      |
    |  √  |   通讯录管理：通讯录 ID 转译   |          服务商          |                      |
    |  √  |   客户联系：企业服务人员管理   |      企业 & 服务商       |                      |
    |  √  |       客户联系：客户管理       |      企业 & 服务商       |                      |
    |  √  |     客户联系：客户标签管理     |      企业 & 服务商       |                      |
    |  √  |       客户联系：在职继承       |      企业 & 服务商       |                      |
    |  √  |       客户联系：离职继承       |      企业 & 服务商       |                      |
    |  √  |      客户联系：客户群管理      |      企业 & 服务商       |                      |
    |  √  |      客户联系：客户朋友圈      |      企业 & 服务商       |                      |
    |  √  |       客户联系：消息推送       |      企业 & 服务商       |                      |
    |  √  |       客户联系：统计管理       |      企业 & 服务商       |                      |
    |  √  |     身份验证：网页授权登录     | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |     身份验证：扫码授权登录     | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |    应用管理：获取或设置应用    | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |      应用管理：自定义菜单      |           企业           |                      |
    |  √  |     应用管理：自定义工作台     |           企业           |                      |
    |  √  |     消息推送：发送应用消息     | 企业 & 服务商 & 硬件接入 |                      |
    |  √  | 消息推送：更新任务卡片消息状态 |      企业 & 服务商       |                      |
    |  √  |  消息推送：发送消息到群聊会话  |           企业           |                      |
    |  √  |   消息推送：互联企业消息推送   |           企业           |                      |
    |  √  |     消息推送：家校消息推送     |           企业           |                      |
    |  √  | 消息推送：查询应用消息发送统计 |      企业 & 服务商       |                      |
    |  √  |            素材管理            | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |            OA：打卡            |      企业 & 服务商       |                      |
    |  √  |            OA：审批            |      企业 & 服务商       |                      |
    |  √  |            OA：汇报            |      企业 & 服务商       |                      |
    |  √  |        OA：审批流程引擎        | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |           OA：会议室           |           企业           |                      |
    |  √  |          OA：紧急通知          |           企业           |                      |
    |  √  |         效率工具：日程         |      企业 & 服务商       |                      |
    |  √  |         效率工具：会议         |      企业 & 服务商       |                      |
    |  √  |         效率工具：直播         |      企业 & 服务商       |                      |
    |  √  |         效率工具：微盘         |           企业           |                      |
    |  √  |       效率工具：公费电话       |           企业           |                      |
    |  ×  | <del>企业支付：企业红包</del>  |     <del>企业</del>      | 异构协议，需独立模块 |
    |  ×  | <del>企业支付：员工付款</del>  |     <del>企业</del>      | 异构协议，需独立模块 |
    |  √  |       企业支付：员工收款       |           企业           |                      |
    |  √  |       企业支付：对外收款       |      企业 & 服务商       |                      |
    |  √  |            企业互联            |      企业 & 服务商       |                      |
    |  √  |          会话内容存档          |           企业           |                      |
    |  √  |            电子发票            | 企业 & 服务商 & 硬件接入 |                      |
    |  √  |       家校沟通：基础接口       |      企业 & 服务商       |                      |
    |  √  |     家校沟通：网页授权登录     |      企业 & 服务商       |                      |
    |  √  |    家校沟通：学生与家长管理    |      企业 & 服务商       |                      |
    |  √  |       家校沟通：部门管理       |      企业 & 服务商       |                      |
    |  √  |       家校应用：健康上报       |           企业           |                      |
    |  √  |        家校应用：复学码        |           企业           |                      |
    |  √  |       家校应用：上课直播       |      企业 & 服务商       |                      |
    |  √  |     政民沟通：配置服务网格     |           企业           |                      |
    |  √  |     政民沟通：配置事件类别     |           企业           |                      |
    |  √  |       政民沟通：巡查上报       |           企业           |                      |
    |  √  |       政民沟通：居民上报       |           企业           |                      |
    |  √  |            应用授权            |    服务商 & 硬件接入     |                      |
    |  √  |           推广二维码           |    服务商 & 硬件接入     |                      |
    |  √  |            设备管理            |         硬件接入         |                      |

---

## 基础用法

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Wechat.Work

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Wechat.Work
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Wechat;
using SKIT.FlurlHttpClient.Wechat.Work;

var options = new WechatWorkClientOptions()
{
    CorpId = "企业微信 CorpId",
    AgentId = "企业微信应用的 AgentId",
    AgentSecret = "企业微信应用的 AgentId"
};
var client = new WechatWorkClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.Work;
using SKIT.FlurlHttpClient.Wechat.Work.Models;

/* 以获取用户信息接口为例 */
var request = new CgibinUserGetRequest()
{
    AccessToken = "企业微信应用的 AccessToken",
    UserId = "企业成员账号"
};
var response = await client.ExecuteCgibinUserGetAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("名称：" + response.Name);
    Console.WriteLine("头像：" + response.AvatarUrl);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何解析回调通知事件？](./Advanced_EventDataDeserialization.md)

-   [如何生成 JS-SDK 初始化时所需的参数及签名？](./Advanced_JSSDK.md)

-   [如何扩展额外的 API？](./Advanced_Extensions.md)
