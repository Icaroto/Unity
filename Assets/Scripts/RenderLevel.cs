using UnityEngine;
using System.Collections;

public class RenderLevel : MonoBehaviour {
	// Use this for initialization

    UIController uiController;

    void Start () {
        //uiController = (UIController)GetComponent(typeof(UIController));
        
        UIController.HideAllItems();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void PlaceObjects()
    {
        // Create floor
        // Create walls
        // Create doors
        // Create room items
    }
}
