using System;
using System.Threading.Tasks;

using R5T.L0032.T000;
using R5T.T0131;
using R5T.T0172;


namespace R5T.O0025.O003
{
    [ValuesMarker]
    public partial interface IProjectElementOperations : IValuesMarker,
        O002.IProjectElementOperations
    {
        /// <summary>
        /// Using the project file path to determine the remote GitHub repository,
        /// test if the GitHub repository is private,
        /// and if so, modify the project element.
        /// </summary>
        public async Task Set_PrivateGitHubRepositoryProperty(
            IProjectElement projectElement,
            IProjectFilePath projectFilePath)
        {
            var projectIsInPrivateGitHubRepository = await Instances.ProjectFilePathOperations.Is_InPrivateGitHubRepository(projectFilePath);

            this.Set_PrivateGitHubRepositoryProperty(
                projectElement,
                projectIsInPrivateGitHubRepository);
        }
    }
}
