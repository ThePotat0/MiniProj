using System.Collections;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private bool _landed = false;
    private Vector3 _target;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !_landed)
        {
            if (!_landed)
            {
                _landed = true;
                _target = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);
            }
            StartCoroutine(LandMover());
        }
    }

    private IEnumerator LandMover()
    {
        while (transform.position != _target)
        {
            transform.position = Vector3.Lerp(transform.position, _target, 4 * Time.deltaTime);
            yield return null;
        }
        GetComponent<PlatformController>().enabled = false;
    }
}
