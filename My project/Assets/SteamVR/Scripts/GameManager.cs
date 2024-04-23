using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] objectInstances; // Array to hold different instances of the object
    private int currentIndex = 0; // Index to track the current instance

    public Button switchButton; // Reference to the button in the Unity Editor

    void Start()
    {
        // Add listener to the button
        switchButton.onClick.AddListener(SwitchObjectInstance);

        // Ensure only the first instance is active at start
        for (int i = 0; i < objectInstances.Length; i++)
        {
            if (i == currentIndex)
                objectInstances[i].SetActive(true);
            else
                objectInstances[i].SetActive(false);
        }
    }

    void SwitchObjectInstance()
    {
        // Deactivate the current instance
        objectInstances[currentIndex].SetActive(false);

        // Move to the next instance or loop back to the first one if reached the end
        currentIndex = (currentIndex + 1) % objectInstances.Length;

        // Activate the new instance
        objectInstances[currentIndex].SetActive(true);
    }
}
