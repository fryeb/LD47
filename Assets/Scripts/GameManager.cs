﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set; }

    public GameObject[] stages;
    public GameObject exitStage;
    private int currentStageIndex = 0;

    private Transform player;
    private Vector3 spawnPoint;

    void Awake()
    {
        Debug.Assert(instance == null);
        instance = this;
        player = GameObject.FindWithTag("Player").transform;
        spawnPoint = player.position;

        exitStage.SetActive(false);
        foreach (GameObject stage in stages)
            stage.SetActive(false);
        stages[currentStageIndex].SetActive(true);
    }

    private void SwitchStage(int newStageIndex)
    {
        Debug.Assert(currentStageIndex != newStageIndex);
        Debug.Assert(currentStageIndex != -1);
        stages[currentStageIndex].SetActive(false);
        currentStageIndex = newStageIndex;

        if (newStageIndex == -1)
        {
            exitStage.SetActive(true);
        }
        else
        {
            currentStageIndex %= stages.Length;
            exitStage.SetActive(false);
            stages[currentStageIndex].SetActive(true);
        }
    }

    // Go to the Next Stage
    public void NextStage()
    {
        player.position = spawnPoint;
        SwitchStage(currentStageIndex + 1);
    }

    // Go to the Previous Stage
    public void PreviousStage()
    {
        player.position = spawnPoint;
        SwitchStage(-1);
    }
}
