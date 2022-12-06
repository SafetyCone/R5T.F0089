using System;


namespace R5T.F0089
{
	public class EndeavorContextOperations : IEndeavorContextOperations
	{
		#region Infrastructure

	    public static IEndeavorContextOperations Instance { get; } = new EndeavorContextOperations();

	    private EndeavorContextOperations()
	    {
        }

	    #endregion
	}
}