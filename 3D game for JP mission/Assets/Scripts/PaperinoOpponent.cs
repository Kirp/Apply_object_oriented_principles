using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//INHERITANCE
public class PaperinoOpponent : OpponentBase
{
    void Start()
    {
        MyName = "Paperino";
        ChangeChance(30f, 40f, 30f);
    }
}
