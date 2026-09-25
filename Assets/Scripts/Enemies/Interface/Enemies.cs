using UnityEngine;


    public abstract class Enemies : MonoBehaviour 
    {//orginally not abstract 

    //Waddle Dee
    //Sirkibble
    //Cappy 

   public abstract GameObject GetEnemyPrefab();
   public abstract void SetEnemyPrefab(GameObject enemy);

        public virtual void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                Destroy(other.gameObject);
                Debug.Log("OH GREAT HEAVENS!!!!");
            }
        }


    }