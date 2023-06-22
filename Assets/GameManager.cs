using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void EndGame()
    {
        // Действия при окончании игры (например, перезапуск уровня)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
