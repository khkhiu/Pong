using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;

    public Text _computerScoreText;
    public Text _playerScoreText;

    public Square _square;
    public Paddle _playerPaddle;
    public Paddle _computerPaddle;

    private void Update()
    {
        // Use R key to reset game
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1); // Scene 1 == Game, Scene 0 == Main Menu
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PlayerScore()
    {
        _playerScore++;
        this._playerScoreText.text = _playerScore.ToString();
        Reset();
    }

    public void ComputerScore()
    {
        _computerScore++;
        this._computerScoreText.text = _computerScore.ToString();
        Reset();
    }

    private void Reset()
    {
        this._playerPaddle.ResetPosition();
        this._computerPaddle.ResetPosition();
        // FX found in Square.cs
        this._square.ResetPosition();
        this._square.AddStartingForce();
    }
}
