using System;

using R5T.T0132;
using R5T.T0153;


namespace R5T.F0089
{
	[FunctionalityMarker]
	public partial interface IEndeavorContextOperations : IFunctionalityMarker
	{
		public EndeavorContext Create(
			string endeavorName,
			string endeavorDescription)
		{
			var endeavorContext = new EndeavorContext
			{
				EndeavorName = endeavorName,
				EndeavorDescription = endeavorDescription,
			};

			return endeavorContext;
		}
	}
}