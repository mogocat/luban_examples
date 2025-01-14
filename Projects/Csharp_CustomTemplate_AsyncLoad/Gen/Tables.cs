
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Text.Json;
using System.Threading.Tasks;


namespace cfg
{
   
public sealed class Tables
{
    public ai.TbBlackboard TbBlackboard {get; private set; }
    public ai.TbBehaviorTree TbBehaviorTree {get; private set; }
    public blueprint.TbClazz TbClazz {get; private set; }
    public bonus.TbDrop TbDrop {get; private set; }
    public common.TbGlobalConfig TbGlobalConfig {get; private set; }
    public error.TbErrorInfo TbErrorInfo {get; private set; }
    public error.TbCodeInfo TbCodeInfo {get; private set; }
    /// <summary>
    /// 道具表
    /// </summary>
    public item.TbItem TbItem {get; private set; }
    public item.TbItemFunc TbItemFunc {get; private set; }
    public item.TbItemExtra TbItemExtra {get; private set; }
    public l10n.TbL10NDemo TbL10NDemo {get; private set; }
    public l10n.TbPatchDemo TbPatchDemo {get; private set; }
    public mail.TbSystemMail TbSystemMail {get; private set; }
    public mail.TbGlobalMail TbGlobalMail {get; private set; }
    public role.TbRoleLevelExpAttr TbRoleLevelExpAttr {get; private set; }
    public role.TbRoleLevelBonusCoefficient TbRoleLevelBonusCoefficient {get; private set; }
    public tag.TbTestTag TbTestTag {get; private set; }
    public test.TbFullTypes TbFullTypes {get; private set; }
    public test.TbSingleton TbSingleton {get; private set; }
    public test.TbNotIndexList TbNotIndexList {get; private set; }
    public test.TbMultiUnionIndexList TbMultiUnionIndexList {get; private set; }
    public test.TbMultiIndexList TbMultiIndexList {get; private set; }
    public test.TbDataFromMisc TbDataFromMisc {get; private set; }
    public test.TbMultiRowRecord TbMultiRowRecord {get; private set; }
    public test.TbMultiRowTitle TbMultiRowTitle {get; private set; }
    public test.TbTestNull TbTestNull {get; private set; }
    public test.TbDemoPrimitive TbDemoPrimitive {get; private set; }
    public test.TbTestString TbTestString {get; private set; }
    public test.TbDemoGroup TbDemoGroup {get; private set; }
    public test.TbDemoGroup_C TbDemoGroup_C {get; private set; }
    public test.TbDemoGroup_S TbDemoGroup_S {get; private set; }
    public test.TbDemoGroup_E TbDemoGroup_E {get; private set; }
    public test.TbTestGlobal TbTestGlobal {get; private set; }
    public test.TbTestBeRef TbTestBeRef {get; private set; }
    public test.TbTestRef TbTestRef {get; private set; }
    public test.TbTestSize TbTestSize {get; private set; }
    public test.TbTestSet TbTestSet {get; private set; }
    public test.TbDetectCsvEncoding TbDetectCsvEncoding {get; private set; }
    public test.TbDefineFromExcel TbDefineFromExcel {get; private set; }
    public test.TbDefineFromExcelOne TbDefineFromExcelOne {get; private set; }
    public test.TbTestIndex TbTestIndex {get; private set; }
    public test.TbTestMap TbTestMap {get; private set; }
    public test.TbExcelFromJson TbExcelFromJson {get; private set; }
    public test.TbCompositeJsonTable1 TbCompositeJsonTable1 {get; private set; }
    public test.TbCompositeJsonTable2 TbCompositeJsonTable2 {get; private set; }
    public test.TbCompositeJsonTable3 TbCompositeJsonTable3 {get; private set; }
    public test.TbExcelFromJsonMultiRow TbExcelFromJsonMultiRow {get; private set; }
    public test.TbTestExternalType TbTestExternalType {get; private set; }
    public test.TbDemoGroupDefineFromExcel TbDemoGroupDefineFromExcel {get; private set; }
    public test.TbDefineFromExcel2 TbDefineFromExcel2 {get; private set; }
    public test.TbTestExcelBean TbTestExcelBean {get; private set; }
    public test.TbTestDesc TbTestDesc {get; private set; }

    public Tables() { }
    
    public async Task LoadAsync(System.Func<string, Task<JsonElement>> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        TbBlackboard = new ai.TbBlackboard(await loader("ai_tbblackboard")); 
        tables.Add("ai.TbBlackboard", TbBlackboard);
        TbBehaviorTree = new ai.TbBehaviorTree(await loader("ai_tbbehaviortree")); 
        tables.Add("ai.TbBehaviorTree", TbBehaviorTree);
        TbClazz = new blueprint.TbClazz(await loader("blueprint_tbclazz")); 
        tables.Add("blueprint.TbClazz", TbClazz);
        TbDrop = new bonus.TbDrop(await loader("bonus_tbdrop")); 
        tables.Add("bonus.TbDrop", TbDrop);
        TbGlobalConfig = new common.TbGlobalConfig(await loader("common_tbglobalconfig")); 
        tables.Add("common.TbGlobalConfig", TbGlobalConfig);
        TbErrorInfo = new error.TbErrorInfo(await loader("error_tberrorinfo")); 
        tables.Add("error.TbErrorInfo", TbErrorInfo);
        TbCodeInfo = new error.TbCodeInfo(await loader("error_tbcodeinfo")); 
        tables.Add("error.TbCodeInfo", TbCodeInfo);
        TbItem = new item.TbItem(await loader("item_tbitem")); 
        tables.Add("item.TbItem", TbItem);
        TbItemFunc = new item.TbItemFunc(await loader("item_tbitemfunc")); 
        tables.Add("item.TbItemFunc", TbItemFunc);
        TbItemExtra = new item.TbItemExtra(await loader("item_tbitemextra")); 
        tables.Add("item.TbItemExtra", TbItemExtra);
        TbL10NDemo = new l10n.TbL10NDemo(await loader("l10n_tbl10ndemo")); 
        tables.Add("l10n.TbL10NDemo", TbL10NDemo);
        TbPatchDemo = new l10n.TbPatchDemo(await loader("l10n_tbpatchdemo")); 
        tables.Add("l10n.TbPatchDemo", TbPatchDemo);
        TbSystemMail = new mail.TbSystemMail(await loader("mail_tbsystemmail")); 
        tables.Add("mail.TbSystemMail", TbSystemMail);
        TbGlobalMail = new mail.TbGlobalMail(await loader("mail_tbglobalmail")); 
        tables.Add("mail.TbGlobalMail", TbGlobalMail);
        TbRoleLevelExpAttr = new role.TbRoleLevelExpAttr(await loader("role_tbrolelevelexpattr")); 
        tables.Add("role.TbRoleLevelExpAttr", TbRoleLevelExpAttr);
        TbRoleLevelBonusCoefficient = new role.TbRoleLevelBonusCoefficient(await loader("role_tbrolelevelbonuscoefficient")); 
        tables.Add("role.TbRoleLevelBonusCoefficient", TbRoleLevelBonusCoefficient);
        TbTestTag = new tag.TbTestTag(await loader("tag_tbtesttag")); 
        tables.Add("tag.TbTestTag", TbTestTag);
        TbFullTypes = new test.TbFullTypes(await loader("test_tbfulltypes")); 
        tables.Add("test.TbFullTypes", TbFullTypes);
        TbSingleton = new test.TbSingleton(await loader("test_tbsingleton")); 
        tables.Add("test.TbSingleton", TbSingleton);
        TbNotIndexList = new test.TbNotIndexList(await loader("test_tbnotindexlist")); 
        tables.Add("test.TbNotIndexList", TbNotIndexList);
        TbMultiUnionIndexList = new test.TbMultiUnionIndexList(await loader("test_tbmultiunionindexlist")); 
        tables.Add("test.TbMultiUnionIndexList", TbMultiUnionIndexList);
        TbMultiIndexList = new test.TbMultiIndexList(await loader("test_tbmultiindexlist")); 
        tables.Add("test.TbMultiIndexList", TbMultiIndexList);
        TbDataFromMisc = new test.TbDataFromMisc(await loader("test_tbdatafrommisc")); 
        tables.Add("test.TbDataFromMisc", TbDataFromMisc);
        TbMultiRowRecord = new test.TbMultiRowRecord(await loader("test_tbmultirowrecord")); 
        tables.Add("test.TbMultiRowRecord", TbMultiRowRecord);
        TbMultiRowTitle = new test.TbMultiRowTitle(await loader("test_tbmultirowtitle")); 
        tables.Add("test.TbMultiRowTitle", TbMultiRowTitle);
        TbTestNull = new test.TbTestNull(await loader("test_tbtestnull")); 
        tables.Add("test.TbTestNull", TbTestNull);
        TbDemoPrimitive = new test.TbDemoPrimitive(await loader("test_tbdemoprimitive")); 
        tables.Add("test.TbDemoPrimitive", TbDemoPrimitive);
        TbTestString = new test.TbTestString(await loader("test_tbteststring")); 
        tables.Add("test.TbTestString", TbTestString);
        TbDemoGroup = new test.TbDemoGroup(await loader("test_tbdemogroup")); 
        tables.Add("test.TbDemoGroup", TbDemoGroup);
        TbDemoGroup_C = new test.TbDemoGroup_C(await loader("test_tbdemogroup_c")); 
        tables.Add("test.TbDemoGroup_C", TbDemoGroup_C);
        TbDemoGroup_S = new test.TbDemoGroup_S(await loader("test_tbdemogroup_s")); 
        tables.Add("test.TbDemoGroup_S", TbDemoGroup_S);
        TbDemoGroup_E = new test.TbDemoGroup_E(await loader("test_tbdemogroup_e")); 
        tables.Add("test.TbDemoGroup_E", TbDemoGroup_E);
        TbTestGlobal = new test.TbTestGlobal(await loader("test_tbtestglobal")); 
        tables.Add("test.TbTestGlobal", TbTestGlobal);
        TbTestBeRef = new test.TbTestBeRef(await loader("test_tbtestberef")); 
        tables.Add("test.TbTestBeRef", TbTestBeRef);
        TbTestRef = new test.TbTestRef(await loader("test_tbtestref")); 
        tables.Add("test.TbTestRef", TbTestRef);
        TbTestSize = new test.TbTestSize(await loader("test_tbtestsize")); 
        tables.Add("test.TbTestSize", TbTestSize);
        TbTestSet = new test.TbTestSet(await loader("test_tbtestset")); 
        tables.Add("test.TbTestSet", TbTestSet);
        TbDetectCsvEncoding = new test.TbDetectCsvEncoding(await loader("test_tbdetectcsvencoding")); 
        tables.Add("test.TbDetectCsvEncoding", TbDetectCsvEncoding);
        TbDefineFromExcel = new test.TbDefineFromExcel(await loader("test_tbdefinefromexcel")); 
        tables.Add("test.TbDefineFromExcel", TbDefineFromExcel);
        TbDefineFromExcelOne = new test.TbDefineFromExcelOne(await loader("test_tbdefinefromexcelone")); 
        tables.Add("test.TbDefineFromExcelOne", TbDefineFromExcelOne);
        TbTestIndex = new test.TbTestIndex(await loader("test_tbtestindex")); 
        tables.Add("test.TbTestIndex", TbTestIndex);
        TbTestMap = new test.TbTestMap(await loader("test_tbtestmap")); 
        tables.Add("test.TbTestMap", TbTestMap);
        TbExcelFromJson = new test.TbExcelFromJson(await loader("test_tbexcelfromjson")); 
        tables.Add("test.TbExcelFromJson", TbExcelFromJson);
        TbCompositeJsonTable1 = new test.TbCompositeJsonTable1(await loader("test_tbcompositejsontable1")); 
        tables.Add("test.TbCompositeJsonTable1", TbCompositeJsonTable1);
        TbCompositeJsonTable2 = new test.TbCompositeJsonTable2(await loader("test_tbcompositejsontable2")); 
        tables.Add("test.TbCompositeJsonTable2", TbCompositeJsonTable2);
        TbCompositeJsonTable3 = new test.TbCompositeJsonTable3(await loader("test_tbcompositejsontable3")); 
        tables.Add("test.TbCompositeJsonTable3", TbCompositeJsonTable3);
        TbExcelFromJsonMultiRow = new test.TbExcelFromJsonMultiRow(await loader("test_tbexcelfromjsonmultirow")); 
        tables.Add("test.TbExcelFromJsonMultiRow", TbExcelFromJsonMultiRow);
        TbTestExternalType = new test.TbTestExternalType(await loader("test_tbtestexternaltype")); 
        tables.Add("test.TbTestExternalType", TbTestExternalType);
        TbDemoGroupDefineFromExcel = new test.TbDemoGroupDefineFromExcel(await loader("test_tbdemogroupdefinefromexcel")); 
        tables.Add("test.TbDemoGroupDefineFromExcel", TbDemoGroupDefineFromExcel);
        TbDefineFromExcel2 = new test.TbDefineFromExcel2(await loader("test_tbdefinefromexcel2")); 
        tables.Add("test.TbDefineFromExcel2", TbDefineFromExcel2);
        TbTestExcelBean = new test.TbTestExcelBean(await loader("test_tbtestexcelbean")); 
        tables.Add("test.TbTestExcelBean", TbTestExcelBean);
        TbTestDesc = new test.TbTestDesc(await loader("test_tbtestdesc")); 
        tables.Add("test.TbTestDesc", TbTestDesc);

        TbBlackboard.Resolve(tables); 
        TbBehaviorTree.Resolve(tables); 
        TbClazz.Resolve(tables); 
        TbDrop.Resolve(tables); 
        TbGlobalConfig.Resolve(tables); 
        TbErrorInfo.Resolve(tables); 
        TbCodeInfo.Resolve(tables); 
        TbItem.Resolve(tables); 
        TbItemFunc.Resolve(tables); 
        TbItemExtra.Resolve(tables); 
        TbL10NDemo.Resolve(tables); 
        TbPatchDemo.Resolve(tables); 
        TbSystemMail.Resolve(tables); 
        TbGlobalMail.Resolve(tables); 
        TbRoleLevelExpAttr.Resolve(tables); 
        TbRoleLevelBonusCoefficient.Resolve(tables); 
        TbTestTag.Resolve(tables); 
        TbFullTypes.Resolve(tables); 
        TbSingleton.Resolve(tables); 
        TbNotIndexList.Resolve(tables); 
        TbMultiUnionIndexList.Resolve(tables); 
        TbMultiIndexList.Resolve(tables); 
        TbDataFromMisc.Resolve(tables); 
        TbMultiRowRecord.Resolve(tables); 
        TbMultiRowTitle.Resolve(tables); 
        TbTestNull.Resolve(tables); 
        TbDemoPrimitive.Resolve(tables); 
        TbTestString.Resolve(tables); 
        TbDemoGroup.Resolve(tables); 
        TbDemoGroup_C.Resolve(tables); 
        TbDemoGroup_S.Resolve(tables); 
        TbDemoGroup_E.Resolve(tables); 
        TbTestGlobal.Resolve(tables); 
        TbTestBeRef.Resolve(tables); 
        TbTestRef.Resolve(tables); 
        TbTestSize.Resolve(tables); 
        TbTestSet.Resolve(tables); 
        TbDetectCsvEncoding.Resolve(tables); 
        TbDefineFromExcel.Resolve(tables); 
        TbDefineFromExcelOne.Resolve(tables); 
        TbTestIndex.Resolve(tables); 
        TbTestMap.Resolve(tables); 
        TbExcelFromJson.Resolve(tables); 
        TbCompositeJsonTable1.Resolve(tables); 
        TbCompositeJsonTable2.Resolve(tables); 
        TbCompositeJsonTable3.Resolve(tables); 
        TbExcelFromJsonMultiRow.Resolve(tables); 
        TbTestExternalType.Resolve(tables); 
        TbDemoGroupDefineFromExcel.Resolve(tables); 
        TbDefineFromExcel2.Resolve(tables); 
        TbTestExcelBean.Resolve(tables); 
        TbTestDesc.Resolve(tables); 
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        TbBlackboard.TranslateText(translator); 
        TbBehaviorTree.TranslateText(translator); 
        TbClazz.TranslateText(translator); 
        TbDrop.TranslateText(translator); 
        TbGlobalConfig.TranslateText(translator); 
        TbErrorInfo.TranslateText(translator); 
        TbCodeInfo.TranslateText(translator); 
        TbItem.TranslateText(translator); 
        TbItemFunc.TranslateText(translator); 
        TbItemExtra.TranslateText(translator); 
        TbL10NDemo.TranslateText(translator); 
        TbPatchDemo.TranslateText(translator); 
        TbSystemMail.TranslateText(translator); 
        TbGlobalMail.TranslateText(translator); 
        TbRoleLevelExpAttr.TranslateText(translator); 
        TbRoleLevelBonusCoefficient.TranslateText(translator); 
        TbTestTag.TranslateText(translator); 
        TbFullTypes.TranslateText(translator); 
        TbSingleton.TranslateText(translator); 
        TbNotIndexList.TranslateText(translator); 
        TbMultiUnionIndexList.TranslateText(translator); 
        TbMultiIndexList.TranslateText(translator); 
        TbDataFromMisc.TranslateText(translator); 
        TbMultiRowRecord.TranslateText(translator); 
        TbMultiRowTitle.TranslateText(translator); 
        TbTestNull.TranslateText(translator); 
        TbDemoPrimitive.TranslateText(translator); 
        TbTestString.TranslateText(translator); 
        TbDemoGroup.TranslateText(translator); 
        TbDemoGroup_C.TranslateText(translator); 
        TbDemoGroup_S.TranslateText(translator); 
        TbDemoGroup_E.TranslateText(translator); 
        TbTestGlobal.TranslateText(translator); 
        TbTestBeRef.TranslateText(translator); 
        TbTestRef.TranslateText(translator); 
        TbTestSize.TranslateText(translator); 
        TbTestSet.TranslateText(translator); 
        TbDetectCsvEncoding.TranslateText(translator); 
        TbDefineFromExcel.TranslateText(translator); 
        TbDefineFromExcelOne.TranslateText(translator); 
        TbTestIndex.TranslateText(translator); 
        TbTestMap.TranslateText(translator); 
        TbExcelFromJson.TranslateText(translator); 
        TbCompositeJsonTable1.TranslateText(translator); 
        TbCompositeJsonTable2.TranslateText(translator); 
        TbCompositeJsonTable3.TranslateText(translator); 
        TbExcelFromJsonMultiRow.TranslateText(translator); 
        TbTestExternalType.TranslateText(translator); 
        TbDemoGroupDefineFromExcel.TranslateText(translator); 
        TbDefineFromExcel2.TranslateText(translator); 
        TbTestExcelBean.TranslateText(translator); 
        TbTestDesc.TranslateText(translator); 
    }
}

}
