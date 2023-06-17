// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UE5ProcGenSurfacesEditorTarget : TargetRules
{
	public UE5ProcGenSurfacesEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("UE5ProcGenSurfaces");
        AdditionalPlugins.Add("ImGui");

        
    }
}
