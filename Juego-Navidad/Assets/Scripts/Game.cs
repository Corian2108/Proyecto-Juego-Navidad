using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Game{
    public static Game current;
    public Character Boy;

    public Game(){
        Boy = new Character();
    }
}
