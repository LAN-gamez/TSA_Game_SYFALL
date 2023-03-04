using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameCreater : MonoBehaviour 
{
    private int playerCount;
    public void HandleInputData(int val)
    {
        playerCount = val + 3;
    }
}
