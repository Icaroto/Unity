using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour
{

    private bool moving;
    private bool interacting;

    private int targetID;

    private Vector3 newPosition;

	void Update() {
        if (moving)
        {
            float step = 2 * Time.deltaTime;
            GetComponent<Transform>().position = Vector3.MoveTowards(GetComponent<Transform>().position, newPosition, step);
        }
	}
	// Use this for initialization
	void Start () {
	
	}

    public void HideCharacter(bool isInteracting)
    {
        gameObject.SetActive(!isInteracting);
    }

    public void Move(Vector3 toWhere)
    {
        moving = true;
        newPosition = toWhere;
        GetComponent<Animator>().SetBool("isMoving", true);
    }

    public void StopMove()
    {
        moving = false;
        GetComponent<Animator>().SetBool("isMoving", false);
    }

    public bool AmIMoving()
    {
        return moving;
    }

    public void StartInteract()
    {
        interacting = true;
    }

    public void StopInteract()
    {
        interacting = false;
    }

    public bool AmIInteracting()
    {
        return interacting;
    }

    public void SetTargetID(int id)
    {
        targetID = id;
    }

    public int GetTargetID()
    {
        return targetID;
    }




}
