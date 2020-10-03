using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set; }

    private Transform player;
    private Vector3 spawnPoint;

    void Awake()
    {
        Debug.Assert(instance == null);
        instance = this;
        player = GameObject.FindWithTag("Player").transform;
        spawnPoint = player.position;
    }

    // Go to the Next Stage
    public void NextStage()
    {
        Debug.Log("Next");
        player.position = spawnPoint;
    }

    // Go to the Previous Stage
    public void PreviousStage()
    {
        Debug.Log("Previous");
        player.position = spawnPoint;
    }
}
