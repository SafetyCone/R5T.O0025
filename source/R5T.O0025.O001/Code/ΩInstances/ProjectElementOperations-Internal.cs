using System;


namespace R5T.O0025.O001.Internal
{
    public class ProjectElementOperations : IProjectElementOperations
    {
        #region Infrastructure

        public static IProjectElementOperations Instance { get; } = new ProjectElementOperations();


        private ProjectElementOperations()
        {
        }

        #endregion
    }
}
