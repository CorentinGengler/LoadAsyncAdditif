using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnEnter  : MonoBehaviour
{

    #region Public Members

    #endregion


    #region Public Void
    public void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().Play();
    }
    #endregion


    #region System


    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
