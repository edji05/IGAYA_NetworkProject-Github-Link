using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkConnect : MonoBehaviour
{
    [SerializeField] private Button hostButton;

    private void Start()
    {
        // Listen for the button click to start the host session
        hostButton.onClick.AddListener(() => {
            NetworkManager.Singleton.StartHost();

            // Hide the button once clicked
            hostButton.gameObject.SetActive(false);
        });
    }
}