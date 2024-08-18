using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapScript : MonoBehaviour
{
    public GameObject Player;

    private void LateUpdate() {
        transform.position = new Vector3(Player.transform.position.x,8, Player.transform.position.z);
    }
   
    // Start is called before the first frame update
    
}
