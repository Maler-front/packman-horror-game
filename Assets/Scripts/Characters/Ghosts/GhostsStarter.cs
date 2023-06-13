using System.Collections.Generic;
using UnityEngine;

public class GhostsStarter : MonoBehaviour
{
    [SerializeReference] private List<Ghost> _ghosts;
    [SerializeReference] private List<GhostAIInjector.Ghosts> _ghostsTypes;

    [SerializeField] private Transform _ghostsTarget;

    private void Awake()
    {
        if (_ghosts.Count != _ghostsTypes.Count)
            throw new System.Exception("The number of ghosts does not match number of their types");

        if (_ghostsTarget == null)
            Debug.LogError("You forgot to set a target for ghosts");

        GhostAI.SetTarget(_ghostsTarget);

        for(int i = 0; i < _ghosts.Count; i++)
        {
            GhostAIInjector.SetGhostAI(_ghosts[i], _ghostsTypes[i]);
        }

        enabled = false;
    }
}
