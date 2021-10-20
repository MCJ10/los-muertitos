using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] animalPrefab;
    private float randomRangeX = 5;

    private float timer = 0.0f;
    private float timelapse = 3.0f;



    private float startDelay = 4;
    private float spawnInterval = 5;

    // Update is called once per frame
   
  

    private void LateUpdate()
    {
        timer += Time.deltaTime;
        if (timer > timelapse)
        {
            timer -= timelapse;
            InvokeRepeating("sweetsSpanwManager", startDelay, spawnInterval);
        }
    }
    public void sweetsSpanwManager()
    {

        UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(transform.position.x, UnityEngine.Random.Range( -randomRangeX, randomRangeX));
        int animalIndex = UnityEngine.Random.Range(0, animalPrefab.Length);
        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);

    }
}
