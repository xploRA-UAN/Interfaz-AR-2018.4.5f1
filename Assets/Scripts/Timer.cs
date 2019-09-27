using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script for change scene after timer finish.
 */

public class Timer : MonoBehaviour {

    #region PRIVATE_VARIABLES

    private float iniTime = 0.0f;

    #endregion //PRIVATE_VARIABLES

    #region PUBLIC_VARIABLES

    public float endTime;

    #endregion //PUBLIC_VARIABLES

    #region PRIVATE_METHODS

    // Update is called once per frame
    void Update () {
        iniTime += Time.deltaTime;

        if (iniTime >= endTime)
        {
            Application.LoadLevel("Inicio");
        }
	}

    #endregion //PRIVATE_METHODS
}