using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class OpponentBase : MonoBehaviour
{
    public string shownName { get; set; } = "Anonymous";

    private string myQuip = "Hello, guess and win!";

    private float RockChance = 33.3f;
    private float PaperChance = 33.3f;
    private float ScissorChance = 33.3f;

    public void ChangeChance(float rock, float paper, float scissor)
    {
        RockChance = rock;
        PaperChance = paper;
        ScissorChance = scissor;
    }

    public string GetHandResult()
    {
        var roll = Random.Range(0f,99.9f);
        if(roll < (RockChance))
        {
            return "rock";
        }else
            if (roll < (RockChance + PaperChance))
            {
                return "paper";
            }else
                {
                    return "scissor";
                }
    }










}
