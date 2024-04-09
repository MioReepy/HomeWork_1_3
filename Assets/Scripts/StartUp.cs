using UnityEngine.SceneManagement;
using UnityEngine;

public class StartUp : MonoBehaviour
{
    [SerializeField] private string _uiSceneName;

    private void Start()
    {
        SceneManager.LoadScene(_uiSceneName);
    }
}