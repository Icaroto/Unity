using UnityEngine;
using System.Collections;

public class ObjectController : MonoBehaviour {

	public GameObject character;
    public GameObject camera;
    private Vector3 objectSize;
	private Vector3 objectPosition;
	
    private bool moveChar;

    CharController charController;
    ScoreController scoreController;
    UIController uiController;
	
    // Use this for initialization
	void Start () {
        charController = (CharController)character.GetComponent(typeof(CharController));
        scoreController = (ScoreController)camera.GetComponent(typeof(ScoreController));
        uiController = (UIController)camera.GetComponent(typeof(UIController));

        objectPosition = GetComponent<Transform>().position;
		moveChar = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (moveChar && !charController.AmIInteracting())
		{
			charController.Move(objectPosition);
            charController.StartInteract();
		}

	}

    void OnMouseDown()
	{
        if (charController.AmIInteracting()) return;
        //GetComponent<Animator>().SetInteger("ObjectState", 1);
        //GetComponent<Renderer>().material.color = Color.yellow;
        if (Input.GetMouseButtonDown (0)) {
			moveChar = true;
            charController.SetTargetID(GetInstanceID());
        }

	}

    void OnTouchDown()
    {
        if (charController.AmIInteracting()) return;
        moveChar = true;
        charController.SetTargetID(GetInstanceID());
    }
	
    void OnTriggerEnter2D ()
    {
        if (charController.GetTargetID() != GetInstanceID()) return;
        charController.StopMove();
	    moveChar = false;
        if (GetComponent<Transform>().tag == "DoorKey") {
            //Good Animation
            GetComponent<Animator>().SetInteger("ObjectState", 3);
        }
        else
        {
            //Bad animation
            GetComponent<Animator>().SetInteger("ObjectState", 2);
            scoreController.AddBar(1);
        }
            charController.HideCharacter(true);
        GetComponent<PolygonCollider2D>().enabled = false;

    }

    void OnTriggerStay2D()
    {
        OnTriggerEnter2D();
    }
    void AfterAnimationEnds()
    {
        charController.HideCharacter(false);
        charController.StopInteract();
    }
}
