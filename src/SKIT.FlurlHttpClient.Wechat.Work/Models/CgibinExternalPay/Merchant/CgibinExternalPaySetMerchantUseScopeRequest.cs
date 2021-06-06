using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalpay/set_mch_use_scope 接口的请求。</para>
    /// </summary>
    public class CgibinExternalPaySetMerchantUseScopeRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class UseScope
            {
                /// <summary>
                /// 获取或设置成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user")]
                [System.Text.Json.Serialization.JsonPropertyName("user")]
                public IList<string>? UserIdList { get; set; }

                /// <summary>
                /// 获取或设置部门 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("partyid")]
                [System.Text.Json.Serialization.JsonPropertyName("partyid")]
                public IList<int>? DepartmentIdList { get; set; }

                /// <summary>
                /// 获取或设置标签 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tagid")]
                [System.Text.Json.Serialization.JsonPropertyName("tagid")]
                public IList<int>? TagIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信支付商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置使用范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_use_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_use_scope")]
        public Types.UseScope UseScope { get; set; } = new Types.UseScope();
    }
}
