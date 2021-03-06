using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float damage;

    float timer = 5f;
    float time = 0f;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > timer)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            collision.transform.GetComponent<Player>().ReceiveDamage(damage, false);
        }
        Destroy(gameObject);
    }
}
