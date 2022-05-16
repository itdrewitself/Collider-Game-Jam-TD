using UnrealBuildTool;

public class CYPHER_GAME_BUILD_V1 : ModuleRules
{
	public CYPHER_GAME_BUILD_V1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
