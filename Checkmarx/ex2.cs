//Exercise 0 - 

//Using the following atomic queries:
//CxList.FindByType()
CxList.FindByShortName()

//Find all method decleration that start with b

CxList bType = All.FindByShortName("b*");
CxList methodD = bType.FindByType(typeof(MethodDecl));
result = methodD;