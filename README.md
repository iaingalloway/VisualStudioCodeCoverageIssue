#### Visual Studio 2015's Code Coverage tool doesn't ignore auto-properties

 - Open `VisualStudio2013.sln` in Visual Studio 2013 Premium or Ultimate.
 - Click Test -> Analyze Code Coverage -> All Tests.
 - Observe that the "Code Coverage Results" window reports 0 Blocks "Not Covered".
 - Open `VisualStudio2015.sln` in Visual Studio 2015 Enterprise.
 - Click Test -> Analyze Code Coverage -> All Tests.
 - Observe that the "Code Coverage Results" window reports 1 Block "Not Covered" (the getter for ExampleDto.Value)
