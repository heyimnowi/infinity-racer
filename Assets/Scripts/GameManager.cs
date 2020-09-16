﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void EndGame() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            Debug.Log("END GAME");
            Invoke("Restart", restartDelay);
        }
    }

    public void CompleteLevel() {
        //completeLevelUI.SetActive(true);
    }

    public void Restart() {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
