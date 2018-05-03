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

}