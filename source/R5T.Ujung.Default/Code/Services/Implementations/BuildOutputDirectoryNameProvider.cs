using System;

using R5T.Angleterria;


namespace R5T.Ujung.Default
{
    public class BuildOutputDirectoryNameProvider : IBuildOutputDirectoryNameProvider
    {
        public string GetBuildOutputDirectoryName()
        {
            var buildOutputDirectoryName = DirectoryName.bin;
            return buildOutputDirectoryName;
        }
    }
}
