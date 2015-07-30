using UnityEngine;
using System.Collections;
using AnnoyingFlatmate.Enum;

public class ObjectController : MonoBehaviour {

	public GameObject character;

	private Vector3 size;
	private Vector3 position;
	private bool shouldmove;
    CharController charController;

	// Use this for initialization
	void Start () {
        charController = (CharController)character.GetComponent(typeof(CharController));
		position = GetComponent<Transform>().position;
		character.GetComponent<Animator>().SetBool("isMoving", false);
		shouldmove = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (shouldmove) {
			float step = 2 * Time.deltaTime;
			character.GetComponent<Transform>().position = Vector3.MoveTowards(character.GetComponent<Transform>().position,position, step);
		}
	}

	void OnMouseOver ()
	{
		GetComponent<Renderer>().material.color = Color.yellow;// * Time.deltaTime;
        GetComponent<Animator>().SetInteger("ObjectState", 1);
        if (Input.GetMouseButtonDown (0)) {
			character.GetComponent<Animator>().SetBool("isMoving", true);
			shouldmove = true;
		}
	}
	
	void OnMouseExit ()
	{
        GetComponent<Animator>().SetInteger("ObjectState", 0);
		GetComponent<Renderer>().material.color = Color.white;
	}


	void OnTriggerEnter2D (){
        shouldmove = false;
        GetComponent<Animator>().SetInteger("ObjectState", 2);
        GetComponent<PolygonCollider2D>().enabled = false;
        charController.HideCharacter(true);
    }

    void AfterAnimationEnds()
    {
        charController.HideCharacter(false);
    }
}
