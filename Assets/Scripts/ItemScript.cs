using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public int heathPack = 10;
    public GameObject empty_object;
    private void OnCollisionEnter(Collision collision)
    {
        Player playerScript = collision.gameObject.GetComponent<Player>();
        playerScript.updateheath(heathPack);
        Destroy(empty_object);
    }
}
