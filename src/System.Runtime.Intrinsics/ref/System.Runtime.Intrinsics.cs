// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace System.Runtime.Intrinsics
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct Vector64<T> where T : struct {}
    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct Vector128<T> where T : struct {}
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct Vector256<T> where T : struct {}
}
namespace System.Runtime.Intrinsics.Arm.Arm64
{
#if ARM64_HW_INTRINSIC_NYI
    public static class Base
    {
        public static bool IsSupported { get { throw null; } }

        public static uint  LeadingSignCount(int  value) { throw null; }
        public static ulong LeadingSignCount(long value) { throw null; }
        public static uint  LeadingZeroCount(uint  value) { throw null; }
        public static ulong LeadingZeroCount(ulong value) { throw null; }
    }
#endif
    public static class Simd
    {
        public static bool IsSupported { get { throw null; } }

        /// <summary>
        /// Vector abs
        /// Corresponds to vector forms of ARM64 ABS & FABS
        /// </summary>
        public static Vector64<byte>    Abs(Vector64<sbyte>   value) { throw null; }
        public static Vector64<ushort>  Abs(Vector64<short>   value) { throw null; }
        public static Vector64<uint>    Abs(Vector64<int>     value) { throw null; }
        public static Vector64<float>   Abs(Vector64<float>   value) { throw null; }
        public static Vector128<byte>   Abs(Vector128<sbyte>  value) { throw null; }
        public static Vector128<ushort> Abs(Vector128<short>  value) { throw null; }
        public static Vector128<uint>   Abs(Vector128<int>    value) { throw null; }
        public static Vector128<ulong>  Abs(Vector128<long>   value) { throw null; }
        public static Vector128<float>  Abs(Vector128<float>  value) { throw null; }
        public static Vector128<double> Abs(Vector128<double> value) { throw null; }

        /// <summary>
        /// Vector add
        /// Corresponds to vector forms of ARM64 ADD & FADD
        /// </summary>
        public static Vector64<T>  Add<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> Add<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector and
        /// Corresponds to vector forms of ARM64 AND
        /// </summary>
        public static Vector64<T>  And<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> And<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector and not
        /// Corresponds to vector forms of ARM64 BIC
        /// </summary>
        public static Vector64<T>  AndNot<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector BitwiseSelect
        /// For each bit in the vector result[bit] = sel[bit] ? left[bit] : right[bit]
        /// Corresponds to vector forms of ARM64 BSL (Also BIF & BIT)
        /// </summary>
        public static Vector64<T>  BitwiseSelect<T>(Vector64<T>  sel, Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> BitwiseSelect<T>(Vector128<T> sel, Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector CompareEqual
        /// For each element result[elem] = (left[elem] == right[elem]) ? ~0 : 0
        /// Corresponds to vector forms of ARM64 CMEQ & FCMEQ
        /// </summary>
        public static Vector64<T>  CompareEqual<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> CompareEqual<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector CompareEqualZero
        /// For each element result[elem] = (left[elem] == 0) ? ~0 : 0
        /// Corresponds to vector forms of ARM64 CMEQ & FCMEQ
        /// </summary>
        public static Vector64<T>  CompareEqualZero<T>(Vector64<T>  value) where T : struct { throw null; }
        public static Vector128<T> CompareEqualZero<T>(Vector128<T> value) where T : struct { throw null; }

        /// <summary>
        /// Vector CompareGreaterThan
        /// For each element result[elem] = (left[elem] > right[elem]) ? ~0 : 0
        /// Corresponds to vector forms of ARM64 CMGT/CMHI & FCMGT
        /// </summary>
        public static Vector64<T>  CompareGreaterThan<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> CompareGreaterThan<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector CompareGreaterThanZero
        /// For each element result[elem] = (left[elem] > 0) ? ~0 : 0
        /// Corresponds to vector forms of ARM64 CMGT & FCMGT
        /// </summary>
        public static Vector64<T>  CompareGreaterThanZero<T>(Vector64<T>  value) where T : struct { throw null; }
        public static Vector128<T> CompareGreaterThanZero<T>(Vector128<T> value) where T : struct { throw null; }

        /// <summary>
        /// Vector CompareGreaterThanOrEqual
        /// For each element result[elem] = (left[elem] >= right[elem]) ? ~0 : 0
        /// Corresponds to vector forms of ARM64 CMGE/CMHS & FCMGE
        /// </summary>
        public static Vector64<T>  CompareGreaterThanOrEqual<T>(Vector64<T>  left, Vector64<T>    right) where T : struct { throw null; }
        public static Vector128<T> CompareGreaterThanOrEqual<T>(Vector128<T> left, Vector128<T>   right) where T : struct { throw null; }

        /// <summary>
        /// Vector CompareGreaterThanOrEqualZero
        /// For each element result[elem] = (left[elem] >= 0) ? ~0 : 0
        /// Corresponds to vector forms of ARM64 CMGE & FCMGE
        /// </summary>
        public static Vector64<T>  CompareGreaterThanOrEqualZero<T>(Vector64<T>  value) where T : struct { throw null; }
        public static Vector128<T> CompareGreaterThanOrEqualZero<T>(Vector128<T> value) where T : struct { throw null; }

        /// <summary>
        /// Vector CompareLessThanZero
        /// For each element result[elem] = (left[elem] < 0) ? ~0 : 0
        /// Corresponds to vector forms of ARM64 CMGT & FCMGT
        /// </summary>
        public static Vector64<T>  CompareLessThanZero<T>(Vector64<T>  value) where T : struct { throw null; }
        public static Vector128<T> CompareLessThanZero<T>(Vector128<T> value) where T : struct { throw null; }

        /// <summary>
        /// Vector CompareLessThanOrEqualZero
        /// For each element result[elem] = (left[elem] < 0) ? ~0 : 0
        /// Corresponds to vector forms of ARM64 CMGT & FCMGT
        /// </summary>
        public static Vector64<T>  CompareLessThanOrEqualZero<T>(Vector64<T>  value) where T : struct { throw null; }
        public static Vector128<T> CompareLessThanOrEqualZero<T>(Vector128<T> value) where T : struct { throw null; }

        /// <summary>
        /// Vector CompareTest
        /// For each element result[elem] = (left[elem] & right[elem]) ? ~0 : 0
        /// Corresponds to vector forms of ARM64 CMTST
        /// </summary>
        public static Vector64<T>  CompareTest<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> CompareTest<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// TBD Convert...

        /// <summary>
        /// Vector Divide
        /// Corresponds to vector forms of ARM64 FDIV
        /// </summary>
        public static Vector64<float>   Divide(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<float>  Divide(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> Divide(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector extract item
        ///
        /// result = vector[index]
        ///
        /// Note: In order to be inlined, index must be a JIT time const expression which can be used to
        /// populate the literal immediate field.  Use of a non constant will result in generation of a switch table
        ///
        /// Corresponds to vector forms of ARM64 MOV
        /// </summary>
        public static T Extract<T>(Vector64<T>  vector, byte index) where T : struct { throw null; }
        public static T Extract<T>(Vector128<T> vector, byte index) where T : struct { throw null; }

        /// <summary>
        /// Vector insert item
        ///
        /// result = vector;
        /// result[index] = data;
        ///
        /// Note: In order to be inlined, index must be a JIT time const expression which can be used to
        /// populate the literal immediate field.  Use of a non constant will result in generation of a switch table
        ///
        /// Corresponds to vector forms of ARM64 INS
        /// </summary>
        public static Vector64<T>  Insert<T>(Vector64<T>  vector, byte index, T data) where T : struct { throw null; }
        public static Vector128<T> Insert<T>(Vector128<T> vector, byte index, T data) where T : struct { throw null; }

        /// <summary>
        /// Vector LeadingSignCount
        /// Corresponds to vector forms of ARM64 CLS
        /// </summary>
        public static Vector64<sbyte>  LeadingSignCount(Vector64<sbyte>  value) { throw null; }
        public static Vector64<short>  LeadingSignCount(Vector64<short>  value) { throw null; }
        public static Vector64<int>    LeadingSignCount(Vector64<int>    value) { throw null; }
        public static Vector128<sbyte> LeadingSignCount(Vector128<sbyte> value) { throw null; }
        public static Vector128<short> LeadingSignCount(Vector128<short> value) { throw null; }
        public static Vector128<int>   LeadingSignCount(Vector128<int>   value) { throw null; }
        public static Vector128<long>  LeadingSignCount(Vector128<long>  value) { throw null; }

        /// <summary>
        /// Vector LeadingZeroCount
        /// Corresponds to vector forms of ARM64 CLZ
        /// </summary>
        public static Vector64<byte>    LeadingZeroCount(Vector64<byte>    value) { throw null; }
        public static Vector64<sbyte>   LeadingZeroCount(Vector64<sbyte>   value) { throw null; }
        public static Vector64<ushort>  LeadingZeroCount(Vector64<ushort>  value) { throw null; }
        public static Vector64<short>   LeadingZeroCount(Vector64<short>   value) { throw null; }
        public static Vector64<uint>    LeadingZeroCount(Vector64<uint>    value) { throw null; }
        public static Vector64<int>     LeadingZeroCount(Vector64<int>     value) { throw null; }
        public static Vector128<byte>   LeadingZeroCount(Vector128<byte>   value) { throw null; }
        public static Vector128<sbyte>  LeadingZeroCount(Vector128<sbyte>  value) { throw null; }
        public static Vector128<ushort> LeadingZeroCount(Vector128<ushort> value) { throw null; }
        public static Vector128<short>  LeadingZeroCount(Vector128<short>  value) { throw null; }
        public static Vector128<uint>   LeadingZeroCount(Vector128<uint>   value) { throw null; }
        public static Vector128<int>    LeadingZeroCount(Vector128<int>    value) { throw null; }
        public static Vector128<ulong>  LeadingZeroCount(Vector128<ulong>  value) { throw null; }
        public static Vector128<long>   LeadingZeroCount(Vector128<long>   value) { throw null; }

        /// <summary>
        /// Vector multiply
        ///
        /// For each element result[elem] = left[elem] * right[elem]
        ///
        /// Corresponds to vector forms of ARM64 MUL & FMUL
        /// </summary>
        public static Vector64<byte>    Multiply(Vector64<byte>    left, Vector64<byte>    right) { throw null; }
        public static Vector64<sbyte>   Multiply(Vector64<sbyte>   left, Vector64<sbyte>   right) { throw null; }
        public static Vector64<ushort>  Multiply(Vector64<ushort>  left, Vector64<ushort>  right) { throw null; }
        public static Vector64<short>   Multiply(Vector64<short>   left, Vector64<short>   right) { throw null; }
        public static Vector64<uint>    Multiply(Vector64<uint>    left, Vector64<uint>    right) { throw null; }
        public static Vector64<int>     Multiply(Vector64<int>     left, Vector64<int>     right) { throw null; }
        public static Vector64<float>   Multiply(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<byte>   Multiply(Vector128<byte>   left, Vector128<byte>   right) { throw null; }
        public static Vector128<sbyte>  Multiply(Vector128<sbyte>  left, Vector128<sbyte>  right) { throw null; }
        public static Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static Vector128<short>  Multiply(Vector128<short>  left, Vector128<short>  right) { throw null; }
        public static Vector128<uint>   Multiply(Vector128<uint>   left, Vector128<uint>   right) { throw null; }
        public static Vector128<int>    Multiply(Vector128<int>    left, Vector128<int>    right) { throw null; }
        public static Vector128<ulong>  Multiply(Vector128<ulong>  left, Vector128<ulong>  right) { throw null; }
        public static Vector128<long>   Multiply(Vector128<long>   left, Vector128<long>   right) { throw null; }
        public static Vector128<float>  Multiply(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> Multiply(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector max
        /// Corresponds to vector forms of ARM64 SMAX, UMAX & FMAX
        /// </summary>
        public static Vector64<T>  Max<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> Max<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector min
        /// Corresponds to vector forms of ARM64 SMIN, UMIN & FMIN
        /// </summary>
        public static Vector64<T>  Min<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> Min<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector negate
        /// Corresponds to vector forms of ARM64 NEG & FNEG
        /// </summary>
        public static Vector64<sbyte>   Negate(Vector64<sbyte>   value) { throw null; }
        public static Vector64<short>   Negate(Vector64<short>   value) { throw null; }
        public static Vector64<int>     Negate(Vector64<int>     value) { throw null; }
        public static Vector64<float>   Negate(Vector64<float>   value) { throw null; }
        public static Vector128<sbyte>  Negate(Vector128<sbyte>  value) { throw null; }
        public static Vector128<short>  Negate(Vector128<short>  value) { throw null; }
        public static Vector128<int>    Negate(Vector128<int>    value) { throw null; }
        public static Vector128<long>   Negate(Vector128<long>   value) { throw null; }
        public static Vector128<float>  Negate(Vector128<float>  value) { throw null; }
        public static Vector128<double> Negate(Vector128<double> value) { throw null; }

        /// <summary>
        /// Vector not
        /// Corresponds to vector forms of ARM64 NOT
        /// </summary>
        public static Vector64<T>  Not<T>(Vector64<T>  value) where T : struct { throw null; }
        public static Vector128<T> Not<T>(Vector128<T> value) where T : struct { throw null; }

        /// <summary>
        /// Vector or
        /// Corresponds to vector forms of ARM64 ORR
        /// </summary>
        public static Vector64<T>  Or<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> Or<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector or not
        /// Corresponds to vector forms of ARM64 ORN
        /// </summary>
        public static Vector64<T>  OrNot<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> OrNot<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector PopCount
        /// Corresponds to vector forms of ARM64 CNT
        /// </summary>
        public static Vector64<byte>    PopCount(Vector64<byte>    value) { throw null; }
        public static Vector64<sbyte>   PopCount(Vector64<sbyte>   value) { throw null; }
        public static Vector64<ushort>  PopCount(Vector64<ushort>  value) { throw null; }
        public static Vector64<short>   PopCount(Vector64<short>   value) { throw null; }
        public static Vector64<uint>    PopCount(Vector64<uint>    value) { throw null; }
        public static Vector64<int>     PopCount(Vector64<int>     value) { throw null; }
        public static Vector128<byte>   PopCount(Vector128<byte>   value) { throw null; }
        public static Vector128<sbyte>  PopCount(Vector128<sbyte>  value) { throw null; }
        public static Vector128<ushort> PopCount(Vector128<ushort> value) { throw null; }
        public static Vector128<short>  PopCount(Vector128<short>  value) { throw null; }
        public static Vector128<uint>   PopCount(Vector128<uint>   value) { throw null; }
        public static Vector128<int>    PopCount(Vector128<int>    value) { throw null; }
        public static Vector128<ulong>  PopCount(Vector128<ulong>  value) { throw null; }
        public static Vector128<long>   PopCount(Vector128<long>   value) { throw null; }

        /// <summary>
        /// SetVector* Fill vector elements by replicating element value
        ///
        /// Corresponds to vector forms of ARM64 DUP (general), DUP (element 0), FMOV (vector, immediate)
        /// </summary>
        public static Vector64<T>    SetAllVector64<T>(T value) where T : struct { throw null; }
        public static Vector128<T>   SetAllVector128<T>(T value) where T : struct { throw null; }

        /// <summary>
        /// Vector square root
        /// Corresponds to vector forms of ARM64 FRSQRT
        /// </summary>
        public static Vector64<float>   Sqrt(Vector64<float>   value) { throw null; }
        public static Vector128<float>  Sqrt(Vector128<float>  value) { throw null; }
        public static Vector128<double> Sqrt(Vector128<double> value) { throw null; }

        /// <summary>
        /// Vector subtract
        /// Corresponds to vector forms of ARM64 SUB & FSUB
        /// </summary>
        public static Vector64<T>  Subtract<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> Subtract<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }


        /// <summary>
        /// Vector exclusive or
        /// Corresponds to vector forms of ARM64 EOR
        /// </summary>
        public static Vector64<T>  Xor<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

#if ARM64_HW_INTRINSIC_NYI
        /// <summary>
        /// Vector CompareGreaterThanOrEqual
        /// For each element result[elem] = (|left[elem]| >= |right[elem]|) ? ~0 : 0
        /// Corresponds to vector forms of ARM64 FACGE
        /// </summary>
        public static Vector64<float>   AbsoluteCompareGreaterThanOrEqual(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<float>  AbsoluteCompareGreaterThanOrEqual(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> AbsoluteCompareGreaterThanOrEqual(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector CompareGreaterThan
        ///
        /// For each element result[elem] = (|left[elem]| > |right[elem]|) ? ~0 : 0
        ///
        /// Corresponds to vector forms of ARM64 FACGT
        /// </summary>
        public static Vector64<float>   AbsoluteCompareGreaterThan(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<float>  AbsoluteCompareGreaterThan(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> AbsoluteCompareGreaterThan(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector absolute difference
        /// Corresponds to vector forms of ARM64 SABD, UABD & FABD
        /// </summary>
        public static Vector64<byte>    AbsoluteDifference(Vector64<byte>    left, Vector64<byte>    right) { throw null; }
        public static Vector64<byte>    AbsoluteDifference(Vector64<sbyte>   left, Vector64<sbyte>   right) { throw null; }
        public static Vector64<ushort>  AbsoluteDifference(Vector64<ushort>  left, Vector64<ushort>  right) { throw null; }
        public static Vector64<ushort>  AbsoluteDifference(Vector64<short>   left, Vector64<short>   right) { throw null; }
        public static Vector64<uint>    AbsoluteDifference(Vector64<uint>    left, Vector64<uint>    right) { throw null; }
        public static Vector64<uint>    AbsoluteDifference(Vector64<int>     left, Vector64<int>     right) { throw null; }
        public static Vector64<float>   AbsoluteDifference(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<byte>   AbsoluteDifference(Vector128<byte>   left, Vector128<byte>   right) { throw null; }
        public static Vector128<byte>   AbsoluteDifference(Vector128<sbyte>  left, Vector128<sbyte>  right) { throw null; }
        public static Vector128<ushort> AbsoluteDifference(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static Vector128<ushort> AbsoluteDifference(Vector128<short>  left, Vector128<short>  right) { throw null; }
        public static Vector128<uint>   AbsoluteDifference(Vector128<uint>   left, Vector128<uint>   right) { throw null; }
        public static Vector128<uint>   AbsoluteDifference(Vector128<int>    left, Vector128<int>    right) { throw null; }
        public static Vector128<float>  AbsoluteDifference(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> AbsoluteDifference(Vector128<double> left, Vector128<double> right) { throw null; }

        /// TBD Addhn, Addhn2

        /// <summary>
        /// Vector absolute difference add
        ///
        /// For each element result[elem] = acc[elem] + | left[elem] - right[elem] |
        ///
        /// Corresponds to vector forms of ARM64 SABA, UABA
        /// </summary>
        public static Vector64<byte>    AbsoluteDifferenceAdd(Vector64<byte>    acc, Vector64<byte>    left, Vector64<byte>    right) { throw null; }
        public static Vector64<byte>    AbsoluteDifferenceAdd(Vector64<sbyte>   acc, Vector64<sbyte>   left, Vector64<sbyte>   right) { throw null; }
        public static Vector64<ushort>  AbsoluteDifferenceAdd(Vector64<ushort>  acc, Vector64<ushort>  left, Vector64<ushort>  right) { throw null; }
        public static Vector64<ushort>  AbsoluteDifferenceAdd(Vector64<short>   acc, Vector64<short>   left, Vector64<short>   right) { throw null; }
        public static Vector64<uint>    AbsoluteDifferenceAdd(Vector64<uint>    acc, Vector64<uint>    left, Vector64<uint>    right) { throw null; }
        public static Vector64<uint>    AbsoluteDifferenceAdd(Vector64<int>     acc, Vector64<int>     left, Vector64<int>     right) { throw null; }
        public static Vector128<byte>   AbsoluteDifferenceAdd(Vector128<byte>   acc, Vector128<byte>   left, Vector128<byte>   right) { throw null; }
        public static Vector128<byte>   AbsoluteDifferenceAdd(Vector128<sbyte>  acc, Vector128<sbyte>  left, Vector128<sbyte>  right) { throw null; }
        public static Vector128<ushort> AbsoluteDifferenceAdd(Vector128<ushort> acc, Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static Vector128<ushort> AbsoluteDifferenceAdd(Vector128<short>  acc, Vector128<short>  left, Vector128<short>  right) { throw null; }
        public static Vector128<uint>   AbsoluteDifferenceAdd(Vector128<uint>   acc, Vector128<uint>   left, Vector128<uint>   right) { throw null; }
        public static Vector128<uint>   AbsoluteDifferenceAdd(Vector128<int>    acc, Vector128<int>    left, Vector128<int>    right) { throw null; }

        /// <summary>
        /// Vector add pairwise
        /// For each byte result[byte] = 2*byte < result.Length ? (left[2*byte] + left[2*byte + 1]) : (right[2*byte - result.Length] + right[2*byte + 1 - result.Length])
        /// Corresponds to vector forms of ARM64 ADDP & FADDP
        /// </summary>
        public static Vector64<T>  AddPairwise<T>(Vector64<T>  left, Vector64<T>  right) where T : struct { throw null; }
        public static Vector128<T> AddPairwise<T>(Vector128<T> left, Vector128<T> right) where T : struct { throw null; }

        /// <summary>
        /// Vector add across vector elements
        /// Corresponds to vector forms of ARM64 ADDV
        /// </summary>
        public static byte   AddAcross(Vector64<byte>    value) { throw null; }
        public static sbyte  AddAcross(Vector64<sbyte>   value) { throw null; }
        public static ushort AddAcross(Vector64<ushort>  value) { throw null; }
        public static short  AddAcross(Vector64<short>   value) { throw null; }
        public static uint   AddAcross(Vector64<uint>    value) { throw null; }
        public static int    AddAcross(Vector64<int>     value) { throw null; }
        public static byte   AddAcross(Vector128<byte>   value) { throw null; }
        public static sbyte  AddAcross(Vector128<sbyte>  value) { throw null; }
        public static ushort AddAcross(Vector128<ushort> value) { throw null; }
        public static short  AddAcross(Vector128<short>  value) { throw null; }
        public static uint   AddAcross(Vector128<uint>   value) { throw null; }
        public static int    AddAcross(Vector128<int>    value) { throw null; }

        /// <summary>
        /// Vector extract from pair of vectors
        /// For each byte result[byte] = byte + index < result.Length ? left[byte + index] : right[byte + index - result.Length]
        ///
        /// Note: index must be a JIT time const expression which can be used to populate the literal immediate field
        ///
        /// Corresponds to vector forms of ARM64 EXT
        /// </summary>
        public static Vector64<T>  Extract<T>(Vector64<T>  left, Vector64<T>  right, byte index) where T : struct { throw null; }
        public static Vector128<T> Extract<T>(Vector128<T> left, Vector128<T> right, byte index) where T : struct { throw null; }

        /// <summary>
        /// Vector max numeric
        /// Corresponds to vector forms of ARM64 FMAXNM
        /// </summary>
        public static Vector64<float>   MaxNumeric(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<float>  MaxNumeric(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> MaxNumeric(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector max numeric pairwise
        ///
        /// For each element result[elem] = 2*elem < result.Length ? max(left[2*elem], left[2*byte + 1]) : max(right[2*byte - result.Length], right[2*byte + 1 - result.Length])
        ///
        /// Corresponds to vector forms of ARM64 FMAXNMP
        /// </summary>
        public static Vector64<float>   MaxNumericPairwise(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<float>  MaxNumericPairwise(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> MaxNumericPairwise(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector max numeric across
        ///
        /// result = max(value[0], ... , value[length -1])
        ///
        /// Corresponds to vector forms of ARM64 FMAXNMV
        /// </summary>
        public static float  MaxNumericAcross(Vector64<float>   value) { throw null; }
        public static float  MaxNumericAcross(Vector128<float>  value) { throw null; }
        public static double MaxNumericAcross(Vector128<double> value) { throw null; }

        /// <summary>
        /// Vector max pairwise
        ///
        /// For each element result[elem] = 2*elem < result.Length ? max(left[2*elem], left[2*byte + 1]) : max(right[2*byte - result.Length], right[2*byte + 1 - result.Length])
        ///
        /// Corresponds to vector forms of ARM64 SMAXP, UMAXP & FMAXP
        /// </summary>
        public static Vector64<byte>    MaxPairwise(Vector64<byte>    left, Vector64<byte>    right) { throw null; }
        public static Vector64<sbyte>   MaxPairwise(Vector64<sbyte>   left, Vector64<sbyte>   right) { throw null; }
        public static Vector64<ushort>  MaxPairwise(Vector64<ushort>  left, Vector64<ushort>  right) { throw null; }
        public static Vector64<short>   MaxPairwise(Vector64<short>   left, Vector64<short>   right) { throw null; }
        public static Vector64<uint>    MaxPairwise(Vector64<uint>    left, Vector64<uint>    right) { throw null; }
        public static Vector64<int>     MaxPairwise(Vector64<int>     left, Vector64<int>     right) { throw null; }
        public static Vector64<float>   MaxPairwise(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<byte>   MaxPairwise(Vector128<byte>   left, Vector128<byte>   right) { throw null; }
        public static Vector128<sbyte>  MaxPairwise(Vector128<sbyte>  left, Vector128<sbyte>  right) { throw null; }
        public static Vector128<ushort> MaxPairwise(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static Vector128<short>  MaxPairwise(Vector128<short>  left, Vector128<short>  right) { throw null; }
        public static Vector128<uint>   MaxPairwise(Vector128<uint>   left, Vector128<uint>   right) { throw null; }
        public static Vector128<int>    MaxPairwise(Vector128<int>    left, Vector128<int>    right) { throw null; }
        public static Vector128<float>  MaxPairwise(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> MaxPairwise(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector max across
        ///
        /// result = max(value[0], ... , value[length -1])
        ///
        /// Corresponds to vector forms of ARM64 SMAXP, UMAXP & FMAXP
        /// </summary>
        public static byte   MaxAcross(Vector64<byte>    value) { throw null; }
        public static sbyte  MaxAcross(Vector64<sbyte>   value) { throw null; }
        public static ushort MaxAcross(Vector64<ushort>  value) { throw null; }
        public static short  MaxAcross(Vector64<short>   value) { throw null; }
        public static uint   MaxAcross(Vector64<uint>    value) { throw null; }
        public static int    MaxAcross(Vector64<int>     value) { throw null; }
        public static float  MaxAcross(Vector64<float>   value) { throw null; }
        public static byte   MaxAcross(Vector128<byte>   value) { throw null; }
        public static sbyte  MaxAcross(Vector128<sbyte>  value) { throw null; }
        public static ushort MaxAcross(Vector128<ushort> value) { throw null; }
        public static short  MaxAcross(Vector128<short>  value) { throw null; }
        public static uint   MaxAcross(Vector128<uint>   value) { throw null; }
        public static int    MaxAcross(Vector128<int>    value) { throw null; }
        public static ulong  MaxAcross(Vector128<ulong>  value) { throw null; }
        public static long   MaxAcross(Vector128<long>   value) { throw null; }
        public static float  MaxAcross(Vector128<float>  value) { throw null; }
        public static double MaxAcross(Vector128<double> value) { throw null; }

        /// <summary>
        /// Vector min numeric
        /// Corresponds to vector forms of ARM64 FMINNM
        /// </summary>
        public static Vector64<float>   MinNumeric(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<float>  MinNumeric(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> MinNumeric(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector min numeric pairwise
        ///
        /// For each element result[elem] = 2*elem < result.Length ? min(left[2*elem], left[2*byte + 1]) : min(right[2*byte - result.Length], right[2*byte + 1 - result.Length])
        ///
        /// Corresponds to vector forms of ARM64 FMINNMP
        /// </summary>
        public static Vector64<float>   MaxNumericPairwise(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<float>  MaxNumericPairwise(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> MaxNumericPairwise(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector min numeric across
        ///
        /// result = min(value[0], ... , value[length -1])
        ///
        /// Corresponds to vector forms of ARM64 FMINNMV
        /// </summary>
        public static float  MaxNumericAcross(Vector64<float>   value) { throw null; }
        public static float  MaxNumericAcross(Vector128<float>  value) { throw null; }
        public static double MaxNumericAcross(Vector128<double> value) { throw null; }

        /// <summary>
        /// Vector min pairwise
        ///
        /// For each element result[elem] = 2*elem < result.Length ? min(left[2*elem], left[2*byte + 1]) : min(right[2*byte - result.Length], right[2*byte + 1 - result.Length])
        ///
        /// Corresponds to vector forms of ARM64 SMAXP, UMAXP & FMAXP
        /// </summary>
        public static Vector64<byte>    MinPairwise(Vector64<byte>    left, Vector64<byte>    right) { throw null; }
        public static Vector64<sbyte>   MinPairwise(Vector64<sbyte>   left, Vector64<sbyte>   right) { throw null; }
        public static Vector64<ushort>  MinPairwise(Vector64<ushort>  left, Vector64<ushort>  right) { throw null; }
        public static Vector64<short>   MinPairwise(Vector64<short>   left, Vector64<short>   right) { throw null; }
        public static Vector64<uint>    MinPairwise(Vector64<uint>    left, Vector64<uint>    right) { throw null; }
        public static Vector64<int>     MinPairwise(Vector64<int>     left, Vector64<int>     right) { throw null; }
        public static Vector64<float>   MinPairwise(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<byte>   MinPairwise(Vector128<byte>   left, Vector128<byte>   right) { throw null; }
        public static Vector128<sbyte>  MinPairwise(Vector128<sbyte>  left, Vector128<sbyte>  right) { throw null; }
        public static Vector128<ushort> MinPairwise(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static Vector128<short>  MinPairwise(Vector128<short>  left, Vector128<short>  right) { throw null; }
        public static Vector128<uint>   MinPairwise(Vector128<uint>   left, Vector128<uint>   right) { throw null; }
        public static Vector128<int>    MinPairwise(Vector128<int>    left, Vector128<int>    right) { throw null; }
        public static Vector128<float>  MinPairwise(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> MinPairwise(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector min across
        ///
        /// result = max(value[0], ... , value[length -1])
        ///
        /// Corresponds to vector forms of ARM64 SMAXP, UMAXP & FMAXP
        /// </summary>
        public static byte   MinAcross(Vector64<byte>    value) { throw null; }
        public static sbyte  MinAcross(Vector64<sbyte>   value) { throw null; }
        public static ushort MinAcross(Vector64<ushort>  value) { throw null; }
        public static short  MinAcross(Vector64<short>   value) { throw null; }
        public static uint   MinAcross(Vector64<uint>    value) { throw null; }
        public static int    MinAcross(Vector64<int>     value) { throw null; }
        public static float  MinAcross(Vector64<float>   value) { throw null; }
        public static byte   MinAcross(Vector128<byte>   value) { throw null; }
        public static sbyte  MinAcross(Vector128<sbyte>  value) { throw null; }
        public static ushort MinAcross(Vector128<ushort> value) { throw null; }
        public static short  MinAcross(Vector128<short>  value) { throw null; }
        public static uint   MinAcross(Vector128<uint>   value) { throw null; }
        public static int    MinAcross(Vector128<int>    value) { throw null; }
        public static float  MinAcross(Vector128<float>  value) { throw null; }
        public static double MinAcross(Vector128<double> value) { throw null; }

        /// <summary>
        /// Vector multiply by element
        ///
        /// For each element result[elem] = left[elem] * right
        ///
        /// Right can contain Extract element
        ///
        /// Corresponds to vector forms of ARM64 FMUL
        /// </summary>
        public static Vector64<byte>    Multiply(Vector64<byte>    left, byte    right) { throw null; }
        public static Vector64<sbyte>   Multiply(Vector64<sbyte>   left, sbyte   right) { throw null; }
        public static Vector64<ushort>  Multiply(Vector64<ushort>  left, ushort  right) { throw null; }
        public static Vector64<short>   Multiply(Vector64<short>   left, short   right) { throw null; }
        public static Vector64<uint>    Multiply(Vector64<uint>    left, uint    right) { throw null; }
        public static Vector64<int>     Multiply(Vector64<int>     left, int     right) { throw null; }
        public static Vector64<float>   Multiply(Vector64<float>   left, float   right) { throw null; }
        public static Vector128<byte>   Multiply(Vector128<byte>   left, byte    right) { throw null; }
        public static Vector128<sbyte>  Multiply(Vector128<sbyte>  left, sbyte   right) { throw null; }
        public static Vector128<ushort> Multiply(Vector128<ushort> left, ushort  right) { throw null; }
        public static Vector128<short>  Multiply(Vector128<short>  left, short   right) { throw null; }
        public static Vector128<uint>   Multiply(Vector128<uint>   left, uint    right) { throw null; }
        public static Vector128<int>    Multiply(Vector128<int>    left, int     right) { throw null; }
        public static Vector128<float>  Multiply(Vector128<float>  left, float   right) { throw null; }
        public static Vector128<double> Multiply(Vector128<double> left, double  right) { throw null; }

        /// <summary>
        /// Vector multiply add
        ///
        /// For each element result[elem] = acc[elem] + left[elem] * right[elem]
        ///
        /// Corresponds to vector forms of ARM64 MLA & FMLA
        /// </summary>
        public static Vector64<byte>    MultiplyAdd(Vector64<byte>    acc, Vector64<byte>    left, Vector64<byte>    right) { throw null; }
        public static Vector64<sbyte>   MultiplyAdd(Vector64<sbyte>   acc, Vector64<sbyte>   left, Vector64<sbyte>   right) { throw null; }
        public static Vector64<ushort>  MultiplyAdd(Vector64<ushort>  acc, Vector64<ushort>  left, Vector64<ushort>  right) { throw null; }
        public static Vector64<short>   MultiplyAdd(Vector64<short>   acc, Vector64<short>   left, Vector64<short>   right) { throw null; }
        public static Vector64<uint>    MultiplyAdd(Vector64<uint>    acc, Vector64<uint>    left, Vector64<uint>    right) { throw null; }
        public static Vector64<int>     MultiplyAdd(Vector64<int>     acc, Vector64<int>     left, Vector64<int>     right) { throw null; }
        public static Vector64<float>   MultiplyAdd(Vector64<float>   acc, Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<byte>   MultiplyAdd(Vector128<byte>   acc, Vector128<byte>   left, Vector128<byte>   right) { throw null; }
        public static Vector128<sbyte>  MultiplyAdd(Vector128<sbyte>  acc, Vector128<sbyte>  left, Vector128<sbyte>  right) { throw null; }
        public static Vector128<ushort> MultiplyAdd(Vector128<ushort> acc, Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static Vector128<short>  MultiplyAdd(Vector128<short>  acc, Vector128<short>  left, Vector128<short>  right) { throw null; }
        public static Vector128<uint>   MultiplyAdd(Vector128<uint>   acc, Vector128<uint>   left, Vector128<uint>   right) { throw null; }
        public static Vector128<int>    MultiplyAdd(Vector128<int>    acc, Vector128<int>    left, Vector128<int>    right) { throw null; }
        public static Vector128<float>  MultiplyAdd(Vector128<float>  acc, Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> MultiplyAdd(Vector128<double> acc, Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector multiply add by element
        ///
        /// For each element result[elem] = acc[elem] + left[elem] * right
        ///
        /// Corresponds to vector forms of ARM64 MLA & FMLA
        /// </summary>
        public static Vector64<byte>    MultiplyAdd(Vector64<byte>    acc, Vector64<byte>    left, byte    right) { throw null; }
        public static Vector64<sbyte>   MultiplyAdd(Vector64<sbyte>   acc, Vector64<sbyte>   left, sbyte   right) { throw null; }
        public static Vector64<ushort>  MultiplyAdd(Vector64<ushort>  acc, Vector64<ushort>  left, ushort  right) { throw null; }
        public static Vector64<short>   MultiplyAdd(Vector64<short>   acc, Vector64<short>   left, short   right) { throw null; }
        public static Vector64<uint>    MultiplyAdd(Vector64<uint>    acc, Vector64<uint>    left, uint    right) { throw null; }
        public static Vector64<int>     MultiplyAdd(Vector64<int>     acc, Vector64<int>     left, int     right) { throw null; }
        public static Vector64<float>   MultiplyAdd(Vector64<float>   acc, Vector64<float>   left, float   right) { throw null; }
        public static Vector128<byte>   MultiplyAdd(Vector128<byte>   acc, Vector128<byte>   left, byte    right) { throw null; }
        public static Vector128<sbyte>  MultiplyAdd(Vector128<sbyte>  acc, Vector128<sbyte>  left, sbyte   right) { throw null; }
        public static Vector128<ushort> MultiplyAdd(Vector128<ushort> acc, Vector128<ushort> left, ushort  right) { throw null; }
        public static Vector128<short>  MultiplyAdd(Vector128<short>  acc, Vector128<short>  left, short   right) { throw null; }
        public static Vector128<uint>   MultiplyAdd(Vector128<uint>   acc, Vector128<uint>   left, uint    right) { throw null; }
        public static Vector128<int>    MultiplyAdd(Vector128<int>    acc, Vector128<int>    left, int     right) { throw null; }
        public static Vector128<float>  MultiplyAdd(Vector128<float>  acc, Vector128<float>  left, float   right) { throw null; }
        public static Vector128<double> MultiplyAdd(Vector128<double> acc, Vector128<double> left, double  right) { throw null; }

        /// <summary>
        /// Vector multiply extend
        ///
        /// For each element result[elem] = left[elem] * right[elem]
        /// Handle extend special cases zero and infinite.  FMULX
        ///
        /// Corresponds to vector forms of ARM64 FMULX
        /// </summary>
        public static Vector64<float>   MultiplyExtend(Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<float>  MultiplyExtend(Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> MultiplyExtend(Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector multiply extend by element
        ///
        /// For each element result[elem] = left[elem] * right
        /// Handle extend special cases zero and infinite.  FMULX
        ///
        /// Corresponds to vector forms of ARM64 FMULX
        /// </summary>
        public static Vector64<float>   MultiplyExtend(Vector64<float>   left, float  right) { throw null; }
        public static Vector128<float>  MultiplyExtend(Vector128<float>  left, float  right) { throw null; }
        public static Vector128<double> MultiplyExtend(Vector128<double> left, double right) { throw null; }

        /// <summary>
        /// Vector multiply subtract
        ///
        /// For each element result[elem] = acc[elem] - left[elem] * right[elem]
        ///
        /// Corresponds to vector forms of ARM64 MLS & FMLS
        /// </summary>
        public static Vector64<byte>    MultiplySubtract(Vector64<byte>    acc, Vector64<byte>    left, Vector64<byte>    right) { throw null; }
        public static Vector64<sbyte>   MultiplySubtract(Vector64<sbyte>   acc, Vector64<sbyte>   left, Vector64<sbyte>   right) { throw null; }
        public static Vector64<ushort>  MultiplySubtract(Vector64<ushort>  acc, Vector64<ushort>  left, Vector64<ushort>  right) { throw null; }
        public static Vector64<short>   MultiplySubtract(Vector64<short>   acc, Vector64<short>   left, Vector64<short>   right) { throw null; }
        public static Vector64<uint>    MultiplySubtract(Vector64<uint>    acc, Vector64<uint>    left, Vector64<uint>    right) { throw null; }
        public static Vector64<int>     MultiplySubtract(Vector64<int>     acc, Vector64<int>     left, Vector64<int>     right) { throw null; }
        public static Vector64<float>   MultiplySubtract(Vector64<float>   acc, Vector64<float>   left, Vector64<float>   right) { throw null; }
        public static Vector128<byte>   MultiplySubtract(Vector128<byte>   acc, Vector128<byte>   left, Vector128<byte>   right) { throw null; }
        public static Vector128<sbyte>  MultiplySubtract(Vector128<sbyte>  acc, Vector128<sbyte>  left, Vector128<sbyte>  right) { throw null; }
        public static Vector128<ushort> MultiplySubtract(Vector128<ushort> acc, Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static Vector128<short>  MultiplySubtract(Vector128<short>  acc, Vector128<short>  left, Vector128<short>  right) { throw null; }
        public static Vector128<uint>   MultiplySubtract(Vector128<uint>   acc, Vector128<uint>   left, Vector128<uint>   right) { throw null; }
        public static Vector128<int>    MultiplySubtract(Vector128<int>    acc, Vector128<int>    left, Vector128<int>    right) { throw null; }
        public static Vector128<float>  MultiplySubtract(Vector128<float>  acc, Vector128<float>  left, Vector128<float>  right) { throw null; }
        public static Vector128<double> MultiplySubtract(Vector128<double> acc, Vector128<double> left, Vector128<double> right) { throw null; }

        /// <summary>
        /// Vector multiply subtract by element
        ///
        /// For each element result[elem] = acc[elem] - left[elem] * right
        ///
        /// Corresponds to vector forms of ARM64 MLS & FMLS
        /// </summary>
        public static Vector64<byte>    MultiplySubtract(Vector64<byte>    acc, Vector64<byte>    left, byte    right) { throw null; }
        public static Vector64<sbyte>   MultiplySubtract(Vector64<sbyte>   acc, Vector64<sbyte>   left, sbyte   right) { throw null; }
        public static Vector64<ushort>  MultiplySubtract(Vector64<ushort>  acc, Vector64<ushort>  left, ushort  right) { throw null; }
        public static Vector64<short>   MultiplySubtract(Vector64<short>   acc, Vector64<short>   left, short   right) { throw null; }
        public static Vector64<uint>    MultiplySubtract(Vector64<uint>    acc, Vector64<uint>    left, uint    right) { throw null; }
        public static Vector64<int>     MultiplySubtract(Vector64<int>     acc, Vector64<int>     left, int     right) { throw null; }
        public static Vector64<float>   MultiplySubtract(Vector64<float>   acc, Vector64<float>   left, float   right) { throw null; }
        public static Vector128<byte>   MultiplySubtract(Vector128<byte>   acc, Vector128<byte>   left, byte    right) { throw null; }
        public static Vector128<sbyte>  MultiplySubtract(Vector128<sbyte>  acc, Vector128<sbyte>  left, sbyte   right) { throw null; }
        public static Vector128<ushort> MultiplySubtract(Vector128<ushort> acc, Vector128<ushort> left, ushort  right) { throw null; }
        public static Vector128<short>  MultiplySubtract(Vector128<short>  acc, Vector128<short>  left, short   right) { throw null; }
        public static Vector128<uint>   MultiplySubtract(Vector128<uint>   acc, Vector128<uint>   left, uint    right) { throw null; }
        public static Vector128<int>    MultiplySubtract(Vector128<int>    acc, Vector128<int>    left, int     right) { throw null; }
        public static Vector128<float>  MultiplySubtract(Vector128<float>  acc, Vector128<float>  left, float   right) { throw null; }
        public static Vector128<double> MultiplySubtract(Vector128<double> acc, Vector128<double> left, double  right) { throw null; }

        /// <summary>
        /// Vector polynomial multiply
        /// Corresponds to vector forms of ARM64 PMUL
        /// </summary>
        public static Vector64<byte>    PolynomialMultiply(Vector64<byte>    left, Vector64<byte>    right) { throw null; }
        public static Vector64<sbyte>   PolynomialMultiply(Vector64<sbyte>   left, Vector64<sbyte>   right) { throw null; }
        public static Vector128<byte>   PolynomialMultiply(Vector128<byte>   left, Vector128<byte>   right) { throw null; }
        public static Vector128<sbyte>  PolynomialMultiply(Vector128<sbyte>  left, Vector128<sbyte>  right) { throw null; }

        /// Vector reciprocal estimate
        ///
        /// See FRECPE docs
        ///
        /// Corresponds to vector forms of ARM64 FRECPE
        /// </summary>
        public static Vector64<float>   ReciprocalEstimate(Vector64<float>   value) { throw null; }
        public static Vector128<float>  ReciprocalEstimate(Vector128<float>  value) { throw null; }
        public static Vector128<double> ReciprocalEstimate(Vector128<double> value) { throw null; }

        /// <summary>
        /// Vector reciprocal step
        ///
        /// See FRECPS docs
        ///
        /// Corresponds to vector forms of ARM64 FRECPS
        /// </summary>
        public static Vector64<float>   ReciprocalStep(Vector64<float>   left, Vector64<float>   right, byte index) { throw null; }
        public static Vector128<float>  ReciprocalStep(Vector128<float>  left, Vector128<float>  right, byte index) { throw null; }
        public static Vector128<double> ReciprocalStep(Vector128<double> left, Vector128<double> right, byte index) { throw null; }

        /// <summary>
        /// Vector reciprocal exponent
        ///
        /// See FRECPX docs
        ///
        /// Corresponds to vector forms of ARM64 FRECPX
        /// </summary>
        public static Vector64<float>   ReciprocalExponent(Vector64<float>   value) { throw null; }
        public static Vector128<float>  ReciprocalExponent(Vector128<float>  value) { throw null; }
        public static Vector128<double> ReciprocalExponent(Vector128<double> value) { throw null; }

        /// <summary>
        /// Vector reciprocal square root estimate
        ///
        /// See FRSQRTE docs
        ///
        /// Corresponds to vector forms of ARM64 FRSQRTE
        /// </summary>
        public static Vector64<float>   ReciprocalSquareRootEstimate(Vector64<float>   value) { throw null; }
        public static Vector128<float>  ReciprocalSquareRootEstimate(Vector128<float>  value) { throw null; }
        public static Vector128<double> ReciprocalSquareRootEstimate(Vector128<double> value) { throw null; }

        /// <summary>
        /// Vector reciprocal square root step
        ///
        /// See FRSQRTS docs
        ///
        /// Corresponds to vector forms of ARM64 FRSQRTS
        /// </summary>
        public static Vector64<float>   ReciprocalSquareRootEstimate(Vector64<float>   left, Vector64<float>   right, byte index) { throw null; }
        public static Vector128<float>  ReciprocalSquareRootEstimate(Vector128<float>  left, Vector128<float>  right, byte index) { throw null; }
        public static Vector128<double> ReciprocalSquareRootEstimate(Vector128<double> left, Vector128<double> right, byte index) { throw null; }

        /// <summary>
        /// Vector reverse byte bits
        /// Corresponds to vector forms of ARM64 RBIT
        /// </summary>
        public static Vector64<byte>    ReverseElementBits(Vector64<byte>    value) { throw null; }
        public static Vector64<sbyte>   ReverseElementBits(Vector64<sbyte>   value) { throw null; }
        public static Vector128<byte>   ReverseElementBits(Vector128<byte>   value) { throw null; }
        public static Vector128<sbyte>  ReverseElementBits(Vector128<sbyte>  value) { throw null; }

        /// <summary>
        /// Vector reverse element bytes
        /// Corresponds to vector forms of ARM64 REV16, REV32, REV64
        /// </summary>
        public static Vector64<ushort>  ReverseElementBytes(Vector64<ushort>  value) { throw null; }
        public static Vector64<short>   ReverseElementBytes(Vector64<short>   value) { throw null; }
        public static Vector64<uint>    ReverseElementBytes(Vector64<uint>    value) { throw null; }
        public static Vector64<int>     ReverseElementBytes(Vector64<int>     value) { throw null; }
        public static Vector64<float>   ReverseElementBytes(Vector64<float>   value) { throw null; }
        public static Vector128<ushort> ReverseElementBytes(Vector128<ushort> value) { throw null; }
        public static Vector128<short>  ReverseElementBytes(Vector128<short>  value) { throw null; }
        public static Vector128<uint>   ReverseElementBytes(Vector128<uint>   value) { throw null; }
        public static Vector128<int>    ReverseElementBytes(Vector128<int>    value) { throw null; }
        public static Vector128<ulong>  ReverseElementBytes(Vector128<ulong>  value) { throw null; }
        public static Vector128<long>   ReverseElementBytes(Vector128<long>   value) { throw null; }
        public static Vector128<float>  ReverseElementBytes(Vector128<float>  value) { throw null; }
        public static Vector128<double> ReverseElementBytes(Vector128<double> value) { throw null; }
#endif
    }
}
namespace System.Runtime.Intrinsics.X86
{
    public static class Aes 
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<sbyte> Decrypt(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw null; }
        public static Vector128<byte> Decrypt(Vector128<byte> value, Vector128<byte> roundKey) { throw null; }
        public static Vector128<sbyte> DecryptLast(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw null; }
        public static Vector128<byte> DecryptLast(Vector128<byte> value, Vector128<byte> roundKey) { throw null; }
        public static Vector128<sbyte> Encrypt(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw null; }
        public static Vector128<byte> Encrypt(Vector128<byte> value, Vector128<byte> roundKey) { throw null; }
        public static Vector128<sbyte> EncryptLast(Vector128<sbyte> value, Vector128<sbyte> roundKey) { throw null; }
        public static Vector128<byte> EncryptLast(Vector128<byte> value, Vector128<byte> roundKey) { throw null; }
        public static Vector128<sbyte> InvisibleMixColumn(Vector128<sbyte> value) { throw null; }
        public static Vector128<byte> InvisibleMixColumn(Vector128<byte> value) { throw null; }
        public static Vector128<sbyte> KeygenAssist(Vector128<sbyte> value, byte control) { throw null; }
        public static Vector128<byte> KeygenAssist(Vector128<byte> value, byte control) { throw null; }
    }
    public static class Avx
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector256<float> Add(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Add(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> AddSubtract(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> AddSubtract(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> And(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> And(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> AndNot(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> AndNot(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> Blend(Vector256<float> left, Vector256<float> right, byte control) { throw null; }
        public static Vector256<double> Blend(Vector256<double> left, Vector256<double> right, byte control) { throw null; }
        public static Vector256<float> BlendVariable(Vector256<float> left, Vector256<float> right, Vector256<float> mask) { throw null; }
        public static Vector256<double> BlendVariable(Vector256<double> left, Vector256<double> right, Vector256<double> mask) { throw null; }
        public static Vector128<float> BroadcastElementToVector128(ref float source) { throw null; }
        public static unsafe Vector256<float> BroadcastVector128ToVector256(float* address) { throw null; }
        public static Vector256<float> BroadcastElementToVector256(ref float source) { throw null; }
        public static unsafe Vector256<double> BroadcastVector128ToVector256(double* address) { throw null; }
        public static Vector256<double> BroadcastElementToVector256(ref double source) { throw null; }
        public static Vector256<float> Ceiling(Vector256<float> value) { throw null; }
        public static Vector256<double> Ceiling(Vector256<double> value) { throw null; }
        public static Vector128<float> Compare(Vector128<float> left, Vector128<float> right, FloatComparisonMode mode) { throw null; }
        public static Vector128<double> Compare(Vector128<double> left, Vector128<double> right, FloatComparisonMode mode) { throw null; }
        public static Vector256<float> Compare(Vector256<float> left, Vector256<float> right, FloatComparisonMode mode) { throw null; }
        public static Vector256<double> Compare(Vector256<double> left, Vector256<double> right, FloatComparisonMode mode) { throw null; }
        public static Vector128<double> CompareScalar(Vector128<double> left, Vector128<double> right, FloatComparisonMode mode) { throw null; }
        public static Vector128<float> CompareScalar(Vector128<float> left, Vector128<float> right, FloatComparisonMode mode) { throw null; }
        public static float ConvertToSingle(Vector256<float> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32(Vector256<double> value) { throw null; }
        public static Vector128<float> ConvertToVector128Single(Vector256<double> value) { throw null; }
        public static Vector256<int> ConvertToVector256Int32(Vector256<float> value) { throw null; }
        public static Vector256<float> ConvertToVector256Single(Vector256<int> value) { throw null; }
        public static Vector256<double> ConvertToVector256Double(Vector256<float> value) { throw null; }
        public static Vector256<double> ConvertToVector256Double(Vector256<int> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32WithTruncation(Vector256<double> value) { throw null; }
        public static Vector256<int> ConvertToVector256Int32WithTruncation(Vector256<float> value) { throw null; }
        public static Vector256<float> Divide(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Divide(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> DotProduct(Vector256<float> left, Vector256<float> right, byte control) { throw null; }
        public static Vector256<float> DuplicateEvenIndexed(Vector256<float> value) { throw null; }
        public static Vector256<double> DuplicateEvenIndexed(Vector256<double> value) { throw null; }
        public static Vector256<float> DuplicateOddIndexed(Vector256<float> value) { throw null; }
        public static sbyte Extract(Vector256<sbyte> value, byte index) { throw null; }
        public static byte Extract(Vector256<byte> value, byte index) { throw null; }
        public static short Extract(Vector256<short> value, byte index) { throw null; }
        public static ushort Extract(Vector256<ushort> value, byte index) { throw null; }
        public static int Extract(Vector256<int> value, byte index) { throw null; }
        public static uint Extract(Vector256<uint> value, byte index) { throw null; }
        public static long Extract(Vector256<long> value, byte index) { throw null; }
        public static ulong Extract(Vector256<ulong> value, byte index) { throw null; }
        public static Vector128<T> ExtractVector128<T>(Vector256<T> value, byte index) where T : struct { throw null; }
        public static unsafe void ExtractVector128(byte* address, Vector256<byte> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(sbyte* address, Vector256<sbyte> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(short* address, Vector256<short> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(ushort* address, Vector256<ushort> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(int* address, Vector256<int> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(uint* address, Vector256<uint> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(long* address, Vector256<long> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(ulong* address, Vector256<ulong> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(float* address, Vector256<float> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(double* address, Vector256<double> value, byte index) { throw null; }
        public static Vector256<T> ExtendToVector256<T>(Vector128<T> value) where T : struct { throw null; }
        public static Vector256<float> Floor(Vector256<float> value) { throw null; }
        public static Vector256<double> Floor(Vector256<double> value) { throw null; }
        public static Vector128<T> GetLowerHalf<T>(Vector256<T> value) where T : struct { throw null; }
        public static Vector256<float> HorizontalAdd(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> HorizontalAdd(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> HorizontalSubtract(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> HorizontalSubtract(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<sbyte> Insert(Vector256<sbyte> value, sbyte data, byte index) { throw null; }
        public static Vector256<byte> Insert(Vector256<byte> value, byte data, byte index) { throw null; }
        public static Vector256<short> Insert(Vector256<short> value, short data, byte index) { throw null; }
        public static Vector256<ushort> Insert(Vector256<ushort> value, ushort data, byte index) { throw null; }
        public static Vector256<int> Insert(Vector256<int> value, int data, byte index) { throw null; }
        public static Vector256<uint> Insert(Vector256<uint> value, uint data, byte index) { throw null; }
        public static Vector256<long> Insert(Vector256<long> value, long data, byte index) { throw null; }
        public static Vector256<ulong> Insert(Vector256<ulong> value, ulong data, byte index) { throw null; }
        public static Vector256<T> Insert<T>(Vector256<T> value, Vector128<T> data, byte index) where T : struct { throw null; }
        public static unsafe Vector256<sbyte> Insert(Vector256<sbyte> value, sbyte* address, byte index) { throw null; }
        public static unsafe Vector256<byte> Insert(Vector256<byte> value, byte* address, byte index) { throw null; }
        public static unsafe Vector256<short> Insert(Vector256<short> value, short* address, byte index) { throw null; }
        public static unsafe Vector256<ushort> Insert(Vector256<ushort> value, ushort* address, byte index) { throw null; }
        public static unsafe Vector256<int> Insert(Vector256<int> value, int* address, byte index) { throw null; }
        public static unsafe Vector256<uint> Insert(Vector256<uint> value, uint* address, byte index) { throw null; }
        public static unsafe Vector256<long> Insert(Vector256<long> value, long* address, byte index) { throw null; }
        public static unsafe Vector256<ulong> Insert(Vector256<ulong> value, ulong* address, byte index) { throw null; }
        public static unsafe Vector256<float> Insert(Vector256<float> value, float* address, byte index) { throw null; }
        public static unsafe Vector256<double> Insert(Vector256<double> value, double* address, byte index) { throw null; }
        public static unsafe Vector256<sbyte> LoadVector256(sbyte* address) { throw null; }
        public static unsafe Vector256<byte> LoadVector256(byte* address) { throw null; }
        public static unsafe Vector256<short> LoadVector256(short* address) { throw null; }
        public static unsafe Vector256<ushort> LoadVector256(ushort* address) { throw null; }
        public static unsafe Vector256<int> LoadVector256(int* address) { throw null; }
        public static unsafe Vector256<uint> LoadVector256(uint* address) { throw null; }
        public static unsafe Vector256<long> LoadVector256(long* address) { throw null; }
        public static unsafe Vector256<ulong> LoadVector256(ulong* address) { throw null; }
        public static unsafe Vector256<float> LoadVector256(float* address) { throw null; }
        public static unsafe Vector256<double> LoadVector256(double* address) { throw null; }
        public static unsafe Vector256<sbyte> LoadAlignedVector256(sbyte* address) { throw null; }
        public static unsafe Vector256<byte> LoadAlignedVector256(byte* address) { throw null; }
        public static unsafe Vector256<short> LoadAlignedVector256(short* address) { throw null; }
        public static unsafe Vector256<ushort> LoadAlignedVector256(ushort* address) { throw null; }
        public static unsafe Vector256<int> LoadAlignedVector256(int* address) { throw null; }
        public static unsafe Vector256<uint> LoadAlignedVector256(uint* address) { throw null; }
        public static unsafe Vector256<long> LoadAlignedVector256(long* address) { throw null; }
        public static unsafe Vector256<ulong> LoadAlignedVector256(ulong* address) { throw null; }
        public static unsafe Vector256<float> LoadAlignedVector256(float* address) { throw null; }
        public static unsafe Vector256<double> LoadAlignedVector256(double* address) { throw null; }
        public static unsafe Vector256<sbyte> LoadDquVector256(sbyte* address) { throw null; }
        public static unsafe Vector256<byte> LoadDquVector256(byte* address) { throw null; }
        public static unsafe Vector256<short> LoadDquVector256(short* address) { throw null; }
        public static unsafe Vector256<ushort> LoadDquVector256(ushort* address) { throw null; }
        public static unsafe Vector256<int> LoadDquVector256(int* address) { throw null; }
        public static unsafe Vector256<uint> LoadDquVector256(uint* address) { throw null; }
        public static unsafe Vector256<long> LoadDquVector256(long* address) { throw null; }
        public static unsafe Vector256<ulong> LoadDquVector256(ulong* address) { throw null; }
        public static unsafe Vector128<float> MaskLoad(float* address, Vector128<uint> mask) { throw null; }
        public static unsafe Vector128<double> MaskLoad(double* address, Vector128<ulong> mask) { throw null; }
        public static unsafe Vector256<float> MaskLoad(float* address, Vector256<uint> mask) { throw null; }
        public static unsafe Vector256<double> MaskLoad(double* address, Vector256<ulong> mask) { throw null; }
        public static unsafe void MaskStore(float* address, Vector128<float> mask, Vector128<uint> source) { throw null; }
        public static unsafe void MaskStore(double* address, Vector128<double> mask, Vector128<ulong> source) { throw null; }
        public static unsafe void MaskStore(float* address, Vector256<float> mask, Vector256<uint> source) { throw null; }
        public static unsafe void MaskStore(double* address, Vector256<double> mask, Vector256<ulong> source) { throw null; }
        public static Vector256<float> Max(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Max(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> Min(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Min(Vector256<double> left, Vector256<double> right) { throw null; }
        public static int MoveMask(Vector256<float> value) { throw null; }
        public static int MoveMask(Vector256<double> value) { throw null; }
        public static Vector256<float> Multiply(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Multiply(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> Or(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Or(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector128<float> Permute(Vector128<float> value, byte control) { throw null; }
        public static Vector128<double> Permute(Vector128<double> value, byte control) { throw null; }
        public static Vector256<float> Permute(Vector256<float> value, byte control) { throw null; }
        public static Vector256<double> Permute(Vector256<double> value, byte control) { throw null; }
        public static Vector256<T> Permute2x128<T>(Vector256<T> left, Vector256<T> right, byte control) where T : struct { throw null; }
        public static Vector128<float> PermuteVar(Vector128<float> left, Vector128<float> mask) { throw null; }
        public static Vector128<double> PermuteVar(Vector128<double> left, Vector128<double> mask) { throw null; }
        public static Vector256<float> PermuteVar(Vector256<float> left, Vector256<float> mask) { throw null; }
        public static Vector256<double> PermuteVar(Vector256<double> left, Vector256<double> mask) { throw null; }
        public static Vector256<float> Reciprocal(Vector256<float> value) { throw null; }
        public static Vector256<float> ReciprocalSqrt(Vector256<float> value) { throw null; }
        public static Vector256<float> RoundToNearestInteger(Vector256<float> value) { throw null; }
        public static Vector256<float> RoundToNegativeInfinity(Vector256<float> value) { throw null; }
        public static Vector256<float> RoundToPositiveInfinity(Vector256<float> value) { throw null; }
        public static Vector256<float> RoundToZero(Vector256<float> value) { throw null; }
        public static Vector256<float> RoundCurrentDirection(Vector256<float> value) { throw null; }
        public static Vector256<double> RoundToNearestInteger(Vector256<double> value) { throw null; }
        public static Vector256<double> RoundToNegativeInfinity(Vector256<double> value) { throw null; }
        public static Vector256<double> RoundToPositiveInfinity(Vector256<double> value) { throw null; }
        public static Vector256<double> RoundToZero(Vector256<double> value) { throw null; }
        public static Vector256<double> RoundCurrentDirection(Vector256<double> value) { throw null; }
        public static Vector256<sbyte> SetVector256(sbyte e31, sbyte e30, sbyte e29, sbyte e28, sbyte e27, sbyte e26, sbyte e25, sbyte e24, sbyte e23, sbyte e22, sbyte e21, sbyte e20, sbyte e19, sbyte e18, sbyte e17, sbyte e16, sbyte e15, sbyte e14, sbyte e13, sbyte e12, sbyte e11, sbyte e10, sbyte e9, sbyte e8, sbyte e7, sbyte e6, sbyte e5, sbyte e4, sbyte e3, sbyte e2, sbyte e1, sbyte e0) { throw null; }
        public static Vector256<byte> SetVector256(byte e31, byte e30, byte e29, byte e28, byte e27, byte e26, byte e25, byte e24, byte e23, byte e22, byte e21, byte e20, byte e19, byte e18, byte e17, byte e16, byte e15, byte e14, byte e13, byte e12, byte e11, byte e10, byte e9, byte e8, byte e7, byte e6, byte e5, byte e4, byte e3, byte e2, byte e1, byte e0) { throw null; }
        public static Vector256<short> SetVector256(short e15, short e14, short e13, short e12, short e11, short e10, short e9, short e8, short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0) { throw null; }
        public static Vector256<ushort> SetVector256(ushort e15, ushort e14, ushort e13, ushort e12, ushort e11, ushort e10, ushort e9, ushort e8, ushort e7, ushort e6, ushort e5, ushort e4, ushort e3, ushort e2, ushort e1, ushort e0) { throw null; }
        public static Vector256<int> SetVector256(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0) { throw null; }
        public static Vector256<uint> SetVector256(uint e7, uint e6, uint e5, uint e4, uint e3, uint e2, uint e1, uint e0) { throw null; }
        public static Vector256<long> SetVector256(long e3, long e2, long e1, long e0) { throw null; }
        public static Vector256<ulong> SetVector256(ulong e3, ulong e2, ulong e1, ulong e0) { throw null; }
        public static Vector256<float> SetVector256(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0) { throw null; }
        public static Vector256<double> SetVector256(double e3, double e2, double e1, double e0) { throw null; }
        public static Vector256<T> SetAllVector256<T>(T value) where T : struct { throw null; }
        public static Vector256<T> SetHighLow<T>(Vector128<T> hi, Vector128<T> lo) where T : struct { throw null; }
        public static Vector256<T> SetZeroVector256<T>() where T : struct { throw null; }
        public static Vector256<float> Shuffle(Vector256<float> value, Vector256<float> right, byte control) { throw null; }
        public static Vector256<double> Shuffle(Vector256<double> value, Vector256<double> right, byte control) { throw null; }
        public static Vector256<float> Sqrt(Vector256<float> value) { throw null; }
        public static Vector256<double> Sqrt(Vector256<double> value) { throw null; }
        public static Vector256<U> StaticCast<T, U>(Vector256<T> value) where T : struct where U : struct { throw null; }
        public static unsafe void StoreAligned(sbyte* address, Vector256<sbyte> source) { throw null; }
        public static unsafe void StoreAligned(byte* address, Vector256<byte> source) { throw null; }
        public static unsafe void StoreAligned(short* address, Vector256<short> source) { throw null; }
        public static unsafe void StoreAligned(ushort* address, Vector256<ushort> source) { throw null; }
        public static unsafe void StoreAligned(int* address, Vector256<int> source) { throw null; }
        public static unsafe void StoreAligned(uint* address, Vector256<uint> source) { throw null; }
        public static unsafe void StoreAligned(long* address, Vector256<long> source) { throw null; }
        public static unsafe void StoreAligned(ulong* address, Vector256<ulong> source) { throw null; }
        public static unsafe void StoreAligned(float* address, Vector256<float> source) { throw null; }
        public static unsafe void StoreAligned(double* address, Vector256<double> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(sbyte* address, Vector256<sbyte> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(byte* address, Vector256<byte> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(short* address, Vector256<short> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(ushort* address, Vector256<ushort> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(int* address, Vector256<int> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(uint* address, Vector256<uint> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(long* address, Vector256<long> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(ulong* address, Vector256<ulong> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(float* address, Vector256<float> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(double* address, Vector256<double> source) { throw null; }
        public static unsafe void Store(sbyte* address, Vector256<sbyte> source) { throw null; }
        public static unsafe void Store(byte* address, Vector256<byte> source) { throw null; }
        public static unsafe void Store(short* address, Vector256<short> source) { throw null; }
        public static unsafe void Store(ushort* address, Vector256<ushort> source) { throw null; }
        public static unsafe void Store(int* address, Vector256<int> source) { throw null; }
        public static unsafe void Store(uint* address, Vector256<uint> source) { throw null; }
        public static unsafe void Store(long* address, Vector256<long> source) { throw null; }
        public static unsafe void Store(ulong* address, Vector256<ulong> source) { throw null; }
        public static unsafe void Store(float* address, Vector256<float> source) { throw null; }
        public static unsafe void Store(double* address, Vector256<double> source) { throw null; }
        public static Vector256<float> Subtract(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Subtract(Vector256<double> left, Vector256<double> right) { throw null; }
        public static bool TestC(Vector128<float> left, Vector128<float> right) { throw null; }       
        public static bool TestC(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool TestC<T>(Vector256<T> left, Vector256<T> right) where T : struct { throw null; }
        public static bool TestNotZAndNotC(Vector128<float> left, Vector128<float> right) { throw null; }       
        public static bool TestNotZAndNotC(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool TestNotZAndNotC<T>(Vector256<T> left, Vector256<T> right) where T : struct { throw null; }
        public static bool TestZ(Vector128<float> left, Vector128<float> right) { throw null; }
        public static bool TestZ(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool TestZ<T>(Vector256<T> left, Vector256<T> right) where T : struct { throw null; }
        public static Vector256<float> UnpackHigh(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> UnpackHigh(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> UnpackLow(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> UnpackLow(Vector256<double> left, Vector256<double> right) { throw null; }
        public static Vector256<float> Xor(Vector256<float> left, Vector256<float> right) { throw null; }
        public static Vector256<double> Xor(Vector256<double> left, Vector256<double> right) { throw null; }
        public static void ZeroAll() { throw null; }
        public static void ZeroUpper() { throw null; }
        public static Vector256<T> ZeroExtendToVector256<T>(Vector128<T> value) where T : struct { throw null; }
    }
    public static class Avx2
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector256<byte> Abs(Vector256<sbyte> value) { throw null; }
        public static Vector256<ushort> Abs(Vector256<short> value) { throw null; }
        public static Vector256<uint> Abs(Vector256<int> value) { throw null; }
        public static Vector256<sbyte> Add(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Add(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> Add(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Add(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Add(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Add(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> Add(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> Add(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> AddSaturate(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> AddSaturate(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> AddSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> AddSaturate(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<sbyte> AlignRight(Vector256<sbyte> left, Vector256<sbyte> right, byte mask) { throw null; }
        public static Vector256<sbyte> And(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> And(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> And(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> And(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> And(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> And(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> And(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> And(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> AndNot(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> AndNot(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> AndNot(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> AndNot(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> AndNot(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> AndNot(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> AndNot(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> AndNot(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<byte> Average(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<ushort> Average(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector128<int> Blend(Vector128<int> left, Vector128<int> right, byte control) { throw null; }
        public static Vector128<uint> Blend(Vector128<uint> left, Vector128<uint> right, byte control) { throw null; }
        public static Vector256<short> Blend(Vector256<short> left, Vector256<short> right, byte control) { throw null; }
        public static Vector256<ushort> Blend(Vector256<ushort> left, Vector256<ushort> right, byte control) { throw null; }
        public static Vector256<int> Blend(Vector256<int> left, Vector256<int> right, byte control) { throw null; }
        public static Vector256<uint> Blend(Vector256<uint> left, Vector256<uint> right, byte control) { throw null; }
        public static Vector256<sbyte> BlendVariable(Vector256<sbyte> left, Vector256<sbyte> right, Vector256<sbyte> mask) { throw null; }
        public static Vector256<byte> BlendVariable(Vector256<byte> left, Vector256<byte> right, Vector256<byte> mask) { throw null; }
        public static Vector128<T> BroadcastElementToVector128<T>(Vector128<T> value) where T : struct { throw null; }
        public static Vector256<T> BroadcastElementToVector256<T>(Vector128<T> value) where T : struct { throw null; }
        public static unsafe Vector256<sbyte> BroadcastVector128ToVector256(sbyte* address) { throw null; }
        public static unsafe Vector256<byte> BroadcastVector128ToVector256(byte* address) { throw null; }
        public static unsafe Vector256<short> BroadcastVector128ToVector256(short* address) { throw null; }
        public static unsafe Vector256<ushort> BroadcastVector128ToVector256(ushort* address) { throw null; }
        public static unsafe Vector256<int> BroadcastVector128ToVector256(int* address) { throw null; }
        public static unsafe Vector256<uint> BroadcastVector128ToVector256(uint* address) { throw null; }
        public static unsafe Vector256<long> BroadcastVector128ToVector256(long* address) { throw null; }
        public static unsafe Vector256<ulong> BroadcastVector128ToVector256(ulong* address) { throw null; }
        public static Vector256<sbyte> CompareEqual(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> CompareEqual(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> CompareEqual(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> CompareEqual(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> CompareEqual(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> CompareEqual(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> CompareEqual(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> CompareEqual(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> CompareGreaterThan(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<short> CompareGreaterThan(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<int> CompareGreaterThan(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<long> CompareGreaterThan(Vector256<long> left, Vector256<long> right) { throw null; }
        public static double ConvertToDouble(Vector256<double> value) { throw null; }
        public static int ConvertToInt32(Vector256<int> value) { throw null; }
        public static uint ConvertToUInt32(Vector256<uint> value) { throw null; }
        public static Vector256<short> ConvertToVector256Int16(Vector128<sbyte> value) { throw null; }
        public static Vector256<ushort> ConvertToVector256UInt16(Vector128<byte> value) { throw null; }
        public static Vector256<int> ConvertToVector256Int32(Vector128<sbyte> value) { throw null; }
        public static Vector256<int> ConvertToVector256Int32(Vector128<short> value) { throw null; }
        public static Vector256<uint> ConvertToVector256UInt32(Vector128<byte> value) { throw null; }
        public static Vector256<uint> ConvertToVector256UInt32(Vector128<ushort> value) { throw null; }
        public static Vector256<long> ConvertToVector256Int64(Vector128<sbyte> value) { throw null; }
        public static Vector256<long> ConvertToVector256Int64(Vector128<short> value) { throw null; }
        public static Vector256<long> ConvertToVector256Int64(Vector128<int> value) { throw null; }
        public static Vector256<ulong> ConvertToVector256UInt64(Vector128<byte> value) { throw null; }
        public static Vector256<ulong> ConvertToVector256UInt64(Vector128<ushort> value) { throw null; }
        public static Vector256<ulong> ConvertToVector256UInt64(Vector128<uint> value) { throw null; }
        public static Vector128<sbyte> ExtractVector128(Vector256<sbyte> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(sbyte* address, Vector256<sbyte> value, byte index) { throw null; }
        public static Vector128<byte> ExtractVector128(Vector256<byte> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(byte* address, Vector256<byte> value, byte index) { throw null; }
        public static Vector128<short> ExtractVector128(Vector256<short> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(short* address, Vector256<short> value, byte index) { throw null; }
        public static Vector128<ushort> ExtractVector128(Vector256<ushort> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(ushort* address, Vector256<ushort> value, byte index) { throw null; }
        public static Vector128<int> ExtractVector128(Vector256<int> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(int* address, Vector256<int> value, byte index) { throw null; }
        public static Vector128<uint> ExtractVector128(Vector256<uint> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(uint* address, Vector256<uint> value, byte index) { throw null; }
        public static Vector128<long> ExtractVector128(Vector256<long> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(long* address, Vector256<long> value, byte index) { throw null; }
        public static Vector128<ulong> ExtractVector128(Vector256<ulong> value, byte index) { throw null; }
        public static unsafe void ExtractVector128(ulong* address, Vector256<ulong> value, byte index) { throw null; }
        public static unsafe Vector128<int> GatherVector128(int* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherVector128(uint* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<long> GatherVector128(long* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<ulong> GatherVector128(ulong* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherVector128(float* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<double> GatherVector128(double* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<int> GatherVector128(int* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherVector128(uint* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector128<long> GatherVector128(long* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector128<ulong> GatherVector128(ulong* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherVector128(float* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector128<double> GatherVector128(double* baseAddress, Vector128<long> index, byte scale) { throw null; }
        public static unsafe Vector256<int> GatherVector256(int* baseAddress, Vector256<int> index, byte scale) { throw null; }
        public static unsafe Vector256<uint> GatherVector256(uint* baseAddress, Vector256<int> index, byte scale) { throw null; }
        public static unsafe Vector256<long> GatherVector256(long* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector256<ulong> GatherVector256(ulong* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector256<float> GatherVector256(float* baseAddress, Vector256<int> index, byte scale) { throw null; }
        public static unsafe Vector256<double> GatherVector256(double* baseAddress, Vector128<int> index, byte scale) { throw null; }
        public static unsafe Vector128<int> GatherVector128(int* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherVector128(uint* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector256<long> GatherVector256(long* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector256<ulong> GatherVector256(ulong* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherVector128(float* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector256<double> GatherVector256(double* baseAddress, Vector256<long> index, byte scale) { throw null; }
        public static unsafe Vector128<int> GatherMaskVector128(Vector128<int> source, int* baseAddress, Vector128<int> index, Vector128<int> mask, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherMaskVector128(Vector128<uint> source, uint* baseAddress, Vector128<int> index, Vector128<uint> mask, byte scale) { throw null; }
        public static unsafe Vector128<long> GatherMaskVector128(Vector128<long> source, long* baseAddress, Vector128<int> index, Vector128<long> mask, byte scale) { throw null; }
        public static unsafe Vector128<ulong> GatherMaskVector128(Vector128<ulong> source, ulong* baseAddress, Vector128<int> index, Vector128<ulong> mask, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherMaskVector128(Vector128<float> source, float* baseAddress, Vector128<int> index, Vector128<float> mask, byte scale) { throw null; }
        public static unsafe Vector128<double> GatherMaskVector128(Vector128<double> source, double* baseAddress, Vector128<int> index, Vector128<double> mask, byte scale) { throw null; }
        public static unsafe Vector128<int> GatherMaskVector128(Vector128<int> source, int* baseAddress, Vector128<long> index, Vector128<int> mask, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherMaskVector128(Vector128<uint> source, uint* baseAddress, Vector128<long> index, Vector128<uint> mask, byte scale) { throw null; }
        public static unsafe Vector128<long> GatherMaskVector128(Vector128<long> source, long* baseAddress, Vector128<long> index, Vector128<long> mask, byte scale) { throw null; }
        public static unsafe Vector128<ulong> GatherMaskVector128(Vector128<ulong> source, ulong* baseAddress, Vector128<long> index, Vector128<ulong> mask, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherMaskVector128(Vector128<float> source, float* baseAddress, Vector128<long> index, Vector128<float> mask, byte scale) { throw null; }
        public static unsafe Vector128<double> GatherMaskVector128(Vector128<double> source, double* baseAddress, Vector128<long> index, Vector128<double> mask, byte scale) { throw null; }
        public static unsafe Vector256<int> GatherMaskVector256(Vector256<int> source, int* baseAddress, Vector256<int> index, Vector256<int> mask, byte scale) { throw null; }
        public static unsafe Vector256<uint> GatherMaskVector256(Vector256<uint> source, uint* baseAddress, Vector256<int> index, Vector256<uint> mask, byte scale) { throw null; }
        public static unsafe Vector256<long> GatherMaskVector256(Vector256<long> source, long* baseAddress, Vector128<int> index, Vector256<long> mask, byte scale) { throw null; }
        public static unsafe Vector256<ulong> GatherMaskVector256(Vector256<ulong> source, ulong* baseAddress, Vector128<int> index, Vector256<ulong> mask, byte scale) { throw null; }
        public static unsafe Vector256<float> GatherMaskVector256(Vector256<float> source, float* baseAddress, Vector256<int> index, Vector256<float> mask, byte scale) { throw null; }
        public static unsafe Vector256<double> GatherMaskVector256(Vector256<double> source, double* baseAddress, Vector128<int> index, Vector256<double> mask, byte scale) { throw null; }
        public static unsafe Vector128<int> GatherMaskVector128(Vector128<int> source, int* baseAddress, Vector256<long> index, Vector128<int> mask, byte scale) { throw null; }
        public static unsafe Vector128<uint> GatherMaskVector128(Vector128<uint> source, uint* baseAddress, Vector256<long> index, Vector128<uint> mask, byte scale) { throw null; }
        public static unsafe Vector256<long> GatherMaskVector256(Vector256<long> source, long* baseAddress, Vector256<long> index, Vector256<long> mask, byte scale) { throw null; }
        public static unsafe Vector256<ulong> GatherMaskVector256(Vector256<ulong> source, ulong* baseAddress, Vector256<long> index, Vector256<ulong> mask, byte scale) { throw null; }
        public static unsafe Vector128<float> GatherMaskVector128(Vector128<float> source, float* baseAddress, Vector256<long> index, Vector128<float> mask, byte scale) { throw null; }
        public static unsafe Vector256<double> GatherMaskVector256(Vector256<double> source, double* baseAddress, Vector256<long> index, Vector256<double> mask, byte scale) { throw null; }
        public static Vector256<short> HorizontalAdd(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<int> HorizontalAdd(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<short> HorizontalAddSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<short> HorizontalSubtract(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<int> HorizontalSubtract(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<short> HorizontalSubtractSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<sbyte> Insert(Vector256<sbyte> value, Vector128<sbyte> data, byte index) { throw null; }
        public static unsafe Vector256<sbyte> Insert(Vector256<sbyte> value, sbyte* address, byte index) { throw null; }
        public static Vector256<byte> Insert(Vector256<byte> value, Vector128<byte> data, byte index) { throw null; }
        public static unsafe Vector256<byte> Insert(Vector256<byte> value, byte* address, byte index) { throw null; }
        public static Vector256<short> Insert(Vector256<short> value, Vector128<short> data, byte index) { throw null; }
        public static unsafe Vector256<short> Insert(Vector256<short> value, short* address, byte index) { throw null; }
        public static Vector256<ushort> Insert(Vector256<ushort> value, Vector128<ushort> data, byte index) { throw null; }
        public static unsafe Vector256<ushort> Insert(Vector256<ushort> value, ushort* address, byte index) { throw null; }
        public static Vector256<int> Insert(Vector256<int> value, Vector128<int> data, byte index) { throw null; }
        public static unsafe Vector256<int> Insert(Vector256<int> value, int* address, byte index) { throw null; }
        public static Vector256<uint> Insert(Vector256<uint> value, Vector128<uint> data, byte index) { throw null; }
        public static unsafe Vector256<uint> Insert(Vector256<uint> value, uint* address, byte index) { throw null; }
        public static Vector256<long> Insert(Vector256<long> value, Vector128<long> data, byte index) { throw null; }
        public static unsafe Vector256<long> Insert(Vector256<long> value, long* address, byte index) { throw null; }
        public static Vector256<ulong> Insert(Vector256<ulong> value, Vector128<ulong> data, byte index) { throw null; }
        public static unsafe Vector256<ulong> Insert(Vector256<ulong> value, ulong* address, byte index) { throw null; }
        public static unsafe Vector128<int> MaskLoad(int* address, Vector128<int> mask) { throw null; }
        public static unsafe Vector256<sbyte> LoadAlignedVector256NonTemporal(sbyte* address) { throw null; }
        public static unsafe Vector256<byte> LoadAlignedVector256NonTemporal(byte* address) { throw null; }
        public static unsafe Vector256<short> LoadAlignedVector256NonTemporal(short* address) { throw null; }
        public static unsafe Vector256<ushort> LoadAlignedVector256NonTemporal(ushort* address) { throw null; }
        public static unsafe Vector256<int> LoadAlignedVector256NonTemporal(int* address) { throw null; }
        public static unsafe Vector256<uint> LoadAlignedVector256NonTemporal(uint* address) { throw null; }
        public static unsafe Vector256<long> LoadAlignedVector256NonTemporal(long* address) { throw null; }
        public static unsafe Vector256<ulong> LoadAlignedVector256NonTemporal(ulong* address) { throw null; }
        public static unsafe Vector128<uint> MaskLoad(uint* address, Vector128<uint> mask) { throw null; }
        public static unsafe Vector128<long> MaskLoad(long* address, Vector128<long> mask) { throw null; }
        public static unsafe Vector128<ulong> MaskLoad(ulong* address, Vector128<ulong> mask) { throw null; }
        public static unsafe Vector256<int> MaskLoad(int* address, Vector256<int> mask) { throw null; }
        public static unsafe Vector256<uint> MaskLoad(uint* address, Vector256<uint> mask) { throw null; }
        public static unsafe Vector256<long> MaskLoad(long* address, Vector256<long> mask) { throw null; }
        public static unsafe Vector256<ulong> MaskLoad(ulong* address, Vector256<ulong> mask) { throw null; }
        public static unsafe void MaskStore(int* address, Vector128<int> mask, Vector128<int> source) { throw null; }
        public static unsafe void MaskStore(uint* address, Vector128<uint> mask, Vector128<uint> source) { throw null; }
        public static unsafe void MaskStore(long* address, Vector128<long> mask, Vector128<long> source) { throw null; }
        public static unsafe void MaskStore(ulong* address, Vector128<ulong> mask, Vector128<ulong> source) { throw null; }
        public static unsafe void MaskStore(int* address, Vector256<int> mask, Vector256<int> source) { throw null; }
        public static unsafe void MaskStore(uint* address, Vector256<uint> mask, Vector256<uint> source) { throw null; }
        public static unsafe void MaskStore(long* address, Vector256<long> mask, Vector256<long> source) { throw null; }
        public static unsafe void MaskStore(ulong* address, Vector256<ulong> mask, Vector256<ulong> source) { throw null; }
        public static Vector256<int> MultiplyAddAdjacent(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<short> MultiplyAddAdjacent(Vector256<byte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<sbyte> Max(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Max(Vector256<byte> left, Vector256<short> right) { throw null; }
        public static Vector256<short> Max(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Max(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Max(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Max(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<sbyte> Min(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Min(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> Min(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Min(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Min(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Min(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static int MoveMask(Vector256<sbyte> value) { throw null; }
        public static int MoveMask(Vector256<byte> value) { throw null; }
        public static Vector256<ushort> MultipleSumAbsoluteDifferences(Vector256<byte> left, Vector256<byte> right, byte mask) { throw null; }
        public static Vector256<long> Multiply(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<ulong> Multiply(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<short> MultiplyHigh(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> MultiplyHigh(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<short> MultiplyHighRoundScale(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<short> MultiplyLow(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<int> MultiplyLow(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<sbyte> Or(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Or(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> Or(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Or(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Or(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Or(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> Or(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> Or(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> PackSignedSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<short> PackSignedSaturate(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<byte> PackUnsignedSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> PackUnsignedSaturate(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<sbyte> Permute2x128(Vector256<sbyte> left, Vector256<sbyte> right, byte control) { throw null; }
        public static Vector256<byte> Permute2x128(Vector256<byte> left, Vector256<byte> right, byte control) { throw null; }
        public static Vector256<short> Permute2x128(Vector256<short> left, Vector256<short> right, byte control) { throw null; }
        public static Vector256<ushort> Permute2x128(Vector256<ushort> left, Vector256<ushort> right, byte control) { throw null; }
        public static Vector256<int> Permute2x128(Vector256<int> left, Vector256<int> right, byte control) { throw null; }
        public static Vector256<uint> Permute2x128(Vector256<uint> left, Vector256<uint> right, byte control) { throw null; }
        public static Vector256<long> Permute2x128(Vector256<long> left, Vector256<long> right, byte control) { throw null; }
        public static Vector256<ulong> Permute2x128(Vector256<ulong> left, Vector256<ulong> right, byte control) { throw null; }
        public static Vector256<long> Permute4x64(Vector256<long> value, byte control) { throw null; }
        public static Vector256<ulong> Permute4x64(Vector256<ulong> value, byte control) { throw null; }
        public static Vector256<double> Permute4x64(Vector256<double> value, byte control) { throw null; }
        public static Vector256<int> PermuteVar8x32(Vector256<int> left, Vector256<int> mask) { throw null; }
        public static Vector256<uint> PermuteVar8x32(Vector256<uint> left, Vector256<uint> mask) { throw null; }
        public static Vector256<float> PermuteVar8x32(Vector256<float> left, Vector256<float> mask) { throw null; }
        public static Vector256<short> ShiftLeftLogical(Vector256<short> value, Vector128<short> count) { throw null; }
        public static Vector256<ushort> ShiftLeftLogical(Vector256<ushort> value, Vector128<ushort> count) { throw null; }
        public static Vector256<int> ShiftLeftLogical(Vector256<int> value, Vector128<int> count) { throw null; }
        public static Vector256<uint> ShiftLeftLogical(Vector256<uint> value, Vector128<uint> count) { throw null; }
        public static Vector256<long> ShiftLeftLogical(Vector256<long> value, Vector128<long> count) { throw null; }
        public static Vector256<ulong> ShiftLeftLogical(Vector256<ulong> value, Vector128<ulong> count) { throw null; }
        public static Vector256<short> ShiftLeftLogical(Vector256<short> value, byte count) { throw null; }
        public static Vector256<ushort> ShiftLeftLogical(Vector256<ushort> value, byte count) { throw null; }
        public static Vector256<int> ShiftLeftLogical(Vector256<int> value, byte count) { throw null; }
        public static Vector256<uint> ShiftLeftLogical(Vector256<uint> value, byte count) { throw null; }
        public static Vector256<long> ShiftLeftLogical(Vector256<long> value, byte count) { throw null; }
        public static Vector256<ulong> ShiftLeftLogical(Vector256<ulong> value, byte count) { throw null; }
        public static Vector256<sbyte> ShiftLeftLogical128BitLane(Vector256<sbyte> value, byte numBytes) { throw null; }
        public static Vector256<byte> ShiftLeftLogical128BitLane(Vector256<byte> value, byte numBytes) { throw null; }
        public static Vector256<short> ShiftLeftLogical128BitLane(Vector256<short> value, byte numBytes) { throw null; }
        public static Vector256<ushort> ShiftLeftLogical128BitLane(Vector256<ushort> value, byte numBytes) { throw null; }
        public static Vector256<int> ShiftLeftLogical128BitLane(Vector256<int> value, byte numBytes) { throw null; }
        public static Vector256<uint> ShiftLeftLogical128BitLane(Vector256<uint> value, byte numBytes) { throw null; }
        public static Vector256<long> ShiftLeftLogical128BitLane(Vector256<long> value, byte numBytes) { throw null; }
        public static Vector256<ulong> ShiftLeftLogical128BitLane(Vector256<ulong> value, byte numBytes) { throw null; }
        public static Vector256<int> ShiftLeftLogicalVariable(Vector256<int> value, Vector256<uint> count) { throw null; }
        public static Vector256<uint> ShiftLeftLogicalVariable(Vector256<uint> value, Vector256<uint> count) { throw null; }
        public static Vector256<long> ShiftLeftLogicalVariable(Vector256<long> value, Vector256<ulong> count) { throw null; }
        public static Vector256<ulong> ShiftLeftLogicalVariable(Vector256<ulong> value, Vector256<ulong> count) { throw null; }
        public static Vector128<int> ShiftLeftLogicalVariable(Vector128<int> value, Vector128<uint> count) { throw null; }
        public static Vector128<uint> ShiftLeftLogicalVariable(Vector128<uint> value, Vector128<uint> count) { throw null; }
        public static Vector128<long> ShiftLeftLogicalVariable(Vector128<long> value, Vector128<ulong> count) { throw null; }
        public static Vector128<ulong> ShiftLeftLogicalVariable(Vector128<ulong> value, Vector128<ulong> count) { throw null; }
        public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, Vector128<short> count) { throw null; }
        public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, Vector128<int> count) { throw null; }
        public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, byte count) { throw null; }
        public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, byte count) { throw null; }
        public static Vector256<int> ShiftRightArithmeticVariable(Vector256<int> value, Vector256<uint> count) { throw null; }
        public static Vector128<int> ShiftRightArithmeticVariable(Vector128<int> value, Vector128<uint> count) { throw null; }
        public static Vector256<short> ShiftRightLogical(Vector256<short> value, Vector128<short> count) { throw null; }
        public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, Vector128<ushort> count) { throw null; }
        public static Vector256<int> ShiftRightLogical(Vector256<int> value, Vector128<int> count) { throw null; }
        public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, Vector128<uint> count) { throw null; }
        public static Vector256<long> ShiftRightLogical(Vector256<long> value, Vector128<long> count) { throw null; }
        public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, Vector128<ulong> count) { throw null; }
        public static Vector256<short> ShiftRightLogical(Vector256<short> value, byte count) { throw null; }
        public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, byte count) { throw null; }
        public static Vector256<int> ShiftRightLogical(Vector256<int> value, byte count) { throw null; }
        public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, byte count) { throw null; }
        public static Vector256<long> ShiftRightLogical(Vector256<long> value, byte count) { throw null; }
        public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, byte count) { throw null; }
        public static Vector256<sbyte> ShiftRightLogical128BitLane(Vector256<sbyte> value, byte numBytes) { throw null; }
        public static Vector256<byte> ShiftRightLogical128BitLane(Vector256<byte> value, byte numBytes) { throw null; }
        public static Vector256<short> ShiftRightLogical128BitLane(Vector256<short> value, byte numBytes) { throw null; }
        public static Vector256<ushort> ShiftRightLogical128BitLane(Vector256<ushort> value, byte numBytes) { throw null; }
        public static Vector256<int> ShiftRightLogical128BitLane(Vector256<int> value, byte numBytes) { throw null; }
        public static Vector256<uint> ShiftRightLogical128BitLane(Vector256<uint> value, byte numBytes) { throw null; }
        public static Vector256<long> ShiftRightLogical128BitLane(Vector256<long> value, byte numBytes) { throw null; }
        public static Vector256<ulong> ShiftRightLogical128BitLane(Vector256<ulong> value, byte numBytes) { throw null; }
        public static Vector256<int> ShiftRightLogicalVariable(Vector256<int> value, Vector256<uint> count) { throw null; }
        public static Vector256<uint> ShiftRightLogicalVariable(Vector256<uint> value, Vector256<uint> count) { throw null; }
        public static Vector256<long> ShiftRightLogicalVariable(Vector256<long> value, Vector256<ulong> count) { throw null; }
        public static Vector256<ulong> ShiftRightLogicalVariable(Vector256<ulong> value, Vector256<ulong> count) { throw null; }
        public static Vector128<int> ShiftRightLogicalVariable(Vector128<int> value, Vector128<uint> count) { throw null; }
        public static Vector128<uint> ShiftRightLogicalVariable(Vector128<uint> value, Vector128<uint> count) { throw null; }
        public static Vector128<long> ShiftRightLogicalVariable(Vector128<long> value, Vector128<ulong> count) { throw null; }
        public static Vector128<ulong> ShiftRightLogicalVariable(Vector128<ulong> value, Vector128<ulong> count) { throw null; }
        public static Vector256<sbyte> Shuffle(Vector256<sbyte> value, Vector256<sbyte> mask) { throw null; }
        public static Vector256<byte> Shuffle(Vector256<byte> value, Vector256<byte> mask) { throw null; }
        public static Vector256<int> Shuffle(Vector256<int> value, byte control) { throw null; }
        public static Vector256<uint> Shuffle(Vector256<uint> value, byte control) { throw null; }
        public static Vector256<short> ShuffleHigh(Vector256<short> value, byte control) { throw null; }
        public static Vector256<ushort> ShuffleHigh(Vector256<ushort> value, byte control) { throw null; }
        public static Vector256<short> ShuffleLow(Vector256<short> value, byte control) { throw null; }
        public static Vector256<ushort> ShuffleLow(Vector256<ushort> value, byte control) { throw null; }
        public static Vector256<sbyte> Sign(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<short> Sign(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<int> Sign(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<sbyte> Subtract(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Subtract(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> Subtract(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Subtract(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Subtract(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Subtract(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> Subtract(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> Subtract(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> SubtractSaturate(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<short> SubtractSaturate(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<byte> SubtractSaturate(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<ushort> SubtractSaturate(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<ulong> SumAbsoluteDifferences(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<sbyte> UnpackHigh(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> UnpackHigh(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> UnpackHigh(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> UnpackHigh(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> UnpackHigh(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> UnpackHigh(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> UnpackHigh(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> UnpackHigh(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> UnpackLow(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> UnpackLow(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> UnpackLow(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> UnpackLow(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> UnpackLow(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> UnpackLow(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> UnpackLow(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> UnpackLow(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
        public static Vector256<sbyte> Xor(Vector256<sbyte> left, Vector256<sbyte> right) { throw null; }
        public static Vector256<byte> Xor(Vector256<byte> left, Vector256<byte> right) { throw null; }
        public static Vector256<short> Xor(Vector256<short> left, Vector256<short> right) { throw null; }
        public static Vector256<ushort> Xor(Vector256<ushort> left, Vector256<ushort> right) { throw null; }
        public static Vector256<int> Xor(Vector256<int> left, Vector256<int> right) { throw null; }
        public static Vector256<uint> Xor(Vector256<uint> left, Vector256<uint> right) { throw null; }
        public static Vector256<long> Xor(Vector256<long> left, Vector256<long> right) { throw null; }
        public static Vector256<ulong> Xor(Vector256<ulong> left, Vector256<ulong> right) { throw null; }
    }
    public static class Bmi1
    {
        public static bool IsSupported { get { throw null; } }
        public static uint AndNot(uint left, uint right) { throw null; }
        public static ulong AndNot(ulong left, ulong right) { throw null; }
        public static uint BitFieldExtract(uint value, uint start, uint length) { throw null; }
        public static ulong BitFieldExtract(ulong value, ulong start, ulong length) { throw null; }
        public static uint BitFieldExtract(uint value, uint control) { throw null; }
        public static ulong BitFieldExtract(ulong value, ulong control) { throw null; }
        public static uint ExtractLowestSetBit(uint value) { throw null; }
        public static ulong ExtractLowestSetBit(ulong value) { throw null; }
        public static uint GetMaskUptoLowestSetBit(uint value) { throw null; }
        public static ulong GetMaskUptoLowestSetBit(ulong value) { throw null; }
        public static uint ResetLowestSetBit(uint value) { throw null; }
        public static ulong ResetLowestSetBit(ulong value) { throw null; }
        public static uint TrailingZeroCount(uint value) { throw null; }
        public static ulong TrailingZeroCount(ulong value) { throw null; }
    }
    public static class Bmi2
    {
        public static bool IsSupported { get { throw null; } }
        public static uint ZeroHighBits(uint value, uint index) { throw null; }
        public static ulong ZeroHighBits(ulong value, ulong index) { throw null; }
        public static unsafe uint MultiplyNoFlags(uint left, uint right, uint* high) { throw null; }
        public static unsafe ulong MultiplyNoFlags(ulong left, ulong right, ulong* high) { throw null; }
        public static uint ParallelBitDeposit(uint value, uint mask) { throw null; }
        public static ulong ParallelBitDeposit(ulong value, ulong mask) { throw null; }
        public static uint ParallelBitExtract(uint value, uint mask) { throw null; }
        public static ulong ParallelBitExtract(ulong value, ulong mask) { throw null; }    
    }
    public enum FloatComparisonMode : byte
    {
        EqualOrderedNonSignaling = 0,
        LessThanOrderedSignaling = 1,
        LessThanOrEqualOrderedSignaling = 2,
        UnorderedNonSignaling = 3,
        NotEqualUnorderedNonSignaling = 4,
        NotLessThanUnorderedSignaling = 5,
        NotLessThanOrEqualUnorderedSignaling = 6,
        OrderedNonSignaling = 7,
        EqualUnorderedNonSignaling = 8,
        NotGreaterThanOrEqualUnorderedSignaling = 9,
        NotGreaterThanUnorderedSignaling = 10,
        FalseOrderedNonSignaling = 11,
        NotEqualOrderedNonSignaling = 12,
        GreaterThanOrEqualOrderedSignaling = 13,
        GreaterThanOrderedSignaling = 14,
        TrueUnorderedNonSignaling = 15,
        EqualOrderedSignaling = 16,
        LessThanOrderedNonSignaling = 17,
        LessThanOrEqualOrderedNonSignaling = 18,
        UnorderedSignaling = 19,
        NotEqualUnorderedSignaling = 20,
        NotLessThanUnorderedNonSignaling = 21,
        NotLessThanOrEqualUnorderedNonSignaling = 22,
        OrderedSignaling = 23,
        EqualUnorderedSignaling = 24,
        NotGreaterThanOrEqualUnorderedNonSignaling = 25,
        NotGreaterThanUnorderedNonSignaling = 26,
        FalseOrderedSignaling = 27,
        NotEqualOrderedSignaling = 28,
        GreaterThanOrEqualOrderedNonSignaling = 29,
        GreaterThanOrderedNonSignaling = 30,
        TrueUnorderedSignaling = 31,
    }
    public enum StringComparisonMode : byte
    {
        EqualAny = 0x00,
        Ranges = 0x04,
        EqualEach = 0x08,
        EqualOrdered = 0x0c,
        NegativePolarity = 0x10,
        MaskedNegativePolarity = 0x30,
        LeastSignificant = 0x00,
        MostSignificant = 0x40,
    }
    public enum ResultsFlag : byte
    {
        CFlag = 0,
        NotCFlagAndNotZFlag = 1,
        OFlag = 2,
        SFlag = 3,
        ZFlag = 4,
    }
    public static class Fma
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<float> MultiplyAdd(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplyAdd(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplyAdd(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplyAdd(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<double> MultiplyAddScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector128<float> MultiplyAddScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<float> MultiplyAddSubtract(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplyAddSubtract(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplyAddSubtract(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplyAddSubtract(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<float> MultiplySubtract(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplySubtract(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplySubtract(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplySubtract(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<float> MultiplySubtractAdd(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplySubtractAdd(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplySubtractAdd(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplySubtractAdd(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<double> MultiplySubtractScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector128<float> MultiplySubtractScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<float> MultiplyAddNegated(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplyAddNegated(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplyAddNegated(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplyAddNegated(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<double> MultiplyAddNegatedScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector128<float> MultiplyAddNegatedScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<float> MultiplySubtractNegated(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
        public static Vector128<double> MultiplySubtractNegated(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector256<float> MultiplySubtractNegated(Vector256<float> a, Vector256<float> b, Vector256<float> c) { throw null; }
        public static Vector256<double> MultiplySubtractNegated(Vector256<double> a, Vector256<double> b, Vector256<double> c) { throw null; }
        public static Vector128<double> MultiplySubtractNegatedScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c) { throw null; }
        public static Vector128<float> MultiplySubtractNegatedScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c) { throw null; }
    }
    public static class Lzcnt
    {
        public static bool IsSupported { get { throw null; } }
        public static uint LeadingZeroCount(uint value) { throw null; }
        public static ulong LeadingZeroCount(ulong value) { throw null; }
    }
    public static class Pclmulqdq
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<long> CarryLessMultiply(Vector128<long> left, Vector128<long> right, byte control) { throw null; }
        public static Vector128<ulong> CarryLessMultiply(Vector128<ulong> left, Vector128<ulong> right, byte control) { throw null; }
    }
    public static class Popcnt
    {
        public static bool IsSupported { get { throw null; } }
        public static int PopCount(uint value) { throw null; }
        public static long PopCount(ulong value) { throw null; }
    }
    public static class Sse
    {
        public static bool IsSupported { get { return false; } }
        public static Vector128<float> Add(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> AddScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> And(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> AndNot(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> CompareEqual(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static bool CompareEqualOrderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareEqualScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static bool CompareEqualUnorderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareGreaterThan(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static bool CompareGreaterThanOrderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareGreaterThanScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static bool CompareGreaterThanUnorderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareGreaterThanOrEqual(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static bool CompareGreaterThanOrEqualOrderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareGreaterThanOrEqualScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static bool CompareGreaterThanOrEqualUnorderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareLessThan(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static bool CompareLessThanOrderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareLessThanScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static bool CompareLessThanUnorderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareLessThanOrEqual(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static bool CompareLessThanOrEqualOrderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareLessThanOrEqualScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static bool CompareLessThanOrEqualUnorderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareNotEqual(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static bool CompareNotEqualOrderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareNotEqualScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static bool CompareNotEqualUnorderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareNotGreaterThan(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> CompareNotGreaterThanScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareNotGreaterThanOrEqual(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> CompareNotGreaterThanOrEqualScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareNotLessThan(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> CompareNotLessThanScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareNotLessThanOrEqual(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> CompareNotLessThanOrEqualScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareOrdered(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> CompareOrderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> CompareUnordered(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> CompareUnorderedScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static int ConvertToInt32(Vector128<float> value) { throw null; }
        public static int ConvertToInt32WithTruncation(Vector128<float> value) { throw null; }
        public static long ConvertToInt64WithTruncation(Vector128<float> value) { throw null; }
        public static long ConvertToInt64(Vector128<float> value) { throw null; }
        public static float ConvertToSingle(Vector128<float> value) { throw null; }
        public static Vector128<float> ConvertToVector128SingleScalar(Vector128<float> upper, int value) { throw null; }
        public static Vector128<float> ConvertToVector128SingleScalar(Vector128<float> upper, long value) { throw null; }
        public static Vector128<float> Divide(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> DivideScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static unsafe Vector128<float> LoadVector128(float* address) { throw null; }
        public static unsafe Vector128<float> LoadAlignedVector128(float* address) { throw null; }
        public static unsafe Vector128<float> LoadHigh(Vector128<float> value, float* address) { throw null; }
        public static unsafe Vector128<float> LoadLow(Vector128<float> value, float* address) { throw null; }
        public static unsafe Vector128<float> LoadScalar(float* address) { throw null; }
        public static Vector128<float> Max(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> MaxScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> Min(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> MinScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> MoveHighToLow(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> MoveLowToHigh(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> MoveScalar(Vector128<float> upper, Vector128<float> value) { throw null; }
        public static int MoveMask(Vector128<float> value) { throw null; }
        public static Vector128<float> Multiply(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> MultiplyScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> Or(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> Reciprocal(Vector128<float> value) { throw null; }
        public static Vector128<float> ReciprocalScalar(Vector128<float> value) { throw null; }
        public static Vector128<float> ReciprocalSqrt(Vector128<float> value) { throw null; }
        public static Vector128<float> ReciprocalSqrtScalar(Vector128<float> value) { throw null; }
        public static Vector128<float> SetVector128(float e3, float e2, float e1, float e0) { throw null; }
        public static Vector128<float> SetAllVector128(float value) { throw null; }
        public static Vector128<float> SetScalar(float value) { throw null; }
        public static Vector128<float> SetZeroVector128() { throw null; }
        public static Vector128<U> StaticCast<T, U>(Vector128<T> value) where T : struct where U : struct { throw null; }
        public static Vector128<float> Shuffle(Vector128<float> left, Vector128<float> right, byte control) { throw null; }
        public static Vector128<float> Sqrt(Vector128<float> value) { throw null; }
        public static Vector128<float> SqrtScalar(Vector128<float> value) { throw null; }
        public static unsafe void StoreAligned(float* address, Vector128<float> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(float* address, Vector128<float> source) { throw null; }
        public static unsafe void Store(float* address, Vector128<float> source) { throw null; }
        public static unsafe void StoreHigh(float* address, Vector128<float> source) { throw null; }
        public static unsafe void StoreLow(float* address, Vector128<float> source) { throw null; }        
        public static unsafe void StoreScalar(float* address, Vector128<float> source) { throw null; }
        public static Vector128<float> Subtract(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> SubtractScalar(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<float> UnpackHigh(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> UnpackLow(Vector128<float> left,  Vector128<float> right) { throw null; }
        public static Vector128<float> Xor(Vector128<float> left,  Vector128<float> right) { throw null; }
    }
    public static class Sse2
    {
        public static bool IsSupported { get { return false; } }
        public static Vector128<byte> Add(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<sbyte> Add(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> Add(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> Add(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> Add(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> Add(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<long> Add(Vector128<long> left,  Vector128<long> right) { throw null; }
        public static Vector128<ulong> Add(Vector128<ulong> left,  Vector128<ulong> right) { throw null; }
        public static Vector128<double> Add(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> AddScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<sbyte> AddSaturate(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<byte> AddSaturate(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<short> AddSaturate(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> AddSaturate(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<byte> And(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<sbyte> And(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> And(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> And(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> And(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> And(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<long> And(Vector128<long> left,  Vector128<long> right) { throw null; }
        public static Vector128<ulong> And(Vector128<ulong> left,  Vector128<ulong> right) { throw null; }
        public static Vector128<double> And(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<byte> AndNot(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<sbyte> AndNot(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> AndNot(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> AndNot(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> AndNot(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> AndNot(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<long> AndNot(Vector128<long> left,  Vector128<long> right) { throw null; }
        public static Vector128<ulong> AndNot(Vector128<ulong> left,  Vector128<ulong> right) { throw null; }
        public static Vector128<double> AndNot(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<byte> Average(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<ushort> Average(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<sbyte> CompareEqual(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<byte> CompareEqual(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<short> CompareEqual(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> CompareEqual(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> CompareEqual(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> CompareEqual(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<double> CompareEqual(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static bool CompareEqualOrderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareEqualScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool CompareEqualUnorderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<sbyte> CompareGreaterThan(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> CompareGreaterThan(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<int> CompareGreaterThan(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<double> CompareGreaterThan(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static bool CompareGreaterThanOrderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareGreaterThanScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool CompareGreaterThanUnorderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareGreaterThanOrEqual(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static bool CompareGreaterThanOrEqualOrderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareGreaterThanOrEqualScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool CompareGreaterThanOrEqualUnorderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<sbyte> CompareLessThan(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> CompareLessThan(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<int> CompareLessThan(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<double> CompareLessThan(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static bool CompareLessThanOrderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareLessThanScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool CompareLessThanUnorderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareLessThanOrEqual(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static bool CompareLessThanOrEqualOrderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareLessThanOrEqualScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool CompareLessThanOrEqualUnorderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareNotEqual(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static bool CompareNotEqualOrderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareNotEqualScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static bool CompareNotEqualUnorderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareNotGreaterThan(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> CompareNotGreaterThanScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareNotGreaterThanOrEqual(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> CompareNotGreaterThanOrEqualScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareNotLessThan(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> CompareNotLessThanScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareNotLessThanOrEqual(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> CompareNotLessThanOrEqualScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareOrdered(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> CompareOrderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<double> CompareUnordered(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> CompareUnorderedScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static double ConvertToDouble(Vector128<double> value) { throw null; }
        public static int ConvertToInt32(Vector128<double> value) { throw null; }
        public static int ConvertToInt32(Vector128<int> value) { throw null; }
        public static int ConvertToInt32WithTruncation(Vector128<double> value) { throw null; }
        public static long ConvertToInt64(Vector128<double> value) { throw null; }
        public static long ConvertToInt64(Vector128<long> value) { throw null; }
        public static long ConvertToInt64WithTruncation(Vector128<double> value) { throw null; }
        public static uint ConvertToUInt32(Vector128<uint> value) { throw null; }
        public static ulong ConvertToUInt64(Vector128<ulong> value) { throw null; }
        public static Vector128<double> ConvertToVector128DoubleScalar(Vector128<double> upper, int value) { throw null; }
        public static Vector128<double> ConvertToVector128DoubleScalar(Vector128<double> upper, long value) { throw null; }
        public static Vector128<double> ConvertToVector128DoubleScalar(Vector128<double> upper, Vector128<float> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32(Vector128<float> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32(Vector128<double> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32Scalar(int value) { throw null; }
        public static Vector128<long> ConvertToVector128Int64Scalar(long value) { throw null; }
        public static Vector128<float> ConvertToVector128Single(Vector128<int> value) { throw null; }
        public static Vector128<float> ConvertToVector128Single(Vector128<double> value) { throw null; }
        public static Vector128<float> ConvertToVector128SingleScalar(Vector128<float> upper, Vector128<double> value) { throw null; }
        public static Vector128<double> ConvertToVector128Double(Vector128<int> value) { throw null; }
        public static Vector128<double> ConvertToVector128Double(Vector128<float> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32WithTruncation(Vector128<float> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32WithTruncation(Vector128<double> value) { throw null; }
        public static Vector128<uint> ConvertToVector128UInt32Scalar(uint value) { throw null; }
        public static Vector128<ulong> ConvertToVector128UInt64Scalar(ulong value) { throw null; }
        public static Vector128<double> Divide(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> DivideScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static short Extract(Vector128<short> value, byte index) { throw null; }
        public static ushort Extract(Vector128<ushort> value, byte index) { throw null; }
        public static Vector128<short> Insert(Vector128<short> value, short data, byte index) { throw null; }
        public static Vector128<ushort> Insert(Vector128<ushort> value, ushort data, byte index) { throw null; }
        public static unsafe Vector128<sbyte> LoadVector128(sbyte* address) { throw null; }
        public static unsafe Vector128<byte> LoadVector128(byte* address) { throw null; }
        public static unsafe Vector128<short> LoadVector128(short* address) { throw null; }
        public static unsafe Vector128<ushort> LoadVector128(ushort* address) { throw null; }
        public static unsafe Vector128<int> LoadVector128(int* address) { throw null; }
        public static unsafe Vector128<uint> LoadVector128(uint* address) { throw null; }
        public static unsafe Vector128<long> LoadVector128(long* address) { throw null; }
        public static unsafe Vector128<ulong> LoadVector128(ulong* address) { throw null; }
        public static unsafe Vector128<double> LoadVector128(double* address) { throw null; }
        public static unsafe Vector128<sbyte> LoadAlignedVector128(sbyte* address) { throw null; }
        public static unsafe Vector128<byte> LoadAlignedVector128(byte* address) { throw null; }
        public static unsafe Vector128<short> LoadAlignedVector128(short* address) { throw null; }
        public static unsafe Vector128<ushort> LoadAlignedVector128(ushort* address) { throw null; }
        public static unsafe Vector128<int> LoadAlignedVector128(int* address) { throw null; }
        public static unsafe Vector128<uint> LoadAlignedVector128(uint* address) { throw null; }
        public static unsafe Vector128<long> LoadAlignedVector128(long* address) { throw null; }
        public static unsafe Vector128<ulong> LoadAlignedVector128(ulong* address) { throw null; }
        public static unsafe Vector128<double> LoadAlignedVector128(double* address) { throw null; }
        public static unsafe Vector128<double> LoadHigh(Vector128<double> value, double* address) { throw null; }
        public static unsafe Vector128<double> LoadLow(Vector128<double> value, double* address) { throw null; }
        public static unsafe Vector128<sbyte> LoadScalar(sbyte* address) { throw null; }
        public static unsafe Vector128<byte> LoadScalar(byte* address) { throw null; }
        public static unsafe Vector128<short> LoadScalar(short* address) { throw null; }
        public static unsafe Vector128<ushort> LoadScalar(ushort* address) { throw null; }
        public static unsafe Vector128<int> LoadScalar(int* address) { throw null; }
        public static unsafe Vector128<uint> LoadScalar(uint* address) { throw null; }
        public static unsafe Vector128<long> LoadScalar(long* address) { throw null; }
        public static unsafe Vector128<ulong> LoadScalar(ulong* address) { throw null; }
        public static unsafe Vector128<double> LoadScalar(double* address) { throw null; }
        public static unsafe void MaskMove(Vector128<sbyte> source,  Vector128<sbyte> mask, sbyte* address) { throw null; }
        public static unsafe void MaskMove(Vector128<byte> source,  Vector128<byte> mask, byte* address) { throw null; }
        public static Vector128<byte> Max(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<short> Max(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<double> Max(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> MaxScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<byte> Min(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<short> Min(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<double> Min(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> MinScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static int MoveMask(Vector128<sbyte> value) { throw null; }
        public static int MoveMask(Vector128<double> value) { throw null; }
        public static Vector128<double> MoveScalar(Vector128<double> upper, Vector128<double> value) { throw null; }
        public static Vector128<ulong> Multiply(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<double> Multiply(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<double> MultiplyScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<short> MultiplyHigh(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> MultiplyHigh(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> MultiplyHorizontalAdd(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<short> MultiplyLow(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<byte> Or(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<sbyte> Or(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> Or(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> Or(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> Or(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> Or(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<long> Or(Vector128<long> left,  Vector128<long> right) { throw null; }
        public static Vector128<ulong> Or(Vector128<ulong> left,  Vector128<ulong> right) { throw null; }
        public static Vector128<double> Or(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<sbyte> PackSignedSaturate(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<short> PackSignedSaturate(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<byte> PackUnsignedSaturate(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<sbyte> SetVector128(sbyte e15, sbyte e14, sbyte e13, sbyte e12, sbyte e11, sbyte e10, sbyte e9, sbyte e8, sbyte e7, sbyte e6, sbyte e5, sbyte e4, sbyte e3, sbyte e2, sbyte e1, sbyte e0) { throw null; }
        public static Vector128<byte> SetVector128(byte e15, byte e14, byte e13, byte e12, byte e11, byte e10, byte e9, byte e8, byte e7, byte e6, byte e5, byte e4, byte e3, byte e2, byte e1, byte e0) { throw null; }
        public static Vector128<short> SetVector128(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0) { throw null; }
        public static Vector128<ushort> SetVector128(ushort e7, ushort e6, ushort e5, ushort e4, ushort e3, ushort e2, ushort e1, ushort e0) { throw null; }
        public static Vector128<int> SetVector128(int e3, int e2, int e1, int e0) { throw null; }
        public static Vector128<uint> SetVector128(uint e3, uint e2, uint e1, uint e0) { throw null; }
        public static Vector128<long> SetVector128(long e1, long e0) { throw null; }
        public static Vector128<ulong> SetVector128(ulong e1, ulong e0) { throw null; }
        public static Vector128<double> SetVector128(double e1, double e0) { throw null; }
        public static Vector128<byte> SetAllVector128(byte value) { throw null; }
        public static Vector128<sbyte> SetAllVector128(sbyte value) { throw null; }
        public static Vector128<short> SetAllVector128(short value) { throw null; }
        public static Vector128<ushort> SetAllVector128(ushort value) { throw null; }
        public static Vector128<int> SetAllVector128(int value) { throw null; }
        public static Vector128<uint> SetAllVector128(uint value) { throw null; }
        public static Vector128<long> SetAllVector128(long value) { throw null; }
        public static Vector128<ulong> SetAllVector128(ulong value) { throw null; }
        public static Vector128<double> SetAllVector128(double value) { throw null; }
        public static Vector128<double> SetScalar(double value) { throw null; }
        public static Vector128<T> SetZeroVector128<T>() where T : struct { throw null; }
        public static Vector128<long> SumAbsoluteDifferences(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<int> Shuffle(Vector128<int> value, byte control) { throw null; }
        public static Vector128<uint> Shuffle(Vector128<uint> value,  byte control) { throw null; }
        public static Vector128<double> Shuffle(Vector128<double> left, Vector128<double> right, byte control) { throw null; }
        public static Vector128<short> ShuffleHigh(Vector128<short> value, byte control) { throw null; }
        public static Vector128<ushort> ShuffleHigh(Vector128<ushort> value, byte control) { throw null; }
        public static Vector128<short> ShuffleLow(Vector128<short> value, byte control) { throw null; }
        public static Vector128<ushort> ShuffleLow(Vector128<ushort> value, byte control) { throw null; }
        public static Vector128<short> ShiftLeftLogical(Vector128<short> value, Vector128<short> count) { throw null; }
        public static Vector128<ushort> ShiftLeftLogical(Vector128<ushort> value, Vector128<ushort> count) { throw null; }
        public static Vector128<int> ShiftLeftLogical(Vector128<int> value, Vector128<int> count) { throw null; }
        public static Vector128<uint> ShiftLeftLogical(Vector128<uint> value, Vector128<uint> count) { throw null; }
        public static Vector128<long> ShiftLeftLogical(Vector128<long> value, Vector128<long> count) { throw null; }
        public static Vector128<ulong> ShiftLeftLogical(Vector128<ulong> value, Vector128<ulong> count) { throw null; }
        public static Vector128<short> ShiftLeftLogical(Vector128<short> value, byte count) { throw null; }
        public static Vector128<ushort> ShiftLeftLogical(Vector128<ushort> value, byte count) { throw null; }
        public static Vector128<int> ShiftLeftLogical(Vector128<int> value, byte count) { throw null; }
        public static Vector128<uint> ShiftLeftLogical(Vector128<uint> value, byte count) { throw null; }
        public static Vector128<long> ShiftLeftLogical(Vector128<long> value, byte count) { throw null; }
        public static Vector128<ulong> ShiftLeftLogical(Vector128<ulong> value, byte count) { throw null; }
        public static Vector128<sbyte> ShiftLeftLogical128BitLane(Vector128<sbyte> value, byte numBytes) { throw null; }
        public static Vector128<byte> ShiftLeftLogical128BitLane(Vector128<byte> value, byte numBytes) { throw null; }
        public static Vector128<short> ShiftLeftLogical128BitLane(Vector128<short> value, byte numBytes) { throw null; }
        public static Vector128<ushort> ShiftLeftLogical128BitLane(Vector128<ushort> value, byte numBytes) { throw null; }
        public static Vector128<int> ShiftLeftLogical128BitLane(Vector128<int> value, byte numBytes) { throw null; }
        public static Vector128<uint> ShiftLeftLogical128BitLane(Vector128<uint> value, byte numBytes) { throw null; }
        public static Vector128<long> ShiftLeftLogical128BitLane(Vector128<long> value, byte numBytes) { throw null; }
        public static Vector128<ulong> ShiftLeftLogical128BitLane(Vector128<ulong> value, byte numBytes) { throw null; }
        public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, Vector128<short> count) { throw null; }
        public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, Vector128<int> count) { throw null; }
        public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, byte count) { throw null; }
        public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, byte count) { throw null; }
        public static Vector128<short> ShiftRightLogical(Vector128<short> value, Vector128<short> count) { throw null; }
        public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, Vector128<ushort> count) { throw null; }
        public static Vector128<int> ShiftRightLogical(Vector128<int> value, Vector128<int> count) { throw null; }
        public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, Vector128<uint> count) { throw null; }
        public static Vector128<long> ShiftRightLogical(Vector128<long> value, Vector128<long> count) { throw null; }
        public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, Vector128<ulong> count) { throw null; }
        public static Vector128<short> ShiftRightLogical(Vector128<short> value, byte count) { throw null; }
        public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, byte count) { throw null; }
        public static Vector128<int> ShiftRightLogical(Vector128<int> value, byte count) { throw null; }
        public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, byte count) { throw null; }
        public static Vector128<long> ShiftRightLogical(Vector128<long> value, byte count) { throw null; }
        public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, byte count) { throw null; }
        public static Vector128<sbyte> ShiftRightLogical128BitLane(Vector128<sbyte> value, byte numBytes) { throw null; }
        public static Vector128<byte> ShiftRightLogical128BitLane(Vector128<byte> value, byte numBytes) { throw null; }
        public static Vector128<short> ShiftRightLogical128BitLane(Vector128<short> value, byte numBytes) { throw null; }
        public static Vector128<ushort> ShiftRightLogical128BitLane(Vector128<ushort> value, byte numBytes) { throw null; }
        public static Vector128<int> ShiftRightLogical128BitLane(Vector128<int> value, byte numBytes) { throw null; }
        public static Vector128<uint> ShiftRightLogical128BitLane(Vector128<uint> value, byte numBytes) { throw null; }
        public static Vector128<long> ShiftRightLogical128BitLane(Vector128<long> value, byte numBytes) { throw null; }
        public static Vector128<ulong> ShiftRightLogical128BitLane(Vector128<ulong> value, byte numBytes) { throw null; }
        public static Vector128<double> Sqrt(Vector128<double> value) { throw null; }
        public static Vector128<double> SqrtScalar(Vector128<double> value) { throw null; }
        public static unsafe void StoreAligned(sbyte* address, Vector128<sbyte> source) { throw null; }
        public static unsafe void StoreAligned(byte* address, Vector128<byte> source) { throw null; }
        public static unsafe void StoreAligned(short* address, Vector128<short> source) { throw null; }
        public static unsafe void StoreAligned(ushort* address, Vector128<ushort> source) { throw null; }
        public static unsafe void StoreAligned(int* address, Vector128<int> source) { throw null; }
        public static unsafe void StoreAligned(uint* address, Vector128<uint> source) { throw null; }
        public static unsafe void StoreAligned(long* address, Vector128<long> source) { throw null; }
        public static unsafe void StoreAligned(ulong* address, Vector128<ulong> source) { throw null; }
        public static unsafe void StoreAligned(double* address, Vector128<double> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(sbyte* address, Vector128<sbyte> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(byte* address, Vector128<byte> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(short* address, Vector128<short> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(ushort* address, Vector128<ushort> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(int* address, Vector128<int> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(uint* address, Vector128<uint> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(long* address, Vector128<long> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(ulong* address, Vector128<ulong> source) { throw null; }
        public static unsafe void StoreAlignedNonTemporal(double* address, Vector128<double> source) { throw null; }
        public static unsafe void StoreScalar(double* address, Vector128<double> source) { throw null; }
        public static unsafe void Store(sbyte* address, Vector128<sbyte> source) { throw null; }
        public static unsafe void Store(byte* address, Vector128<byte> source) { throw null; }
        public static unsafe void Store(short* address, Vector128<short> source) { throw null; }
        public static unsafe void Store(ushort* address, Vector128<ushort> source) { throw null; }
        public static unsafe void Store(int* address, Vector128<int> source) { throw null; }
        public static unsafe void Store(uint* address, Vector128<uint> source) { throw null; }
        public static unsafe void Store(long* address, Vector128<long> source) { throw null; }
        public static unsafe void Store(ulong* address, Vector128<ulong> source) { throw null; }
        public static unsafe void Store(double* address, Vector128<double> source) { throw null; }
        public static unsafe void StoreHigh(double* address, Vector128<double> source) { throw null; }
        public static unsafe void StoreLow(long* address, Vector128<long> source) { throw null; }
        public static unsafe void StoreLow(ulong* address, Vector128<ulong> source) { throw null; }
        public static unsafe void StoreLow(double* address, Vector128<double> source) { throw null; }
        public static Vector128<byte> Subtract(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<sbyte> Subtract(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> Subtract(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> Subtract(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> Subtract(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> Subtract(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<long> Subtract(Vector128<long> left,  Vector128<long> right) { throw null; }
        public static Vector128<ulong> Subtract(Vector128<ulong> left,  Vector128<ulong> right) { throw null; }
        public static Vector128<double> Subtract(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<sbyte> SubtractSaturate(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> SubtractSaturate(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<byte> SubtractSaturate(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<ushort> SubtractSaturate(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<double> SubtractScalar(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<byte> UnpackHigh(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<sbyte> UnpackHigh(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> UnpackHigh(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> UnpackHigh(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> UnpackHigh(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> UnpackHigh(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<long> UnpackHigh(Vector128<long> left,  Vector128<long> right) { throw null; }
        public static Vector128<ulong> UnpackHigh(Vector128<ulong> left,  Vector128<ulong> right) { throw null; }
        public static Vector128<double> UnpackHigh(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<byte> UnpackLow(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<sbyte> UnpackLow(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> UnpackLow(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> UnpackLow(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> UnpackLow(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> UnpackLow(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<long> UnpackLow(Vector128<long> left,  Vector128<long> right) { throw null; }
        public static Vector128<ulong> UnpackLow(Vector128<ulong> left,  Vector128<ulong> right) { throw null; }
        public static Vector128<double> UnpackLow(Vector128<double> left,  Vector128<double> right) { throw null; }
        public static Vector128<byte> Xor(Vector128<byte> left,  Vector128<byte> right) { throw null; }
        public static Vector128<sbyte> Xor(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<short> Xor(Vector128<short> left,  Vector128<short> right) { throw null; }
        public static Vector128<ushort> Xor(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> Xor(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> Xor(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<long> Xor(Vector128<long> left,  Vector128<long> right) { throw null; }
        public static Vector128<ulong> Xor(Vector128<ulong> left,  Vector128<ulong> right) { throw null; }
        public static Vector128<double> Xor(Vector128<double> left,  Vector128<double> right) { throw null; }
    }
    public static class Sse3
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<float> AddSubtract(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<double> AddSubtract(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<float> HorizontalAdd(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<double> HorizontalAdd(Vector128<double> left, Vector128<double> right) { throw null; }
        public static Vector128<float> HorizontalSubtract(Vector128<float> left, Vector128<float> right) { throw null; }
        public static Vector128<double> HorizontalSubtract(Vector128<double> left, Vector128<double> right) { throw null; }
        public static unsafe Vector128<double> LoadAndDuplicateToVector128(double* address) { throw null; }
        public static unsafe Vector128<sbyte> LoadDquVector128(sbyte* address) { throw null; }
        public static unsafe Vector128<byte> LoadDquVector128(byte* address) { throw null; }
        public static unsafe Vector128<short> LoadDquVector128(short* address) { throw null; }
        public static unsafe Vector128<ushort> LoadDquVector128(ushort* address) { throw null; }
        public static unsafe Vector128<int> LoadDquVector128(int* address) { throw null; }
        public static unsafe Vector128<uint> LoadDquVector128(uint* address) { throw null; }
        public static unsafe Vector128<long> LoadDquVector128(long* address) { throw null; }
        public static unsafe Vector128<ulong> LoadDquVector128(ulong* address) { throw null; }
        public static Vector128<double> MoveAndDuplicate(Vector128<double> source) { throw null; }
        public static Vector128<float> MoveHighAndDuplicate(Vector128<float> source) { throw null; }
        public static Vector128<float> MoveLowAndDuplicate(Vector128<float> source) { throw null; }
    }
    public static class Sse41
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<short> Blend(Vector128<short> left, Vector128<short> right, byte control) { throw null; }
        public static Vector128<ushort> Blend(Vector128<ushort> left, Vector128<ushort> right, byte control) { throw null; }
        public static Vector128<float> Blend(Vector128<float> left, Vector128<float> right, byte control) { throw null; }
        public static Vector128<double> Blend(Vector128<double> left, Vector128<double> right, byte control) { throw null; }
        public static Vector128<sbyte> BlendVariable(Vector128<sbyte> left, Vector128<sbyte> right, Vector128<sbyte> mask) { throw null; }
        public static Vector128<byte> BlendVariable(Vector128<byte> left, Vector128<byte> right, Vector128<byte> mask) { throw null; }
        public static Vector128<float> BlendVariable(Vector128<float> left, Vector128<float> right, Vector128<float> mask) { throw null; }
        public static Vector128<double> BlendVariable(Vector128<double> left, Vector128<double> right, Vector128<double> mask) { throw null; }
        public static Vector128<float> Ceiling(Vector128<float> value) { throw null; }
        public static Vector128<double> Ceiling(Vector128<double> value) { throw null; }
        public static Vector128<double> CeilingScalar(Vector128<double> value) { throw null; }
        public static Vector128<float> CeilingScalar(Vector128<float> value) { throw null; }
        public static Vector128<long> CompareEqual(Vector128<long> left, Vector128<long> right) { throw null; }
        public static Vector128<ulong> CompareEqual(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
        public static Vector128<short> ConvertToVector128Int16(Vector128<sbyte> value) { throw null; }
        public static Vector128<short> ConvertToVector128Int16(Vector128<byte> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32(Vector128<sbyte> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32(Vector128<byte> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32(Vector128<short> value) { throw null; }
        public static Vector128<int> ConvertToVector128Int32(Vector128<ushort> value) { throw null; }
        public static Vector128<long> ConvertToVector128Int64(Vector128<sbyte> value) { throw null; }
        public static Vector128<long> ConvertToVector128Int64(Vector128<byte> value) { throw null; }
        public static Vector128<long> ConvertToVector128Int64(Vector128<short> value) { throw null; }
        public static Vector128<long> ConvertToVector128Int64(Vector128<ushort> value) { throw null; }
        public static Vector128<long> ConvertToVector128Int64(Vector128<int> value) { throw null; }
        public static Vector128<long> ConvertToVector128Int64(Vector128<uint> value) { throw null; }
        public static Vector128<float> DotProduct(Vector128<float> left, Vector128<float> right, byte control) { throw null; }
        public static Vector128<double> DotProduct(Vector128<double> left, Vector128<double> right, byte control) { throw null; }
        public static sbyte Extract(Vector128<sbyte> value, byte index) { throw null; }
        public static byte Extract(Vector128<byte> value, byte index) { throw null; }
        public static int Extract(Vector128<int> value, byte index) { throw null; }
        public static uint Extract(Vector128<uint> value, byte index) { throw null; }
        public static long Extract(Vector128<long> value, byte index) { throw null; }
        public static ulong Extract(Vector128<ulong> value, byte index) { throw null; }
        public static float Extract(Vector128<float> value, byte index) { throw null; }
        public static Vector128<float> Floor(Vector128<float> value) { throw null; }
        public static Vector128<double> Floor(Vector128<double> value) { throw null; }
        public static Vector128<double> FloorScalar(Vector128<double> value) { throw null; }
        public static Vector128<float> FloorScalar(Vector128<float> value) { throw null; }
        public static Vector128<sbyte> Insert(Vector128<sbyte> value, sbyte data, byte index) { throw null; }
        public static Vector128<byte> Insert(Vector128<byte> value, byte data, byte index) { throw null; }
        public static Vector128<int> Insert(Vector128<int> value, int data, byte index) { throw null; }
        public static Vector128<uint> Insert(Vector128<uint> value, uint data, byte index) { throw null; }
        public static Vector128<long> Insert(Vector128<long> value, long data, byte index) { throw null; }
        public static Vector128<ulong> Insert(Vector128<ulong> value, ulong data, byte index) { throw null; }
        public static Vector128<float> Insert(Vector128<float> value, float data, byte index) { throw null; }
        public static Vector128<sbyte> Max(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<ushort> Max(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> Max(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> Max(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<sbyte> Min(Vector128<sbyte> left,  Vector128<sbyte> right) { throw null; }
        public static Vector128<ushort> Min(Vector128<ushort> left,  Vector128<ushort> right) { throw null; }
        public static Vector128<int> Min(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<uint> Min(Vector128<uint> left,  Vector128<uint> right) { throw null; }
        public static Vector128<ushort> MinHorizontal(Vector128<ushort> value) { throw null; }
        public static Vector128<ushort> MultipleSumAbsoluteDifferences(Vector128<byte> left, Vector128<byte> right, byte mask) { throw null; }
        public static Vector128<long> Multiply(Vector128<int> left, Vector128<int> right) { throw null; }
        public static Vector128<int> MultiplyLow(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<ushort> PackUnsignedSaturate(Vector128<int> left,  Vector128<int> right) { throw null; }
        public static Vector128<double> RoundCurrentDirectionScalar(Vector128<double> value) { throw null; }
        public static Vector128<float> RoundCurrentDirectionScalar(Vector128<float> value) { throw null; }
        public static Vector128<float> RoundToNearestInteger(Vector128<float> value) { throw null; }
        public static Vector128<double> RoundToNearestIntegerScalar(Vector128<double> value) { throw null; }
        public static Vector128<float> RoundToNearestIntegerScalar(Vector128<float> value) { throw null; }
        public static Vector128<float> RoundToNegativeInfinity(Vector128<float> value) { throw null; }
        public static Vector128<double> RoundToNegativeInfinityScalar(Vector128<double> value) { throw null; }
        public static Vector128<float> RoundToNegativeInfinityScalar(Vector128<float> value) { throw null; }
        public static Vector128<float> RoundToPositiveInfinity(Vector128<float> value) { throw null; }
        public static Vector128<double> RoundToPositiveInfinityScalar(Vector128<double> value) { throw null; }
        public static Vector128<float> RoundToPositiveInfinityScalar(Vector128<float> value) { throw null; }
        public static Vector128<float> RoundToZero(Vector128<float> value) { throw null; }
        public static Vector128<double> RoundToZeroScalar(Vector128<double> value) { throw null; }
        public static Vector128<float> RoundToZeroScalar(Vector128<float> value) { throw null; }
        public static Vector128<float> RoundCurrentDirection(Vector128<float> value) { throw null; }
        public static Vector128<double> RoundToNearestInteger(Vector128<double> value) { throw null; }
        public static Vector128<double> RoundToNegativeInfinity(Vector128<double> value) { throw null; }
        public static Vector128<double> RoundToPositiveInfinity(Vector128<double> value) { throw null; }
        public static Vector128<double> RoundToZero(Vector128<double> value) { throw null; }
        public static Vector128<double> RoundCurrentDirection(Vector128<double> value) { throw null; }
        public static unsafe Vector128<sbyte> LoadAlignedNonTemporal(sbyte* address) { throw null; }
        public static unsafe Vector128<byte> LoadAlignedNonTemporal(byte* address) { throw null; }
        public static unsafe Vector128<short> LoadAlignedNonTemporal(short* address) { throw null; }
        public static unsafe Vector128<ushort> LoadAlignedNonTemporal(ushort* address) { throw null; }
        public static unsafe Vector128<int> LoadAlignedNonTemporal(int* address) { throw null; }
        public static unsafe Vector128<uint> LoadAlignedNonTemporal(uint* address) { throw null; }
        public static unsafe Vector128<long> LoadAlignedNonTemporal(long* address) { throw null; }
        public static unsafe Vector128<ulong> LoadAlignedNonTemporal(ulong* address) { throw null; }
        public static bool TestAllOnes(Vector128<sbyte> value) { throw null; }
        public static bool TestAllOnes(Vector128<byte> value) { throw null; }
        public static bool TestAllOnes(Vector128<short> value) { throw null; }
        public static bool TestAllOnes(Vector128<ushort> value) { throw null; }
        public static bool TestAllOnes(Vector128<int> value) { throw null; }
        public static bool TestAllOnes(Vector128<uint> value) { throw null; }
        public static bool TestAllOnes(Vector128<long> value) { throw null; }
        public static bool TestAllOnes(Vector128<ulong> value) { throw null; }
        public static bool TestAllZeros(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static bool TestAllZeros(Vector128<byte> left, Vector128<byte> right) { throw null; }
        public static bool TestAllZeros(Vector128<short> left, Vector128<short> right) { throw null; }
        public static bool TestAllZeros(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static bool TestAllZeros(Vector128<int> left, Vector128<int> right) { throw null; }
        public static bool TestAllZeros(Vector128<uint> left, Vector128<uint> right) { throw null; }
        public static bool TestAllZeros(Vector128<long> left, Vector128<long> right) { throw null; }
        public static bool TestAllZeros(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
        public static bool TestC(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static bool TestC(Vector128<byte> left, Vector128<byte> right) { throw null; }
        public static bool TestC(Vector128<short> left, Vector128<short> right) { throw null; }
        public static bool TestC(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static bool TestC(Vector128<int> left, Vector128<int> right) { throw null; }
        public static bool TestC(Vector128<uint> left, Vector128<uint> right) { throw null; }
        public static bool TestC(Vector128<long> left, Vector128<long> right) { throw null; }
        public static bool TestC(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<byte> left, Vector128<byte> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<short> left, Vector128<short> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<int> left, Vector128<int> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<uint> left, Vector128<uint> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<long> left, Vector128<long> right) { throw null; }
        public static bool TestMixOnesZeros(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<byte> left, Vector128<byte> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<short> left, Vector128<short> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<int> left, Vector128<int> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<uint> left, Vector128<uint> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<long> left, Vector128<long> right) { throw null; }
        public static bool TestNotZAndNotC(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
        public static bool TestZ(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static bool TestZ(Vector128<byte> left, Vector128<byte> right) { throw null; }
        public static bool TestZ(Vector128<short> left, Vector128<short> right) { throw null; }
        public static bool TestZ(Vector128<ushort> left, Vector128<ushort> right) { throw null; }
        public static bool TestZ(Vector128<int> left, Vector128<int> right) { throw null; }
        public static bool TestZ(Vector128<uint> left, Vector128<uint> right) { throw null; }
        public static bool TestZ(Vector128<long> left, Vector128<long> right) { throw null; }
        public static bool TestZ(Vector128<ulong> left, Vector128<ulong> right) { throw null; }
    }
    public static class Sse42
    {
        public static bool IsSupported { get { throw null; } }
        public static bool CompareImplicitLength(Vector128<sbyte> left, Vector128<sbyte> right, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareImplicitLength(Vector128<byte> left, Vector128<byte> right, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareImplicitLength(Vector128<short> left, Vector128<short> right, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareImplicitLength(Vector128<ushort> left, Vector128<ushort> right, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareExplicitLength(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareExplicitLength(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareExplicitLength(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static bool CompareExplicitLength(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, ResultsFlag flag, StringComparisonMode mode) { throw null; }
        public static int CompareImplicitLengthIndex(Vector128<sbyte> left, Vector128<sbyte> right, StringComparisonMode mode) { throw null; }
        public static int CompareImplicitLengthIndex(Vector128<byte> left, Vector128<byte> right, StringComparisonMode mode) { throw null; }
        public static int CompareImplicitLengthIndex(Vector128<short> left, Vector128<short> right, StringComparisonMode mode) { throw null; }
        public static int CompareImplicitLengthIndex(Vector128<ushort> left, Vector128<ushort> right, StringComparisonMode mode) { throw null; }
        public static int CompareExplicitLengthIndex(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static int CompareExplicitLengthIndex(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static int CompareExplicitLengthIndex(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static int CompareExplicitLengthIndex(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareImplicitLengthBitMask(Vector128<sbyte> left, Vector128<sbyte> right, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareImplicitLengthBitMask(Vector128<byte> left, Vector128<byte> right, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareImplicitLengthBitMask(Vector128<short> left, Vector128<short> right, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareImplicitLengthBitMask(Vector128<ushort> left, Vector128<ushort> right, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareImplicitLengthUnitMask(Vector128<sbyte> left, Vector128<sbyte> right, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareImplicitLengthUnitMask(Vector128<byte> left, Vector128<byte> right, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareImplicitLengthUnitMask(Vector128<short> left, Vector128<short> right, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareImplicitLengthUnitMask(Vector128<ushort> left, Vector128<ushort> right, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareExplicitLengthBitMask(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareExplicitLengthBitMask(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareExplicitLengthBitMask(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareExplicitLengthBitMask(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareExplicitLengthUnitMask(Vector128<sbyte> left, byte leftLength, Vector128<sbyte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<byte> CompareExplicitLengthUnitMask(Vector128<byte> left, byte leftLength, Vector128<byte> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareExplicitLengthUnitMask(Vector128<short> left, byte leftLength, Vector128<short> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<ushort> CompareExplicitLengthUnitMask(Vector128<ushort> left, byte leftLength, Vector128<ushort> right, byte rightLength, StringComparisonMode mode) { throw null; }
        public static Vector128<long> CompareGreaterThan(Vector128<long> left, Vector128<long> right) { throw null; }
        public static uint Crc32(uint crc, byte data) { throw null; }
        public static uint Crc32(uint crc, ushort data) { throw null; }
        public static uint Crc32(uint crc, uint data) { throw null; }
        public static ulong Crc32(ulong crc, ulong data) { throw null; }
    }
    public static class Ssse3
    {
        public static bool IsSupported { get { throw null; } }
        public static Vector128<byte> Abs(Vector128<sbyte> value) { throw null; }
        public static Vector128<ushort> Abs(Vector128<short> value) { throw null; }
        public static Vector128<uint> Abs(Vector128<int> value) { throw null; }
        public static Vector128<sbyte> AlignRight(Vector128<sbyte> left, Vector128<sbyte> right, byte mask) { throw null; }
        public static Vector128<short> HorizontalAdd(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<int> HorizontalAdd(Vector128<int> left, Vector128<int> right) { throw null; }
        public static Vector128<short> HorizontalAddSaturate(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<short> HorizontalSubtract(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<int> HorizontalSubtract(Vector128<int> left, Vector128<int> right) { throw null; }
        public static Vector128<short> HorizontalSubtractSaturate(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<short> MultiplyAddAdjacent(Vector128<byte> left, Vector128<sbyte> right) { throw null; }
        public static Vector128<short> MultiplyHighRoundScale(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<sbyte> Shuffle(Vector128<sbyte> value, Vector128<sbyte> mask) { throw null; }
        public static Vector128<sbyte> Sign(Vector128<sbyte> left, Vector128<sbyte> right) { throw null; }
        public static Vector128<short> Sign(Vector128<short> left, Vector128<short> right) { throw null; }
        public static Vector128<int> Sign(Vector128<int> left, Vector128<int> right) { throw null; }
    }
}
