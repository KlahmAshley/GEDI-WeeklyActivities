using UnityEngine;

public class WinLoseConditions : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("KIRBY HAS DIED </3");
        }

        if(other.gameObject.tag == "Win")
        {
            Debug.Log("KIRBY WINS!!!");
        }

    }

}
