using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    //[SerializeField] private TextMeshProUGUI inputScore; //int.Parse(inputScore.text)
    [SerializeField] private TMP_InputField inputName;
    [SerializeField] private TMP_InputField inputScore;

    public UnityEvent<string, int> submitScoreEvent;
    public void SubmitScore()
    {
        // Get reference to input name & score.
        // Leaderboard is listening for event that contains string & int.
        // Event called when submit button is clicked.
        submitScoreEvent.Invoke(inputName.text, int.Parse(inputScore.text));
    }
}
