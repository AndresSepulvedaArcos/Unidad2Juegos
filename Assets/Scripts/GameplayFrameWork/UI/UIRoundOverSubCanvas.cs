using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Taller;
using UnityEngine;

public class UIRoundOverSubCanvas : MonoBehaviour
{
    public float fadeInTime = 0.2f;
    public float fadeOutTime = 0.2f;

    [Header("Referencia al container")]
    public GameObject container;
    CanvasGroup canvasGroup;
    private void Awake()
    {
        if(container==null)
        {
            canvasGroup=GetComponentInChildren<CanvasGroup>();
            container = canvasGroup.gameObject;
        }
        if(canvasGroup==null)
        {
            canvasGroup = GetComponentInChildren<CanvasGroup>();

        }
    }
    private void OnEnable()
    {
        container?.SetActive(false);
        GameManager.OnGameStateChange += GameManager_OnGameStateChange;
       
    }

   

    private void OnDisable()
    {
        GameManager.OnGameStateChange -= GameManager_OnGameStateChange;
    }
    protected virtual void GameManager_OnGameStateChange(EGameStates NewGameState)
    {
        switch (NewGameState)
        {
            
            case EGameStates.ROUND_OVER:
                ShowContainer();
                break;

            default: HideRoundOver();break;
        }
    }

    protected void ShowContainer()
    {
        container?.SetActive(true);
        canvasGroup?.DOFade(1, fadeInTime);
    }

    protected  void HideRoundOver()
    {
        container?.SetActive(false);
        canvasGroup?.DOFade(0, fadeOutTime);
    }
}