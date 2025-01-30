using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int score=0;
    public SingleNoteSpawnerController singleNoteSpawnerController; // Reference to the single note spawner controller script
    
    // Start is called before the first frame update
    void Start()
    {
        singleNoteSpawnerController = FindObjectOfType<SingleNoteSpawnerController>(); // Get the reference to SingleNoteSpawnerController
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject item in singleNoteSpawnerController.singleNotes)
        {
            if (item != null && item.GetComponent<SingleNoteController>().onJudgeline==true && Input.GetMouseButtonDown(0)) 
            {
                HandleMouseClick(item);
            }
        }
    }

    private void HandleMouseClick(GameObject singleNote)
    {
        // Check if the single note object exists and hasn't been destroyed
        if (singleNote != null)
        {
            IncreaseScore();
            Destroy(singleNote); // Destroy the single note object
        }
    }

    private void IncreaseScore() // Increase the player's score by 1
    {
        score++;
        Debug.Log("Score: " + score); // Display new score
    }
}