using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOverSubCanvas : UIRoundOverSubCanvas
{
    protected override void GameManager_OnGameStateChange(EGameStates NewGameState)
    {
        switch (NewGameState)
        {

            case EGameStates.GAME_OVER:
                ShowContainer();
                break;

            default: HideRoundOver(); break;
        }
    }
}
