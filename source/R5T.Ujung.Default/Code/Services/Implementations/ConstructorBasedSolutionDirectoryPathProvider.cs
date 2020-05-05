using System;


namespace R5T.Ujung.Default
{
    public class ConstructorBasedSolutionDirectoryPathProvider : ISolutionDirectoryPathProvider
    {
        private string SolutionDirectoryPath { get; }


        public ConstructorBasedSolutionDirectoryPathProvider(string solutionDirectoryPath)
        {
            this.SolutionDirectoryPath = solutionDirectoryPath;
        }

        public string GetSolutionDirectoryPath()
        {
            return this.SolutionDirectoryPath;
        }
    }
}
