using System;

using R5T.L0032.T000;
using R5T.T0131;


namespace R5T.O0025.O001
{
    /// <summary>
    /// Variance detection and remediation operations.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectElementOperations : IValuesMarker
    {
        private static Internal.IProjectElementOperations Internal => O001.Internal.ProjectElementOperations.Instance;


        /// <summary>
        /// Identify all variances and remediate them.
        /// </summary>
        public void IdentifyAndRemedyVariances(
            IProjectElement projectElement,
            bool projectIsInPrivateGitHubRepository)
        {
            Internal.HasPrivateGitHubRepositoryProperty_IfInPrivateGitHubRepository(
                projectElement,
                projectIsInPrivateGitHubRepository);

            Internal.ItemGroupLabel_ForProjectReferences(projectElement);

            Internal.CorrectIgnoredWarnings(projectElement);
        }
    }
}
