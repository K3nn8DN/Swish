using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text scoretext;
    public GameObject playbutton;
    public GameObject gameover;
    public Text text;
    public player player;

    private int score;
    

    private void  Awake() {
      Pause();
      Application.targetFrameRate=60;
    }

    public void PLay(){
      score=0;
      scoretext.text= score.ToString();
      playbutton.SetActive(false);
      gameover.SetActive(false);
      text.text="";

      Time.timeScale=1f;
      player.enabled=true;
      hoops[] hoops= FindObjectsOfType<hoops>();
       
      for (int i=0;i<hoops.Length;i++){
        Destroy(hoops[i].gameObject);
      }
    }
     

    public void Pause(){

      Time.timeScale=0f;
      player.enabled=false;
    }
    public void GameOver(){

       gameover.SetActive(true);
       playbutton.SetActive(true);
       text.text="Go through the hoop,Dont hit the rim";

       Time.timeScale=0.1f;
    
       Pause();
    }

    public void IncreaseScore(){
      score++;
      scoretext.text=score.ToString();
    }

    public void Quit(){
      Application.Quit();
    }
}

