using System;


namespace R5T.O0007
{
    public class ProjectDescriptionOperations : IProjectDescriptionOperations
    {
        #region Infrastructure

        public static IProjectDescriptionOperations Instance { get; } = new ProjectDescriptionOperations();


        private ProjectDescriptionOperations()
        {
        }

        #endregion
    }
}
