using Assets.Scripts.GameRoot.Commands;
using Assets.Scripts.GameRoot.Models;
using Assets.Scripts.GameRoot.Signals;
using strange.examples.signals;
using UnityEngine;

namespace Assets.Scripts.GameRoot.Root
{
    public class GameContext : SignalsContext
    {
        public GameContext(MonoBehaviour view) : base(view) { }

        private StartGameSignals _gameSignals { get; set; }
        
        protected override void mapBindings()
        {
            injectionBinder.Bind<StartSignal>().To<StartSignal>().ToSingleton();
            injectionBinder.Bind<UpdateUISignal>().To<UpdateUISignal>().ToSingleton();

            // Model'i baðlama
            injectionBinder.Bind<IGameModel>().To<GameModel>().ToSingleton();

            // Controller'ý baðlama
            commandBinder.Bind<StartGameSignals>().To<StartGameCommand>().To<UpdateUICommand>().InSequence();
            commandBinder.Bind<AddPointSignal>().To<AddPointCommand>().To<UpdateUICommand>().InSequence();
            
            // View'i baðlama
            mediationBinder.Bind<GameView>().To<GameMediator>();
        }
    }
}