using UnityEngine.SceneManagement;
using UnityEngine;

public class StartUp : MonoBehaviour
{
    [SerializeField] private string _uiSceneName;

    private void Start()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(_uiSceneName);
        }
    }
}