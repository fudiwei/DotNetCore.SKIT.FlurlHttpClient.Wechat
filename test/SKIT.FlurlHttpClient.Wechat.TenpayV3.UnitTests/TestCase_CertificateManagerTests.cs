using System;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    public class TestCase_CertificateManagerTests
    {
        private const string CERT_RSA_SN = "3050f72e2dce03e7efe49557dd231d176649afbd";
        private const string CERT_RSA_PEM = "-----BEGIN CERTIFICATE-----\nMIIFRzCCAy8CFDBQ9y4tzgPn7+SVV90jHRdmSa+9MA0GCSqGSIb3DQEBCwUAMGAx\nCzAJBgNVBAYTAkNOMREwDwYDVQQIDAhTaGFuZ2hhaTERMA8GA1UEBwwIU2hhbmdo\nYWkxDTALBgNVBAoMBFNLSVQxDTALBgNVBAsMBFNLSVQxDTALBgNVBAMMBFNLSVQw\nHhcNMjExMTI1MTgzNzQ4WhcNMjExMjI1MTgzNzQ4WjBgMQswCQYDVQQGEwJDTjER\nMA8GA1UECAwIU2hhbmdoYWkxETAPBgNVBAcMCFNoYW5naGFpMQ0wCwYDVQQKDART\nS0lUMQ0wCwYDVQQLDARTS0lUMQ0wCwYDVQQDDARTS0lUMIICIjANBgkqhkiG9w0B\nAQEFAAOCAg8AMIICCgKCAgEA52DszUZzPKPo1d9Hi5Hjlu7OINwADaeXifA4rvmJ\nJaA+jm4DCMwrAMzyS12EiW31xCAF8LZ/xkrFHO5CZgvK87Y+kY9DmhvNX6FVYsn4\nay7KER0zo87zqQjC+njUu1rYuKnio7MYb354PitwQ3SWNv2qTCbCNCXTN9pJXNhl\nCudWCEWrNrYc4/hKz3bqu1DjpY0oHuuKPk/iRr2TTUIAwahNkNQheQNB2a8hL7L2\nOG1Sn1vaDWe+5RJYlMRZ3NgYDTqoy8GMs+6q091MQMDlQ90jtW/JEoM5DUyI8zfQ\nfDLGnU7FuY0rrZ/+6OQT/o7ISf0OR5TISS0lqnDN3vVaph0ftDGRdGqJk2SJAHIo\nxp5gt410rfWS9kpSDFJs3Pvt4rtNZBYvkGD8obSm91brAkoX4+u1Y4p1qZpWJ4LI\nKw8oyeieqlLZtF/VGKOtKxe/IKn8GwoQJLx4dUGFOqM7HPwR9cyjMaC1o3V1NQG+\n1wD9TLtGh3WXUFJRYDmePaSp39GFPupTMlPRbD0RK80B6xv2rYTyYyd8s2LN6P6H\nh/nFIkc1rekIf9JhPy0WKzrXdmnfjSHKPxmz0WSYN8FxKasqcJhncOdhLTzzVEhj\n9xHSI8ejP2fJ4v+ARoD3GURPD9H7KMa7xmzRSAZ8A8LM3uvdJNhbKBwWqvo45ncz\n+7cCAwEAATANBgkqhkiG9w0BAQsFAAOCAgEAVTS6oMfDA3XTwEel0BvaXMCdo7yM\ns5ueM87151eywnPlConYDXeqhfF0OCSBnY2g7Fpmn+YAUoa/L+FNOx/gMC9QV/lP\nHhhAcWpiCRy52RX/IyTDxFD6OqtH0BaBtDTb+QBXZuFypMUkPy6EUYs5Cl9qYepy\nHcgGVomx7tcwWcvI4o/KZtj8hXC5wu/k4Y0GGUriTt8xmnJ+RTRedZ6hzAFVHtXm\n/YIT9Lc1IIYZuHVyCbX/HXwa0E4r8lghwZRg94HUvpbfabNA3obt5auwtJUfW1tK\n2ERgFrtBRBWf9EGb8TstXqksqYZ04U4OjLm/3ZJhSSYKNbriRLlSEzAlHikNVW+t\n6cTh+sasrGt/qNIRMs5PiipwmV/T3z1LbyoiU7fXZ4GqiWBnZARFC9KiPPTzLszh\nBKJGYHaC8wkGb3WfNWFBqVRfFL8kdME+shLB8/ETQ31gIFeudnW1QlujJ7ZSZtwz\nxT3HxzZIIbNEqLFP+d37kmuKjRmI4KWc+pKOUw9BOl4g/TJH6ySljSNs8LSDWwQY\n76Dsnr+ovz8ZVLNUCmedZCyumeJo2tLkJmsPo5GuMnXpL94mhqpCoUS4l4JbJl44\nT2lmqp1Ueoz+Qlkqyt2lj3heTv9bvB7NO9KHTsDy1hhWHOG1QyXzajyWETU+1XdW\nx1hGvYxtpQPLUE8=\n-----END CERTIFICATE-----";
        private const string CERT_RSA_START_DATE = "2021-11-26 02:37:48";
        private const string CERT_RSA_END_DATE = "2021-12-26 02:37:48";
        private const string CERT_SM2_PEM = "-----BEGIN CERTIFICATE-----\nMIICNzCCAdygAwIBAgIJAOWoGwJCnY0IMAoGCCqBHM9VAYN1MGcxCzAJBgNVBAYT\nAkNOMRAwDgYDVQQIDAdCZWlqaW5nMRAwDgYDVQQHDAdIYWlEaWFuMRMwEQYDVQQK\nDApHTUNlcnQub3JnMR8wHQYDVQQDDBZHTUNlcnQgR00gUm9vdCBDQSAtIDAxMB4X\nDTIyMTEwOTEzMTIyMFoXDTIzMTEwOTEzMTIyMFowSzEtMCsGA1UEAwwkU0tJVC5G\nbHVybEh0dHBDbGllbnQuV2VjaGF0LlRlbnBheVYzMQ0wCwYDVQQKDARTS0lUMQsw\nCQYDVQQGEwJDTjBZMBMGByqGSM49AgEGCCqBHM9VAYItA0IABMXP1hZc2zBzreRN\nZgOR9hklE01tw10RDUfj176EXcVoVOvITMENJ3HREQtDPlOfz8i1SXCQEwclYyxI\n2KcTdKqjgYwwgYkwDAYDVR0TAQH/BAIwADALBgNVHQ8EBAMCA/gwLAYJYIZIAYb4\nQgENBB8WHUdNQ2VydC5vcmcgU2lnbmVkIENlcnRpZmljYXRlMB0GA1UdDgQWBBRj\nIhoxmSgP84XT/scjkQNSWylMFTAfBgNVHSMEGDAWgBR/Wl47AIRZKg+YvqEObzmV\nQxBNBzAKBggqgRzPVQGDdQNJADBGAiEAnXykM0qDOWay2EMB6+c6YJ7h4n7Wbju7\nXuT5RkuM/3ICIQDAA3sLba/dQMhmKkCoJl31iZwYKz7NP+0aq6NhWDommQ==\n-----END CERTIFICATE-----";
        private const string CERT_SM2_SN = "e5a81b02429d8d08";
        private const string CERT_SM2_START_DATE = "2022-11-09 21:12:20";
        private const string CERT_SM2_END_DATE = "2023-11-09 21:12:20";
        
        [Fact(DisplayName = "测试用例：`CertificateEntry` 序列化")]
        public void TestCertificateEntrySerialization()
        {
            var entry = new Settings.CertificateEntry(Settings.CertificateEntry.ALGORITHM_TYPE_RSA, CERT_RSA_SN, CERT_RSA_PEM, DateTimeOffset.Parse(CERT_RSA_START_DATE), DateTimeOffset.Parse(CERT_RSA_END_DATE));

            var serialized1 = Newtonsoft.Json.JsonConvert.SerializeObject(entry);
            var deserialized1 = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings.CertificateEntry>(serialized1);

            Assert.Equal(entry.AlgorithmType, deserialized1.AlgorithmType);
            Assert.Equal(entry.SerialNumber, deserialized1.SerialNumber);
            Assert.Equal(entry.Certificate, deserialized1.Certificate);
            Assert.Equal(entry.EffectiveTime, deserialized1.EffectiveTime);
            Assert.Equal(entry.ExpireTime, deserialized1.ExpireTime);

            var serialized2 = System.Text.Json.JsonSerializer.Serialize(entry);
            var deserialized2 = System.Text.Json.JsonSerializer.Deserialize<Settings.CertificateEntry>(serialized2);

            Assert.Equal(entry.AlgorithmType, deserialized2.AlgorithmType);
            Assert.Equal(entry.SerialNumber, deserialized2.SerialNumber);
            Assert.Equal(entry.Certificate, deserialized2.Certificate);
            Assert.Equal(entry.EffectiveTime, deserialized2.EffectiveTime);
            Assert.Equal(entry.ExpireTime, deserialized2.ExpireTime);
        }

        [Fact(DisplayName = "测试用例：`CertificateEntry` 构造器")]
        public void TestCertificateEntryConstructor()
        {
            var certRSA = Settings.CertificateEntry.Parse(
                new Models.QueryCertificatesResponse.Types.Certificate()
                {
                    SerialNumber = CERT_RSA_SN,
                    EncryptCertificate = new Models.QueryCertificatesResponse.Types.Certificate.Types.EncryptCertificate()
                    {
                        CipherText = CERT_RSA_PEM
                    },
                    EffectiveTime = DateTimeOffset.Parse(CERT_RSA_START_DATE),
                    ExpireTime = DateTimeOffset.Parse(CERT_RSA_END_DATE)
                }
            );
            Assert.Equal(Settings.CertificateEntry.ALGORITHM_TYPE_RSA, certRSA.AlgorithmType);

            var certSM2 = Settings.CertificateEntry.Parse(
                new Models.QueryCertificatesResponse.Types.Certificate()
                {
                    SerialNumber = CERT_SM2_SN,
                    EncryptCertificate = new Models.QueryCertificatesResponse.Types.Certificate.Types.EncryptCertificate()
                    {
                        CipherText = CERT_SM2_PEM
                    },
                    EffectiveTime = DateTimeOffset.Parse(CERT_SM2_START_DATE),
                    ExpireTime = DateTimeOffset.Parse(CERT_SM2_END_DATE)
                }
            );
            Assert.Equal(Settings.CertificateEntry.ALGORITHM_TYPE_SM2, certSM2.AlgorithmType);
        }
    }
}
