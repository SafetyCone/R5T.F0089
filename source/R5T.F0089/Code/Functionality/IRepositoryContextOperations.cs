using System;

using R5T.T0132;
using R5T.T0153;

using N001 = R5T.T0153.N001;
using N002 = R5T.T0153.N002;
using N003 = R5T.T0153.N003;
using N004 = R5T.T0153.N004;
using N005 = R5T.T0153.N005;
using N006 = R5T.T0153.N006;


namespace R5T.F0089
{
	[FunctionalityMarker]
	public partial interface IRepositoryContextOperations : IFunctionalityMarker
	{
		public string GetRepositoryDirectoryPath(
			string repositoriesDirectoryPath,
			string repositoryName)
		{
			var repositoryDirectoryPath = Instances.RepositoryDirectoryPathOperator.GetRepositoryDirectoryPath_FromRepositoriesDirectoryPath(
				repositoriesDirectoryPath,
				repositoryName);

			return repositoryDirectoryPath;
		}

        public N005.RepositoryContext GetRepositoryContext(
            string owner,
            LibraryContext libraryContext,
            bool isPrivate)
        {
            var unadjustedRepositoryName = Instances.RepositoryNameOperator.GetRepositoryName_FromLibraryName(
                libraryContext.LibraryName);

            var repositoryDescription = Instances.RepositoryDescriptionOperator.GetRepositoryDescription_FromLibraryDescription(
                libraryContext.LibraryDescription);

            var repositoryContext = this.GetRepositoryContext(
                owner,
                unadjustedRepositoryName,
                repositoryDescription,
                isPrivate);

            return repositoryContext;
        }

        public N005.RepositoryContext GetRepositoryContext(
            string owner,
            string unadjustedRepositoryName,
            string repositoryDescription,
            bool isPrivate)
        {
            var privacyAdjustedRepositoryName = Instances.RepositoryNameOperator.AdjustRepositoryNameForPrivacy(
                unadjustedRepositoryName,
                isPrivate);

            var repositoryName = privacyAdjustedRepositoryName;

            var localRepositoryDirectoryPath = F0041.DirectoryPathOperator.Instance.GetLocalRepositoryDirectoryPath(
                repositoryName,
                owner);

            var repositoryContext = new N005.RepositoryContext
            {
                RepositoryOwner = owner,
                RepositoryName = repositoryName,
                UnadjustedRepositoryName = unadjustedRepositoryName,
                PrivacyAdjustedRepositoryName = privacyAdjustedRepositoryName,
                RepositoryDescription = repositoryDescription,
                IsPrivate = isPrivate,
                LocalDirectoryPath = localRepositoryDirectoryPath,
            };

            return repositoryContext;
        }

        public N004.RepositoryContext GetRepositoryContext(
            LibraryContext libraryContext,
            bool isPrivate,
			string repositoriesDirectoryPath)
        {
            var unadjustedRepositoryName = Instances.RepositoryNameOperator.GetRepositoryName_FromLibraryName(
                libraryContext.LibraryName);

            var privacyAdjustedRepositoryName = Instances.RepositoryNameOperator.AdjustRepositoryNameForPrivacy(
                unadjustedRepositoryName,
                isPrivate);

            var repositoryName = privacyAdjustedRepositoryName;

            var repositoryDescription = Instances.RepositoryDescriptionOperator.GetRepositoryDescription_FromLibraryDescription(
                libraryContext.LibraryDescription);

			var repositoryDirectoryPath = this.GetRepositoryDirectoryPath(
				repositoriesDirectoryPath,
				repositoryName);

            var repositoryContext = new N004.RepositoryContext
            {
                RepositoryName = repositoryName,
                RepositoryDescription = repositoryDescription,
                UnadjustedRepositoryName = unadjustedRepositoryName,
                PrivacyAdjustedRepositoryName = privacyAdjustedRepositoryName,
                IsPrivate = isPrivate,
				LocalDirectoryPath = repositoryDirectoryPath,
            };

            return repositoryContext;
        }

        public N003.RepositoryContext GetRepositoryContext(
			LibraryContext libraryContext,
			bool isPrivate)
		{
			var unadjustedRepositoryName = Instances.RepositoryNameOperator.GetRepositoryName_FromLibraryName(
				libraryContext.LibraryName);

			var privacyAdjustedRepositoryName = Instances.RepositoryNameOperator.AdjustRepositoryNameForPrivacy(
				unadjustedRepositoryName,
				isPrivate);

			var repositoryName = privacyAdjustedRepositoryName;

			var repositoryDescription = Instances.RepositoryDescriptionOperator.GetRepositoryDescription_FromLibraryDescription(
				libraryContext.LibraryDescription);

			var repositoryContext = new N003.RepositoryContext
			{
				RepositoryName = repositoryName,
				RepositoryDescription = repositoryDescription,
				UnadjustedRepositoryName = unadjustedRepositoryName,
				PrivacyAdjustedRepositoryName = privacyAdjustedRepositoryName,
				IsPrivate = isPrivate,
			};

			return repositoryContext;
		}

        public N006.RepositoryContext GetRepositoryContext(
            string unadjustedRepositoryName,
            bool isPrivate)
        {
            var privacyAdjustedRepositoryName = Instances.RepositoryNameOperator.AdjustRepositoryNameForPrivacy(
                unadjustedRepositoryName,
                isPrivate);

            var repositoryName = privacyAdjustedRepositoryName;

            var repositoryContext = new N006.RepositoryContext
            {
                RepositoryName = repositoryName,
                UnadjustedRepositoryName = unadjustedRepositoryName,
                PrivacyAdjustedRepositoryName = privacyAdjustedRepositoryName,
                IsPrivate = isPrivate,
            };

            return repositoryContext;
        }
    }
}