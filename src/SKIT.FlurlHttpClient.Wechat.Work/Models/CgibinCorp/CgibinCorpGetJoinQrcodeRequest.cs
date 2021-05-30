using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/corp/get_join_qrcode 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGetJoinQrcodeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置二维码尺寸类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? SizeType { get; set; }
    }
}
