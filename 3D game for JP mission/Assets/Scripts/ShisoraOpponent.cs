using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class ShisoraOpponent : OpponentBase
{
    // Start is called before the first frame update
    void Start()
    {
        MyName = "Shisora";
        ChangeChance(30f,30f,40f);
    }

}
