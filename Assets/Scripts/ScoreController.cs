using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
    public Text annoyingLevel;
    private int currentBarLevel;
    // Use this for initialization
	void Start () {
        currentBarLevel = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    if (isBarFull()){
            //Execute EndGame
        }
	}

    public void AddBar(int howManyBars){
        currentBarLevel = currentBarLevel + howManyBars;
        annoyingLevel.text = "Annoying Level: " + currentBarLevel;
    }

    bool isBarFull()
    {
        return false;
    }

    void EndGame()
    {

    }
}
