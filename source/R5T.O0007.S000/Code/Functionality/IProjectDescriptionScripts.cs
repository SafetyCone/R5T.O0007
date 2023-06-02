using System;

using R5T.T0132;


namespace R5T.O0007.S000
{
    [FunctionalityMarker]
    public partial interface IProjectDescriptionScripts : IFunctionalityMarker
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
