using UnrealBuildTool;
using System.Collections.Generic;

public class SproutScapeTarget : TargetRules
{
    public SproutScapeTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        ExtraModuleNames.Add("SproutScape"); // Must match your .uproject module name
    }
}
