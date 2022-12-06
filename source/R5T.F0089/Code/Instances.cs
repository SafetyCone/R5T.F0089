using System;


namespace R5T.F0089
{
    public static class Instances
    {
        public static F0041.IDirectoryPathOperator DirectoryPathOperator { get; } = F0041.DirectoryPathOperator.Instance;
        public static F0055.IProjectDescriptionOperator ProjectDescriptionOperator => F0055.ProjectDescriptionOperator.Instance;
        public static F0055.IProjectNameOperator ProjectNameOperator => F0055.ProjectNameOperator.Instance;
        public static F0040.F000.IProjectNamespacesOperator ProjectNamespacesOperator => F0040.F000.ProjectNamespacesOperator.Instance;
        public static F0052.IProjectPathsOperator ProjectPathsOperator => F0052.ProjectPathsOperator.Instance;
        public static F0046.IRepositoryDescriptionOperator RepositoryDescriptionOperator => F0046.RepositoryDescriptionOperator.Instance;
        public static F0046.IRepositoryNameOperator RepositoryNameOperator => F0046.RepositoryNameOperator.Instance;
        public static F0048.ISolutionDescriptionOperator SolutionDescriptionOperator => F0048.SolutionDescriptionOperator.Instance;
        public static F0057.IRepositoryDirectoryPathOperator RepositoryDirectoryPathOperator => F0057.RepositoryDirectoryPathOperator.Instance;
        public static F0057.IRepositoryPathsOperator RepositoryPathsOperator => F0057.RepositoryPathsOperator.Instance;
        public static F0050.ISolutionPathsOperator SolutionPathsOperator => F0050.SolutionPathsOperator.Instance;
        public static F0048.ISolutionNameOperator SolutionNameOperator => F0048.SolutionNameOperator.Instance;
    }
}