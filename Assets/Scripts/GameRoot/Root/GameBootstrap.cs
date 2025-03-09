using Assets.Scripts.GameRoot.Root;
using strange.extensions.context.impl;

public class GameBootstrap : ContextView
{
    void Awake()
    {
        context = new GameContext(this);
    }
}