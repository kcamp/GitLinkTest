#tool "nuget:?package=NUnit.ConsoleRunner"

// params
var target = Argument("Target", "Default");
var configuration = Argument("configuration", "Release");

// const
var solutionFile = "./src/GitLinkTest.sln";

Task("Restore-NuGet-Packages")    
    .Does(() => {        
        NuGetRestore(solutionFile);
    });

Task("Clean")
    .Does(()=>{                
        CleanDirectories("./src/**/bin");        
        CleanDirectories("./src/**/obj");        
    });

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() => {
         MSBuild(solutionFile, settings => 
            settings.SetConfiguration(configuration)
                .SetPlatformTarget(PlatformTarget.MSIL)
                .UseToolVersion(MSBuildToolVersion.VS2015)
                .SetMSBuildPlatform(MSBuildPlatform.x86)
        );
    });
    
Task("Clean-Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Build");

Task("Run-Unit-Tests")
    .IsDependentOn("Build")
    .Does(()=>{        
        NUnit3("./src/**/bin/" + configuration + "/*.Tests.dll", new NUnit3Settings());
    });

Task("Default").IsDependentOn("Build");

RunTarget(target);