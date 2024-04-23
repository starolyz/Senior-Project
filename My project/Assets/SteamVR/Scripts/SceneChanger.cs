using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public string sceneName; // The name of the scene to switch to
    public Button switchButton; // Reference to the button in the Unity Editor

    void Start()
    {
        // Add listener to the button
        switchButton.onClick.AddListener(ChangeScene);
    }

    void ChangeScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneName);
    }
}
