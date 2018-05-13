// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/******************************************************************************
 * This file is auto-generated from a template file by the GenerateTests.csx  *
 * script in tests\src\JIT\HardwareIntrinsics\X86\Shared. In order to make    *
 * changes, please update the corresponding template and run according to the *
 * directions listed in the file.                                             *
 ******************************************************************************/

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace JIT.HardwareIntrinsics.X86
{
    public static partial class Program
    {
        private static void ShiftLeftLogicalUInt321()
        {
            var test = new SimpleUnaryOpTest__ShiftLeftLogicalUInt321();

            if (test.IsSupported)
            {
                // Validates basic functionality works, using Unsafe.Read
                test.RunBasicScenario_UnsafeRead();

                if (Avx.IsSupported)
                {
                    // Validates basic functionality works, using Load
                    test.RunBasicScenario_Load();

                    // Validates basic functionality works, using LoadAligned
                    test.RunBasicScenario_LoadAligned();
                }

                // Validates calling via reflection works, using Unsafe.Read
                test.RunReflectionScenario_UnsafeRead();

                if (Avx.IsSupported)
                {
                    // Validates calling via reflection works, using Load
                    test.RunReflectionScenario_Load();

                    // Validates calling via reflection works, using LoadAligned
                    test.RunReflectionScenario_LoadAligned();
                }

                // Validates passing a static member works
                test.RunClsVarScenario();

                // Validates passing a local works, using Unsafe.Read
                test.RunLclVarScenario_UnsafeRead();

                if (Avx.IsSupported)
                {
                    // Validates passing a local works, using Load
                    test.RunLclVarScenario_Load();

                    // Validates passing a local works, using LoadAligned
                    test.RunLclVarScenario_LoadAligned();
                }

                // Validates passing the field of a local works
                test.RunLclFldScenario();

                // Validates passing an instance member works
                test.RunFldScenario();
            }
            else
            {
                // Validates we throw on unsupported hardware
                test.RunUnsupportedScenario();
            }

            if (!test.Succeeded)
            {
                throw new Exception("One or more scenarios did not complete as expected.");
            }
        }
    }

    public sealed unsafe class SimpleUnaryOpTest__ShiftLeftLogicalUInt321
    {
        private static readonly int LargestVectorSize = 32;

        private static readonly int Op1ElementCount = Unsafe.SizeOf<Vector256<UInt32>>() / sizeof(UInt32);
        private static readonly int RetElementCount = Unsafe.SizeOf<Vector256<UInt32>>() / sizeof(UInt32);

        private static UInt32[] _data = new UInt32[Op1ElementCount];

        private static Vector256<UInt32> _clsVar;

        private Vector256<UInt32> _fld;

        private SimpleUnaryOpTest__DataTable<UInt32, UInt32> _dataTable;

        static SimpleUnaryOpTest__ShiftLeftLogicalUInt321()
        {
            var random = new Random();

            for (var i = 0; i < Op1ElementCount; i++) { _data[i] = (uint)(random.Next(0, int.MaxValue)); }
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Vector256<UInt32>, byte>(ref _clsVar), ref Unsafe.As<UInt32, byte>(ref _data[0]), (uint)Unsafe.SizeOf<Vector256<UInt32>>());
        }

        public SimpleUnaryOpTest__ShiftLeftLogicalUInt321()
        {
            Succeeded = true;

            var random = new Random();

            for (var i = 0; i < Op1ElementCount; i++) { _data[i] = (uint)(random.Next(0, int.MaxValue)); }
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<Vector256<UInt32>, byte>(ref _fld), ref Unsafe.As<UInt32, byte>(ref _data[0]), (uint)Unsafe.SizeOf<Vector256<UInt32>>());

            for (var i = 0; i < Op1ElementCount; i++) { _data[i] = (uint)(random.Next(0, int.MaxValue)); }
            _dataTable = new SimpleUnaryOpTest__DataTable<UInt32, UInt32>(_data, new UInt32[RetElementCount], LargestVectorSize);
        }

        public bool IsSupported => Avx2.IsSupported;

        public bool Succeeded { get; set; }

        public void RunBasicScenario_UnsafeRead()
        {
            var result = Avx2.ShiftLeftLogical(
                Unsafe.Read<Vector256<UInt32>>(_dataTable.inArrayPtr),
                1
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunBasicScenario_Load()
        {
            var result = Avx2.ShiftLeftLogical(
                Avx.LoadVector256((UInt32*)(_dataTable.inArrayPtr)),
                1
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunBasicScenario_LoadAligned()
        {
            var result = Avx2.ShiftLeftLogical(
                Avx.LoadAlignedVector256((UInt32*)(_dataTable.inArrayPtr)),
                1
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunReflectionScenario_UnsafeRead()
        {
            var result = typeof(Avx2).GetMethod(nameof(Avx2.ShiftLeftLogical), new Type[] { typeof(Vector256<UInt32>), typeof(byte) })
                                     .Invoke(null, new object[] {
                                        Unsafe.Read<Vector256<UInt32>>(_dataTable.inArrayPtr),
                                        (byte)1
                                     });

            Unsafe.Write(_dataTable.outArrayPtr, (Vector256<UInt32>)(result));
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunReflectionScenario_Load()
        {
            var result = typeof(Avx2).GetMethod(nameof(Avx2.ShiftLeftLogical), new Type[] { typeof(Vector256<UInt32>), typeof(byte) })
                                     .Invoke(null, new object[] {
                                        Avx.LoadVector256((UInt32*)(_dataTable.inArrayPtr)),
                                        (byte)1
                                     });

            Unsafe.Write(_dataTable.outArrayPtr, (Vector256<UInt32>)(result));
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunReflectionScenario_LoadAligned()
        {
            var result = typeof(Avx2).GetMethod(nameof(Avx2.ShiftLeftLogical), new Type[] { typeof(Vector256<UInt32>), typeof(byte) })
                                     .Invoke(null, new object[] {
                                        Avx.LoadAlignedVector256((UInt32*)(_dataTable.inArrayPtr)),
                                        (byte)1
                                     });

            Unsafe.Write(_dataTable.outArrayPtr, (Vector256<UInt32>)(result));
            ValidateResult(_dataTable.inArrayPtr, _dataTable.outArrayPtr);
        }

        public void RunClsVarScenario()
        {
            var result = Avx2.ShiftLeftLogical(
                _clsVar,
                1
            );

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_clsVar, _dataTable.outArrayPtr);
        }

        public void RunLclVarScenario_UnsafeRead()
        {
            var firstOp = Unsafe.Read<Vector256<UInt32>>(_dataTable.inArrayPtr);
            var result = Avx2.ShiftLeftLogical(firstOp, 1);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(firstOp, _dataTable.outArrayPtr);
        }

        public void RunLclVarScenario_Load()
        {
            var firstOp = Avx.LoadVector256((UInt32*)(_dataTable.inArrayPtr));
            var result = Avx2.ShiftLeftLogical(firstOp, 1);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(firstOp, _dataTable.outArrayPtr);
        }

        public void RunLclVarScenario_LoadAligned()
        {
            var firstOp = Avx.LoadAlignedVector256((UInt32*)(_dataTable.inArrayPtr));
            var result = Avx2.ShiftLeftLogical(firstOp, 1);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(firstOp, _dataTable.outArrayPtr);
        }

        public void RunLclFldScenario()
        {
            var test = new SimpleUnaryOpTest__ShiftLeftLogicalUInt321();
            var result = Avx2.ShiftLeftLogical(test._fld, 1);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(test._fld, _dataTable.outArrayPtr);
        }

        public void RunFldScenario()
        {
            var result = Avx2.ShiftLeftLogical(_fld, 1);

            Unsafe.Write(_dataTable.outArrayPtr, result);
            ValidateResult(_fld, _dataTable.outArrayPtr);
        }

        public void RunUnsupportedScenario()
        {
            Succeeded = false;

            try
            {
                RunBasicScenario_UnsafeRead();
            }
            catch (PlatformNotSupportedException)
            {
                Succeeded = true;
            }
        }

        private void ValidateResult(Vector256<UInt32> firstOp, void* result, [CallerMemberName] string method = "")
        {
            UInt32[] inArray = new UInt32[Op1ElementCount];
            UInt32[] outArray = new UInt32[RetElementCount];

            Unsafe.WriteUnaligned(ref Unsafe.As<UInt32, byte>(ref inArray[0]), firstOp);
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<UInt32, byte>(ref outArray[0]), ref Unsafe.AsRef<byte>(result), (uint)Unsafe.SizeOf<Vector256<UInt32>>());

            ValidateResult(inArray, outArray, method);
        }

        private void ValidateResult(void* firstOp, void* result, [CallerMemberName] string method = "")
        {
            UInt32[] inArray = new UInt32[Op1ElementCount];
            UInt32[] outArray = new UInt32[RetElementCount];

            Unsafe.CopyBlockUnaligned(ref Unsafe.As<UInt32, byte>(ref inArray[0]), ref Unsafe.AsRef<byte>(firstOp), (uint)Unsafe.SizeOf<Vector256<UInt32>>());
            Unsafe.CopyBlockUnaligned(ref Unsafe.As<UInt32, byte>(ref outArray[0]), ref Unsafe.AsRef<byte>(result), (uint)Unsafe.SizeOf<Vector256<UInt32>>());

            ValidateResult(inArray, outArray, method);
        }

        private void ValidateResult(UInt32[] firstOp, UInt32[] result, [CallerMemberName] string method = "")
        {
            if ((uint)(firstOp[0] << 1) != result[0])
            {
                Succeeded = false;
            }
            else
            {
                for (var i = 1; i < RetElementCount; i++)
                {
                    if ((uint)(firstOp[i] << 1) != result[i])
                    {
                        Succeeded = false;
                        break;
                    }
                }
            }

            if (!Succeeded)
            {
                Console.WriteLine($"{nameof(Avx2)}.{nameof(Avx2.ShiftLeftLogical)}<UInt32>(Vector256<UInt32><9>): {method} failed:");
                Console.WriteLine($"  firstOp: ({string.Join(", ", firstOp)})");
                Console.WriteLine($"   result: ({string.Join(", ", result)})");
                Console.WriteLine();
            }
        }
    }
}