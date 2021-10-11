using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [GET] /v1/openapi/get_detail 接口的响应。</para>
    /// </summary>
    public class OpenApiGetDetailResponse : WechatOpenAIThirdPartyResponse<OpenApiGetDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : OpenApiCreateResponse.Types.Data
            {
            }
        }
    }
}
