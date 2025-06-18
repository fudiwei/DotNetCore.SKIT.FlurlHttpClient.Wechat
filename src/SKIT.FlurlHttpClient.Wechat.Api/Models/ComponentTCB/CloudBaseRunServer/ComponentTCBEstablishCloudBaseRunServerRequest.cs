using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/establishcloudbaserunserver 接口的请求。</para>
    /// </summary>
    public class ComponentTCBEstablishCloudBaseRunServerRequest : WechatApiRequest, IInferable<ComponentTCBEstablishCloudBaseRunServerRequest, ComponentTCBEstablishCloudBaseRunServerResponse>
    {
        public static class Types
        {
            public class ES
            {
                /// <summary>
                /// 获取或设置 ES ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long ESId { get; set; }

                /// <summary>
                /// 获取或设置 Secret 名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("secret_name")]
                [System.Text.Json.Serialization.JsonPropertyName("secret_name")]
                public string? SecretName { get; set; }

                /// <summary>
                /// 获取或设置 IP 地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ip")]
                [System.Text.Json.Serialization.JsonPropertyName("ip")]
                public string? Ip { get; set; }

                /// <summary>
                /// 获取或设置端口。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("port")]
                [System.Text.Json.Serialization.JsonPropertyName("port")]
                public int? Port { get; set; }

                /// <summary>
                /// 获取或设置索引。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("index")]
                [System.Text.Json.Serialization.JsonPropertyName("index")]
                public string? Index { get; set; }

                /// <summary>
                /// 获取或设置用户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account")]
                [System.Text.Json.Serialization.JsonPropertyName("account")]
                public string? Account { get; set; }

                /// <summary>
                /// 获取或设置密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("password")]
                [System.Text.Json.Serialization.JsonPropertyName("password")]
                public string? Password { get; set; }
            }

            public class VPC
            {
                /// <summary>
                /// 获取或设置服务描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vpc_id")]
                [System.Text.Json.Serialization.JsonPropertyName("vpc_id")]
                public string VPCId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置子网 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subnet_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("subnet_ids")]
                public IList<string>? SubnetIdList { get; set; }

                /// <summary>
                /// 获取或设置创建类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_type")]
                [System.Text.Json.Serialization.JsonPropertyName("create_type")]
                public int CreateType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_id")]
        [System.Text.Json.Serialization.JsonPropertyName("env_id")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_name")]
        [System.Text.Json.Serialization.JsonPropertyName("service_name")]
        public string ServiceName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否开通外网访问。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_public")]
        [System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool IsPublic { get; set; }

        /// <summary>
        /// 获取或设置镜像地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_repo")]
        [System.Text.Json.Serialization.JsonPropertyName("image_repo")]
        public string? ImageRepository { get; set; }

        /// <summary>
        /// 获取或设置服务描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置日志类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_type")]
        [System.Text.Json.Serialization.JsonPropertyName("log_type")]
        public string? LogType { get; set; }

        /// <summary>
        /// 获取或设置 ES 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("es_info")]
        [System.Text.Json.Serialization.JsonPropertyName("es_info")]
        public Types.ES? ES { get; set; }

        /// <summary>
        /// 获取或设置 VPC 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vpc_info")]
        [System.Text.Json.Serialization.JsonPropertyName("vpc_info")]
        public Types.VPC? VPC { get; set; }
    }
}
