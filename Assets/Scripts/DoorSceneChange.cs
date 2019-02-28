using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneChange : MonoBehaviour {

    public int num;
    
   
    
	
	// Update is called once per frame
	void Update ()
    {
        

        
    }

    void OnMouseDown()
    {
        
        SceneManager.LoadScene(num);
        Debug.Log("Scene changed to" + num);
        
    }
}
