using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roof_transparent : MonoBehaviour
{
    SpriteRenderer rf;

    private void Awake()
    {
        rf = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rf.color = new(rf.color.r, rf.color.g, rf.color.b, 0.3f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            rf.color = new(rf.color.r, rf.color.g, rf.color.b, 1f);
        }
    }
}
