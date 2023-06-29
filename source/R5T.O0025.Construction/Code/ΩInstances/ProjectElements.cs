using System;


namespace R5T.O0025.Construction
{
    public class ProjectElements : IProjectElements
    {
        #region Infrastructure

        public static IProjectElements Instance { get; } = new ProjectElements();


        private ProjectElements()
        {
        }

        #endregion
    }
}
