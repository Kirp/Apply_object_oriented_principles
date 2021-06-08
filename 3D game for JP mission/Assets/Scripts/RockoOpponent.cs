using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class RockoOpponent : OpponentBase
{
    


    void Start()
    {
        MyName = "Rocko";
        ChangeChance(40f,30f,30f);
    }


}
