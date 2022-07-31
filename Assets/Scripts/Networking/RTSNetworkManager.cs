using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSNetworkManager : NetworkManager
{
    [SerializeField] private GameObject _unitSpawnerPrefab;
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);

        GameObject unitSpawnerInstance = Instantiate(_unitSpawnerPrefab, conn.identity.transform.position, conn.identity.transform.rotation);

        NetworkServer.Spawn(unitSpawnerInstance, conn);
    }
}
