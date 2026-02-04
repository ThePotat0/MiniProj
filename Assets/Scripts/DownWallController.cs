using UnityEngine;

public class DownWallController : MonoBehaviour
{
    [SerializeField] private GameObject _startingPosition;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            collision.transform.position = _startingPosition.transform.position;
        }
    }
}
