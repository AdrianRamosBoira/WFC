using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera entranceCam;
    public Material cameraMat;


    // Start is called before the first frame update
    void Start()
    {
        if(entranceCam.targetTexture != null)
        {
            entranceCam.targetTexture.Release();
        }

        entranceCam.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMat.mainTexture = entranceCam.targetTexture;
    }
}
