using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class NextDoorController : MonoBehaviour
{
    void Awake()
    {
        Debug.Assert(GetComponent<BoxCollider2D>().isTrigger);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.instance.NextStage();
    }
}
