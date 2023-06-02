using System;

using R5T.T0131;
using R5T.T0187;
using R5T.T0187.Extensions;


namespace R5T.O0007
{
    [ValuesMarker]
    public partial interface IProjectDescriptionOperations : IValuesMarker
    {
        public IProjectDescription Get_ConstructionProjectDescription(IProjectName baseProjectName)
        {
            var output = $"Construction console project for the {baseProjectName} library."
                .ToProjectDescription();

            return output;
        }
    }
}
