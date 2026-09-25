using UnityEngine;

//The factory 
public class EnemeySpawner : MonoBehaviour
{
    [SerializeField] GameObject CappyPrefab;
    [SerializeField] GameObject SirkibblePrefab;
    [SerializeField] GameObject WaddleDeePrefab;

    public Enemies CreateEnemy(string s)
    {
       Enemies enemy = null;
        if(s == "Cappy")
        {
            enemy = new Cappy();
            enemy.SetEnemyPrefab(CappyPrefab);
            return enemy;
        }
        if (s == "Sirkibble")
        {
            enemy = new Sirkibble();
            enemy.SetEnemyPrefab(SirkibblePrefab);
            return enemy;
        }
        if (s == "WaddleDee")
        {
            enemy = new WaddleDee();
            enemy.SetEnemyPrefab(WaddleDeePrefab);
            return enemy;
        }
        else
        {
            Debug.Log("unknown enemy type");
            return null; 
        }

    }
}