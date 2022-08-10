using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{ 
    public int correctAnswer=0;
    public int maxQuestionNumber=5;
    TextMeshProUGUI scoreText;

private void Start()
 {
    scoreText=GetComponent<TextMeshProUGUI>();

  
 }

public void calculateScore()
{
scoreText.text=correctAnswer.ToString()+"/"+maxQuestionNumber.ToString();
}

}
