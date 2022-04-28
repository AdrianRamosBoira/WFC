using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public Transform shotPos;

    private void OnTriggerEnter(Collider other)
    {
        OntriggerEnterAndStay(other);
    }

    private void OnTriggerStay(Collider other)
    {
        OntriggerEnterAndStay(other);
    }

    private void OntriggerEnterAndStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 dir = new Vector3(other.transform.position.x - shotPos.position.x, 0f, transform.position.z - shotPos.position.z);
            dir = dir.normalized;

            Vector3 originalPos = new Vector3(shotPos.position.x, shotPos.position.y, shotPos.position.z);

            Debug.DrawRay(shotPos.position, dir * 5f, Color.red, 10f);
            RaycastHit hit;
            if (Physics.Raycast(shotPos.position, dir, out hit) && hit.transform.tag == "Player")
            {
                GetComponentInParent<EnemyAgent>().PlayerDetected();
            }
        }
    }
}
