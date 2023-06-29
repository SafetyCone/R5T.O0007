using System;

using R5T.T0131;
using R5T.T0187;
using R5T.T0187.Extensions;


namespace R5T.O0007
{
    /// <summary>
    /// Prior work: R5T.F0055.IProjectDescriptionOperator.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectDescriptionOperations : IValuesMarker
    {
        public IProjectDescription Get_BlazorClientProjectDescription(IProjectName baseProjectName)
        {
            var output = $"Blazor client for the {baseProjectName} project."
                .ToProjectDescription();

            return output;
        }

        public IProjectDescription Get_ConstructionProjectDescription(IProjectName baseProjectName)
        {
            var output = $"Construction console project for the {baseProjectName} library."
                .ToProjectDescription();

            return output;
        }

        public IProjectDescription Get_ServerForBlazorClientProjectDescription(IProjectName baseProjectName)
        {
            var output = $"Server for the {baseProjectName} Blazor client."
                .ToProjectDescription();

            return output;
        }

        public IProjectDescription Get_WebLibraryProjectDescription(IProjectName baseProjectName)
        {
            var output = $"Server for the {baseProjectName} Blazor client."
                .ToProjectDescription();

            return output;
        }
    }
}
