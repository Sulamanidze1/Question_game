using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScene : MonoBehaviour
{ 

   [SerializeField] Score finalScore;
    [SerializeField] TextMeshProUGUI finalText;

    void Start()
    {
      // finalScore=FindObjectOfType<Score>();
    }



  public void ShowFinalText()
  {
   switch (finalScore.correctAnswer)
        {
        case 0:
         finalText.text="Terrible!\n You scored 0 out of 5";
            break;
        case 1:
            finalText.text="Terrible!\n You scored 1 out of 5";
            break;
        case 2:
            finalText.text="Good Job!\n You scored 2 out of 5";
            break;
        case 3:
            finalText.text="Good Job!\n You scored 3 out of 5";
            break;
        case 4:
           finalText.text="Good Job!\n You scored 4 out of 5";
            break;
         case 5:
           finalText.text="Great Job!\n You scored 5 out of 5";
            break;
       }

  }
   
}
