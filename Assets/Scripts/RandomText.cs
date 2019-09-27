using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Script for the selection of info text
 * after activate LoadPanel in "Recorridos" scene.
 */

public class RandomText : MonoBehaviour {

    #region PUBLIC_VARIABLES

    public Text texto;

    #endregion //PUBLIC_VARIABLES

    #region PRIVATE_VARIABLES

    private int random;

    #endregion //PRIVATE_VARIABLES

    #region PRIVATE_METHODS

    private void Awake()
    {
        random = 0;
    }

    #endregion //PRIVATE_METHODS

    #region PUBLIC_METHODS

    public void RandomValue()
    {
        random = Random.Range(1, 5);

        switch (random)
        {
            case 1:
                texto.text = "Recomendación: Utiliza audífonos para poder escuchar mejor los audios.";
                break;
            case 2:
                texto.text = "No camines viendo la pantalla de tu teléfono. Evita accidentes.";
                break;
            case 3:
                texto.text = "Recomendación: Manten distancia del mural para poder ver el modelo 3D.";
                break;
            case 4:
                texto.text = "Recomendación: Procura estar bajo una buena fuente de luz.";
                break;
        }
    }

    #endregion //PUBLIC_METHODS
}
