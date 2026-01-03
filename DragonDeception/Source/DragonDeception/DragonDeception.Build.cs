// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DragonDeception : ModuleRules
{
	public DragonDeception(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"DragonDeception",
			"DragonDeception/Variant_Platforming",
			"DragonDeception/Variant_Platforming/Animation",
			"DragonDeception/Variant_Combat",
			"DragonDeception/Variant_Combat/AI",
			"DragonDeception/Variant_Combat/Animation",
			"DragonDeception/Variant_Combat/Gameplay",
			"DragonDeception/Variant_Combat/Interfaces",
			"DragonDeception/Variant_Combat/UI",
			"DragonDeception/Variant_SideScrolling",
			"DragonDeception/Variant_SideScrolling/AI",
			"DragonDeception/Variant_SideScrolling/Gameplay",
			"DragonDeception/Variant_SideScrolling/Interfaces",
			"DragonDeception/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
