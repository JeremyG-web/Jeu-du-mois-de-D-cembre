using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    /*
    private AssetBundle sceneAssetBundle;
    private string[] scenePath;

    void Start()
    {
        sceneAssetBundle = AssetBundle.LoadFromFile("Asset/scenes");
        scenePath = sceneAssetBundle.GetAllScenePaths();

    }
    public void StartGame(int LevelToLoad)
    {
        SceneManager.LoadScene(scenePath[LevelToLoad],LoadSceneMode.Single);

    }
    */
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
        
    }

    public void doExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
