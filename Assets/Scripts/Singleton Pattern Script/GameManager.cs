using UnityEngine;
using AK.Singleton;
using System.Collections;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
// This means the game manager is an instance of the singleton class ahhhh i see i see im getting it i am locked in
{
    [SerializeField] public EnemeySpawner enemySpawner;
    public GameObject kirby;
    private int Points; 

    void Start()
    {
        Points = 0; 
        StartCoroutine(PointCount());
        SpawnEnemyRando();
    }

    void Update()
    {
        CheckPlayerAlive();
        Debug.Log(Points);
    }

    private void SpawnEnemyRando()
    {
        int RandomNumber = Random.Range(0, 3);

        Debug.Log("The Random Number = " + RandomNumber);
        if (RandomNumber == 0)
        {
            Debug.Log("Spawn Cappy");
            Instantiate(enemySpawner.CreateEnemy("Cappy").GetEnemyPrefab(), new Vector3(7f, -4f, 0f), Quaternion.identity);
        }
        else if (RandomNumber == 1)
        {
            Debug.Log("Spawn Sirkibble");
            Instantiate(enemySpawner.CreateEnemy("Sirkibble").GetEnemyPrefab(), new Vector3(7f, -4f, 0f), Quaternion.identity);
        }
        else if (RandomNumber == 2)
        {
            Debug.Log("Spawn WaddleDee");
            Instantiate(enemySpawner.CreateEnemy("WaddleDee").GetEnemyPrefab(), new Vector3(7f, -4f, 0f), Quaternion.identity);
        }
        else
        {
            Debug.Log("WRONG!!");
            Debug.Log(RandomNumber);
        }
    }

        

    private void CheckPlayerAlive()
    {
        if (kirby == null)
        {
            Debug.Log("Player is dead (Message from Singleton)");
        }
        else return; 
    }

   private IEnumerator PointCount()
    {
        while(true) 
        {
        Points = Points + 1; 
        yield return new WaitForSeconds(1f);
            }
    }


    void OnApplicationQuit()
    {
        if(kirby == null)
        {
            Debug.Log("Kirbys Current Level Points:" + Points);

        }


        if (kirby != null)
        {
            Debug.Log("Didnt die yay! and also the singleton worked woahhh!!");
            Debug.Log("Kirbys Current Level Points:" + Points);
        }
    }
}
  