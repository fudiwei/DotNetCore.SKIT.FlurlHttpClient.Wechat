﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    public interface IMapResponse<TRequest, TResponse>
    where TRequest : WechatApiRequest
    where TResponse : WechatApiResponse
    {
    }

}
