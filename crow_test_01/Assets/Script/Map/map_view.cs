using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_view : MonoBehaviour
{
    private List<SpriteRenderer> spDynamic;
    private List<SpriteRenderer> spStatic;

    private void Awake()
    {
        SpriteRenderer[] spriteRenderers = GetComponentsInChildren<SpriteRenderer>();
        spDynamic = new List<SpriteRenderer>();
        spStatic = new List<SpriteRenderer>();

        for (int i = 0; i < spriteRenderers.Length; i++)
        {
            if (spriteRenderers[i].gameObject.isStatic)
            {
                spriteRenderers[i].sortingOrder = Mathf.RoundToInt(spriteRenderers[i].transform.position.y * -100);
                spStatic.Add(spriteRenderers[i]);
            }
            else
            {
                spDynamic.Add(spriteRenderers[i]);
            }
        }
    }

    private void Update()
    {
        for (int i = 0; i < spDynamic.Count; i++)
        {
            spDynamic[i].sortingOrder = Mathf.RoundToInt(spDynamic[i].transform.position.y * -100);
        }
    }
}




