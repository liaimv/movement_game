using UnityEngine;
using System.Collections;

public class GravityAttractor : MonoBehaviour
{
    public float gravity = -10f;
    public float maxAttractionDistance = 10f;

    public void Attract(Transform body)
    {
        Vector3 targetDirection = (body.position - transform.position).normalized; //direction between body and the center of the planet
        Vector3 bodyUp = body.up;
        float distance = Vector3.Distance(body.position, transform.position);

        if (distance <= maxAttractionDistance)
        {
            body.rotation = Quaternion.FromToRotation(bodyUp, targetDirection) * body.rotation; //applying the rotation
            body.GetComponent<Rigidbody>().AddForce(targetDirection * gravity); //applying downwards force to simulate gravity
        }
    }
}
