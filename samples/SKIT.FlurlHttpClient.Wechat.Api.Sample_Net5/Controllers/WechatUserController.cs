using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SKIT.FlurlHttpClient.Wechat.Api;
using SKIT.FlurlHttpClient.Wechat.Api.Models;

namespace SKIT.FlurlHttpClient.Wechat.Api.Sample_Net5.Controllers
{
    [ApiController]
    [Route("user")]
    public class WechatUserController : ControllerBase
    {
        private readonly ILogger _logger;

        private readonly Services.Repositories.IWechatAccessTokenEntityRepository _wechatAccessTokenEntityRepository;

        private readonly Services.HttpClients.IWechatApiHttpClientFactory _wechatApiHttpClientFactory;

        public WechatUserController(
            ILoggerFactory loggerFactory,
            Services.Repositories.IWechatAccessTokenEntityRepository wechatAccessTokenEntityRepository,
            Services.HttpClients.IWechatApiHttpClientFactory wechatApiHttpClientFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _wechatAccessTokenEntityRepository = wechatAccessTokenEntityRepository;
            _wechatApiHttpClientFactory = wechatApiHttpClientFactory;
        }

        [HttpGet]
        [Route("info")]
        public async Task<IActionResult> GetUserInfoByOpenId(
            [FromQuery(Name = "app_id")] string appId,
            [FromQuery(Name = "open_id")] string openId)
        {
            // 获取用户基本信息
            // 文档：https://developers.weixin.qq.com/doc/offiaccount/User_Management/Get_users_basic_information_UnionID.html#UinonId

            var entity = _wechatAccessTokenEntityRepository.FirstOrDefault(e => e.AppId == appId);
            var client = _wechatApiHttpClientFactory.Create(appId);
            var request = new CgibinUserInfoRequest() { AccessToken = entity?.AccessToken, OpenId = openId };
            var response = await client.ExecuteCgibinUserInfoAsync(request, cancellationToken: HttpContext.RequestAborted);
            if (!response.IsSuccessful())
            {
                _logger.LogWarning(
                    "获取用户基本信息失败（状态码：{0}，错误代码：{1}，错误描述：{2}）。",
                    response.RawStatus, response.ErrorCode, response.ErrorMessage
                );
            }

            return new JsonResult(response);
        }
    }
}
