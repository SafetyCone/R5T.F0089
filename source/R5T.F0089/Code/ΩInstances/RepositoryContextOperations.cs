using System;


namespace R5T.F0089
{
	public class RepositoryContextOperations : IRepositoryContextOperations
	{
		#region Infrastructure

	    public static IRepositoryContextOperations Instance { get; } = new RepositoryContextOperations();

	    private RepositoryContextOperations()
	    {
        }

	    #endregion
	}
}