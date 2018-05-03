using System;

namespace PKHeX.Core {
    public static class BridgeExtensions {
        public static dynamic ToArray(this Array a) {
            return a;
        }

        public static bool IsPrimitive(this Type t) {
            return t == typeof(Int64)
                || t == typeof(UInt64)
                || t == typeof(Double)
                || t == typeof(Single)
                || t == typeof(Byte)
                || t == typeof(SByte)
                || t == typeof(Int16)
                || t == typeof(UInt16)
                || t == typeof(Int32)
                || t == typeof(Boolean)
                || t == typeof(Char);
        }
    }

    public static class Buffer {
        public static void BlockCopy(Array src, int off1, Array target, int off2, int len) {
            for(int i = 0; i < len; i++) {
                target[off2 + i] = src[off1 + i];
            }
        }
    }

}