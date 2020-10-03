using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class PreviousDoorController : MonoBehaviour
{
    void Awake()
    {
        Debug.Assert(GetComponent<BoxCollider2D>().isTrigger);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.instance.PreviousStage();
    }
}
