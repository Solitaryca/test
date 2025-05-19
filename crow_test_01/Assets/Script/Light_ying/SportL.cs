using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportL : MonoBehaviour
{
    public GameObject LightYing;
    public GameObject light_track1;
    public GameObject relation_1;

    void Start()
    {
        LightYing.SetActive(false);
        light_track1.SetActive(false);
    }

    void Update()
    {
        Talkself myComponent1 = relation_1.GetComponent<Talkself>();

        if (myComponent1.isEnd == true)
        {
            LightYing.SetActive(true);
            light_track1.SetActive(true);
        }
    }
}
