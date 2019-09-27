using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script for enable the info panel and continue button of the "Pantalla Principal" scene.
 */

public class ActivateInfo : MonoBehaviour {

    #region PUBLIC_VARIABLES

    public GameObject infoPanel;
    public GameObject continueButton;

    #endregion //PUBLIC_VARIABLES

    #region PRIVATE_VARIABLES

    private float timer = 0.0f;

    #endregion //PRIVATE_VARIABLES

    #region METHODS

    //This method activate the InfoPanel

    public void Activate()
    {
        infoPanel.SetActive(true);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        //Condition for active the continue button.
        if (timer >= 3.0f)
        {
            continueButton.SetActive(true);
        }
    }

    #endregion //METHODS
}
