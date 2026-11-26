using System.Globalization;

namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto
{
    static partial class DerOID
    {
        private static byte[] EncodeObjectIdentifier(string oid)
        {
            string[] arcs = oid.Split('.');
            if (arcs.Length < 2 ||
                !uint.TryParse(arcs[0], NumberStyles.None, CultureInfo.InvariantCulture, out uint arc1) ||
                !uint.TryParse(arcs[1], NumberStyles.None, CultureInfo.InvariantCulture, out uint arc2) ||
                arc1 > 2 ||
                (arc1 < 2 && arc2 > 39))
            {
                throw new FormatException("Invalid object identifier.");
            }

            var encoded = new List<byte>();
            EncodeSubIdentifier(encoded, arc1 * 40UL + arc2);

            for (int i = 2; i < arcs.Length; i++)
            {
                if (!uint.TryParse(arcs[i], NumberStyles.None, CultureInfo.InvariantCulture, out uint arc))
                    throw new FormatException("Invalid object identifier.");

                EncodeSubIdentifier(encoded, arc);
            }

            return encoded.ToArray();
        }

        private static void EncodeSubIdentifier(List<byte> encoded, ulong value)
        {
            byte[] buffer = new byte[10];

            int position = buffer.Length;
            buffer[--position] = (byte)(value & 0x7f);
            value >>= 7;

            while (value > 0)
            {
                buffer[--position] = (byte)((value & 0x7f) | 0x80);
                value >>= 7;
            }

            for (; position < buffer.Length; position++)
            {
                encoded.Add(buffer[position]);
            }
        }
    }
}
