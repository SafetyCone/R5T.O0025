using System;

using R5T.L0032.T000;
using R5T.T0131;


namespace R5T.O0025.O002
{
    [ValuesMarker]
    public partial interface IProjectElementOperations : IValuesMarker
    {
        public void Set_PrivateGitHubRepositoryProperty(
            IProjectElement projectElement,
            bool projectIsInPrivateGitHubRepository)
        {
            // Only care if the project is in a private GitHub repository.
            if (!projectIsInPrivateGitHubRepository)
            {
                return;
            }

            var hasPrivateGitHubRepositoryProperty = Instances.ProjectXmlOperator.Has_PrivateGitHubRepositoryProperty(projectElement);
            if (!hasPrivateGitHubRepositoryProperty)
            {
                // Variance, might accumulate variances in the future.

                // Ensure the property exists.
                Instances.ProjectElementOperator.Ensure_HasPrivateGitHubRepositoryProperty(projectElement);
            }
        }

        public void Set_IgnoredWarnings_Default(IProjectElement projectElement)
        {
            Instances.ProjectElementOperator.Set_NoWarn(
                projectElement,
                Instances.WarningSets.DefaultIgnoredWarnings);
        }
    }
}
