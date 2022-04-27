using System;

using R5T.Angleterria;

using R5T.T0064;


namespace R5T.Ujung.Default
{
    [ServiceImplementationMarker]
    public class BuildOutputDirectoryNameProvider : IBuildOutputDirectoryNameProvider, IServiceImplementation
    {
        public string GetBuildOutputDirectoryName()
        {
            var buildOutputDirectoryName = DirectoryName.bin;
            return buildOutputDirectoryName;
        }
    }
}
