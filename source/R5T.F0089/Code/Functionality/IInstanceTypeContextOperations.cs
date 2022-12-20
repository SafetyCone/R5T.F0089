using System;

using R5T.F0002;
using R5T.F0052;
using R5T.F0053;
using R5T.L0026.T000;
using R5T.T0132;
using R5T.T0153;
using R5T.Z0007;


namespace R5T.F0089
{
	[FunctionalityMarker]
	public partial interface IInstanceTypeContextOperations : IFunctionalityMarker
	{
		public InstanceTypeContext GetInstanceTypeContext(
			string projectFilePath,
			string instanceTypeNameStem,
			InstanceTypeInformation instanceTypeInformation)
		{
            var namespaceName = F0040.F000.ProjectNamespacesOperator.Instance.GetDefaultNamespaceName_FromProjectFilePath(
                projectFilePath);

			var classTypeName = F0000.TypeNameOperator.Instance.GetClassTypeName(instanceTypeNameStem);
			var interfaceTypeName = F0000.TypeNameOperator.Instance.GetInterfaceTypeName(instanceTypeNameStem);

			var markerAttributeTypeName = F0000.NamespacedTypeNameOperator.Instance.GetTypeName(
				instanceTypeInformation.MarkerAttributeNamespacedTypeName);
			var markerAttributeNamespaceName = F0000.NamespacedTypeNameOperator.Instance.GetNamespaceName(
				instanceTypeInformation.MarkerAttributeNamespacedTypeName);

            var markerInterfaceTypeName = F0000.NamespacedTypeNameOperator.Instance.GetTypeName(
                instanceTypeInformation.MarkerInterfaceNamespacedTypeName);
            var markerInterfaceNamespaceName = F0000.NamespacedTypeNameOperator.Instance.GetNamespaceName(
                instanceTypeInformation.MarkerInterfaceNamespacedTypeName);

			var interfacesDirectoryPath = ProjectPathsOperator.Instance.GetPath_ForProjectDirectoryRelativePath(
				projectFilePath,
				instanceTypeInformation.InterfacesProjectDirectoryRelativeDirectoryPath);

			var interfaceCodeFileName = CodeFileNameOperator.Instance.GetCSharpCodeFileName_ForTypeName(interfaceTypeName);

			var interfaceCodeFilePath = PathOperator.Instance.GetFilePath(
				interfacesDirectoryPath,
				interfaceCodeFileName);

			var classesDirectoryPath = ProjectPathsOperator.Instance.GetPath_ForProjectDirectoryRelativePath(
				projectFilePath,
				ProjectDirectoryRelativePath.Instance.InstanceClassesDirectory);

			var classCodeFileName = CodeFileNameOperator.Instance.GetCSharpCodeFileName_ForTypeName(classTypeName);

			var classCodeFilePath = PathOperator.Instance.GetFilePath(
				classesDirectoryPath,
                classCodeFileName);

			var instanceTypeContext = new InstanceTypeContext
			{
				NamespaceName = namespaceName,
				InterfaceTypeName = interfaceTypeName,
				ClassTypeName = classTypeName,

				MarkerAttributeTypeName = markerAttributeTypeName,
				MarkerAttributeNamespaceName = markerAttributeNamespaceName,
				MarkerInterfaceTypeName = markerInterfaceTypeName,
				MarkerInterfaceNamespaceName = markerInterfaceNamespaceName,

				InterfaceCodeFilePath = interfaceCodeFilePath,
				ClassCodeFilePath = classCodeFilePath,
			};

			return instanceTypeContext;
        }
	}
}