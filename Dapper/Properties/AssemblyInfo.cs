
#if PLAT_SKIP_LOCALS_INIT
[module: System.Runtime.CompilerServices.SkipLocalsInit]
#endif

#if !NET5_0_OR_GREATER

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    internal sealed class MemberNotNullAttribute : Attribute
    {
        public MemberNotNullAttribute(string member) {}
        public MemberNotNullAttribute(params string[] members) {}
    }
}

#endif
