using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_moment_customer_list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetMomentCustomerListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Customer
            {
                /// <summary>
                /// 获取或设置发布者成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置可见的外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置可见的客户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_list")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_list")]
        public Types.Customer[] CustomerList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
