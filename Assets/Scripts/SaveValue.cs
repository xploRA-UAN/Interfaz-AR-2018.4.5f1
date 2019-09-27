using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This Script is used to send the String type value of the "value" variable to SelectValue script.
 */

public class SaveValue : MonoBehaviour {

    #region PRIVATE_VARIABLES

    public static string value = " ";

    #endregion //PRIVATE_VARIABLES

    #region PRIVATE_METHODS

    void Awake()
    {
        //Method for dont destroy the game object called value when change scene
        DontDestroyOnLoad(gameObject);
        value = null;
    }

    #endregion //PRIVATE_METHODS

    #region PUBLIC_METHODS

    //"Recorridos" and "Principal" method's to used in "Camara" scene
    public void Paseo()
    {
        value = "P";
    }

    public void Murales()
    {
        value = "M";
    }

    public void Libre()
    {
        value = "L";
    }

    //"Recorridos" and "Principal" method's to used in "About" scene
    public void Recorridos()
    {
        value = "Recorridos";
    }

    public void Principal()
    {
        value = "Principal";
    }

    #endregion //PUBLIC_METHODS
}
