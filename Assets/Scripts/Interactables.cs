
using UnityEngine;
using UnityEngine.Jobs;

// Class for all interactable items 

public class Interactables : MonoBehaviour
{
    public float radius = 3f;

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
