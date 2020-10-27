using UnrealBuildTool;

public class MapitaTarget : TargetRules
{
	public MapitaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Mapita");
	}
}
