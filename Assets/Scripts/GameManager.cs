using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int scoreCounter;
    public int scoreCounterSubtract;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void LevelComplete()
    {
        endText();
    }
    public void endText()
    {
        if (scoreCounter == 10)
        {
            print("You did it! Make your way to the vault");
        }
        else if (scoreCounter == 8)
        {
            print("Not bad young one. Not bad.");
        }
        else if (scoreCounter == 6)
        {
            print("Wait is this really your best?");
        }
        else if (scoreCounter == 4)
        {
            print("This is getting sad...");
        }
        else if (scoreCounter == 2)
        {
            print("This has swung around to funny again.");
        }
        else if (scoreCounter == 0)
        {
            print("Lose the hands someone else needs them.");
        }
    }
}
