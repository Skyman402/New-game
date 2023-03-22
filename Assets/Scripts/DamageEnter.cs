using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnter : MonoBehaviour
{
    public int damage = 5;
    private void OnCollisionEnter(Collision collision)
    {
       Player playerScript = collision.gameObject.GetComponent<Player>();
       playerScript.updateheath(-damage);
    }
}
