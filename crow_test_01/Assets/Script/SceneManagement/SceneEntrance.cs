using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneEntrance : MonoBehaviour
{
    public string entrancePw;

    private void Start()
    {
        if (crow_sport.instance.scenePw == entrancePw)
        {
            crow_sport.instance.transform.position = transform.position;
            FindAnyObjectByType<CameraFollow>().MoveCameraToTargetPosition(crow_sport.instance.transform.position);
        }
    }
}

