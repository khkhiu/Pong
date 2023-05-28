using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;

    public Square _square;

    public void PlayerScore()
    {
        _playerScore++;
        Debug.Log("Player score");
        this._square.ResetPosition();
    }

    public void ComputerScore()
    {
        _computerScore++;
        Debug.Log("Computer score");
        this._square.ResetPosition();
    }
}
