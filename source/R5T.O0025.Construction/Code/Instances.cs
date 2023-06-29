using System;


namespace R5T.O0025.Construction
{
    public static class Instances
    {
        public static Z0046.IFilePaths FilePaths => Z0046.FilePaths.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static IProjectElements ProjectElements => Construction.ProjectElements.Instance;
        public static O000.IProjectElementOperations ProjectElementOperations_Basic => O000.ProjectElementOperations.Instance;
        public static O001.IProjectElementOperations ProjectElementOperations_Variance => O001.ProjectElementOperations.Instance;
    }
}