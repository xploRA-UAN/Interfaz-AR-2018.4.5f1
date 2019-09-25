using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectValue : MonoBehaviour {

    public string value;
    public GameObject paseo;
    public GameObject murales;

    // Use this for initialization
    void Start () {
        value = SaveValue.value;

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
}
