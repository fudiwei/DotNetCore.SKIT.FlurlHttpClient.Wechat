namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/user/get 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolUserGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Student : CgibinSchoolUserListResponse.Types.__zz__Student
            {
                public static class Types
                {
                    public class Parent : CgibinSchoolUserListResponse.Types.Student.Types.Parent
                    {
                    }
                }

                /// <summary>
                /// 获取或设置学生的家长列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parents")]
                [System.Text.Json.Serialization.JsonPropertyName("parents")]
                public List<Types.Parent>? Parents { get; set; }
            }

            public class Parent : CgibinSchoolUserListParentResponse.Types.__zz__Parent
            {
                public static class Types
                {
                    public class Child : CgibinSchoolUserListParentResponse.Types.Parent.Types.Child
                    {
                    }
                }

                /// <summary>
                /// 获取或设置家长的孩子列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("children")]
                [System.Text.Json.Serialization.JsonPropertyName("children")]
                public List<Types.Child>? Children { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_type")]
        [System.Text.Json.Serialization.JsonPropertyName("user_type")]
        public int UserType { get; set; }

        /// <summary>
        /// 获取或设置学生信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("student")]
        [System.Text.Json.Serialization.JsonPropertyName("student")]
        public Types.Student? Student { get; set; }

        /// <summary>
        /// 获取或设置家长信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent")]
        [System.Text.Json.Serialization.JsonPropertyName("parent")]
        public Types.Parent? Parent { get; set; }
    }
}
