using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    public class WechatWorkWxBizMsgCryptorTests
    {
        [Fact(DisplayName = "验签回调数据")]
        public void VerifyEventTest()
        {
            string token = "ovAkP0Tb";
            string reqMsgSig = "8128e41a38892d814e4aa67753425da9dc8ec2b3";
            string reqTimeStamp = "1628737717";
            string reqNonce = "1811081856";
            string reqCipherText = "Q/jUxIL3/jRaFeTKesIr1QSq2SOEApDqlzcRrRM6Jlk4EbMBns3plPOR/W3gThOEq+zYI42fNSoIUb3cQwt9zyD1aLU/7D3WNLute7LQ9LSHjZEfVmx5zcIR9zvrUWGjhe1whTPH4e1WR6vbOYs8o/bDRF0vX/NcE4XK7P83Y6CzQiJoKbjVCne84s0zcw5eh+ZUDB55eaDHPSoS7kAC8kB00pfBoDF0jyfc8CUKLW97e72vJGyUWjZ0BvYN+R+tFjMgEzg/EN1imuuFnf40DMAcvB6y+C97TuaWjpgfRdowGWzn10JAFNukRfQqjdA0e2bfczJ7+t9w/t8/XSMADJOt1xbnP+I5cRX/r7ueBGmG/6ejP3myO9yTXHdujGvwrXHuWw+J7qD4VoUVjbm2vQ1qQKbrweKssr6O+3XSbanZ5R3n26EpN/gfgX+r6rcGViqsFop9Ai9xMnfJUubB6Q==";

            Assert.True(Utilities.WxBizMsgCryptor.VerifySignature(token, reqTimeStamp, reqNonce, reqCipherText, reqMsgSig));
        }
    }
}
