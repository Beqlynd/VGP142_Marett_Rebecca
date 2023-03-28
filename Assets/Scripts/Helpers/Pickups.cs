using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public Animator animator;
    public string pickup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);

            if (animator != null)
            {
                animator.SetBool(pickup, true);
            }
        }
    }
}
