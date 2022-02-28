using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/img/aicrop 接口的请求。</para>
    /// </summary>
    public class CVImageAICropRequest : CVImageQrcodeRequest, IInferable<CVImageAICropRequest, CVImageAICropResponse>
    {
        /// <summary>
        /// 获取或设置裁剪宽高比列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<double>? RatioList { get; set; }
    }
}
