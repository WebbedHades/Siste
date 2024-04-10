using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other == null)
            return;
        if (other.TryGetComponent<ITalable>(out var talable))
        {
            talable.ReducirVida(1);
            if (talable.vida <= 0)
            {
                other.gameObject.SetActive(false);
            }
            Debug.Log($"Talanding{talable.vida}");
        }

    }
}
