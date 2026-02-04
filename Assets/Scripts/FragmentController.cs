using UnityEngine;

public class FragmentController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            FindObjectOfType<GameController>().FragmentsCount++;
            Destroy(gameObject);
        }
    }
}
