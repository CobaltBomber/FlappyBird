using UnityEngine;
using System.Collections;
using System.Security.Cryptography;
using System.Diagnostics;

public class ColumnPool : MonoBehaviour
{
    public GameObject columnPrefab;                                    
    public int columnPoolSize = 5;                                    
    public float spawnRate = 4f;                                    
    public float columnMin = -5;                                    
    public float columnMax = 5f;                                    
    public float columnMin1 = -2f;                                    
    public float columnMax1 = 3.5f;
    public float columnMin2 = -1f;
    public float columnMax2 = 3f;
    public float columnMin3 = 0f;
    public float columnMax3 = 1.5f;
    public float columnMin4 = 0f;
    public float columnMax4 = 0f;
    public int difficulty = 0;

    private GameObject[] columns;                                    
    private int currentColumn = 0;                                    

    private Vector2 objectPoolPosition = new Vector2(-15, -15);        
    private float spawnXPosition = 15f;

    private float timeSinceLastSpawned;


    void Start()
    {
        timeSinceLastSpawned = 0f;

        
        columns = new GameObject[columnPoolSize];
         
        for (int i = 0; i < columnPoolSize; i++)
        {
            
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate && difficulty == 0)
        {
            timeSinceLastSpawned = 0f;

            
            float spawnYPosition = Random.Range(columnMin4, columnMax4);

            
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            
            currentColumn++;
            

            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
                difficulty = 1;
            }
        }

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate && difficulty == 1)
        {
            timeSinceLastSpawned = 0.5f;

            
            float spawnYPosition = Random.Range(columnMin3, columnMax3);

            
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            
            currentColumn++;


            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
                difficulty = 2;
            }
        }


        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate && difficulty == 2)
        {
            timeSinceLastSpawned = 1f;

            
            float spawnYPosition = Random.Range(columnMin2, columnMax2);

            
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            
            currentColumn++;

            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
                difficulty = 3;
            }

        }

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate && difficulty == 3)
        {
            timeSinceLastSpawned = 2f;

            
            float spawnYPosition = Random.Range(columnMin1, columnMax1);

            
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            
            currentColumn++;

            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
                difficulty = 4;
            }

        }

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate && difficulty == 4)
        {
            timeSinceLastSpawned = 2f;

            
            float spawnYPosition = Random.Range(columnMin, columnMax);

            
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            
            currentColumn++;

            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
                difficulty = 4;
            }

        }




    }
}