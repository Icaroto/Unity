using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour
{
    public Canvas canvas;
    
    // Use this for initialization
	void Start () {
        HideAllItems();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TurnItemVisible(string itemName)
    {

    }

    public void HideAllItems()
    {
        canvas.transform.FindChild("ItemsGroup").FindChild("ItemIcons").gameObject.SetActive(false);
    }   
}
