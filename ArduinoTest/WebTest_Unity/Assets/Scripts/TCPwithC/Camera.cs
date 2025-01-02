using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour
{
    public Camera FirstCamera;
    public Camera SecondCamera;
    public Camera ThirdCamera;

    public void FirstView()
    {
        FirstCamera.enabled = true;
        SecondCamera.enabled = false;
        ThirdCamera.enabled = false;
    }

    public void SecondView()
    {
        FirstCamera.enabled = false;
        SecondCamera.enabled = true;
        ThirdCamera.enabled = false;
    }

    public void ThirdView()
    {
        FirstCamera.enabled = false;
        SecondCamera.enabled = false;
        ThirdCamera.enabled = true;
    }

}