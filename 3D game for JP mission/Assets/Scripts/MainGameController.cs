using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameController : MonoBehaviour
{
    public GameObject OpponentSelection;
    public GameObject HandSelection;
    public GameObject FeedBackGroup;

    private FeedbackController feedbackController;

    private OpponentBase CurrentOpponent = null;


    // Start is called before the first frame update
    void Start()
    {
        feedbackController = FeedBackGroup.GetComponent<FeedbackController>();
        
    }

    public void OpponentSelected(GameObject selected)
    {
        var insideScript = selected.GetComponent<OpponentBase>();
        CurrentOpponent = insideScript;
        
        OpponentSelection.SetActive(false);
        HandSelection.SetActive(true);
        FeedBackGroup.SetActive(true);

        feedbackController.LoadVsText("You VS " + CurrentOpponent.MyName);
    }
   
    public void HandSelected(GameObject hand)
    {
        HandSelection.SetActive(false);
        var enemyHand = CurrentOpponent.GetHandResult();
    
        //ABSTRACTION
        var result = GetWinner(hand.name, enemyHand);
        var resultString = "You play, " + hand.name + ", against the opponents ," + enemyHand + ", so you get a :" + result;

        feedbackController.LoadResponseText(resultString);



    }

    private string GetWinner(string playerHand, string opponentHand)
    {
        if(playerHand == "Rock")
        {
            if(opponentHand == "Paper")
            {
                return "Lose";
            }else if(opponentHand == "Scissor")
                {
                return "Win";
                }else
                    {
                    return "Tie";
                    }
        }

        if (playerHand == "Paper")
        {
            if (opponentHand == "Scissor")
            {
                return "Lose";
            }
            else if (opponentHand == "Rock")
            {
                return "Win";
            }
            else
            {
                return "Tie";
            }
        }

        if (playerHand == "Scissor")
        {
            if (opponentHand == "Rock")
            {
                return "Lose";
            }
            else if (opponentHand == "Paper")
            {
                return "Win";
            }
            else
            {
                return "Tie";
            }
        }

        return "Error";
    }
}
