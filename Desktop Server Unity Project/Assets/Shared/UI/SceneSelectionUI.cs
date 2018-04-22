using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneSelectionUI : MonoBehaviour {

    public GameObject phobiaNetworkManagerPrefab;

    public Button phobiaButton;

    private LoadSceneUI loadSceneUI;

    void Start () {
        loadSceneUI = this.GetComponentInParent<LoadSceneUI>();

        phobiaButton.onClick.AddListener(InstantiatePhobiaNetworkManager);
        phobiaButton.onClick.AddListener(loadSceneUI.LoadPhobiaUI);
	}

    private void InstantiatePhobiaNetworkManager()
    {
        Instantiate(phobiaNetworkManagerPrefab);
    }
}
