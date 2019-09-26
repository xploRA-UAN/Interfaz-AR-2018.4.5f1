using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    #region PUBLIC_TEXT_VARIABLES

    public Text escudo;
    public Text dedicatoria;
    public Text paseo;
    public Text origen;
    public Text porLoNuestro;
    public Text comercio;
    public Text odonto;
    public Text enfermeria;
    public Text gigante;
    public Text despertar;

    #endregion //PUBLIC_TEXT_VARIABLES

    #region PUBLIC_IMAGE_VARIABLES

    public Image dedicatoriaImg;
    public Image escudoImg;
    public Image paseoImg;
    public Image origenImg;
    public Image porLoNuestroImg;
    public Image comercioImg;
    public Image odontoImg;
    public Image enfermeriaImg;
    public Image giganteImg;
    public Image despertarImg;

    #endregion //PUBLIC_IMAGE_VARIABLES

    public void Escudo()
    {
        if (!escudo.IsActive())
        {
            escudo.gameObject.SetActive(true);
            escudoImg.gameObject.SetActive(true);
        }
        else
        {
            escudoImg.gameObject.SetActive(false);
            escudo.gameObject.SetActive(false);
        }
    }

    public void Dedicatoria()
    {
        if (!dedicatoria.IsActive())
        {
            dedicatoria.gameObject.SetActive(true);
            dedicatoriaImg.gameObject.SetActive(true);
        }
        else
        {
            dedicatoria.gameObject.SetActive(false);
            dedicatoriaImg.gameObject.SetActive(false);
        }
    }

    public void Paseo()
    {
        if (!paseo.IsActive())
        {
            paseo.gameObject.SetActive(true);
            paseoImg.gameObject.SetActive(true);
        }
        else
        {
            paseo.gameObject.SetActive(false);
            paseoImg.gameObject.SetActive(false);
        }
    }

    public void Origen()
    {
        if (!origen.IsActive())
        {
            origen.gameObject.SetActive(true);
            origenImg.gameObject.SetActive(true);
        }
        else
        {
            origen.gameObject.SetActive(false);
            origenImg.gameObject.SetActive(false);
        }
    }

    public void PorLoNuestro()
    {
        if (!porLoNuestro.IsActive())
        {
            porLoNuestro.gameObject.SetActive(true);
            porLoNuestroImg.gameObject.SetActive(true);
        }
        else
        {
            porLoNuestro.gameObject.SetActive(false);
            porLoNuestroImg.gameObject.SetActive(false);
        }
    }

    public void Comercio()
    {
        if (!comercio.IsActive())
        {
            comercio.gameObject.SetActive(true);
            comercioImg.gameObject.SetActive(true);
        }
        else
        {
            comercio.gameObject.SetActive(false);
            comercioImg.gameObject.SetActive(false);
        }
    }

    public void Odonto()
    {
        if (!odonto.IsActive())
        {
            odonto.gameObject.SetActive(true);
            odontoImg.gameObject.SetActive(true);
        }
        else
        {
            odonto.gameObject.SetActive(false);
            odontoImg.gameObject.SetActive(false);
        }
    }

    public void Enfermeria()
    {
        if (!enfermeria.IsActive())
        {
            enfermeria.gameObject.SetActive(true);
            enfermeriaImg.gameObject.SetActive(true);
        }
        else
        {
            enfermeria.gameObject.SetActive(false);
            enfermeriaImg.gameObject.SetActive(false);
        }
    }

    public void Gigante()
    {
        if (!gigante.IsActive())
        {
            gigante.gameObject.SetActive(true);
            giganteImg.gameObject.SetActive(true);
        }
        else
        {
            gigante.gameObject.SetActive(false);
            giganteImg.gameObject.SetActive(false);
        }
    }

    public void Despertar()
    {
        if (!despertar.IsActive())
        {
            despertar.gameObject.SetActive(true);
            despertarImg.gameObject.SetActive(true);
            GameObject.Find("PanelDespertar").gameObject.SetActive(true);
        }
        else
        {
            despertar.gameObject.SetActive(false);
            despertarImg.gameObject.SetActive(false);
            GameObject.Find("PanelDespertar").GetComponentInChildren<Image>().gameObject.SetActive(false);
        }
    }
}
