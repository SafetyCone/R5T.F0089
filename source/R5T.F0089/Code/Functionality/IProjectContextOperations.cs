using System;

using R5T.T0132;
using R5T.T0153;

using N001 = R5T.T0153.N001;


namespace R5T.F0089
{
	[FunctionalityMarker]
	public partial interface IProjectContextOperations : IFunctionalityMarker
	{
        public Func<TSolutionContext, ProjectContext> GetProjectContext<TSolutionContext>(
            string projectName,
            string projectDescription)
            where TSolutionContext : IHasSolutionDirectoryPath
        {
            return projectContext => this.GetProjectContext(
                projectName,
                projectDescription,
                projectContext.SolutionDirectoryPath);
        }

        public ProjectContext GetProjectContext(
            string projectName,
            string projectDescription,
            string solutionDirectoryPath)
        {
            var projectContext = new ProjectContext
            {
                ProjectName = projectName,
                ProjectDescription = projectDescription,
            };

            this.FillProjectContext(projectContext,
                projectName,
                solutionDirectoryPath);

            return projectContext;
        }

        public ProjectContext GetRazorClassLibraryProjectContext(
            LibraryContext libraryContext,
            string solutionDirectoryPath)
        {
            var projectName = Instances.ProjectNameOperator.Get_ProjectName_FromLibraryName(libraryContext.LibraryName);
            var projectDescription = Instances.ProjectDescriptionOperator.Get_ProjectDescription_FromLibraryDescription(libraryContext.LibraryDescription);

            var projectContext = this.GetProjectContext(
                projectName,
                projectDescription,
                solutionDirectoryPath);

            return projectContext;
        }

        public void FillProjectContext(
            ProjectContext projectContext,
            string projectName,
            string solutionDirectoryPath)
        {
            var projectDefaultNamespace = Instances.ProjectNamespacesOperator.Get_DefaultNamespaceName_FromProjectName(
                projectName);

            var projectDirectoryPath = Instances.ProjectPathsOperator.Get_ProjectDirectoryPath_FromSolutionDirectoryPath(
                solutionDirectoryPath,
                projectName);

            var projectFilePath = Instances.ProjectPathsOperator.Get_ProjectFilePath(
                projectDirectoryPath,
                projectName);

            projectContext.ProjectDefaultNamespaceName = projectDefaultNamespace;
            projectContext.ProjectDirectoryPath = projectDirectoryPath;
            projectContext.ProjectFilePath = projectFilePath;
        }

        public ProjectContext GetWebBlazorClientProjectContext(
            LibraryContext libraryContext,
            string solutionDirectoryPath)
        {
            var webBlazorClientProjectName = Instances.ProjectNameOperator.GetWebBlazorClientProjectName_FromLibraryName(
                libraryContext.LibraryName);

            var webBlazorProjectDescription = Instances.ProjectDescriptionOperator.GetWebBlazorClientProjectDescription_FromLibraryName(
                libraryContext.LibraryName);

            var projectContext = new ProjectContext
            {
                ProjectName = webBlazorClientProjectName,
                ProjectDescription = webBlazorProjectDescription,
            };

            this.FillProjectContext(projectContext,
                webBlazorClientProjectName,
                solutionDirectoryPath);

            return projectContext;
        }

        public ProjectContext GetWebStaticRazorComponentsProjectContext(
            LibraryContext libraryContext,
            string solutionDirectoryPath)
        {
            var webServerProjectName = Instances.ProjectNameOperator.GetWebServerProjectName_FromLibraryName(
                libraryContext.LibraryName);

            var webServerForStaticRazorComponentsProjectDescription = Instances.ProjectDescriptionOperator.GetWebServerForStaticRazorComponentsProjectDescription_FromLibraryName(
                libraryContext.LibraryName);

            var projectContext = new ProjectContext
            {
                ProjectName = webServerProjectName,
                ProjectDescription = webServerForStaticRazorComponentsProjectDescription,
            };

            this.FillProjectContext(projectContext,
                webServerProjectName,
                solutionDirectoryPath);

            return projectContext;
        }

        public ProjectContext GetWebServerForBlazorClientProjectContext(
            LibraryContext libraryContext,
            string solutionDirectoryPath)
        {
            var webServerForBlazorClientProjectName = Instances.ProjectNameOperator.GetWebServerForBlazorClientProjectName_FromLibraryName(
                libraryContext.LibraryName);

            var webServerForBlazorProjectDescription = Instances.ProjectDescriptionOperator.GetWebServerForBlazorClientProjectDescription_FromLibraryName(
                libraryContext.LibraryName);

            var projectContext = new ProjectContext
            {
                ProjectName = webServerForBlazorClientProjectName,
                ProjectDescription = webServerForBlazorProjectDescription,
            };

            this.FillProjectContext(projectContext,
                webServerForBlazorClientProjectName,
                solutionDirectoryPath);

            return projectContext;
        }

        public ProjectContext GetLibraryConstructionProjectContext(
            LibraryContext libraryContext,
            string solutionDirectoryPath)
        {
            var libraryConstructionProjectName = Instances.ProjectNameOperator.GetLibraryConstructionProjectName_FromLibraryName(
                libraryContext.LibraryName);

            var consoleLibraryProjectDescription = Instances.ProjectDescriptionOperator.GetLibraryConstructionProjectDescription_FromLibraryName(
                libraryContext.LibraryName);

            var projectContext = new ProjectContext
            {
                ProjectName = libraryConstructionProjectName,
                ProjectDescription = consoleLibraryProjectDescription,
            };

            this.FillProjectContext(projectContext,
                libraryConstructionProjectName,
                solutionDirectoryPath);

            return projectContext;
        }

        public ProjectContext GetLibraryProjectContext(
            LibraryContext libraryContext,
            string solutionDirectoryPath)
        {
            var libraryProjectName = Instances.ProjectNameOperator.GetLibraryProjectName_FromLibraryName(
                libraryContext.LibraryName);

            var consoleLibraryProjectDescription = Instances.ProjectDescriptionOperator.GetLibraryProjectDescription_FromLibraryDescription(
                libraryContext.LibraryDescription);

            var projectContext = new ProjectContext
            {
                ProjectName = libraryProjectName,
                ProjectDescription = consoleLibraryProjectDescription,
            };

            this.FillProjectContext(projectContext,
                libraryProjectName,
                solutionDirectoryPath);

            return projectContext;
        }

        public ProjectContext GetConsoleLibraryProjectContext(
            LibraryContext libraryContext,
            string solutionDirectoryPath)
        {
            var consoleLibraryProjectName = Instances.ProjectNameOperator.GetConsoleLibraryProjectName_FromLibraryName(
                libraryContext.LibraryName);

            var consoleLibraryProjectDescription = Instances.ProjectDescriptionOperator.GetConsoleLibraryProjectDescription_FromLibraryName(
                libraryContext.LibraryName);

            var projectContext = new ProjectContext
            {
                ProjectName = consoleLibraryProjectName,
                ProjectDescription = consoleLibraryProjectDescription,
            };

            this.FillProjectContext(projectContext,
                consoleLibraryProjectName,
                solutionDirectoryPath);

            return projectContext;
        }

        public ProjectContext GetConsoleProjectContext(
			LibraryContext libraryContext,
			string solutionDirectoryPath)
		{
			var consoleProjectName = Instances.ProjectNameOperator.GetConsoleProjectName_FromLibraryName(
				libraryContext.LibraryName);

			var consoleProjectDescription = Instances.ProjectDescriptionOperator.GetConsoleProjectDescription_FromLibraryDescription(
				libraryContext.LibraryDescription);

			var projectContext = new ProjectContext
			{
				ProjectName = consoleProjectName,
				ProjectDescription = consoleProjectDescription,
			};

            this.FillProjectContext(projectContext,
                consoleProjectName,
                solutionDirectoryPath);

            return projectContext;
		}

        public ProjectContext GetProjectContext(
            LibraryContext libraryContext,
            string solutionDirectoryPath)
        {
            var projectName = Instances.ProjectNameOperator.Get_ProjectName_FromLibraryName(
                libraryContext.LibraryName);

            var projectDescription = Instances.ProjectDescriptionOperator.Get_ProjectDescription_FromLibraryDescription(
                libraryContext.LibraryDescription);

            var projectContext = new ProjectContext
            {
                ProjectName = projectName,
                ProjectDescription = projectDescription,
            };

            this.FillProjectContext(projectContext,
                projectName,
                solutionDirectoryPath);

            return projectContext;
        }
    }
}