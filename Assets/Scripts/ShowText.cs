using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * This script is used to enabled or disabled the differents text
 * and Images of the murals located on the markers in Map scene.
 */

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
    public Text hombreYQuimica;
    public Text setuan1;
    public Text setuan2;
    public Text elementales;
    public Text apocalipsis;

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
    public Image hombreYQuimicaImg;
    public Image setuan1Img;
    public Image setuan2Img;
    public Image elementalesImg;
    public Image apocalipsisImg;

    #endregion //PUBLIC_IMAGE_VARIABLES

    #region PUBLIC_PANEL_VARIABLES

    public Image panelDedicatoria;
    public Image panelEscudo;
    public Image panelPaseo;
    public Image panelOrigen;
    public Image panelPorLoNuestro;
    public Image panelComercio;
    public Image panelOdonto;
    public Image panelEnfermeria;
    public Image panelGigante;
    public Image panelDespertar;
    public Image panelHombreYQuimica;
    public Image panelSetuan1;
    public Image panelSetuan2;
    public Image panelElementales;
    public Image panelApocalipsis;

    #endregion //PUBLIC_PANEL_VARIABLES

    #region PUBLIC_METHODS

    //Methods for enable or disable the variables.

    public void Escudo()
    {
        if (!escudo.IsActive())
        {
            escudo.gameObject.SetActive(true);
            escudoImg.gameObject.SetActive(true);
            panelEscudo.gameObject.SetActive(true);
        }
        else
        {
            escudoImg.gameObject.SetActive(false);
            escudo.gameObject.SetActive(false);
            panelEscudo.gameObject.SetActive(false);
        }
    }

    public void Dedicatoria()
    {
        if (!dedicatoria.IsActive())
        {
            dedicatoria.gameObject.SetActive(true);
            dedicatoriaImg.gameObject.SetActive(true);
            panelDedicatoria.gameObject.SetActive(true);
        }
        else
        {
            dedicatoria.gameObject.SetActive(false);
            dedicatoriaImg.gameObject.SetActive(false);
            panelDedicatoria.gameObject.SetActive(false);
        }
    }

    public void Paseo()
    {
        if (!paseo.IsActive())
        {
            paseo.gameObject.SetActive(true);
            paseoImg.gameObject.SetActive(true);
            panelPaseo.gameObject.SetActive(true);
        }
        else
        {
            paseo.gameObject.SetActive(false);
            paseoImg.gameObject.SetActive(false);
            panelPaseo.gameObject.SetActive(false);
        }
    }

    public void Origen()
    {
        if (!origen.IsActive())
        {
            origen.gameObject.SetActive(true);
            origenImg.gameObject.SetActive(true);
            panelOrigen.gameObject.SetActive(true);
        }
        else
        {
            origen.gameObject.SetActive(false);
            origenImg.gameObject.SetActive(false);
            panelOrigen.gameObject.SetActive(false);
        }
    }

    public void PorLoNuestro()
    {
        if (!porLoNuestro.IsActive())
        {
            porLoNuestro.gameObject.SetActive(true);
            porLoNuestroImg.gameObject.SetActive(true);
            panelPorLoNuestro.gameObject.SetActive(true);
        }
        else
        {
            porLoNuestro.gameObject.SetActive(false);
            porLoNuestroImg.gameObject.SetActive(false);
            panelPorLoNuestro.gameObject.SetActive(false);
        }
    }

    public void Comercio()
    {
        if (!comercio.IsActive())
        {
            comercio.gameObject.SetActive(true);
            comercioImg.gameObject.SetActive(true);
            panelComercio.gameObject.SetActive(true);
        }
        else
        {
            comercio.gameObject.SetActive(false);
            comercioImg.gameObject.SetActive(false);
            panelComercio.gameObject.SetActive(false);
        }
    }

    public void Odonto()
    {
        if (!odonto.IsActive())
        {
            odonto.gameObject.SetActive(true);
            odontoImg.gameObject.SetActive(true);
            panelOdonto.gameObject.SetActive(true);
        }
        else
        {
            odonto.gameObject.SetActive(false);
            odontoImg.gameObject.SetActive(false);
            panelOdonto.gameObject.SetActive(false);
        }
    }

    public void Enfermeria()
    {
        if (!enfermeria.IsActive())
        {
            enfermeria.gameObject.SetActive(true);
            enfermeriaImg.gameObject.SetActive(true);
            panelEnfermeria.gameObject.SetActive(true);
        }
        else
        {
            enfermeria.gameObject.SetActive(false);
            enfermeriaImg.gameObject.SetActive(false);
            panelEnfermeria.gameObject.SetActive(false);
        }
    }

    public void Gigante()
    {
        if (!gigante.IsActive())
        {
            gigante.gameObject.SetActive(true);
            giganteImg.gameObject.SetActive(true);
            panelGigante.gameObject.SetActive(true);
        }
        else
        {
            gigante.gameObject.SetActive(false);
            giganteImg.gameObject.SetActive(false);
            panelGigante.gameObject.SetActive(false);
        }
    }

    public void Despertar()
    {
        if (!despertar.IsActive())
        {
            despertar.gameObject.SetActive(true);
            despertarImg.gameObject.SetActive(true);
            panelDespertar.gameObject.SetActive(true);
        }
        else
        {
            despertar.gameObject.SetActive(false);
            despertarImg.gameObject.SetActive(false);
            panelDespertar.gameObject.SetActive(false);
        }
    }

    public void HombreYQuimica()
    {
        if (!hombreYQuimica.IsActive())
        {
            hombreYQuimica.gameObject.SetActive(true);
            hombreYQuimicaImg.gameObject.SetActive(true);
            panelHombreYQuimica.gameObject.SetActive(true);
        }
        else
        {
            hombreYQuimica.gameObject.SetActive(false);
            hombreYQuimicaImg.gameObject.SetActive(false);
            panelHombreYQuimica.gameObject.SetActive(false);
        }
    }

    public void Setuan1()
    {
        if (!setuan1.IsActive())
        {
            setuan1.gameObject.SetActive(true);
            setuan1Img.gameObject.SetActive(true);
            panelSetuan1.gameObject.SetActive(true);
        }
        else
        {
            setuan1.gameObject.SetActive(false);
            setuan1Img.gameObject.SetActive(false);
            panelSetuan1.gameObject.SetActive(false);
        }
    }

    public void Setuan2()
    {
        if (!setuan2.IsActive())
        {
            setuan2.gameObject.SetActive(true);
            setuan2Img.gameObject.SetActive(true);
            panelSetuan2.gameObject.SetActive(true);
        }
        else
        {
            setuan2.gameObject.SetActive(false);
            setuan2Img.gameObject.SetActive(false);
            panelSetuan2.gameObject.SetActive(false);
        }
    }

    public void Elementales()
    {
        if (!elementales.IsActive())
        {
            elementales.gameObject.SetActive(true);
            elementalesImg.gameObject.SetActive(true);
            panelElementales.gameObject.SetActive(true);
        }
        else
        {
            elementales.gameObject.SetActive(false);
            elementalesImg.gameObject.SetActive(false);
            panelElementales.gameObject.SetActive(false);
        }
    }

    public void Apocalipsis()
    {
        if (!apocalipsis.IsActive())
        {
            apocalipsis.gameObject.SetActive(true);
            apocalipsisImg.gameObject.SetActive(true);
            panelApocalipsis.gameObject.SetActive(true);
        }
        else
        {
            apocalipsis.gameObject.SetActive(false);
            apocalipsisImg.gameObject.SetActive(false);
            panelApocalipsis.gameObject.SetActive(false);
        }
    }

    #endregion //PUBLIC_METHODS
}
