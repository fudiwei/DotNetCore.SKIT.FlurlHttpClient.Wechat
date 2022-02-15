using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/setbizattr?action=get_contact 接口的请求。</para>
    /// </summary>
    public class CardInvoiceGetContactRequest : WechatApiRequest, IMapResponse<CardInvoiceGetContactRequest, CardInvoiceGetContactResponse>
    {
    }
}
