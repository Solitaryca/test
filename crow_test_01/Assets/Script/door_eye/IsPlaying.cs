using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlaying : MonoBehaviour
{
    [SerializeField] private bool isLYEntered;

    public IsPlaying(bool isLYEntered) => this.isLYEntered = isLYEntered;

    private Animator animLY;
    public string animationTriggerName = "door";

    void Start()
    {
        animLY = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Light_ying"))
        {
            isLYEntered = true;
            animLY.SetTrigger(animationTriggerName);
        }
    }
}
