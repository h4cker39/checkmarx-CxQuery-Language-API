//Exercise 1
//Find Definitions of Methods that were called
//CxList.FindByType()
//CxList.FindDefinition

CxList decs = All.FindByType(typeof(MethodInvokeExpr));
CxList all = All.FindDefinition(decs);
result = all;