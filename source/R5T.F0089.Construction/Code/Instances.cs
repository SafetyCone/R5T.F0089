using System;


namespace R5T.F0089.Construction
{
    public static class Instances
    {
        public static Z0015.IDirectoryPaths DirectoryPaths => Z0015.DirectoryPaths.Instance;
        public static Z0015.IFilePaths FilePaths => Z0015.FilePaths.Instance;
        public static F0032.IJsonOperator JsonOperator => F0032.JsonOperator.Instance;
        public static T0153.Z001.ILibraryContexts LibraryContexts => T0153.Z001.LibraryContexts.Instance;
        public static ILibraryContextOperations LibraryContextOperations => F0089.LibraryContextOperations.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static IProjectContextOperations ProjectContextOperations => F0089.ProjectContextOperations.Instance;
        public static IRepositoryContextOperations RepositoryContextOperations => F0089.RepositoryContextOperations.Instance;
        public static ISolutionContextOperations SolutionContextOperations => F0089.SolutionContextOperations.Instance;
    }
}