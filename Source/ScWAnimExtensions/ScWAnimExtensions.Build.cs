// Scientific Ways

using UnrealBuildTool;
using System.IO; // for Path

public class ScWAnimExtensions : ModuleRules
{
	public ScWAnimExtensions(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicIncludePaths.AddRange(new string[]
		{

		});

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",

			"ScWGameCore",
		});

		PrivateDependencyModuleNames.AddRange(new string[]
		{
			"CoreUObject",
			"Engine",

			"Niagara",
		});
	}
}
