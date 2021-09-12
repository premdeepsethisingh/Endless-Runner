using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ; 
public class GameOverPannel : MonoBehaviour
{
    public GameObject gameOverPannel ; 
    public Renderer background ; 
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null){
                            gameOverPannel.SetActive(true);
                             background.GetComponent<LoopingBackground>().enabled = false;
                             gameObject.GetComponent<CameraMovement>().enabled = false;
        }
    }

   public void Restart(){
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          background.GetComponent<LoopingBackground>().enabled = true;
                gameObject.GetComponent<CameraMovement>().enabled = true;
   }
}
