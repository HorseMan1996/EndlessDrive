using Assets.Scripts.GameRoot.Models;
using Assets.Scripts.GameRoot.Signals;
using strange.extensions.mediation.impl;
using System;
using UnityEngine;

public class GameMediator : Mediator
{
    [Inject] public GameView view { get; set; }
    [Inject] public IGameModel gameModel { get; set; }
    [Inject] public AddPointSignal _addPointSignal { get; set; }
    [Inject] public UpdateUISignal _updateUISignal { get; set; }

    public override void OnRegister()
    {
        UpdateUI();
        view.AddScore.onClick.AddListener(OnAddScore);
        _updateUISignal.AddListener(UpdateUI);
    }

    private void OnAddScore()
    {
        _addPointSignal.Dispatch();
    }

    private void UpdateUI()
    {
        view.UpdateScore(gameModel.Score);
    }
}