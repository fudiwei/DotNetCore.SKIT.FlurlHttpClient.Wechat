using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_strategy/edit 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactCustomerStrategyEditRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Privilege : CgibinExternalContactCustomerStrategyCreateRequest.Types.Privilege
            {
            }

            public class Range : CgibinExternalContactCustomerStrategyCreateRequest.Types.Range
            {
            }
        }

        /// <summary>
        /// 获取或设置规则组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strategy_id")]
        [System.Text.Json.Serialization.JsonPropertyName("strategy_id")]
        public int StrategyId { get; set; }

        /// <summary>
        /// 获取或设置规则组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strategy_name")]
        [System.Text.Json.Serialization.JsonPropertyName("strategy_name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置管理员 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admin_list")]
        [System.Text.Json.Serialization.JsonPropertyName("admin_list")]
        public IList<string>? AdminUserIdList { get; set; }

        /// <summary>
        /// 获取或设置权限信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("privilege")]
        [System.Text.Json.Serialization.JsonPropertyName("privilege")]
        public Types.Privilege? Privilege { get; set; }

        /// <summary>
        /// 获取或设置要添加的规则组范围列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("range_add")]
        [System.Text.Json.Serialization.JsonPropertyName("range_add")]
        public IList<Types.Range>? AddRangeList { get; set; }

        /// <summary>
        /// 获取或设置要删除的规则组范围列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("range_del")]
        [System.Text.Json.Serialization.JsonPropertyName("range_del")]
        public IList<Types.Range>? DeleteRangeList { get; set; }
    }
}
