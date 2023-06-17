// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UE5ProcGenSurfaces : ModuleRules
{
	public UE5ProcGenSurfaces(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}
