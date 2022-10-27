using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class SceneSetup : NetworkBehaviour
{

    [SerializeField] 
    private GameObject ObjectToMove;
    // Start is called before the first frame update

    private void Start()
    {
      ObjectToMove.transform.position = new Vector3(0.0f, 0.5f, 0.0f);
    }

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        //if (IsServer)
    }
}
