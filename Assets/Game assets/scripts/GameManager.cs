using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 [SerializeField] GameObject startCanvas;
 [SerializeField] GameObject finishCanvas;
 [SerializeField] GameObject questionCanvas;
 [SerializeField]Game gameClass;
 [SerializeField]FinalScene finalScene;


    void Start()
    {   
        startCanvas.SetActive(true);
        questionCanvas.SetActive(false);
        finishCanvas.SetActive(false);
        
        
    }

    private void Update()
    {
        GameCompleteCheck();
    }


    public void StartGame()
    {
        startCanvas.SetActive(false);
        questionCanvas.SetActive(true);
    }

    public void GameCompleteCheck()
    {
         if(gameClass.allQuestions.Count<=0)
        {
            questionCanvas.SetActive(false);
            finishCanvas.SetActive(true);
            finalScene.ShowFinalText();
            
        }
    }
   


   public void StartOverLevel()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }




}
