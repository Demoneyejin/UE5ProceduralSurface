// Copyright Epic Games, Inc. All Rights Reserved.

#include "UE5ProcGenSurfacesGameMode.h"
#include "UE5ProcGenSurfacesCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUE5ProcGenSurfacesGameMode::AUE5ProcGenSurfacesGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
