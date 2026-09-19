using UnityEngine;

public class Enemies : MonoBehaviour
{
    //Waddle Dee
    //Sirkibble
    //Cappy 

    public virtual void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Debug.Log("OH GREAT HEAVENS!!!!");
        }
    }


}
