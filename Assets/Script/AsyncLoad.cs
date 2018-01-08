using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncLoad  : MonoBehaviour
{

    #region Public Members
    public string m_SceneToLoad;
    public string m_SceneToUnload;
    #endregion


    #region Public Void
    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(LoadYourAsyncScene());
        if(m_SceneToUnload.Length>1)
        {
            StartCoroutine(UnLoadYourAsyncScene());
        }
    }


    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(m_SceneToLoad, LoadSceneMode.Additive);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    IEnumerator UnLoadYourAsyncScene()
    {
        AsyncOperation asyncUnLoad = SceneManager.UnloadSceneAsync(m_SceneToUnload);
        while (!asyncUnLoad.isDone)
        {
            yield return null;
        }
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
