using UnityEngine;

//product A 
public class Cappy : Enemies 
{
    //THIS WILL BE THE SAME FOR THE OTHER ENEMIES TOO
    [SerializeField] GameObject EnemyPrefab;

    public override void SetEnemyPrefab(GameObject enemy)
    {
        EnemyPrefab = enemy;
    }

    public override GameObject GetEnemyPrefab()
    {
        return EnemyPrefab; 
    }


    public override void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            base.OnCollisionEnter2D(other);
            Debug.Log("Cappy SOLOS!!");
        }
    }

}
