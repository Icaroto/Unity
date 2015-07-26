using UnityEngine;
using System.Collections;
using AnnoyingFlatmate.Enum;

public class ObjectController : MonoBehaviour {

	public GameObject character;

	private Vector3 size;
	private Vector3 position;
	private bool shouldmove;
    private bool animationFinished;    
	// Use this for initialization
	void Start () {
		size = GetComponentInParent<Transform> ().localScale;
        //Debug.Log("Startou com " + size);
		position = GetComponent<Transform>().position;
		character.GetComponent<Animator>().SetBool("isMoving", false);
		shouldmove = false;
        animationFinished = false;
//		Debug.Log (size);
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
        //ObjectState.IDLE;
		GetComponent<Renderer>().material.color = Color.yellow;// * Time.deltaTime;
        Vector3 newsize = size + new Vector3 (0.5f, 0.5f, 0.5f);
        GetComponentInParent<Transform> ().localScale = newsize;
        //Debug.Log("Tentou aumentar para " + newsize);
		if (Input.GetMouseButtonDown (0)) {
			character.GetComponent<Animator>().SetBool("isMoving", true);
			shouldmove = true;
		}
			
	}
	
	void OnMouseExit ()
	{
		GetComponent<Renderer>().material.color = Color.white;
		GetComponent<Transform>().localScale = size;
	}


	void OnTriggerEnter2D (){
        GetComponent<Animator>().SetBool("startAnimation", true);
        CharController script = (CharController) character.GetComponent(typeof(CharController));
        script.HideCharacter(true);
    }

    void FinishedAnimation()
    {
        Debug.Log("entroufinishedanimation");
        animationFinished = true;
    }
}
