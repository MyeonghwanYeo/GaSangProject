using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public Camera mainCamera;
    public Camera FirstCamera;
    public Camera SecondCamera;
    public Camera ThirdCamera;

    public void FirstView()
    {
        mainCamera.enabled = false;
        FirstCamera.enabled = true;
        SecondCamera.enabled = false;
        ThirdCamera.enabled = false;
    }

    public void SecondView()
    {
        mainCamera.enabled = false;
        FirstCamera.enabled = false;
        SecondCamera.enabled = true;
        ThirdCamera.enabled = false;
    }

    public void ThirdView()
    {
        mainCamera.enabled = false;
        FirstCamera.enabled = false;
        SecondCamera.enabled = false;
        ThirdCamera.enabled = true;
    }

}