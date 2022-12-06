using System;

using R5T.T0132;
using R5T.T0153;


namespace R5T.F0089
{
	[FunctionalityMarker]
	public partial interface ILibraryContextOperations : IFunctionalityMarker
	{
        public LibraryContext Create(
            string libraryName,
            string libraryDescription)
        {
            var endeavorContext = new LibraryContext
            {
                LibraryName = libraryName,
                LibraryDescription = libraryDescription,
            };

            return endeavorContext;
        }
    }
}