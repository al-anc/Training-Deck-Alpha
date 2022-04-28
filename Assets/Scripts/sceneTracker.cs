using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTracker : MonoBehaviour
{
    Scene scene;
    public int previousScene = 0;
    public int sceneDeath;
    public List<int> sceneHistory = new List<int>();
    public int Level1Completed = 0;
    public int Level2Completed = 0;
    public int Level3Completed = 0;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
        
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        scene = SceneManager.GetActiveScene();
        sceneHistory.Add(scene.buildIndex);
        if(sceneHistory.Count >= 2){
            Debug.Log(sceneHistory[sceneHistory.Count-1]);
            Debug.Log(sceneHistory[sceneHistory.Count-2]);
        }
    }
}
