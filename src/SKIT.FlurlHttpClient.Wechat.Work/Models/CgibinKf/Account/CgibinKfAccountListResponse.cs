namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/account/list 接口的响应。</para>
    /// </summary>
    public class CgibinKfAccountListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class KfAccount
            {
                /// <summary>
                /// 获取或设置客服账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_kfid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_kfid")]
                public string OpenKfId { get; set; } = default!;

                /// <summary>
                /// 获取或设置客服名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                public string AvatarUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否有该管理权限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manage_privilege")]
                [System.Text.Json.Serialization.JsonPropertyName("manage_privilege")]
                public bool HasManagePivilege { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客服账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_list")]
        [System.Text.Json.Serialization.JsonPropertyName("account_list")]
        public Types.KfAccount[] KfAccountList { get; set; } = default!;
    }
}
