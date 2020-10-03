using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set; }

    void Awake()
    {
        Debug.Assert(instance == null);
        instance = this;
    }

    // Go to the Next Stage
    public void NextStage()
    {
        Debug.Log("Next");
    }

    // Go to the Previous Stage
    public void PreviousStage()
    {
        Debug.Log("Previous");
    }
}
