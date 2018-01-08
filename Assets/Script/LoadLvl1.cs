using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLvl1  : MonoBehaviour
{

    #region Public Members
    
    #endregion


    #region Public Void
    public void LoadLvl()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Sc1", LoadSceneMode.Single);
        SceneManager.LoadScene("PlayerController", LoadSceneMode.Additive);
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
