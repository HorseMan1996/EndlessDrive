using Assets.Scripts.GameRoot.Models;
using Assets.Scripts.GameRoot.Signals;
using strange.extensions.command.impl;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameRoot.Commands
{
    public class UpdateUICommand : Command
    {
        [Inject] public UpdateUISignal _updateUISignal { get; set; }
        public override void Execute()
        {
            _updateUISignal.Dispatch();
        }
    }
}