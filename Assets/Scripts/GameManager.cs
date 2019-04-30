using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 3f;
    bool gameHasEnded = false;

    public void endGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game Over!!!");
            restart();
           // Invoke("restart()",restartDelay);
        }
    }

    void restart(){
        // load scene forthe given name
        SceneManager.LoadScene("begin");
        // above with return name our current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
