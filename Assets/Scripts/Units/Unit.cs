using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Unit : NetworkBehaviour
{
    [SerializeField] private UnitMovement _unitMovement;
    [SerializeField] private UnityEvent _onSelected;
    [SerializeField] private UnityEvent _onDeselected;

    public UnitMovement GetUnitMovement()
    {
        return _unitMovement;
    }

    #region Client

    [Client]
    public void Select()
    {
        if (!hasAuthority) return;

        _onSelected?.Invoke();
    }

    [Client]
    public void Deselect()
    {
        if (!hasAuthority) return;

        _onDeselected?.Invoke();
    }

    #endregion
}
