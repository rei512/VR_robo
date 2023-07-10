using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WebCamera : MonoBehaviour
{
    int width = 3480;
    int height = 2160;
    int fps = 17;
    WebCamTexture webcamTexture;
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture = new WebCamTexture(devices[1].name, this.width, this.height, this.fps);
        GetComponent<Renderer>().material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
}