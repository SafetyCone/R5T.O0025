using System;
using System.Threading.Tasks;

using R5T.T0141;


namespace R5T.O0025.Construction
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        /// <summary>
        /// Given a project element instance, identify and remedy variances and write the result to a file.
        /// Allows comparison of (possible) modified and unmodified project files in Notepad++.
        /// </summary>
        /// <returns></returns>
        public async Task StandardizeVariances()
        {
            /// Inputs.
            var projectElement =
                Instances.ProjectElements.Has_NoWarnAndGitHubPrivateRepository
                ;
            var unmodifiedOutputProjectFilePath =
                Instances.FilePaths.Sample_ProjectFilePath_Unmodified
                ;
            var modifiedOutputProjectFilePath =
                Instances.FilePaths.Sample_ProjectFilePath
                ;

            var projectIsInPrivateGitHubRepository = true;


            /// Run.
            await Instances.ProjectElementOperations_Basic.To_File(
                unmodifiedOutputProjectFilePath,
                projectElement);

            Instances.ProjectElementOperations_Variance.IdentifyAndRemedyVariances(
                projectElement,
                projectIsInPrivateGitHubRepository);

            await Instances.ProjectElementOperations_Basic.To_File(
                modifiedOutputProjectFilePath,
                projectElement);

            Instances.NotepadPlusPlusOperator.Open(
                unmodifiedOutputProjectFilePath.Value,
                modifiedOutputProjectFilePath.Value);
        }

        //public async Task Write_ProjectFileXmlText_ToFile()
        //{
        //    /// Inputs.
        //    var projectFileXmlText = Instances.ProjectFileXmlTexts.R5T_Z0052_Z000_FromString;
        //    var outputProjectFilePath =
        //        Instances.FilePaths.Sample_ProjectFilePath
        //        ;


        //    /// Run.

        //}
    }
}
