using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class OnColliderEnter : MonoBehaviour
{
    private int doorCollisionCounter = 0;

    void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.tag == "Door")
       {
            doorCollisionCounter++;
            Debug.Log(doorCollisionCounter);
        }   
    }

    public int GetDoorCollisionCount()
    {
        return doorCollisionCounter;
    }
}
