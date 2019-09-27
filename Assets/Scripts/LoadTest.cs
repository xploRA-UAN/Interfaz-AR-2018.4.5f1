using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Script to change to "Camara" scene asynchronously with 
 * current scene(Recorridos).
 */

public class LoadTest : MonoBehaviour {

    #region PUBLIC_VARIABLES

    public GameObject loadPanel;

    #endregion //PUBLIC_VARIABLES

    #region PRIVATE_VARIABLES

    private AsyncOperation asyn;

    #endregion //PRIVATE_VARIABLES

    #region PUBLIC_METHODS

    public void ClickCarga()
    {
        loadPanel.SetActive(true);
        //Method to call and start coroutine
        StartCoroutine(LoadSlider());
    }

    #endregion //PUBLIC_METHODS

    #region COROUTINES

    IEnumerator LoadSlider()
    {
        //Asignation of scene change
        asyn = SceneManager.LoadSceneAsync("Camara");

       while (!asyn.isDone)
        {
            //Method for asignate the value "1" to variable asyn.progress
            Mathf.Clamp01(asyn.progress / 0.9f);
            yield return null;
        }
    }

    #endregion //COROUTINES
}
