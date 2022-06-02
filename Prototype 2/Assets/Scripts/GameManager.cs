using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lifes = 3;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        lifes = 3;
        score = 0;
        Debug.Log("You have " + lifes + " lifes");
        Debug.Log("Your score is " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LessLifes()
    {
        if(lifes > 0)
        {
            lifes =lifes-1;
            Debug.Log("You have " + lifes + " lifes");
            if(lifes == 0)
            {
                Debug.Log("Game over!");
            }
        }
        
    }

    public void ScoreUp()
    {
        score = score + 1;
        Debug.Log("Your score is " + score);
    }
}
