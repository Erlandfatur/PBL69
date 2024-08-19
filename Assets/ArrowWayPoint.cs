using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowWayPoint : MonoBehaviour
{
    public Transform player;     // Referensi ke transform player
    public Transform portal;     // Referensi ke transform portal
    public float heightOffset = 2f; // Jarak vertikal arrow dari kepala player

    private void Update()
    {
        if (player != null && portal != null)
        {
            // Posisi panah berada di atas kepala player dengan offset
            Vector3 arrowPosition = player.position + Vector3.up * heightOffset;
            transform.position = arrowPosition;

            // Menghitung arah dari player menuju portal
            Vector3 directionToPortal = portal.position - transform.position;
            directionToPortal.y = 0; // Mengabaikan sumbu y agar panah tetap horizontal

            // Mengatur rotasi panah agar menghadap portal
            if (directionToPortal != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(directionToPortal);
                transform.rotation = targetRotation;
            }
        }
    }
}
