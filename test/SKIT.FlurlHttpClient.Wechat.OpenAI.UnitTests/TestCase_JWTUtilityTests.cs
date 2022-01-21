using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.UnitTests
{
    public class TestCase_JWTUtilityTests
    {
        [Fact(DisplayName = "测试用例：JWT HS256 编码")]
        public void TestJWTEncodeWithHS256()
        {
            object payload = new
            {
                uid = "xjlsj33lasfaf",
                data = new
                {
                    q = "在微信智言与微信智聆两大技术的支持下，微信AI团队推出了“微信对话开放平台”和“腾讯小微”智能硬件两大核心产品。微信支付团队最新发布的“微信青蛙Pro”在现场设置了体验区，让大家感受AI认脸的本事。"
                }
            };
            string secret = "jWmYm7qr5nMoAUwZRjGtBxmz3KA1tkAj3ykkR6q2B2C";

            string actualJwt = Utilities.JWTUtility.EncodeWithHS256(payload: payload, secret: secret);
            string expectedJwt = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1aWQiOiJ4amxzajMzbGFzZmFmIiwiZGF0YSI6eyJxIjoi5Zyo5b6u5L-h5pm66KiA5LiO5b6u5L-h5pm66IGG5Lik5aSn5oqA5pyv55qE5pSv5oyB5LiL77yM5b6u5L-hQUnlm6LpmJ_mjqjlh7rkuobigJzlvq7kv6Hlr7nor53lvIDmlL7lubPlj7DigJ3lkozigJzohb7orq_lsI_lvq7igJ3mmbrog73noazku7bkuKTlpKfmoLjlv4Pkuqflk4HjgILlvq7kv6HmlK_ku5jlm6LpmJ_mnIDmlrDlj5HluIPnmoTigJzlvq7kv6HpnZLom5lQcm_igJ3lnKjnjrDlnLrorr7nva7kuobkvZPpqozljLrvvIzorqnlpKflrrbmhJ_lj5dBSeiupOiEuOeahOacrOS6i-OAgiJ9fQ.8FeSvxKlIrbI6MCAaWGekB4sHGA8DeUxgVXiHa8ulJk";

            Assert.Equal(expectedJwt, actualJwt, ignoreCase: true);
        }
    }
}
