using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen : MonoBehaviour
{
    Material screenMat;
    WebCamTexture webcamTexture;
    int captureCounter = 1;
    public string savePath = "C:\\Users\\srmic\\OneDrive\\Ing Infor\\4º\\Interfaces Inteligentes\\practica8\\demos\\";
    void Start()
    {
        webcamTexture = new WebCamTexture();
        screenMat = GetComponent<Renderer>().material;
        screenMat.mainTexture = webcamTexture;
        Debug.Log(webcamTexture.deviceName);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.P) && !webcamTexture.isPlaying) webcamTexture.Play();
        else if (Input.GetKey(KeyCode.P) && webcamTexture.isPlaying) webcamTexture.Stop();
        if (Input.GetKey(KeyCode.X)) {
            Texture2D snapshot = new Texture2D(webcamTexture.width, webcamTexture.height);
            snapshot.SetPixels(webcamTexture.GetPixels());
            snapshot.Apply();
            System.IO.File.WriteAllBytes(savePath + captureCounter.ToString() + ".png", snapshot.EncodeToPNG());
        }
    }
}
