using System;


namespace R5T.F0089
{
	public class CodeFileContextOperations : ICodeFileContextOperations
	{
		#region Infrastructure

	    public static ICodeFileContextOperations Instance { get; } = new CodeFileContextOperations();

	    private CodeFileContextOperations()
	    {
        }

	    #endregion
	}
}