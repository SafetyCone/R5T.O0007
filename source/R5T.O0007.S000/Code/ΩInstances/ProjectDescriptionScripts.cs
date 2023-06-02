using System;


namespace R5T.O0007.S000
{
    public class ProjectDescriptionScripts : IProjectDescriptionScripts
    {
        #region Infrastructure

        public static IProjectDescriptionScripts Instance { get; } = new ProjectDescriptionScripts();


        private ProjectDescriptionScripts()
        {
        }

        #endregion
    }
}
