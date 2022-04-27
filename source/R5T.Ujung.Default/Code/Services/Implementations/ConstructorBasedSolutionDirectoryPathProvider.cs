using System;

using R5T.T0064;


namespace R5T.Ujung.Default
{
    [ServiceImplementationMarker]
    public class ConstructorBasedSolutionDirectoryPathProvider : ISolutionDirectoryPathProvider, IServiceImplementation
    {
        private string SolutionDirectoryPath { get; }


        public ConstructorBasedSolutionDirectoryPathProvider(
            [NotServiceComponent] string solutionDirectoryPath)
        {
            this.SolutionDirectoryPath = solutionDirectoryPath;
        }

        public string GetSolutionDirectoryPath()
        {
            return this.SolutionDirectoryPath;
        }
    }
}
