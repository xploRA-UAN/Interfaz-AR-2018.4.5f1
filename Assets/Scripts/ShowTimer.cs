using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * This script is using for hide the markers on the Map scene.
 */

public class ShowTimer : MonoBehaviour
{
    #region PUBLIC_VARIABLES

    public float endTime;
    public GameObject panel;
    public Text text;
    public Image image;

    private float initTime = 0.0f;

    #endregion //PUBLIC_VARIABLES

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        initTime += Time.deltaTime;

        if (initTime >= endTime && image.IsActive())
        {
            text.gameObject.SetActive(false);
            panel.gameObject.SetActive(false);
            image.gameObject.SetActive(false);
        }

        if (!image.IsActive())
        {
            initTime = 0.0f;
        }
    }
}
