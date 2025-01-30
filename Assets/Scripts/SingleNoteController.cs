using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleNoteController : MonoBehaviour
{
    public Vector3 initialPosition;  
    private float speed = 5f; 
    public bool onJudgeline = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPosition; // Set the initial position
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Judgeline"))
        {
            onJudgeline = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //Debug.Log("detach & destroy\n");
        if (other.gameObject.CompareTag("Judgeline"))
        {
            onJudgeline = false;
            Destroy(gameObject); // Destroy the single note
        }
    }
    
}

