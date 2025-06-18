using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/store/classification/tree/set 接口的请求。</para>
    /// </summary>
    public class ChannelsECStoreClassificationTreeSetRequest : WechatApiRequest, IInferable<ChannelsECStoreClassificationTreeSetRequest, ChannelsECStoreClassificationTreeSetResponse>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ClassificationTree
                    {
                        /// <summary>
                        /// 获取或设置一级分类节点信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level_1")]
                        [System.Text.Json.Serialization.JsonPropertyName("level_1")]
                        public IList<Level1ClassificationTreeNode> Level1Nodes { get; set; } = new List<Level1ClassificationTreeNode>();
                    }

                    public abstract class ClassificationTreeNode
                    {
                        /// <summary>
                        /// 获取或设置分类 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public long Id { get; set; }

                        /// <summary>
                        /// 获取或设置分类名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置是否在用户端展示。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_displayed")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_displayed")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool IsDisplayed { get; set; }
                    }

                    public class Level1ClassificationTreeNode : ClassificationTreeNode
                    {
                        /// <summary>
                        /// 获取或设置二级分类节点信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level_2")]
                        [System.Text.Json.Serialization.JsonPropertyName("level_2")]
                        public IList<Level2ClassificationTreeNode> Level2Nodes { get; set; } = new List<Level2ClassificationTreeNode>();
                    }

                    public class Level2ClassificationTreeNode : ClassificationTreeNode
                    {
                    }
                }

                /// <summary>
                /// 获取或设置版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("version")]
                [System.Text.Json.Serialization.JsonPropertyName("version")]
                public int Version { get; set; }

                /// <summary>
                /// 获取或设置分类树形结构数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tree")]
                [System.Text.Json.Serialization.JsonPropertyName("tree")]
                public Types.ClassificationTree ClassificationTree { get; set; } = new Types.ClassificationTree();

                /// <summary>
                /// 获取或设置清空关联的分类 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("classification_id_deleted")]
                [System.Text.Json.Serialization.JsonPropertyName("classification_id_deleted")]
                public IList<string> DeletedClassificationIdList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置请求数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req")]
        [System.Text.Json.Serialization.JsonPropertyName("req")]
        public Types.Data Data { get; set; } = new Types.Data();
    }
}
