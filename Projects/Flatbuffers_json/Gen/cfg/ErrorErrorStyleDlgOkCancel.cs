// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ErrorErrorStyleDlgOkCancel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static ErrorErrorStyleDlgOkCancel GetRootAsErrorErrorStyleDlgOkCancel(ByteBuffer _bb) { return GetRootAsErrorErrorStyleDlgOkCancel(_bb, new ErrorErrorStyleDlgOkCancel()); }
  public static ErrorErrorStyleDlgOkCancel GetRootAsErrorErrorStyleDlgOkCancel(ByteBuffer _bb, ErrorErrorStyleDlgOkCancel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ErrorErrorStyleDlgOkCancel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Btn1Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBtn1NameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetBtn1NameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetBtn1NameArray() { return __p.__vector_as_array<byte>(4); }
  public string Btn2Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBtn2NameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetBtn2NameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetBtn2NameArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<cfg.ErrorErrorStyleDlgOkCancel> CreateErrorErrorStyleDlgOkCancel(FlatBufferBuilder builder,
      StringOffset btn1_nameOffset = default(StringOffset),
      StringOffset btn2_nameOffset = default(StringOffset)) {
    builder.StartTable(2);
    ErrorErrorStyleDlgOkCancel.AddBtn2Name(builder, btn2_nameOffset);
    ErrorErrorStyleDlgOkCancel.AddBtn1Name(builder, btn1_nameOffset);
    return ErrorErrorStyleDlgOkCancel.EndErrorErrorStyleDlgOkCancel(builder);
  }

  public static void StartErrorErrorStyleDlgOkCancel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddBtn1Name(FlatBufferBuilder builder, StringOffset btn1NameOffset) { builder.AddOffset(0, btn1NameOffset.Value, 0); }
  public static void AddBtn2Name(FlatBufferBuilder builder, StringOffset btn2NameOffset) { builder.AddOffset(1, btn2NameOffset.Value, 0); }
  public static Offset<cfg.ErrorErrorStyleDlgOkCancel> EndErrorErrorStyleDlgOkCancel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.ErrorErrorStyleDlgOkCancel>(o);
  }
};


}