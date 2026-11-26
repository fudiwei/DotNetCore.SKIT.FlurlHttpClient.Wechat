namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto
{
    /// <summary>
    /// 
    /// </summary>
    static class DerEncoder
    {
        public static byte[] EncodeNull()
        {
            return new byte[] { 0x05, 0x00 };
        }

        /// <summary>
        /// 将无符号大端整数编码为 DER INTEGER。
        /// </summary>
        public static byte[] EncodeInteger(byte[] value)
        {
            if (value == null || value.Length == 0)
                return new byte[] { 0x02, 0x01, 0x00 };

            int offset = 0;
            while (offset < value.Length - 1 && value[offset] == 0)
                offset++;

            bool needsPadding = (value[offset] & 0x80) != 0;
            List<byte> result = new List<byte> { 0x02 };
            result.AddRange(EncodeLength(value.Length - offset + (needsPadding ? 1 : 0)));
            if (needsPadding)
                result.Add(0x00);
            for (int i = offset; i < value.Length; i++)
                result.Add(value[i]);
            return result.ToArray();
        }

        public static byte[] EncodeOctetString(byte[] value)
        {
            List<byte> result = new List<byte> { 0x04 };
            result.AddRange(EncodeLength(value.Length));
            result.AddRange(value);
            return result.ToArray();
        }

        public static byte[] EncodeBitString(byte[] value)
        {
            List<byte> result = new List<byte> { 0x03 };
            result.AddRange(EncodeLength(value.Length + 1));
            result.Add(0x00);
            result.AddRange(value);
            return result.ToArray();
        }

        public static byte[] EncodeObjectIdentifier(byte[] value)
        {
            List<byte> result = new List<byte> { 0x06 };
            result.AddRange(EncodeLength(value.Length));
            result.AddRange(value);
            return result.ToArray();
        }

        public static byte[] EncodeLength(int length)
        {
            if (length < 0x80)
                return new byte[] { (byte)length };

            List<byte> result = new List<byte>();
            int temp = length;
            while (temp > 0)
            {
                result.Insert(0, (byte)(temp & 0xff));
                temp >>= 8;
            }
            result.Insert(0, (byte)(0x80 | result.Count));
            return result.ToArray();
        }

        public static byte[] EncodeSequence(params byte[][] sequence)
        {
            List<byte> content = new List<byte>();
            foreach (byte[] element in sequence)
            {
                content.AddRange(element);
            }

            List<byte> result = new List<byte> { 0x30 };
            result.AddRange(EncodeLength(content.Count));
            result.AddRange(content);
            return result.ToArray();
        }
    }
}
