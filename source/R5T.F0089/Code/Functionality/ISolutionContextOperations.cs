using System;

using R5T.T0132;
using R5T.T0153;

using N001 = R5T.T0153.N001;
using N003 = R5T.T0153.N003;


namespace R5T.F0089
{
	[FunctionalityMarker]
	public partial interface ISolutionContextOperations : IFunctionalityMarker
	{
        public string GetSolutionDirectoryPath(
            string repositoryDirectoryPath)
		{
            var repositorySourceDirectoryPath = Instances.RepositoryPathsOperator.GetSourceDirectoryPath(
                repositoryDirectoryPath);

            var solutionDirectoryPath = Instances.SolutionPathsOperator.Get_SolutionDirectoryPath_FromRepositorySourceDirectoryPath(
                repositorySourceDirectoryPath);

			return solutionDirectoryPath;
        }

		public (string solutionName, string unadjustedSolutionName, string privacyAdjustedSolutionName) GetSolutionNames(
            LibraryContext libraryContext,
            bool isRepositoryPrivate)
		{
            var unadjustedSolutionName = Instances.SolutionNameOperator.GetUnadjustedSolutionName_FromUnadjustedLibraryName(
                libraryContext.LibraryName);

            var privacyAdjustedSolutionName = Instances.SolutionNameOperator.AdjustSolutionName_ForPrivacy(
                unadjustedSolutionName,
                isRepositoryPrivate);

            // The solution name uses the privacy adjusted solution name.
            var solutionName = privacyAdjustedSolutionName;

			return (solutionName, unadjustedSolutionName, privacyAdjustedSolutionName);
        }

        public N003.SolutionContext GetSolutionContext(
			LibraryContext libraryContext,
			bool isRepositoryPrivate,
			string repositoryDirectoryPath)
		{
			var (solutionName, unadjustedSolutionName, privacyAdjustedSolutionName) = this.GetSolutionNames(
				libraryContext,
				isRepositoryPrivate);

			var solutionDescription = Instances.SolutionDescriptionOperator.GetSolutionDescription_FromLibraryDescription(
				libraryContext.LibraryDescription);

			var solutionDirectoryPath = this.GetSolutionDirectoryPath(repositoryDirectoryPath);

			var solutionFilePath = Instances.SolutionPathsOperator.Get_SolutionFilePath(
				solutionDirectoryPath,
				solutionName);

			var solutionContext = new N003.SolutionContext
			{
				SolutionName = solutionName,
				PrivacyAdjustedSolutionName = privacyAdjustedSolutionName,
				UnadjustedSolutionName = unadjustedSolutionName,
				SolutionDescription = solutionDescription,
				SolutionDirectoryPath = solutionDirectoryPath,
				SolutionFilePath = solutionFilePath,
			};

			return solutionContext;
		}

		public N001.SolutionContext GetSolutionContext(
			string solutionFilePath)
		{
			var solutionDirectoryPath = Instances.SolutionPathsOperator.Get_SolutionDirectoryPath_FromSolutionFilePath(solutionFilePath);

			var solutionContext = new N001.SolutionContext
			{
				SolutionFilePath = solutionFilePath,
				SolutionDirectoryPath = solutionDirectoryPath,
			};

			return solutionContext;
		}
	}
}