
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"

import "bright/math"

type Test_DemoType2 struct {
    X4 int32
    X1 bool
    X2 byte
    X3 int16
    X5 int64
    X6 float32
    X7 float64
    X80 int16
    X8 int32
    X9 int64
    X10 string
    X12 *Test_DemoType1
    X13 int32
    X14 interface{}
    S1 string
    V2 math.Vector2
    V3 math.Vector3
    V4 math.Vector4
    T1 int32
    K1 []int32
    K2 []int32
    K3 []int32
    K4 []int32
    K5 []int32
    K6 []int32
    K7 []int32
    K8 map[int32]int32
    K9 []*Test_DemoE2
    K15 []interface{}
}

func (Test_DemoType2) GetTypeId() int {
    return -367048295
}

func NewTest_DemoType2(_buf *serialization.ByteBuf) (_v *Test_DemoType2, err error) {
    _v = &Test_DemoType2{}
    if _v.X4, err = _buf.ReadInt(); err != nil  { return } 
    if _v.X1, err = _buf.ReadBool(); err != nil  { return } 
    if _v.X2, err = _buf.ReadByte(); err != nil  { return } 
    if _v.X3, err = _buf.ReadShort(); err != nil  { return } 
    if _v.X5, err = _buf.ReadLong(); err != nil  { return } 
    if _v.X6, err = _buf.ReadFloat(); err != nil  { return } 
    if _v.X7, err = _buf.ReadDouble(); err != nil  { return } 
    if _v.X80, err = _buf.ReadFshort(); err != nil  { return } 
    if _v.X8, err = _buf.ReadFint(); err != nil  { return } 
    if _v.X9, err = _buf.ReadFlong(); err != nil  { return } 
    if _v.X10, err = _buf.ReadString(); err != nil  { return } 
    if _v.X12, err = NewTest_DemoType1 (_buf); err != nil  { return } 
    if _v.X13, err = _buf.ReadInt(); err != nil  { return } 
    if _v.X14, err = NewChildTest_DemoDynamic(_buf); err != nil  { return } 
    if _v.S1, err = _buf.ReadString(); err != nil  { return } 
    if _v.V2, err = _buf.ReadVector2(); err != nil  { return } 
    if _v.V3, err = _buf.ReadVector3(); err != nil  { return } 
    if _v.V4, err = _buf.ReadVector4(); err != nil  { return } 
    if _v.T1, err = _buf.ReadInt(); err != nil  { return } 
    if _v.K1, err = func (_buf2 *serialization.ByteBuf) (_v2 []int32, err2 error) {
                _v2 = make([]int32, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 int32
                    if v3, err2 = _buf2.ReadInt(); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    if _v.K2, err = func (_buf2 *serialization.ByteBuf) (_v2 []int32, err2 error) {
                _v2 = make([]int32, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 int32
                    if v3, err2 = _buf2.ReadInt(); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    if _v.K3, err = func (_buf2 *serialization.ByteBuf) (_v2 []int32, err2 error) {
                _v2 = make([]int32, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 int32
                    if v3, err2 = _buf2.ReadInt(); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    if _v.K4, err = func (_buf2 *serialization.ByteBuf) (_v2 []int32, err2 error) {
                _v2 = make([]int32, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 int32
                    if v3, err2 = _buf2.ReadInt(); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    if _v.K5, err = func (_buf2 *serialization.ByteBuf) (_v2 []int32, err2 error) {
                _v2 = make([]int32, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 int32
                    if v3, err2 = _buf2.ReadInt(); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    if _v.K6, err = func (_buf2 *serialization.ByteBuf) (_v2 []int32, err2 error) {
                _v2 = make([]int32, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 int32
                    if v3, err2 = _buf2.ReadInt(); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    if _v.K7, err = func (_buf2 *serialization.ByteBuf) (_v2 []int32, err2 error) {
                _v2 = make([]int32, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 int32
                    if v3, err2 = _buf2.ReadInt(); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    if _v.K8, err = func (_buf2 *serialization.ByteBuf) (_v2 map[int32]int32, err2 error) {
                _v2 = make(map[int32]int32)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var _key int32
                    if _key, err2 = _buf2.ReadInt(); err2 != nil {return}
                    var _value int32
                    if _value, err2 = _buf2.ReadInt(); err2 != nil {return}
                    _v2[_key] = _value
                }
                return
                }(_buf); err != nil  { return } 
    if _v.K9, err = func (_buf2 *serialization.ByteBuf) (_v2 []*Test_DemoE2, err2 error) {
                _v2 = make([]*Test_DemoE2, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 *Test_DemoE2
                    if v3, err2 = NewTest_DemoE2 (_buf2); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    if _v.K15, err = func (_buf2 *serialization.ByteBuf) (_v2 []interface{}, err2 error) {
                _v2 = make([]interface{}, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 interface{}
                    if v3, err2 = NewChildTest_DemoDynamic(_buf2); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    return
}

