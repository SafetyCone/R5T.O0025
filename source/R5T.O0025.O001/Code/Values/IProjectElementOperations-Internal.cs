using System;

using R5T.L0032.T000;
using R5T.L0089.T000;
using R5T.T0131;


namespace R5T.O0025.O001.Internal
{
    /// <summary>
    /// Specific variance detection and remediation operations.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectElementOperations : IValuesMarker,
        O002.IProjectElementOperations
    {
        public void HasPrivateGitHubRepositoryProperty_IfInPrivateGitHubRepository(
            IProjectElement projectElement,
            bool projectIsInPrivateGitHubRepository)
        {
            this.Set_PrivateGitHubRepositoryProperty(
                projectElement,
                projectIsInPrivateGitHubRepository);
        }

        /// <summary>
        /// Does the project file have the correct ignored warnings?
        /// The correct warnings are: <see cref="L0033.Z001.IWarningSets.DefaultIgnoredWarnings"/>.
        /// </summary>
        public void CorrectIgnoredWarnings(IProjectElement projectElement)
        {
            var correctIgnoredWarnings = Instances.WarningSets.DefaultIgnoredWarnings;

            var correctNoWarnValue = Instances.ProjectOperator.Get_WarningsConcatenation(
                correctIgnoredWarnings);

            var hasNoWarnElement = Instances.ProjectXmlOperator.Has_NoWarnElement(projectElement);
            if(hasNoWarnElement)
            {
                var hasCorrectValue = Instances.XmlOperator.Is_Value(hasNoWarnElement, correctNoWarnValue);
                if(!hasCorrectValue)
                {
                    // Variance, might accumulate variances in the future.

                    // Set the correct value.
                    Instances.XmlOperator.Set_Value(hasNoWarnElement, correctNoWarnValue);
                }
            }
            else
            {
                // Variance, might accumulate variances in the future.

                // Set the correct value.
                Instances.ProjectElementOperator.Set_NoWarn(
                    projectElement,
                    correctNoWarnValue);
            }
        }

        /// <summary>
        /// If the project element has a specific labeled element, does the labeled element have the correct value?
        /// </summary>
        public void CorrectLabeledValue_IfExists<TLabeled>(
            IProjectElement projectElement,
            Func<IProjectElement, WasFound<TLabeled>> hasLabeledSelector,
            string correctLabelValue)
            where TLabeled : ILabeled
        {
            var hasLabeled = hasLabeledSelector(projectElement);
            if (hasLabeled)
            {
                var hasCorrectLabelValue = Instances.LabeledOperator.Has_LabelValue(
                    hasLabeled.Result,
                    correctLabelValue);

                if (!hasCorrectLabelValue)
                {
                    // Variance, might accumulate variances in the future.
                    // For now, just fix it.

                    Instances.LabeledOperator.Set_Label(
                        hasLabeled.Result,
                        correctLabelValue);
                }
            }
            // Else, no project references to worry about.
        }

        /// <summary>
        /// If the project has a project references item group, does the item group have the desired label.
        /// </summary>
        public void ItemGroupLabel_ForProjectReferences(IProjectElement projectElement)
        {
            this.CorrectLabeledValue_IfExists(
                projectElement,
                Instances.ProjectXmlOperations.Has_ProjectReferenceItemGroupElement,
                Instances.GroupLabels.ProjectReferences.Value);
        }

        ///// <summary>
        ///// If the project has a project references item group, does the item group have the desired label.
        ///// </summary>
        //public void PropertyGroupLabel_ForMain(IProjectElement projectElement)
        //{
        //    this.CorrectLabeledValue_IfExists(
        //        projectElement,
        //        Instances.ProjectXmlOperations.Has_ProjectReferenceItemGroupElement,
        //        Instances.GroupLabels.ProjectReferences.Value);
        //}
    }
}
