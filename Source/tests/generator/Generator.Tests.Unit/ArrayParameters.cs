using Regress;
using static Regress.Global;

namespace Generator.Tests
{
    public class ArrayParameters
    {
        [Test]
        public void Array_Callback()
        {
            (int[] one, string[] two)? res = null;
            TestCallbackArray cb = new TestCallbackArray(
                (int[] one, string[] two) =>
                {
                    res = (one, two);
                    return 1;
                }
            );
            var ret = TestArrayCallback(cb);

            Assert.IsNotNull(res);
            var notNullRes = res!.Value;
            Assert.AreEqual(2, ret);
        }

        // This test can't work with the bindings since it expects the callback
        // to modifiy the size of the array. The size of the inout array is defined
        // by SizeParamIndex and can't be changed.
        [Ignore("Not supported")]
        [Test]
        public void Array_Callback_InOut()
        {
            var rets = new int[2];
            var callbackCount = 0;

            TestCallbackArrayInOut cb = new TestCallbackArrayInOut(
                (ref int[] ints) =>
                {
                    var length = ints.Length;
                    rets[callbackCount] = length;
                    length--;
                    callbackCount++;
                    ints = new int[length];
                    for (int i = 0; i < length; i++)
                    {
                        ints[i] = i - (2 - callbackCount);
                    }
                }
            );

            var ret = TestArrayInoutCallback(cb);

            Assert.AreEqual(3, ret);
            Assert.AreEqual(2, callbackCount);
            Assert.AreEqual(5, rets[0]);
            Assert.AreEqual(4, rets[1]);
        }

        [Ignore("FIXME: Regress types not registered")]
        [Test]
        public void Array_FixedOut_Objects()
        {
            var res = TestArrayFixedOutObjects();
            Assert.AreEqual(2, res.Length);
            Assert.IsTrue(res[0] is TestObj);
            Assert.IsTrue(res[1] is TestObj);
        }

        [Test]
        public void Array_FixedSize_Int_In()
        {
            var ints = new int[5] { 0, 1, 2, 3, 4 };
            var res = TestArrayFixedSizeIntIn(ints);
            Assert.AreEqual(1 + 2 + 3 + 4, res);
        }

        [Test]
        public void Array_FixedSize_Int_Out()
        {
            var res = TestArrayFixedSizeIntOut();

            Assert.AreEqual(5, res.Length);
            Assert.AreEqual(0, res[0]);
            Assert.AreEqual(1, res[1]);
            Assert.AreEqual(2, res[2]);
            Assert.AreEqual(3, res[3]);
            Assert.AreEqual(4, res[4]);
        }

        [Test]
        public void Array_gint8_In()
        {
            var ints = new sbyte[5] { 0, 1, 2, 3, 4 };
            var res = TestArrayGint8In(ints);
            Assert.AreEqual(1 + 2 + 3 + 4, res);
        }

        [Test]
        public void Array_gint16_In()
        {
            var ints = new short[5] { 0, 1, 2, 3, 4 };
            var res = TestArrayGint16In(ints);
            Assert.AreEqual(1 + 2 + 3 + 4, res);
        }

        [Test]
        public void Array_gint32_In()
        {
            var ints = new int[5] { 0, 1, 2, 3, 4 };
            var res = TestArrayGint32In(ints);
            Assert.AreEqual(1 + 2 + 3 + 4, res);
        }

        [Test]
        public void Array_gint64_In()
        {
            var ints = new long[5] { 0, 1, 2, 3, 4 };
            var res = TestArrayGint64In(ints);
            Assert.AreEqual(1 + 2 + 3 + 4, res);
        }

        [Test]
        public void Array_GType_In()
        {
            var gTypes = new GLib.GType[3] { FooBoxed.GType, FooBuffer.GType, FooObject.GType };
            var res = TestArrayGtypeIn(gTypes);
            Assert.AreEqual("[RegressFooBoxed,RegressFooBuffer,RegressFooObject,]", res);
        }

        [Test]
        public void Array_int_In()
        {
            var ints = new int[5] { 0, 1, 2, 3, 4 };
            var res = TestArrayIntIn(ints);
            Assert.AreEqual(1 + 2 + 3 + 4, res);
        }

        [Test]
        public void Array_int_Out()
        {
            var ints = TestArrayIntOut();
            Assert.AreEqual(new int[5] { 0, 1, 2, 3, 4 }, ints);
        }

        [Test]
        public void Array_int_InOut()
        {
            var ints = new int[5] { 0, 1, 2, 3, 4 };
            TestArrayIntInout(ref ints);
            Assert.AreEqual(new int[4] { 2, 3, 4, 5 }, ints);
        }

        [Test]
        public void Array_int_NullOut()
        {
            int[] arr = TestArrayIntNullOut();
            Assert.IsNull(arr);
        }

        [Test]
        public void Array_Static_int_In()
        {
            var ints = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            TestArrayStaticInInt(ints);
        }

        [Ignore("FIXME: Transfer ful crash, copy needed")]
        [Test]
        public void Array_Struct_In_Full()
        {
            var structs = new TestStructA[2] {
                new TestStructA {SomeInt = 201},
                new TestStructA {SomeInt = 202}
            };
            TestArrayStructInFull(structs);
        }

        [Test]
        public void Array_Struct_In_None()
        {
            var structs = new TestStructA[3] {
                new TestStructA {SomeInt = 301},
                new TestStructA {SomeInt = 302},
                new TestStructA {SomeInt = 303},
            };
            TestArrayStructInNone(structs);
        }

        [Test]
        public void Array_Struct_Out()
        {
            TestStructA[] structs = TestArrayStructOut();
            Assert.AreEqual(3, structs.Length);
            Assert.AreEqual(22, structs[0].SomeInt);
            Assert.AreEqual(33, structs[1].SomeInt);
            Assert.AreEqual(44, structs[2].SomeInt);
        }

        [Ignore("FIXME: caller-allocates not implemented")]
        [Test]
        public void Array_Struct_Out_CallerAlloc()
        {
            TestStructA[] structs = TestArrayStructOutCallerAlloc();
            Assert.AreEqual(3, structs.Length);
            Assert.AreEqual(22, structs[0].SomeInt);
            Assert.AreEqual(33, structs[1].SomeInt);
            Assert.AreEqual(44, structs[2].SomeInt);
        }

        [Test]
        public void Array_Struct_Out_Container()
        {
            TestStructA[] structs = TestArrayStructOutContainer();
            Assert.AreEqual(5, structs.Length);
            Assert.AreEqual(11, structs[0].SomeInt);
            Assert.AreEqual(13, structs[1].SomeInt);
            Assert.AreEqual(17, structs[2].SomeInt);
            Assert.AreEqual(19, structs[3].SomeInt);
            Assert.AreEqual(23, structs[4].SomeInt);
        }

        [Test]
        public void Array_Struct_Out_Full_Fixed()
        {
            var res = TestArrayStructOutFullFixed();

            Assert.AreEqual(4, res.Length);
            Assert.AreEqual(2, res[0].SomeInt);
            Assert.AreEqual(3, res[1].SomeInt);
            Assert.AreEqual(5, res[2].SomeInt);
            Assert.AreEqual(7, res[3].SomeInt);
        }

        [Ignore("FIXME: segfault, copy is needed with transfer none")]
        [Test]
        public void Array_Struct_Out_None()
        {
            TestStructA[] structs = TestArrayStructOutNone();
            Assert.AreEqual(3, structs.Length);
            Assert.AreEqual(111, structs[0].SomeInt);
            Assert.AreEqual(222, structs[1].SomeInt);
            Assert.AreEqual(333, structs[2].SomeInt);
        }
    }
}

