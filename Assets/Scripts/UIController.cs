using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour
{
    public Canvas canvas;
    static GameObject itemsGroup;

	// Use this for initialization
	void Start () {
        itemsGroup = canvas.transform.FindChild("ItemsGroup").FindChild("ItemIcons").gameObject;
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void TurnItemVisible(string itemName)
    {

    }

    public static void HideAllItems()
    {
        itemsGroup.SetActive(false);//GetComponent<Renderer>().enabled = false;
    }   
}
