using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/applyments/{applyment_id} 接口的请求。</para>
    /// </summary>
    public class GetEcommerceApplymentByApplymentIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置申请单编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long ApplymentId { get; set; }
    }
}
