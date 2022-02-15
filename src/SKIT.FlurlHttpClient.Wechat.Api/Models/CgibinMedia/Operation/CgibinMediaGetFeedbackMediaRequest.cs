using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/media/getfeedbackmedia 接口的请求。</para>
    /// </summary>
    public class CgibinMediaGetFeedbackMediaRequest : CgibinMediaGetRequest, IMapResponse<CgibinMediaGetFeedbackMediaRequest, CgibinMediaGetFeedbackMediaResponse>
    {
        /// <summary>
        /// 获取或设置反馈 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RecordId { get; set; }
    }
}
