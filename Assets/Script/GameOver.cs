using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameOver  : MonoBehaviour
{

    #region Public Members
    public Canvas m_canvas;
    #endregion


    #region Public Void
    public void OnTriggerEnter(Collider other)
    {
        m_canvas.gameObject.SetActive(true);
        GameObject MC = GameObject.FindGameObjectWithTag("Player");
        MC.gameObject.SetActive(false);
        Time.timeScale = 0f;
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
