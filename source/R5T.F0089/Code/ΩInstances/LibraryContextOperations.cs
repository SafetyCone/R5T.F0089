using System;


namespace R5T.F0089
{
	public class LibraryContextOperations : ILibraryContextOperations
	{
		#region Infrastructure

	    public static ILibraryContextOperations Instance { get; } = new LibraryContextOperations();

	    private LibraryContextOperations()
	    {
        }

	    #endregion
	}
}