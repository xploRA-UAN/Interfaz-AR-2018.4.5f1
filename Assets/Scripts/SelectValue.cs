using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This Script receive the value of "SaveValue" script
 */

public class SelectValue : MonoBehaviour {

    #region PUBLIC_VARIABLES

    public string value;
    public GameObject paseo;
    public GameObject murales;

    #endregion //PUBLIC_VARIABLES

    #region PRIVATE_METHODS

    // Use this for initialization
    void Start () {
        value = SaveValue.value;

        //This condition is used for enable or disable elements in "Camara" scene
        if (value == "P")
        {
            paseo.SetActive(true);
            murales.SetActive(false);
        }
        else if (value == "M")
        {
            paseo.SetActive(false);
            murales.SetActive(true);
        }
        else if (value == "L")
        {
            paseo.SetActive(true);
            murales.SetActive(true);
        }
    }

    #endregion //PRIVATE_METHODS

    #region PUBLIC_METHODS

    //This method is used for return to "Recorridos" or "Pantalla Principal" scenes
    public void Scene()
    {
        if (value == "Recorridos")
        {
            Application.LoadLevel("Recorridos");
        }
        else if (value == "Principal")
        {
            Application.LoadLevel("Pantalla Principal");
        }
    }

    #endregion //PUBLIC_METHODS
}
