using UnityEngine;

public class Sirkibble : Enemies
{
    public override void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            base.OnCollisionEnter2D(other);
            Debug.Log("Sirkibble SOLOS!!");
        }
    }
}
