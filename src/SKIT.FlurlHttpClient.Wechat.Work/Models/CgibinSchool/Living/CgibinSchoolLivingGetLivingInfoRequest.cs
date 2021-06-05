using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/living/get_living_info 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolLivingGetLivingInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string LivingId { get; set; } = string.Empty;
    }
}
