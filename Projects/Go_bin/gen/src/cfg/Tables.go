
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "bright/serialization"

type ByteBufLoader func(string) (*serialization.ByteBuf, error)

type Tables struct {
    TbBlackboard *Ai_TbBlackboard
    TbBehaviorTree *Ai_TbBehaviorTree
    TbClazz *Blueprint_TbClazz
    TbDrop *Bonus_TbDrop
    TbGlobalConfig *Common_TbGlobalConfig
    TbDummy *Common_TbDummy
    TbErrorInfo *Error_TbErrorInfo
    TbCodeInfo *Error_TbCodeInfo
    TbItem *Item_TbItem
    TbItemFunc *Item_TbItemFunc
    TbItemExtra *Item_TbItemExtra
    TbL10NDemo *L10n_TbL10NDemo
    TbPatchDemo *L10n_TbPatchDemo
    TbSystemMail *Mail_TbSystemMail
    TbGlobalMail *Mail_TbGlobalMail
    TbRoleLevelExpAttr *Role_TbRoleLevelExpAttr
    TbRoleLevelBonusCoefficient *Role_TbRoleLevelBonusCoefficient
    TbTestTag *Tag_TbTestTag
    TbFullTypes *Test_TbFullTypes
    TbSingleton *Test_TbSingleton
    TbDataFromJson *Test_TbDataFromJson
    TbDataFromXml *Test_TbDataFromXml
    TbDataFromLua *Test_TbDataFromLua
    TbMultiRowRecord *Test_TbMultiRowRecord
    TbMultiRowTitle *Test_TbMultiRowTitle
    TbTestNull *Test_TbTestNull
    TbDemoPrimitive *Test_TbDemoPrimitive
    TbTestString *Test_TbTestString
    TbDemoGroup *Test_TbDemoGroup
    TbDemoGroup_C *Test_TbDemoGroup_C
    TbDemoGroup_S *Test_TbDemoGroup_S
    TbDemoGroup_E *Test_TbDemoGroup_E
    TbTestGlobal *Test_TbTestGlobal
}

func NewTables(loader ByteBufLoader) (*Tables, error) {
    var err error
    var buf *serialization.ByteBuf

    tables := &Tables{}
    if buf, err = loader("ai.TbBlackboard.bin") ; err != nil {
        return nil, err
    }
    if tables.TbBlackboard, err = NewAi_TbBlackboard(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("ai.TbBehaviorTree.bin") ; err != nil {
        return nil, err
    }
    if tables.TbBehaviorTree, err = NewAi_TbBehaviorTree(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("blueprint.TbClazz.bin") ; err != nil {
        return nil, err
    }
    if tables.TbClazz, err = NewBlueprint_TbClazz(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("bonus.TbDrop.bin") ; err != nil {
        return nil, err
    }
    if tables.TbDrop, err = NewBonus_TbDrop(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("common.TbGlobalConfig.bin") ; err != nil {
        return nil, err
    }
    if tables.TbGlobalConfig, err = NewCommon_TbGlobalConfig(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("common.TbDummy.bin") ; err != nil {
        return nil, err
    }
    if tables.TbDummy, err = NewCommon_TbDummy(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("error.TbErrorInfo.bin") ; err != nil {
        return nil, err
    }
    if tables.TbErrorInfo, err = NewError_TbErrorInfo(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("error.TbCodeInfo.bin") ; err != nil {
        return nil, err
    }
    if tables.TbCodeInfo, err = NewError_TbCodeInfo(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("item.TbItem.bin") ; err != nil {
        return nil, err
    }
    if tables.TbItem, err = NewItem_TbItem(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("item.TbItemFunc.bin") ; err != nil {
        return nil, err
    }
    if tables.TbItemFunc, err = NewItem_TbItemFunc(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("item.TbItemExtra.bin") ; err != nil {
        return nil, err
    }
    if tables.TbItemExtra, err = NewItem_TbItemExtra(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("l10n.TbL10NDemo.bin") ; err != nil {
        return nil, err
    }
    if tables.TbL10NDemo, err = NewL10n_TbL10NDemo(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("l10n.TbPatchDemo.bin") ; err != nil {
        return nil, err
    }
    if tables.TbPatchDemo, err = NewL10n_TbPatchDemo(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("mail.TbSystemMail.bin") ; err != nil {
        return nil, err
    }
    if tables.TbSystemMail, err = NewMail_TbSystemMail(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("mail.TbGlobalMail.bin") ; err != nil {
        return nil, err
    }
    if tables.TbGlobalMail, err = NewMail_TbGlobalMail(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("role.TbRoleLevelExpAttr.bin") ; err != nil {
        return nil, err
    }
    if tables.TbRoleLevelExpAttr, err = NewRole_TbRoleLevelExpAttr(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("role.TbRoleLevelBonusCoefficient.bin") ; err != nil {
        return nil, err
    }
    if tables.TbRoleLevelBonusCoefficient, err = NewRole_TbRoleLevelBonusCoefficient(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("tag.TbTestTag.bin") ; err != nil {
        return nil, err
    }
    if tables.TbTestTag, err = NewTag_TbTestTag(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbFullTypes.bin") ; err != nil {
        return nil, err
    }
    if tables.TbFullTypes, err = NewTest_TbFullTypes(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbSingleton.bin") ; err != nil {
        return nil, err
    }
    if tables.TbSingleton, err = NewTest_TbSingleton(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbDataFromJson.bin") ; err != nil {
        return nil, err
    }
    if tables.TbDataFromJson, err = NewTest_TbDataFromJson(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbDataFromXml.bin") ; err != nil {
        return nil, err
    }
    if tables.TbDataFromXml, err = NewTest_TbDataFromXml(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbDataFromLua.bin") ; err != nil {
        return nil, err
    }
    if tables.TbDataFromLua, err = NewTest_TbDataFromLua(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbMultiRowRecord.bin") ; err != nil {
        return nil, err
    }
    if tables.TbMultiRowRecord, err = NewTest_TbMultiRowRecord(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbMultiRowTitle.bin") ; err != nil {
        return nil, err
    }
    if tables.TbMultiRowTitle, err = NewTest_TbMultiRowTitle(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbTestNull.bin") ; err != nil {
        return nil, err
    }
    if tables.TbTestNull, err = NewTest_TbTestNull(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbDemoPrimitive.bin") ; err != nil {
        return nil, err
    }
    if tables.TbDemoPrimitive, err = NewTest_TbDemoPrimitive(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbTestString.bin") ; err != nil {
        return nil, err
    }
    if tables.TbTestString, err = NewTest_TbTestString(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbDemoGroup.bin") ; err != nil {
        return nil, err
    }
    if tables.TbDemoGroup, err = NewTest_TbDemoGroup(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbDemoGroup_C.bin") ; err != nil {
        return nil, err
    }
    if tables.TbDemoGroup_C, err = NewTest_TbDemoGroup_C(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbDemoGroup_S.bin") ; err != nil {
        return nil, err
    }
    if tables.TbDemoGroup_S, err = NewTest_TbDemoGroup_S(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbDemoGroup_E.bin") ; err != nil {
        return nil, err
    }
    if tables.TbDemoGroup_E, err = NewTest_TbDemoGroup_E(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("test.TbTestGlobal.bin") ; err != nil {
        return nil, err
    }
    if tables.TbTestGlobal, err = NewTest_TbTestGlobal(buf) ; err != nil {
        return nil, err
    }
    return tables, nil
}

