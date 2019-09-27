using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

/*
 * Script from destroy selected objects.
 */

public class Destroy : MonoBehaviour {

    private void Awake()
    {
        CameraDevice.Instance.Start();
    }

    public void DestroyObject(){
        if (GameObject.Find("Exit"))
        {
            CameraDevice.Instance.Stop();
            //Objects to destroy
            GameObject.Destroy(GameObject.Find("ARCamera"));
            GameObject.Destroy(GameObject.Find("Value"));
            GameObject.Destroy(GameObject.Find("TextureBufferCamera"));
        }
	}
}
