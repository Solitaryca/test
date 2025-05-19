using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] ParticleSystem movementParticle;

    [Range(0, 10)]
    [SerializeField] int occurAftervelocity;

    [Range(0, 0.2f)]
    [SerializeField] float dustFormationPeriod;

    [SerializeField] Rigidbody2D playerRb;

    float counter;

    private void Update()
    {
        counter += Time.deltaTime;
        if (Mathf.Abs(playerRb.velocity.x) > occurAftervelocity)
        {
            if (counter > dustFormationPeriod)
            {
                movementParticle.Play();
                counter =0;
            }
        }
    }
}
