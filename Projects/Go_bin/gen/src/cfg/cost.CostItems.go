
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Cost_CostItems struct {
    Cost_Cost
    ItemList []*Cost_CostItem
}

func (Cost_CostItems) GetTypeId() int {
    return -77945102
}

func NewCost_CostItems(_buf *serialization.ByteBuf) (_v *Cost_CostItems, err error) {
    _v = &Cost_CostItems{}
    var _p *Cost_Cost
     if _p, err = NewCost_Cost(_buf) ; err != nil { return }
    _v.Cost_Cost = *_p
    if _v.ItemList, err = func (_buf2 *serialization.ByteBuf) (_v2 []*Cost_CostItem, err2 error) {
                _v2 = make([]*Cost_CostItem, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 *Cost_CostItem
                    if v3, err2 = NewCost_CostItem (_buf2); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    return
}

