using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhobiaUI : MonoBehaviour {

    public void LoadScene()
    { 
        GameObject.FindGameObjectWithTag("SceneManager").GetComponent<PhobiaSceneBehaviour>().RpcLoadScene();
        GameObject.FindGameObjectWithTag("StreamingButton").GetComponent<Button>().interactable = true;
    }
}
