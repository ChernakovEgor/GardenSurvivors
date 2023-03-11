using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement; //VAZHNO

public class LoseScreen : MonoBehaviour
{
    public void Restart() {
        //SceneManager.LoadScene(0);
        Game.RestartLevel();
    }
    
}
