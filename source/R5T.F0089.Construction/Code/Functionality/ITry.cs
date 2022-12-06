using System;

using R5T.T0132;


namespace R5T.F0089.Construction
{
	[FunctionalityMarker]
	public partial interface ITry : IFunctionalityMarker
	{
        public void GetWebBlazorClientProjectContextFromLibraryContext()
        {
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isPrivate = true;

            /// Run.
            var solutionContext = Instances.SolutionContextOperations.GetSolutionContext(
                libraryContext,
                isPrivate,
                // Temp directory ok, since nothing will actually be output. We just need a directory path.
                Instances.DirectoryPaths.Temp);

            var projectContext = Instances.ProjectContextOperations.GetWebBlazorClientProjectContext(
                libraryContext,
                solutionContext.SolutionDirectoryPath);

            Instances.JsonOperator.Serialize_Synchronous(
                Instances.FilePaths.OutputJsonFilePath,
                projectContext);

            Instances.NotepadPlusPlusOperator.Open(
                Instances.FilePaths.OutputJsonFilePath);
        }

        public void GetWebServerForBlazorClientProjectContextFromLibraryContext()
        {
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isPrivate = true;

            /// Run.
            var solutionContext = Instances.SolutionContextOperations.GetSolutionContext(
                libraryContext,
                isPrivate,
                // Temp directory ok, since nothing will actually be output. We just need a directory path.
                Instances.DirectoryPaths.Temp);

            var projectContext = Instances.ProjectContextOperations.GetWebServerForBlazorClientProjectContext(
                libraryContext,
                solutionContext.SolutionDirectoryPath);

            Instances.JsonOperator.Serialize_Synchronous(
                Instances.FilePaths.OutputJsonFilePath,
                projectContext);

            Instances.NotepadPlusPlusOperator.Open(
                Instances.FilePaths.OutputJsonFilePath);
        }

        public void GetLibraryConstructionProjectContextFromLibraryContext()
        {
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isPrivate = true;

            /// Run.
            var solutionContext = Instances.SolutionContextOperations.GetSolutionContext(
                libraryContext,
                isPrivate,
                // Temp directory ok, since nothing will actually be output. We just need a directory path.
                Instances.DirectoryPaths.Temp);

            var projectContext = Instances.ProjectContextOperations.GetLibraryConstructionProjectContext(
                libraryContext,
                solutionContext.SolutionDirectoryPath);

            Instances.JsonOperator.Serialize_Synchronous(
                Instances.FilePaths.OutputJsonFilePath,
                projectContext);

            Instances.NotepadPlusPlusOperator.Open(
                Instances.FilePaths.OutputJsonFilePath);
        }

        public void GetLibraryProjectContextFromLibraryContext()
        {
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isPrivate = true;

            /// Run.
            var solutionContext = Instances.SolutionContextOperations.GetSolutionContext(
                libraryContext,
                isPrivate,
                // Temp directory ok, since nothing will actually be output. We just need a directory path.
                Instances.DirectoryPaths.Temp);

            var projectContext = Instances.ProjectContextOperations.GetLibraryProjectContext(
                libraryContext,
                solutionContext.SolutionDirectoryPath);

            Instances.JsonOperator.Serialize_Synchronous(
                Instances.FilePaths.OutputJsonFilePath,
                projectContext);

            Instances.NotepadPlusPlusOperator.Open(
                Instances.FilePaths.OutputJsonFilePath);
        }

        public void GetConsoleLibraryProjectContextFromLibraryContext()
        {
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isPrivate = true;

            /// Run.
            var solutionContext = Instances.SolutionContextOperations.GetSolutionContext(
                libraryContext,
                isPrivate,
                // Temp directory ok, since nothing will actually be output. We just need a directory path.
                Instances.DirectoryPaths.Temp);

            var projectContext = Instances.ProjectContextOperations.GetConsoleLibraryProjectContext(
                libraryContext,
                solutionContext.SolutionDirectoryPath);

            Instances.JsonOperator.Serialize_Synchronous(
                Instances.FilePaths.OutputJsonFilePath,
                projectContext);

            Instances.NotepadPlusPlusOperator.Open(
                Instances.FilePaths.OutputJsonFilePath);
        }

        public void GetConsoleProjectContextFromLibraryContext()
        {
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isPrivate = true;

            /// Run.
            var solutionContext = Instances.SolutionContextOperations.GetSolutionContext(
                libraryContext,
                isPrivate,
                // Temp directory ok, since nothing will actually be output. We just need a directory path.
                Instances.DirectoryPaths.Temp);

            var projectContext = Instances.ProjectContextOperations.GetConsoleProjectContext(
                libraryContext,
                solutionContext.SolutionDirectoryPath);

            Instances.JsonOperator.Serialize_Synchronous(
                Instances.FilePaths.OutputJsonFilePath,
                projectContext);

            Instances.NotepadPlusPlusOperator.Open(
                Instances.FilePaths.OutputJsonFilePath);
        }

        public void GetSolutionContextFromLibraryContext()
		{
            /// Inputs.
            var libraryContext = Instances.LibraryContexts.Example;
            var isPrivate = true;

            /// Run.
            var solutionContext = Instances.SolutionContextOperations.GetSolutionContext(
                libraryContext,
                isPrivate,
				// Temp directory ok, since nothing will actually be output. We just need a directory path.
				Instances.DirectoryPaths.Temp);

            Instances.JsonOperator.Serialize_Synchronous(
                Instances.FilePaths.OutputJsonFilePath,
                solutionContext);

            Instances.NotepadPlusPlusOperator.Open(
                Instances.FilePaths.OutputJsonFilePath);
        }

		public void GetRepositoryContextFromLibraryContext()
		{
			/// Inputs.
			var libraryContext = Instances.LibraryContexts.Example;
			var isPrivate = true;

			/// Run.
			var repositoryContext = Instances.RepositoryContextOperations.GetRepositoryContext(
				libraryContext,
				isPrivate);

			Instances.JsonOperator.Serialize_Synchronous(
				Instances.FilePaths.OutputJsonFilePath,
				repositoryContext);

			Instances.NotepadPlusPlusOperator.Open(
				Instances.FilePaths.OutputJsonFilePath);
		}
	}
}