using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.InteropServices
{
    internal sealed class UTF8Marshaler : ICustomMarshaler
    {
        private static readonly Lazy<UTF8Marshaler> _instance = new Lazy<UTF8Marshaler>(() => new UTF8Marshaler());

        public static ICustomMarshaler GetInstance(string pstrCookie)
        {
            return _instance.Value;
        }

        public static string? PtrToStringUTF8(IntPtr pNativeData)
        {
            return _instance.Value.MarshalNativeToManaged(pNativeData) as string;
        }

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            if (managedObj is null)
                return IntPtr.Zero;
            if (!(managedObj is string))
                throw new InvalidOperationException();

            byte[] bytes = Encoding.UTF8.GetBytes((string)managedObj);
            IntPtr pNativeData = Marshal.AllocHGlobal(bytes.Length + 1);
            Marshal.Copy(bytes, 0, pNativeData, bytes.Length);
            Marshal.WriteByte(pNativeData, bytes.Length, 0);
            return pNativeData;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
                return default!;

#if NETCOREAPP || NET5_0_OR_GREATER
            return Marshal.PtrToStringUTF8(pNativeData)!;
#else
            byte b;
            int offset = 0;

            do
            {
                b = Marshal.ReadByte(pNativeData, offset);
                offset++;
            }
            while (b != 0);

            byte[] bytes = new byte[offset - 1];
            Marshal.Copy(pNativeData, bytes, 0, bytes.Length);
            return Encoding.UTF8.GetString(bytes);
#endif
        }

        public void CleanUpManagedData(object managedObj)
        {
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
            {
                return;
            }

            /**
             * NOTICE:
             *   这里释放内存会导致外部 P/Invoke 调用 FreeSlice() 方法时抛出异常
             *   因此请注释下面的代码
             */
            // Marshal.FreeHGlobal(pNativeData);
        }

        public int GetNativeDataSize()
        {
            return -1;
        }
    }
}
