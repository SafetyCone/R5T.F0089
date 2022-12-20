using System;


namespace R5T.F0089
{
    public class WinFormContextOperations : IWinFormContextOperations
    {
        #region Infrastructure

        public static IWinFormContextOperations Instance { get; } = new WinFormContextOperations();


        private WinFormContextOperations()
        {
        }

        #endregion
    }
}
