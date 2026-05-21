using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    // Drag your DoorUI GameObject into this field in the Inspector
    public DoorUI doorUI;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the Player
        if (other.CompareTag("Player"))
        {
            if (doorUI != null)
                doorUI.ShowScreen();
        }
    }
}
