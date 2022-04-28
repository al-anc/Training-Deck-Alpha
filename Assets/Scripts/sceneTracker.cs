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
    public bool  EasyDifficulty = false;
    public bool  MedDifficulty = false;
    public bool  HardDifficulty = false;
    public bool  invincible = false;
    public bool  finalSceneload = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
        
    }

    void Update()
    {
        if (Level1Completed == 1 && Level2Completed == 1 && Level3Completed == 1 && !finalSceneload)
        {
            SceneManager.LoadScene(7);
            finalSceneload = true;
        }
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
    public void difficulty(int difficultyValue)
    {
        if (difficultyValue == 0)
        {
            EasyDifficulty = true;
            MedDifficulty = false;
            HardDifficulty = false;
        }

        if (difficultyValue == 1)
        {
            EasyDifficulty = false;
            MedDifficulty = true;
            HardDifficulty = false;
        }

        if(difficultyValue == 2)
        {
            EasyDifficulty = false;
            MedDifficulty = false;
            HardDifficulty = true;
        }
    }
    public void invincibility(bool invincibilityToggle)
    {
        if(invincibilityToggle){
            invincible = true;
        }
        if(!invincibilityToggle){
            invincible = false;
        }
    }
}
