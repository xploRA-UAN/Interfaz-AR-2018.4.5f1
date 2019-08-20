/*==============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using UnityEngine.UI;
using Vuforia;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    #region PROTECTED_MEMBER_VARIABLES

    public Transform panelTarget;
    public Transform panelLocked;
    public Button play;
    public Button pause;
    public GameObject panel;

    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;

    private AudioSource previousAudio;
    private AudioSource currentAudio;
    private GameObject previousPanel;
    private GameObject currentPanel;

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            //Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            //Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    public void AudioPlay()
    {
        if (currentAudio.isPlaying == false &&
            mTrackableBehaviour.gameObject.GetComponentInChildren<AudioSource>() != null)

        {
            currentAudio.Play();
            pause.gameObject.SetActive(true);
            play.gameObject.SetActive(false);
        }
    }

    public void AudioPause()
    {
        if (currentAudio.isPlaying)
        {
            mTrackableBehaviour.gameObject.GetComponentInChildren<AudioSource>().Pause();
            pause.gameObject.SetActive(false);
            play.gameObject.SetActive(true);
        }
    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;

        // Audio play
        if (mTrackableBehaviour.gameObject.GetComponentInChildren<AudioSource>() != null)
        {
            if (currentAudio == null)
            {
                currentAudio = mTrackableBehaviour.gameObject.GetComponentInChildren<AudioSource>();

                if (!currentAudio.isPlaying)
                {
                    currentAudio.Play();
                }
            }
            else if (currentAudio == mTrackableBehaviour.gameObject.GetComponentInChildren<AudioSource>())
            {
                if (!currentAudio.isPlaying)
                {
                    currentAudio.Play();
                }
            }
            else if (currentAudio != null &&
                currentAudio != mTrackableBehaviour.gameObject.GetComponentInChildren<AudioSource>())
            {
                previousAudio = currentAudio;
                currentAudio = mTrackableBehaviour.gameObject.GetComponentInChildren<AudioSource>();
                previousAudio.Stop();

                if (!currentAudio.isPlaying)
                {
                    currentAudio.Play();
                }
            }
        }

        panelTarget.gameObject.SetActive(false);
        panelLocked.gameObject.SetActive(true);
        if (currentPanel == null)
        {
            currentPanel = panel;
            currentPanel.gameObject.SetActive(true);
        }
        else if (currentPanel == panel)
        {
            currentPanel.gameObject.SetActive(true);
        }
        else if(currentPanel != null && currentPanel != panel)
        {
            currentPanel.gameObject.SetActive(false);
            previousPanel = currentPanel;
            previousPanel.gameObject.SetActive(false);
            currentPanel = panel;
            currentPanel.gameObject.SetActive(true);
        }
        else
        {
            previousPanel.gameObject.SetActive(false);
            currentPanel.gameObject.SetActive(false);
        }
    }


    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;

        // Audio stop
       /* if (mTrackableBehaviour.gameObject.GetComponentInChildren<AudioSource>() != null)
        {
            //Funcion para detener el audio
            mTrackableBehaviour.gameObject.GetComponentInChildren<AudioSource>().Stop();
        }*/

        panelTarget.gameObject.SetActive(true);
        panelLocked.gameObject.SetActive(false);
    }

    #endregion // PROTECTED_METHODS
}