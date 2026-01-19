// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class NPC_Proximity_Logic : ModuleRules
{
	public NPC_Proximity_Logic(ReadOnlyTargetRules Target) : base(Target)
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
			"NPC_Proximity_Logic",
			"NPC_Proximity_Logic/Variant_Platforming",
			"NPC_Proximity_Logic/Variant_Platforming/Animation",
			"NPC_Proximity_Logic/Variant_Combat",
			"NPC_Proximity_Logic/Variant_Combat/AI",
			"NPC_Proximity_Logic/Variant_Combat/Animation",
			"NPC_Proximity_Logic/Variant_Combat/Gameplay",
			"NPC_Proximity_Logic/Variant_Combat/Interfaces",
			"NPC_Proximity_Logic/Variant_Combat/UI",
			"NPC_Proximity_Logic/Variant_SideScrolling",
			"NPC_Proximity_Logic/Variant_SideScrolling/AI",
			"NPC_Proximity_Logic/Variant_SideScrolling/Gameplay",
			"NPC_Proximity_Logic/Variant_SideScrolling/Interfaces",
			"NPC_Proximity_Logic/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
