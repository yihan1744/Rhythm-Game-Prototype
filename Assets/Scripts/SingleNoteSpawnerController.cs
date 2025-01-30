using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleNoteSpawnerController : MonoBehaviour
{
    //private int count = 0;
    public GameObject singleNotePrefab;
    //private float spawnInterval = 0.5f;
    public List<GameObject> singleNotes = new List<GameObject>(); // Collection of single note objects
    
    /*void Start()
    {
        StartCoroutine(SpawnSingleNotes());
    }*/
    
    void Update()
    {
        
    }

    /*
    IEnumerator SpawnSingleNotes()
    {
        while (true)
        {
            GameObject newSingleNote =Instantiate(singleNotePrefab, singleNotePrefab.transform.position, Quaternion.identity);
            singleNotes.Add(newSingleNote); 
            yield return new WaitForSeconds(spawnInterval);
        }
    }*/

    public void SpawnSingleNote() //called in SongController script
    {
        GameObject newSingleNote =Instantiate(singleNotePrefab, singleNotePrefab.transform.position, Quaternion.identity);
        singleNotes.Add(newSingleNote); 
        /*count +=1;
        Debug.Log(count);*/
    }
}
