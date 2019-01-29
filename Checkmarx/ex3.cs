//Find Definitions of Methods that were declared but not called (Dead code)

//Chama os metodos que foram criados - chamados
/// <summary>
///  mothodInvoke - methodDec 
/// </summary>
///
//CxList MD = All.FindByType(typeof(MethodDecl));
//CxList MI = All.FindByType(typeof(MethodInvokeExpr));
//CxList finalRes = MD - MI;
//result = finalRes;

CxList fmd = All.FindDefinition(All.FindByType(typeof(MethodInvokeExpr)));
CxList fmi = All.FindByType(typeof(MethodDecl));
CxList res = fmi - fmd;
result = res;




