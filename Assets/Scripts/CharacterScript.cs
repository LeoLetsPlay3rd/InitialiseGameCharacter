using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{

    public string FirstName = "Holly";

    // Start is called before the first frame update
    void Start()
    {
        int Level = 1;
        int NextLevel = MakeCharacter(FirstName, Level);
        
        Debug.LogFormat($"My frog's name is {FirstName}, I am at level {Level} and the next level is {NextLevel}");
    }

    /// <summary>
    /// This method will add 1 onto the value that was assigned to Level in the start method.
    /// </summary>
    /// <param name="FirstName"></param>
    /// <param name="Level"></param>
    /// <returns></returns>
    public int MakeCharacter(string FirstName, int Level)
    {
        return Level += 1;
    }
}
