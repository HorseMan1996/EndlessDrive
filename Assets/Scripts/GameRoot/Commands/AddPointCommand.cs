using Assets.Scripts.GameRoot.Models;
using strange.extensions.command.impl;

namespace Assets.Scripts.GameRoot.Commands
{
    public class AddPointCommand : Command
    {
        [Inject] public IGameModel gameModel { get; set; }

        public override void Execute()
        {
            gameModel.Score++;
        }
    }
}