using UnrealBuildTool;

public class CYPHER_GAME_BUILD_V1Target : TargetRules
{
	public CYPHER_GAME_BUILD_V1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("CYPHER_GAME_BUILD_V1");
	}
}
