using System;


namespace R5T.O0007.Q000
{
    public class ProjectDescriptionDemonstrations : IProjectDescriptionDemonstrations
    {
        #region Infrastructure

        public static IProjectDescriptionDemonstrations Instance { get; } = new ProjectDescriptionDemonstrations();


        private ProjectDescriptionDemonstrations()
        {
        }

        #endregion
    }
}
