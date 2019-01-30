/// <summary>
///Exercise: Find all methods contains more than 7 statements.
///Using the following 2 atomic queris:
///FindByType(typeof(ExprStmt))
///GetByAncs(ancestors)
/// </summary>
CxList theList = All.FindByType(typeof(MethodDecl));
CxList list = All.FindByType(typeof(ExprStmt));
foreach(CxList m in theList){
	CxList theAncs = list.GetByAncs(m);
	if(theAncs.Count >=7){
	 result += m;
	}
}
