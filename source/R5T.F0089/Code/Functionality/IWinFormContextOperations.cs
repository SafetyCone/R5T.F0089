using System;

using R5T.F0052;
using R5T.F0053;
using R5T.T0132;
using R5T.T0153.N000;


namespace R5T.F0089
{
    [FunctionalityMarker]
    public partial interface IWinFormContextOperations : IFunctionalityMarker
    {
        public WinFormContext GetWinFormContext(
            string projectFilePath,
            string formName)
        {
            var namspaceName = F0040.F000.ProjectNamespacesOperator.Instance.Get_DefaultNamespaceName_FromProjectFilePath(projectFilePath);

            var formClassFileName = CodeFileNameOperator.Instance.GetWindowsFormClassFileName(formName);
            var formClassFilePath = ProjectPathsOperator.Instance.GetFormsDirectoryFilePath(
                projectFilePath,
                formClassFileName);

            var formDesignerFileName = CodeFileNameOperator.Instance.GetWindowsFormDesignerFileName(formName);
            var formDesignerFilePath = ProjectPathsOperator.Instance.GetFormsDirectoryFilePath(
                projectFilePath,
                formDesignerFileName);

            var formResxFileName = CodeFileNameOperator.Instance.GetWindowsFormResxFileName(formName);
            var formResxFilePath = ProjectPathsOperator.Instance.GetFormsDirectoryFilePath(
                projectFilePath,
                formResxFileName);

            var context = new WinFormContext
            {
                Name = formName,
                NamespaceName = namspaceName,
                CodeFilePath = formClassFilePath,
                DesignerFilePath = formDesignerFilePath,
                ResxFilePath = formResxFilePath,
            };

            return context;
        }
    }
}
