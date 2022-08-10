using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Game : MonoBehaviour
{ 
  questionSO puzzleCurrentQuestion;
 [SerializeField] TextMeshProUGUI questionText;
 [SerializeField] GameObject [] buttons;
 public List<questionSO> allQuestions = new List<questionSO>();
 private Score score;



    void Start()
    {
       GetNewQuestion();
       score=FindObjectOfType<Score>();
    }
 

   private void ShowQuestion()
    {
     questionText.text=puzzleCurrentQuestion.question;

        for (int i=0;i<buttons.Length; i++)
        {
          buttons[i].GetComponentInChildren<TextMeshProUGUI>().text= puzzleCurrentQuestion.questionAnswers[i];

        }
    }



 public void OnButtonClicked(int number) //method for getting correct answer
 {
     if (number==puzzleCurrentQuestion.correctAnswer)
     {
       score.correctAnswer++;
       score.calculateScore();
       buttons[number].GetComponent<Image>().color=Color.green;
      
     }
     else
     {
         buttons[number].GetComponent<Image>().color=Color.red;
     }
     SetButtonInteractible(false);
     StartCoroutine(CouritineForNewQuestions());  
    
  
 }

 private void SetButtonInteractible(bool state)
 {
   for (int i =0; i<buttons.Length;i++)
   {
       buttons[i].GetComponent<Button>().interactable=state;
   }
 }
  

  private void GetNewQuestion()
  {  
      if (allQuestions.Count>0)
    {
      SetButtonInteractible(true);
      ResetButtonCollors();
      RandomizeQuestions();
      ShowQuestion();
    }

  }

  private void ResetButtonCollors()
  {
      for (int i=0; i<buttons.Length;i++)
      {
          buttons[i].GetComponent<Image>().color=Color.white;
      }
  }

  void RandomizeQuestions()
    {
        int random  = Random.Range(0, allQuestions.Count);
        puzzleCurrentQuestion = allQuestions[random];

        if (allQuestions.Contains(puzzleCurrentQuestion))
        {
            allQuestions.Remove(puzzleCurrentQuestion);
        }
    }


  IEnumerator CouritineForNewQuestions()
  {
      yield return new WaitForSeconds(2);
      GetNewQuestion();
  }



}
