namespace SKIT.FlurlHttpClient.Wechat.Api.UnitTests.TestCases.Utils
{
    public class TestCase_WxMsgCryptorTests
    {
        [Fact(DisplayName = "测试用例：工具类 `WxMsgCryptor.AESDecrypt`")]
        public void TestVerifyAndDecryptEvent()
        {
            const string encodingAESKey = "jWmYm7qr5nMoAUwZRjGtBxmz3KA1tkAj3ykkR6q2B2C";
            const string cipherText = "RypEvHKD8QQKFhvQ6QleEB4J58tiPdvo+rtK1I9qca6aM/wvqnLSV5zEPeusUiX5L5X/0lWfrf0QADHHhGd3QczcdCUpj911L3vg3W/sYYvuJTs3TUUkSUXxaccAS0qhxchrRYt66wiSpGLYL42aM6A8dTT+6k4aSknmPj48kzJs8qLjvd4Xgpue06DOdnLxAUHzM6+kDZ+HMZfJYuR+LtwGc2hgf5gsijff0ekUNXZiqATP7PF5mZxZ3Izoun1s4zG4LUMnvw2r+KqCKIw+3IQH03v+BCA9nMELNqbSf6tiWSrXJB3LAVGUcallcrw8V2t9EL4EhzJWrQUax5wLVMNS0+rUPA3k22Ncx4XXZS9o0MBH27Bo6BpNelZpS+/uh9KsNlY6bHCmJU9p8g7m3fVKn28H3KDYA5Pl/T8Z1ptDAVe0lXdQ2YoyyH2uyPIGHBZZIs2pDBS8R07+qN+E7Q==";

            string expectedPlainText = "<xml><ToUserName><![CDATA[wx5823bf96d3bd56c7]]></ToUserName>\n<FromUserName><![CDATA[mycreate]]></FromUserName>\n<CreateTime>1409659813</CreateTime>\n<MsgType><![CDATA[text]]></MsgType>\n<Content><![CDATA[hello]]></Content>\n<MsgId>4561255354251345929</MsgId>\n<AgentID>218</AgentID>\n</xml>";
            string actualPlainText = Utilities.WxMsgCryptor.AESDecrypt(cipherText, encodingAESKey, out string appId);
            Assert.Equal(expectedPlainText, actualPlainText);
            Assert.Equal("wx5823bf96d3bd56c7", appId);
        }

        [Fact(DisplayName = "测试用例：工具类 `WxMsgCryptor.VerifySignature`")]
        public void TestVerifyEvent()
        {
            const string token = "ovAkP0Tb";
            const string timeStamp = "1628737717";
            const string nonce = "1811081856";
            const string cipherText = "Q/jUxIL3/jRaFeTKesIr1QSq2SOEApDqlzcRrRM6Jlk4EbMBns3plPOR/W3gThOEq+zYI42fNSoIUb3cQwt9zyD1aLU/7D3WNLute7LQ9LSHjZEfVmx5zcIR9zvrUWGjhe1whTPH4e1WR6vbOYs8o/bDRF0vX/NcE4XK7P83Y6CzQiJoKbjVCne84s0zcw5eh+ZUDB55eaDHPSoS7kAC8kB00pfBoDF0jyfc8CUKLW97e72vJGyUWjZ0BvYN+R+tFjMgEzg/EN1imuuFnf40DMAcvB6y+C97TuaWjpgfRdowGWzn10JAFNukRfQqjdA0e2bfczJ7+t9w/t8/XSMADJOt1xbnP+I5cRX/r7ueBGmG/6ejP3myO9yTXHdujGvwrXHuWw+J7qD4VoUVjbm2vQ1qQKbrweKssr6O+3XSbanZ5R3n26EpN/gfgX+r6rcGViqsFop9Ai9xMnfJUubB6Q==";
            const string msgSig = "8128e41a38892d814e4aa67753425da9dc8ec2b3";

            Assert.True(Utilities.WxMsgCryptor.VerifySignature(token, timeStamp, nonce, cipherText, msgSig));
        }
    }
}
