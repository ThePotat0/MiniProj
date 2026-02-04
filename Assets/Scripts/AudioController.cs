using UnityEngine;

public class AudioController : MonoBehaviour
{
    private void Awake()
    {
        AudioController[] existingObjects = FindObjectsOfType<AudioController>();

        if (existingObjects.Length > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
