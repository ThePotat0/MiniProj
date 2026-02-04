using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int FragmentsCount = 0;

    private void Update()
    {
        if (FragmentsCount == 4) 
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}
