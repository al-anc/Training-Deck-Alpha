using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthCrystalHider : MonoBehaviour
{
    public GameObject HealthCrystalGroup;
    // Start is called before the first frame update
    void Start()
    {
        HealthCrystalGroup.SetActive(false);
    }

}
