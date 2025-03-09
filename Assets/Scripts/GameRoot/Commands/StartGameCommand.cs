using Assets.Scripts.GameRoot.Models;
using strange.extensions.command.impl;

public class StartGameCommand : Command
{
    [Inject] public IGameModel gameModel { get; set; }

    public override void Execute()
    {
        gameModel.Score = 1; // Oyunu başlatırken skor sıfırlanır.
    }
}