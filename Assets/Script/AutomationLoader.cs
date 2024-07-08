using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomationLoader : MonoBehaviour
{
    public SceneLoader SceneLoader;

    public string sceneName;

    public float durationToLoad;
    void Start()
    {
        Invoke("AutoLoad", durationToLoad);
    }

    
    void AutoLoad()
    {
        SceneLoader.ChangeScene(sceneName);
    }
}
