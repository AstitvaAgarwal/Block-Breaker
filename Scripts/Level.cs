using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters 
    [SerializeField]int breakableBlocks ;  //Serialized for debugging purposses 

    SceneLoader sceneloader ;  //cached refrence

    private void Start() {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void CountBreakableBlocks()
    {
        breakableBlocks ++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if(breakableBlocks<=0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
