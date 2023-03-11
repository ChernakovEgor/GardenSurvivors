using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveState
{
    private const string HighScoreKey = "HighScore";
   public static void SetHighScore(int newHighScore) {
        PlayerPrefs.SetInt(HighScoreKey, newHighScore);
   }

   public static int GetHighScore() {
        int highScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        return highScore;
   }
}
