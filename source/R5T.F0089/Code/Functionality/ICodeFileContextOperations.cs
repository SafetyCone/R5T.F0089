using System;

using R5T.T0132;
using R5T.T0153;
using R5T.T0153.N000;


namespace R5T.F0089
{
	[FunctionalityMarker]
	public partial interface ICodeFileContextOperations : IFunctionalityMarker
	{
        public RazorComponentContext GetRazorComponentContext(
            string projectFilePath,
            string componentName)
        {
            var namespaceName = F0040.F000.ProjectNamespacesOperator.Instance.GetDefaultNamespaceName_FromProjectFilePath(projectFilePath);

            var markupFilePath = F0052.ProjectPathsOperator.Instance.GetComponentMarkupFilePath(
                projectFilePath,
                componentName);

            var codeBehindFilePath = F0052.ProjectPathsOperator.Instance.GetComponentCodeBehindFilePath(
                projectFilePath,
                componentName);

            var context = new RazorComponentContext
            {
                Name = componentName,
                NamespaceName = namespaceName,
                CodeBehindFilePath = codeBehindFilePath,
                RazorFilePath = markupFilePath,
            };

            return context;
        }

		public TypeContext GetClassTypeContext(
			string projectFilePath,
			string className)
		{
            var namespaceName = F0040.F000.ProjectNamespacesOperator.Instance.GetDefaultNamespaceName_FromProjectFilePath(projectFilePath);

            var classFilePath = F0052.ProjectPathsOperator.Instance.GetClassCodeFilePath(
                projectFilePath,
                className);

			var typeContext = new TypeContext
			{
				CodeFilePath = classFilePath,
				NamespaceName = namespaceName,
				TypeName = className,
			};

			return typeContext;
        }

        public TypeContext GetInterfaceTypeContext(
            string projectFilePath,
            string interfaceName)
        {
            var namespaceName = F0040.F000.ProjectNamespacesOperator.Instance.GetDefaultNamespaceName_FromProjectFilePath(projectFilePath);

            var classFilePath = F0052.ProjectPathsOperator.Instance.GetInterfaceCodeFilePath(
                projectFilePath,
                interfaceName);

            var typeContext = new TypeContext
            {
                CodeFilePath = classFilePath,
                NamespaceName = namespaceName,
                TypeName = interfaceName,
            };

            return typeContext;
        }
    }
}