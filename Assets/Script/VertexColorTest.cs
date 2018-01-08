using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexColorTest  : MonoBehaviour
{

    #region Public Members
    
    #endregion


    #region Public Void

    #endregion


    #region System

    void Start () 
    {
        
    }
    private void Awake()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;

        // create new colors array where the colors will be created.
        Color[] colors = new Color[vertices.Length];

        for (int i = 0; i < vertices.Length; i++)
            colors[i] = Color.Lerp(Color.green,Color.red,vertices[i].y);

        // assign the array of colors to the Mesh.
        mesh.colors = colors;
    }

    #endregion

    #region Private Void

    #endregion

    #region Tools Debug And Utility

    #endregion


    #region Private And Protected Members

    #endregion

}
