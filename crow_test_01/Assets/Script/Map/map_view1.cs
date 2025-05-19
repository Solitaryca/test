using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class map_view1 : MonoBehaviour
{
    private Transform Player;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.position.y-1.1>transform.position.y)
        {
            sr.sortingOrder = 4;
        }
        else
        {
            sr.sortingOrder = 2;
        }
    }
}
