using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSceneUI : MonoBehaviour {

    public GameObject phobiaUIPrefab;
    public GameObject sceneSelectionPrefab;

    public Button resetUIButton;
    public RawImage streamingRawImage;

    private GameObject sceneControlPanel;
    private GameObject sceneSelection;
    private GameObject phobiaUI;

    private void Start()
    {
        sceneControlPanel = GameObject.Find("SceneControlPanel");
        sceneSelection = GameObject.Find("SceneSelection");
    }

    public void LoadPhobiaUI()
    {
        Destroy(sceneSelection);
        phobiaUI = Instantiate(phobiaUIPrefab, sceneControlPanel.transform);
        resetUIButton.interactable = true;
    }

    public void ResetUI()
    {   
        if(phobiaUI != null)
            Destroy(phobiaUI);
      
        if (sceneSelection == null)
            sceneSelection = Instantiate(sceneSelectionPrefab, sceneControlPanel.transform);

        resetUIButton.interactable = false;
        streamingRawImage.texture = null;
        Destroy(GameObject.FindGameObjectWithTag("NetworkManager"));
        Destroy(GameObject.FindGameObjectWithTag("SceneManager"));
    }
}
