using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/setbizattr?action=get_auth_field 接口的请求。</para>
    /// </summary>
    public class CardInvoiceGetAuthFieldRequest : WechatApiRequest, IMapResponse<CardInvoiceGetAuthFieldRequest, CardInvoiceGetAuthFieldResponse>
    {
    }
}
