using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Taller;
using UnityEngine;

public class UIRoundOverSubCanvas : MonoBehaviour
{
    public float fadeInTime = 0.2f;
    public float fadeOutTime = 0.2f;

    private void OnEnable()
    {
        GameManager.OnGameStateChange += GameManager_OnGameStateChange;
    }

   

    private void OnDisable()
    {
        GameManager.OnGameStateChange -= GameManager_OnGameStateChange;
    }
    private void GameManager_OnGameStateChange(EGameStates NewGameState)
    {
        switch (NewGameState)
        {
            
            case EGameStates.ROUND_OVER:
                ShowRoundOver();
                break;

            default: HideRoundOver();break;
        }
    }

    void ShowRoundOver()
    {

        GetComponent<CanvasGroup>()?.DOFade(1, fadeInTime);
    }

    void HideRoundOver()
    {

        GetComponent<CanvasGroup>()?.DOFade(0, fadeOutTime);
    }
}