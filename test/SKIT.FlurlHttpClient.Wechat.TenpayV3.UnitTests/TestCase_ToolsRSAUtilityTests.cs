using System;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    using SKIT.FlurlHttpClient.Primitives;

    public class TestCase_ToolsRSAUtilityTests
    {
        // 此处测试的 RSA 证书/公钥/私钥是自签名生成的，仅供执行 RSA 相关的单元测试，不能用于调用微信支付 API。
        private const string RSA_CERT_SN = "3050f72e2dce03e7efe49557dd231d176649afbd";
        private const string RSA_CERT_START_DATE = "2021-11-26 02:37:48";
        private const string RSA_CERT_END_DATE = "2021-12-26 02:37:48";
        private const string RSA_PEM_CERTIFICATE = "-----BEGIN CERTIFICATE-----\nMIIFRzCCAy8CFDBQ9y4tzgPn7+SVV90jHRdmSa+9MA0GCSqGSIb3DQEBCwUAMGAx\nCzAJBgNVBAYTAkNOMREwDwYDVQQIDAhTaGFuZ2hhaTERMA8GA1UEBwwIU2hhbmdo\nYWkxDTALBgNVBAoMBFNLSVQxDTALBgNVBAsMBFNLSVQxDTALBgNVBAMMBFNLSVQw\nHhcNMjExMTI1MTgzNzQ4WhcNMjExMjI1MTgzNzQ4WjBgMQswCQYDVQQGEwJDTjER\nMA8GA1UECAwIU2hhbmdoYWkxETAPBgNVBAcMCFNoYW5naGFpMQ0wCwYDVQQKDART\nS0lUMQ0wCwYDVQQLDARTS0lUMQ0wCwYDVQQDDARTS0lUMIICIjANBgkqhkiG9w0B\nAQEFAAOCAg8AMIICCgKCAgEA52DszUZzPKPo1d9Hi5Hjlu7OINwADaeXifA4rvmJ\nJaA+jm4DCMwrAMzyS12EiW31xCAF8LZ/xkrFHO5CZgvK87Y+kY9DmhvNX6FVYsn4\nay7KER0zo87zqQjC+njUu1rYuKnio7MYb354PitwQ3SWNv2qTCbCNCXTN9pJXNhl\nCudWCEWrNrYc4/hKz3bqu1DjpY0oHuuKPk/iRr2TTUIAwahNkNQheQNB2a8hL7L2\nOG1Sn1vaDWe+5RJYlMRZ3NgYDTqoy8GMs+6q091MQMDlQ90jtW/JEoM5DUyI8zfQ\nfDLGnU7FuY0rrZ/+6OQT/o7ISf0OR5TISS0lqnDN3vVaph0ftDGRdGqJk2SJAHIo\nxp5gt410rfWS9kpSDFJs3Pvt4rtNZBYvkGD8obSm91brAkoX4+u1Y4p1qZpWJ4LI\nKw8oyeieqlLZtF/VGKOtKxe/IKn8GwoQJLx4dUGFOqM7HPwR9cyjMaC1o3V1NQG+\n1wD9TLtGh3WXUFJRYDmePaSp39GFPupTMlPRbD0RK80B6xv2rYTyYyd8s2LN6P6H\nh/nFIkc1rekIf9JhPy0WKzrXdmnfjSHKPxmz0WSYN8FxKasqcJhncOdhLTzzVEhj\n9xHSI8ejP2fJ4v+ARoD3GURPD9H7KMa7xmzRSAZ8A8LM3uvdJNhbKBwWqvo45ncz\n+7cCAwEAATANBgkqhkiG9w0BAQsFAAOCAgEAVTS6oMfDA3XTwEel0BvaXMCdo7yM\ns5ueM87151eywnPlConYDXeqhfF0OCSBnY2g7Fpmn+YAUoa/L+FNOx/gMC9QV/lP\nHhhAcWpiCRy52RX/IyTDxFD6OqtH0BaBtDTb+QBXZuFypMUkPy6EUYs5Cl9qYepy\nHcgGVomx7tcwWcvI4o/KZtj8hXC5wu/k4Y0GGUriTt8xmnJ+RTRedZ6hzAFVHtXm\n/YIT9Lc1IIYZuHVyCbX/HXwa0E4r8lghwZRg94HUvpbfabNA3obt5auwtJUfW1tK\n2ERgFrtBRBWf9EGb8TstXqksqYZ04U4OjLm/3ZJhSSYKNbriRLlSEzAlHikNVW+t\n6cTh+sasrGt/qNIRMs5PiipwmV/T3z1LbyoiU7fXZ4GqiWBnZARFC9KiPPTzLszh\nBKJGYHaC8wkGb3WfNWFBqVRfFL8kdME+shLB8/ETQ31gIFeudnW1QlujJ7ZSZtwz\nxT3HxzZIIbNEqLFP+d37kmuKjRmI4KWc+pKOUw9BOl4g/TJH6ySljSNs8LSDWwQY\n76Dsnr+ovz8ZVLNUCmedZCyumeJo2tLkJmsPo5GuMnXpL94mhqpCoUS4l4JbJl44\nT2lmqp1Ueoz+Qlkqyt2lj3heTv9bvB7NO9KHTsDy1hhWHOG1QyXzajyWETU+1XdW\nx1hGvYxtpQPLUE8=\n-----END CERTIFICATE-----";
        private const string RSA_PEM_PUBLIC_KEY_PKCS8 = "-----BEGIN PUBLIC KEY-----\nMIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEA52DszUZzPKPo1d9Hi5Hj\nlu7OINwADaeXifA4rvmJJaA+jm4DCMwrAMzyS12EiW31xCAF8LZ/xkrFHO5CZgvK\n87Y+kY9DmhvNX6FVYsn4ay7KER0zo87zqQjC+njUu1rYuKnio7MYb354PitwQ3SW\nNv2qTCbCNCXTN9pJXNhlCudWCEWrNrYc4/hKz3bqu1DjpY0oHuuKPk/iRr2TTUIA\nwahNkNQheQNB2a8hL7L2OG1Sn1vaDWe+5RJYlMRZ3NgYDTqoy8GMs+6q091MQMDl\nQ90jtW/JEoM5DUyI8zfQfDLGnU7FuY0rrZ/+6OQT/o7ISf0OR5TISS0lqnDN3vVa\nph0ftDGRdGqJk2SJAHIoxp5gt410rfWS9kpSDFJs3Pvt4rtNZBYvkGD8obSm91br\nAkoX4+u1Y4p1qZpWJ4LIKw8oyeieqlLZtF/VGKOtKxe/IKn8GwoQJLx4dUGFOqM7\nHPwR9cyjMaC1o3V1NQG+1wD9TLtGh3WXUFJRYDmePaSp39GFPupTMlPRbD0RK80B\n6xv2rYTyYyd8s2LN6P6Hh/nFIkc1rekIf9JhPy0WKzrXdmnfjSHKPxmz0WSYN8Fx\nKasqcJhncOdhLTzzVEhj9xHSI8ejP2fJ4v+ARoD3GURPD9H7KMa7xmzRSAZ8A8LM\n3uvdJNhbKBwWqvo45ncz+7cCAwEAAQ==\n-----END PUBLIC KEY-----";
        private const string RSA_PEM_PUBLIC_KEY_PKCS1 = "-----BEGIN RSA PUBLIC KEY-----\nMIICCgKCAgEA52DszUZzPKPo1d9Hi5Hjlu7OINwADaeXifA4rvmJJaA+jm4DCMwr\nAMzyS12EiW31xCAF8LZ/xkrFHO5CZgvK87Y+kY9DmhvNX6FVYsn4ay7KER0zo87z\nqQjC+njUu1rYuKnio7MYb354PitwQ3SWNv2qTCbCNCXTN9pJXNhlCudWCEWrNrYc\n4/hKz3bqu1DjpY0oHuuKPk/iRr2TTUIAwahNkNQheQNB2a8hL7L2OG1Sn1vaDWe+\n5RJYlMRZ3NgYDTqoy8GMs+6q091MQMDlQ90jtW/JEoM5DUyI8zfQfDLGnU7FuY0r\nrZ/+6OQT/o7ISf0OR5TISS0lqnDN3vVaph0ftDGRdGqJk2SJAHIoxp5gt410rfWS\n9kpSDFJs3Pvt4rtNZBYvkGD8obSm91brAkoX4+u1Y4p1qZpWJ4LIKw8oyeieqlLZ\ntF/VGKOtKxe/IKn8GwoQJLx4dUGFOqM7HPwR9cyjMaC1o3V1NQG+1wD9TLtGh3WX\nUFJRYDmePaSp39GFPupTMlPRbD0RK80B6xv2rYTyYyd8s2LN6P6Hh/nFIkc1rekI\nf9JhPy0WKzrXdmnfjSHKPxmz0WSYN8FxKasqcJhncOdhLTzzVEhj9xHSI8ejP2fJ\n4v+ARoD3GURPD9H7KMa7xmzRSAZ8A8LM3uvdJNhbKBwWqvo45ncz+7cCAwEAAQ==\n-----END RSA PUBLIC KEY-----\r\n";
        private const string RSA_PEM_PRIVATE_KEY_PKCS8 = "-----BEGIN PRIVATE KEY-----\n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\nhpUq0eKgdGHc2R4r57soRvGoGy2DtA==\n-----END PRIVATE KEY-----";
        private const string RSA_PEM_PRIVATE_KEY_PKCS1 = "-----BEGIN RSA PRIVATE KEY-----\nMIIJKAIBAAKCAgEA52DszUZzPKPo1d9Hi5Hjlu7OINwADaeXifA4rvmJJaA+jm4D\nCMwrAMzyS12EiW31xCAF8LZ/xkrFHO5CZgvK87Y+kY9DmhvNX6FVYsn4ay7KER0z\no87zqQjC+njUu1rYuKnio7MYb354PitwQ3SWNv2qTCbCNCXTN9pJXNhlCudWCEWr\nNrYc4/hKz3bqu1DjpY0oHuuKPk/iRr2TTUIAwahNkNQheQNB2a8hL7L2OG1Sn1va\nDWe+5RJYlMRZ3NgYDTqoy8GMs+6q091MQMDlQ90jtW/JEoM5DUyI8zfQfDLGnU7F\nuY0rrZ/+6OQT/o7ISf0OR5TISS0lqnDN3vVaph0ftDGRdGqJk2SJAHIoxp5gt410\nrfWS9kpSDFJs3Pvt4rtNZBYvkGD8obSm91brAkoX4+u1Y4p1qZpWJ4LIKw8oyeie\nqlLZtF/VGKOtKxe/IKn8GwoQJLx4dUGFOqM7HPwR9cyjMaC1o3V1NQG+1wD9TLtG\nh3WXUFJRYDmePaSp39GFPupTMlPRbD0RK80B6xv2rYTyYyd8s2LN6P6Hh/nFIkc1\nrekIf9JhPy0WKzrXdmnfjSHKPxmz0WSYN8FxKasqcJhncOdhLTzzVEhj9xHSI8ej\nP2fJ4v+ARoD3GURPD9H7KMa7xmzRSAZ8A8LM3uvdJNhbKBwWqvo45ncz+7cCAwEA\nAQKCAgEA0yfoU9nkVsX7Oht/bocgXWDoaqJ7xfpZWIALKtv95oGcNV1+lWvGHv/q\naw8YYlcgf/D9mtTiPPOFecaSgBBpEgsShMJq3lxbC9fvVa2ecSqNLBsrQmYehffC\nANV+xtC8kaIwfFZ4iV+wmoQH+veOEvdikAabGv4eCY3Df+DYLaA7KmdyPgbqzL2O\ngFE1HOdQKYhtwfIRApbimM5vfIUsrY9L4k1Fkut/EAs8TQyUmaBjU51+nNc+Jk2c\n239pxxrKsGAFJZYoMxkvexQtf7bKRCmvaehvZt6slU9weA5KzN2F1o/J8HE+GEC4\nYI+tE5X4gVVYz8ifE/EIu8ggiUX+h3fP2E/TYf7mh4fQ1JoIjeki9r+5EZ3yffuZ\n138sYwv44iYzMKBb0s5FmDXc9ADosKlRVQMyAbzUuIXum5V5acb4vL7ceAZIPOrs\nFJWrirVG7Uccuz2lGCfeunYL2B+qARKkT16knNHeBmmPkUui83F5sC2JrF8GVfhs\nGPUPGOOOb7j9tAHv3XNpfUdfQ6fdFGFilOPUIFyKxqmdLy+ErVrstdGN7aQXVtdq\ngaVRsFCMTIWNnQEeZ1q156m6l2dyiqL1jzyo9PklDf0SoJczY3s5LyanH0x1p99v\nsKo08wIr2CGGYRbWEY3veTsxp46d6lUJv4V2RlmiXTQprveKBXECggEBAP4kcWzM\nWN2QthN1Q/T802rUVsSdGYEdmb10GQ2XvlLdW87inqz0CJBjQwKkY4nGEkukG7aK\nTW1Y8jac+5SXbl16IaU0g61pSI37aP3UPABRzhHjNsp6f7PkPP381wG4JgZoBaRj\nn/22Mw1rsHkPRtvZrCexvKcvi6OUR2+mZob5BlXs+Jt5kewd320TDvyv+H8kUSZu\nNDXN2gJPlG54S/zZfJzEQvm5Iyb9DRuD3+hYX/fbKiUexG0tgeafQvpug7vc1Qv8\n5iITkoOwoOv1Ri3Ul/3pe0IC/a/C3e9WtQZ+IU3lp0YJMsgtnP6IgsdhnCxTDV2R\nAiKlDYaWQ7Gjc/8CggEBAOkR4ssFPolckVtvET91L6CoZtEalh/JBSekowE4tEA0\nzVADhLUzlwJsnPRbsZAUI6CIvKlW8mMGRfWBV29aPNtyeBGnxCl9Q/YBh3ldthZc\n4TEgTs39Ck4tUfSACaCEnASMjcmpmSsAH2u2ywm8TQYkBtyWJkKiNzhOlRRTO7ri\nFr2RxdukbfByymF7Uc2f6YTt5ieCnskGH5fsheT1rnhqSyQIzWCNxNk8cbnUDLWJ\nFg1eqPDia0Oum51HBzMYtVzzWA5QTAELBhyDe/qmMeRGO3xytZMwoWDqDkbKoxsI\n/UkhHZzUzN7gejy15ybKBtDU2mqFaFua35wj4yNIGEkCggEAZTI9uATmndMxrS3U\nkYja5n8GzeOAdFlFDptcHn1926EpHYg/hr7lahkcZcDvobytLFF8d4M6sX/pcrWv\nt8tUtwQawZ3XkQWLTn39oJUSD06Dr7u55YZBs2/+mWREePrKqWJiXMMOwgf67C0l\naA8dOA3E70lmxWu5PrmceGjaCoS+cRibJc2SvWJnxRcBsLyhRn8/kP3w7Du7w4/M\nmvBr0ZMIe6Pqx2VhCfVZcstgLTSDgj5S2dUWgiLMxvhDw1SeP///FXbubEM+5BFB\nArP37efpXcHKws5OFd6SYOs1yhAPUuVPZiPjhLIlAXV6HcpQVZX8jHVhVEpEyIKt\nEd70IQKCAQAbS2/u7LdNKN0RAynW76dbPj2EQYPRRx5mbR511yks18Ivm6nf+qG1\ns/iRmWdrAyDE/R5zCm6qcCKjRLlznfLAlGBBWQ9c+IGL/tPZv8LCTbBFq43vC7I4\nQ5B0fMYj2UPYOImmU0lPwtzrJWYTxsySaoevL5pddVfYLUPCNJkrIq0dGEQ+m7wQ\nS7Etx15mIVMcsSuh9ucXjbMHfLiVfrwm9/PCzZEXvKKP+kcrRw0R+XLur+ZDB5Ee\nRQWOXrIWJs+eihUG4Bp2iM73aeKMEQiIvjzbLyfai/hqPB7d5X9CfEQFW253Xmh7\ntXg7QeZHIaO4syS9EtCM4c9MHtvL1vaZAoIBAG8VW0r6Nc8COqyeVeYTQN5i38kH\n2W3Rmtw77CTaWJJCn3AwwmNAOXPO72iFybPjL9hHP4zZUJyIKwGr6zOEPEMbAQn0\nERH29hivcWTyDQGfQWQMjHKjuRSFBtm+UisV1lWhabedgrCl0CCCVMt1SPZcryjU\nHPcSiF2q2IjMgvV+P7VZqmaiCcD2WWalnqbTZuXciBh2yrMSF3WAYA/Eym9tpxWi\nm0V+3Qddcxn7N6Oazn7VlnsO/4Wt0Hjzfb8vMdD13yswW1jYDsLv7r+LkBdJq4R2\n/rJ+jdl0o979tJyc+etq6KTd7SPKHoaVKtHioHRh3NkeK+e7KEbxqBstg7Q=\n-----END RSA PRIVATE KEY-----\r\n";

        [Fact(DisplayName = "测试用例：从 RSA 证书中导出公钥")]
        public void TestRSAExportPublicKeyFromCertificate()
        {
            string actualPublicKey = Utilities.RSAUtility.ExportPublicKeyFromCertificate(RSA_PEM_CERTIFICATE).Replace("\r", "").Replace("\n", "");
            string expectedPublicKey = RSA_PEM_PUBLIC_KEY_PKCS8.Replace("\r", "").Replace("\n", "");

            Assert.Equal(expectedPublicKey, actualPublicKey, ignoreLineEndingDifferences: true);
        }

        [Fact(DisplayName = "测试用例：从 RSA 证书中导出证书序列号")]
        public void TestRSAExportSerialNumberFromCertificate()
        {
            string actualSerialNumber = Utilities.RSAUtility.ExportSerialNumberFromCertificate(RSA_PEM_CERTIFICATE);
            string expectedSerialNumber = RSA_CERT_SN;

            Assert.Equal(expectedSerialNumber, actualSerialNumber, ignoreCase: true);
        }

        [Fact(DisplayName = "测试用例：从 RSA 证书中导出证书有效期的开始时间")]
        public void TestRSAExportValidFromDateFromCertificate()
        {
            DateTimeOffset actualEffectiveTime = Utilities.RSAUtility.ExportValidFromDateFromCertificate(RSA_PEM_CERTIFICATE);
            DateTimeOffset expectedEffectiveTime = DateTimeOffset.Parse(RSA_CERT_START_DATE);

            Assert.Equal(expectedEffectiveTime, actualEffectiveTime);
        }

        [Fact(DisplayName = "测试用例：从 RSA 证书中导出证书有效期的结束时间")]
        public void TestRSAExportValidToDateFromCertificate()
        {
            DateTimeOffset actualExpireTime = Utilities.RSAUtility.ExportValidToDateFromCertificate(RSA_PEM_CERTIFICATE);
            DateTimeOffset expectedExpireTime = DateTimeOffset.Parse(RSA_CERT_END_DATE);

            Assert.Equal(expectedExpireTime, actualExpireTime);
        }

        [Fact(DisplayName = "测试用例：SHA256WithRSA 签名生成")]
        public void TestRSASignatureSHA256WithRSASign()
        {
            string msgText = "SHA256WithRSASignTest";
            string actualSignByPrivateKeyPkcs8 = Utilities.RSAUtility.Sign(RSA_PEM_PRIVATE_KEY_PKCS8, msgText)!;
            string actualSignByPrivateKeyPkcs1 = Utilities.RSAUtility.Sign(RSA_PEM_PRIVATE_KEY_PKCS1, msgText)!;
            string expectedSign = "EzeVEIoBhzOhXpwbXdJjIuGIGRc6ArKO7sVo2fuAdzYTDgorAEufEnw7lPPXV1GTfFcHOnsAJH9kGJmg7Orwlkh7x7TyOGrkMEhWGulA9SIdmou4iBsHpIZ/TERSgGt/VTmqmfpkzJqrvbQWIQENwo7Lr6uJSJBND0YT3nIBP8TzbO3cHnQb6chHIBHrDF5vOO7HHu+Cga2MZnAtRizhO8BhK0jOmyro32CgIML3EVX8yuPy0kOk6aN1R8xFblZUD4NU2M6zzQpydmxaHr9B1WNFoMwmpoAS5BuKJMYOHO5cc6DhB+0fAGxaWtKp6759KhKCf8M65zh3WKS4l262SGuWq4qG1+AKf2DOgCon769+A4z8flOmvl0iIwoH9FThGJoP156rpAJW7v/bWputSeC6WToUTBRmGWdwWySVwW5AZ26OAFFWs1CmrGp3jF5E2oUy1mQwgfM0QN6DW+wD769ggIYH9HLHqDHbF5UyF7eNh3s8Qy23xXEKZWNMAJ0IdtdMQ7FRRgLFSCai7HELLlBJSCz7P5WTeYZGQpbvnUShkRvzujjO6XlGiKKI0EwKb121z8N6KRpvs4SnRztWBGoXbzHZgnXKXU/BWWADemqB2cvaT3Bj0k3/N3sea0dAEtlNEklRWoyyNUUlscK9zg4LBlHrhbbFo66uuub8ySo=";

            Assert.Equal(expectedSign, actualSignByPrivateKeyPkcs8);
            Assert.Equal(expectedSign, actualSignByPrivateKeyPkcs1);
            Assert.True(Utilities.RSAUtility.Verify(RSA_PEM_PUBLIC_KEY_PKCS8, msgText, (EncodedString)actualSignByPrivateKeyPkcs8));
            Assert.True(Utilities.RSAUtility.Verify(RSA_PEM_PUBLIC_KEY_PKCS1, msgText, (EncodedString)actualSignByPrivateKeyPkcs1));
        }

        [Fact(DisplayName = "测试用例：SHA256WithRSA 签名验证")]
        public void TestRSASignatureSHA256WithRSAVerify()
        {
            string msgText = "SHA256WithRSAVerifyTest";
            string signText = "aHX+MrmZHDEraMKBEPV2Vnps1B9b25lGbv/rdppx/S7+oaXtjKJprzCq5H7RCpvrKS3xYIeTEPwQGC3Vots7dCdLi8v8ew1vvtXf8qNAnd7CTMHqu3wSohXzgyASTmNbXE2ml9LbWYPPYMvPJXROQbGVjoOrsErWBPPJYXuO3lIckIfwI05OTdl4H3+BvpD/ZoljRp8Qgo9+paGvarBc++TaAh0FXnQf0TGNFUIeHHiAKBee5oCBTuZZM9J5RPw0oIq/g7Wun+e/zWiwVBPHltOgZrV46uagSAE6nBDHk+hlNxDivCxkJdBVCSIYFFmBXIcnGZ/u4ZfBui/k1jGoKibyvPK4z2+6GSlj41Yo81kuSBfzLiSsx33EPR1eIJJkwDTsvap0ymL9pfIqMiLuiteH5kGmL/dyONy9oAJywLEeITfoVyElM/CY6Dc+xDhRnjN7Hu54meYyXRZrnCtQ3YhzEr1immNBn6npgA/qi9aHsuWFOw8b8aSwOHDHTDmjmvV+axI8CVMrR0MjB9QNCWrKLq2B9iQX9MtLgcUyDsQvzAsxUJm/OEfzUjs9SHvmgmyAvzNAuTdO7wLQ+ZmKg0yZne6nvcrJVvfh3lD5ZPt7NY57Y6OIJluqKUT5H+a3H6W9Q1Z+cBMnHGYaaK7Tv8IcDdEYqTIG8hc5BqjFOzE=";

            Assert.True(Utilities.RSAUtility.Verify(RSA_PEM_PUBLIC_KEY_PKCS8, msgText, (EncodedString)signText));
            Assert.True(Utilities.RSAUtility.Verify(RSA_PEM_PUBLIC_KEY_PKCS1, msgText, (EncodedString)signText));
            Assert.False(Utilities.RSAUtility.Verify(RSA_PEM_PUBLIC_KEY_PKCS8, msgText, (EncodedString)"FAKE SIGN"));
            Assert.False(Utilities.RSAUtility.Verify(RSA_PEM_PUBLIC_KEY_PKCS1, msgText, (EncodedString)"FAKE SIGN"));
            Assert.True(Utilities.RSAUtility.VerifyByCertificate(RSA_PEM_CERTIFICATE, msgText, (EncodedString)signText));
            Assert.False(Utilities.RSAUtility.VerifyByCertificate(RSA_PEM_CERTIFICATE, msgText, (EncodedString)"FAKE SIGN"));
        }

        [Fact(DisplayName = "测试用例：使用 RSA 公钥加密")]
        public void TestRSAEncrypt()
        {
            string plainText = "RsaEncryptTest";
            string actualCipherByPublicKeyPkcs8 = Utilities.RSAUtility.EncryptWithECB(RSA_PEM_PUBLIC_KEY_PKCS8, plainText)!;
            string actualCipherByPublicKeyPkcs1 = Utilities.RSAUtility.EncryptWithECB(RSA_PEM_PUBLIC_KEY_PKCS1, plainText)!;
            string actualCipherByCertificate = Utilities.RSAUtility.EncryptWithECBByCertificate(RSA_PEM_CERTIFICATE, plainText)!;

            Assert.NotNull(actualCipherByPublicKeyPkcs8);
            Assert.NotNull(actualCipherByPublicKeyPkcs1);
            Assert.NotNull(actualCipherByCertificate);
            Assert.Equal(plainText, Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY_PKCS8, (EncodedString)actualCipherByPublicKeyPkcs8));
            Assert.Equal(plainText, Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY_PKCS1, (EncodedString)actualCipherByPublicKeyPkcs1));
            Assert.Equal(plainText, Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY_PKCS8, (EncodedString)actualCipherByCertificate));
            Assert.Equal(plainText, Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY_PKCS1, (EncodedString)actualCipherByCertificate));
        }

        [Fact(DisplayName = "测试用例：使用 RSA 私钥解密")]
        public void TestRSADecrypt()
        {
            string cipherText = "LXwSqg4jqIv1X8Jx7RAbKw+mc/2SqAfdO4Ytqu09kytzCiDFdIZuJkdo2BQQOoyn/FtCyvn9Loip3VocOuATtsUDo6BmeMJcapl0HfXkyxsYnVRawsq01SPIRz8c83u+K38ZDVjNxEwcwcxH86wMm3PMzLZqISIVrD9sD3an5TfGuS+y/RN8y6W/P7BD/Rpxh0qLJl5B2oPYHOeKK0tdv6GlouUClzxB5tmdK5EKKw0j4WD5qIEwRm8Xzh/V27bt2autzRBbJT47eNypMR5wT7wWm/YwjyDoLLUmuCBaXbWZuqkB0pGS53y3Rdk64LVZ52567hBuQ/JdqMJdCecfy85x+ygnOtCM7bRl/fspU8U5SmwAKohYMc8VH4kRKhxoh8wX9wXCwbngLQ+S50TB3UziY1FmAmWFAI2/fpiyzGJZAVA+mYRCoQAFOksVEuud3ngGkfx2SafJ589IX9z0dnaz1AElaH84LhrOjJyU7dV6E9Su45IegNNai2O8bwN8dliVMPlXZuUAGaZpPLPOxq+hE7GpgNHaVFNye52b7dG3n3mt3hhSwb9AxAyAbSXktBSS/PMOAAS1TxwQ9C/0bKhApUDpjTG8oZBRBVTUHmsX+6/k5+6KSqfOrD88cBDPIhumY6V1h78GtXkFX2lQu9lT2J/fHCrDx39CiRnFAfI=";
            string actualPlain = Utilities.RSAUtility.DecryptWithECB(RSA_PEM_PRIVATE_KEY_PKCS8, (EncodedString)cipherText)!;
            string expectedPlain = "RsaDecryptTest";

            Assert.Equal(expectedPlain, actualPlain);
        }
    }
}
