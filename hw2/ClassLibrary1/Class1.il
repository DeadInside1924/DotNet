.class public auto ansi beforefieldinit
  Calculator.Calculator
    extends [System.Runtime]System.Object
{

  .method public hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    // [13 9 - 13 28]
    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [System.Runtime]System.Object::.ctor()
    IL_0006: nop

    // [14 9 - 14 10]
    IL_0007: nop

    // [16 9 - 16 10]
    IL_0008: ret

  } // end of method Calculator::.ctor

  .method public hidebysig instance float64
    Calculate(
      string expression
    ) cil managed
  {
    .maxstack 3
    .locals init (
      [0] string[] mass,
      [1] float64 result,
      [2] bool V_2,
      [3] bool V_3,
      [4] float64 V_4,
      [5] string V_5,
      [6] float64 V_6
    )

    // [19 9 - 19 10]
    IL_0000: nop

    // [20 13 - 20 43]
    IL_0001: ldarg.1      // expression
    IL_0002: call         !!0/*char*/[] [System.Runtime]System.Array::Empty<char>()
    IL_0007: callvirt     instance string[] [System.Runtime]System.String::Split(char[])
    IL_000c: stloc.0      // mass

    // [21 13 - 21 67]
    IL_000d: ldloc.0      // mass
    IL_000e: ldc.i4.1
    IL_000f: ldelem.ref
    IL_0010: ldstr        "/"
    IL_0015: callvirt     instance bool [System.Runtime]System.String::Equals(string)
    IL_001a: brfalse.s    IL_0031
    IL_001c: ldloc.0      // mass
    IL_001d: ldc.i4.2
    IL_001e: ldelem.ref
    IL_001f: call         float64 [System.Runtime]System.Double::Parse(string)
    IL_0024: ldc.r8       0.0
    IL_002d: ceq
    IL_002f: br.s         IL_0032
    IL_0031: ldc.i4.0
    IL_0032: stloc.2      // V_2

    IL_0033: ldloc.2      // V_2
    IL_0034: brfalse.s    IL_0041

    // [22 17 - 22 62]
    IL_0036: ldstr        "Нельзя делить на ноль"
    IL_003b: newobj       instance void [System.Runtime]System.Exception::.ctor(string)
    IL_0040: throw

    // [25 13 - 25 34]
    IL_0041: ldloc.0      // mass
    IL_0042: ldlen
    IL_0043: conv.i4
    IL_0044: ldc.i4.3
    IL_0045: ceq
    IL_0047: ldc.i4.0
    IL_0048: ceq
    IL_004a: stloc.3      // V_3

    IL_004b: ldloc.3      // V_3
    IL_004c: brfalse.s    IL_005a

    // [26 13 - 26 14]
    IL_004e: nop

    // [27 17 - 27 66]
    IL_004f: ldstr        "Не верная длина выражения"
    IL_0054: newobj       instance void [System.Runtime]System.Exception::.ctor(string)
    IL_0059: throw

    // [30 13 - 37 15]
    IL_005a: ldloc.0      // mass
    IL_005b: ldc.i4.1
    IL_005c: ldelem.ref
    IL_005d: stloc.s      V_5
    IL_005f: ldc.i4.1
    IL_0060: brtrue.s     IL_0063

    // [30 34 - 37 14]
    IL_0062: nop

    IL_0063: ldloc.s      V_5
    IL_0065: ldstr        "+"
    IL_006a: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_006f: brtrue.s     IL_009d
    IL_0071: ldloc.s      V_5
    IL_0073: ldstr        "-"
    IL_0078: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_007d: brtrue.s     IL_00b2
    IL_007f: ldloc.s      V_5
    IL_0081: ldstr        "*"
    IL_0086: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_008b: brtrue.s     IL_00c7
    IL_008d: ldloc.s      V_5
    IL_008f: ldstr        "/"
    IL_0094: call         bool [System.Runtime]System.String::op_Equality(string, string)
    IL_0099: brtrue.s     IL_00dc
    IL_009b: br.s         IL_00f1

    // [32 24 - 32 69]
    IL_009d: ldloc.0      // mass
    IL_009e: ldc.i4.0
    IL_009f: ldelem.ref
    IL_00a0: call         float64 [System.Runtime]System.Double::Parse(string)
    IL_00a5: ldloc.0      // mass
    IL_00a6: ldc.i4.2
    IL_00a7: ldelem.ref
    IL_00a8: call         float64 [System.Runtime]System.Double::Parse(string)
    IL_00ad: add
    IL_00ae: stloc.s      V_4
    IL_00b0: br.s         IL_00fc

    // [33 24 - 33 69]
    IL_00b2: ldloc.0      // mass
    IL_00b3: ldc.i4.0
    IL_00b4: ldelem.ref
    IL_00b5: call         float64 [System.Runtime]System.Double::Parse(string)
    IL_00ba: ldloc.0      // mass
    IL_00bb: ldc.i4.2
    IL_00bc: ldelem.ref
    IL_00bd: call         float64 [System.Runtime]System.Double::Parse(string)
    IL_00c2: sub
    IL_00c3: stloc.s      V_4
    IL_00c5: br.s         IL_00fc

    // [34 24 - 34 69]
    IL_00c7: ldloc.0      // mass
    IL_00c8: ldc.i4.0
    IL_00c9: ldelem.ref
    IL_00ca: call         float64 [System.Runtime]System.Double::Parse(string)
    IL_00cf: ldloc.0      // mass
    IL_00d0: ldc.i4.2
    IL_00d1: ldelem.ref
    IL_00d2: call         float64 [System.Runtime]System.Double::Parse(string)
    IL_00d7: mul
    IL_00d8: stloc.s      V_4
    IL_00da: br.s         IL_00fc

    // [35 24 - 35 69]
    IL_00dc: ldloc.0      // mass
    IL_00dd: ldc.i4.0
    IL_00de: ldelem.ref
    IL_00df: call         float64 [System.Runtime]System.Double::Parse(string)
    IL_00e4: ldloc.0      // mass
    IL_00e5: ldc.i4.2
    IL_00e6: ldelem.ref
    IL_00e7: call         float64 [System.Runtime]System.Double::Parse(string)
    IL_00ec: div
    IL_00ed: stloc.s      V_4
    IL_00ef: br.s         IL_00fc

    // [36 22 - 36 73]
    IL_00f1: ldstr        "Не существует такой операции"
    IL_00f6: newobj       instance void [System.Runtime]System.Exception::.ctor(string)
    IL_00fb: throw

    IL_00fc: ldc.i4.1
    IL_00fd: brtrue.s     IL_0100

    // [30 13 - 37 15]
    IL_00ff: nop

    IL_0100: ldloc.s      V_4
    IL_0102: stloc.1      // result

    // [39 13 - 39 27]
    IL_0103: ldloc.1      // result
    IL_0104: stloc.s      V_6
    IL_0106: br.s         IL_0108

    // [40 9 - 40 10]
    IL_0108: ldloc.s      V_6
    IL_010a: ret

  } // end of method Calculator::Calculate
}