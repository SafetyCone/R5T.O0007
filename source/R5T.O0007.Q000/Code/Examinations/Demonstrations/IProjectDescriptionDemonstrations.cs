using System;

using R5T.T0141;


namespace R5T.O0007.Q000
{
    [DemonstrationsMarker]
    public partial interface IProjectDescriptionDemonstrations : IDemonstrationsMarker
    {
        public void Get_ConstuctionProjectDescription()
        {
            /// Inputs.
            var baseProjectName = Instances.Values.Sample_ProjectName;

            /// Run.
            var constructionProjectDescription = Instances.ProjectDescriptionOperations.Get_ConstructionProjectDescription(
                baseProjectName);

            Console.WriteLine($"{constructionProjectDescription}\n\tConstruction project description for base project name '{baseProjectName}'.");
        }
    }
}
