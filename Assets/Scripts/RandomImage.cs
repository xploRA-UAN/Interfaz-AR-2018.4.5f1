using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script for make visible a background of Info Panel 
 * in "Pantalla Principal" scene.
 */

public class RandomImage : MonoBehaviour {

    #region PUBLIC_VARIABLES

    public GameObject fondoA;
    public GameObject fondoB;

    #endregion //PUBLIC_VARIABLES

    #region PRIVATE_VARIABLES

    private int random;

    #endregion //PRIVATE_VARIABLES

    #region PRIVATE_METHODS

    private void Awake()
    {
        random = 0;
        fondoA.SetActive(false);
        fondoB.SetActive(false);
    }

    #endregion //PRIVATE_METHODS

    #region PUBLIC_METHODS

    public void RandomValue()
    {
        random = Random.Range(1, 3);

        if (random == 1)
        {
            fondoA.SetActive(true);
            fondoB.SetActive(false);
        }
        else if(random == 2)
        {
            fondoB.SetActive(true);
            fondoA.SetActive(false);
        }
    }

    #endregion //PUBLIC_METHODS
}
