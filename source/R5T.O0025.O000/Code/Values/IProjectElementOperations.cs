using System;
using System.Threading.Tasks;

using R5T.L0032.T000;
using R5T.T0131;
using R5T.T0172;
using R5T.T0210;


namespace R5T.O0025.O000
{
    /// <summary>
    /// Basic project element operations (like conversion from 
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectElementOperations : IValuesMarker
    {
        public Task<IProjectElement> From(IProjectFilePath projectFilePath)
        {
            return Instances.ProjectElementOperator.From(projectFilePath);
        }

        public IProjectElement From(IProjectFileXmlText projectFileXmlText)
        {
            var output = Instances.ProjectElementOperator.From(projectFileXmlText);
            return output;
        }

        public async Task<IProjectElement> From(Task<IProjectFileXmlText> gettingProjectFileXmlText)
        {
            var projectFileXmlText = await gettingProjectFileXmlText;

            var output = Instances.ProjectElementOperator.From(projectFileXmlText);
            return output;
        }

        public Task To_File(
            IProjectFilePath projectFilePath,
            IProjectElement projectElement)
        {
            return Instances.ProjectElementOperator.To_File(
                projectFilePath,
                projectElement);
        }

        public void To_File_Synchronous(
            IProjectFilePath projectFilePath,
            IProjectElement projectElement)
        {
            Instances.ProjectElementOperator.To_File_Synchronous(
                projectFilePath,
                projectElement);
        }
    }
}
