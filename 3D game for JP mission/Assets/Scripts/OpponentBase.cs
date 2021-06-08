using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class OpponentBase : MonoBehaviour
{

    private string MainName = "none";
    //ENCAPSULATION
    public string MyName
    {
        get { return MainName; }
        set {
            if (value.Length < 12)
            {
                MainName = value;
            }
        }
    }
   
    protected float RockChance = 33.3f;
    protected float PaperChance = 33.3f;
    protected float ScissorChance = 33.3f;

    //POLYMORPHISM
    public virtual void ChangeChance(float rock, float paper, float scissor)
    {
        RockChance = rock;
        PaperChance = paper;
        ScissorChance = scissor;
    }

    //POLYMORPHISM
    public virtual void ChangeChance(Vector3 rps)
    {
        RockChance = rps.x;
        PaperChance = rps.y;
        ScissorChance = rps.z;
    }

    public virtual string GetHandResult()
    {
        var roll = Random.Range(0f,99.9f);
        if(roll < (RockChance))
        {
            return "Rock";
        }else
            if (roll < (RockChance + PaperChance))
            {
                return "Paper";
            }else
                {
                    return "Scissor";
                }
    }










}
