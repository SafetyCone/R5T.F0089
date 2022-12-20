using System;


namespace R5T.F0089
{
	public class InstanceTypeContextOperations : IInstanceTypeContextOperations
	{
		#region Infrastructure

	    public static IInstanceTypeContextOperations Instance { get; } = new InstanceTypeContextOperations();

	    private InstanceTypeContextOperations()
	    {
        }

	    #endregion
	}
}