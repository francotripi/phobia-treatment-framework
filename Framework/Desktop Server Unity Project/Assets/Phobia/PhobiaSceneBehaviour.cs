using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PhobiaSceneBehaviour : NetworkBehaviour {
    
    [ClientRpc]
    public void RpcLoadScene() { }
}
