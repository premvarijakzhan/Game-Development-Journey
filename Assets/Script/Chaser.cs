using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Transform targetTransform;
    public float speed = 7;

    // Update is called once per frame
    void Update()
    {
        //calcutaing direction between own object and target object
        //substract the position of target with ours to get a displcement
        //normalized it to find direction then calculate velocity

        Vector3 displacementFromTarget = targetTransform.position - transform.position;
        Vector3 directionToTarget = displacementFromTarget.normalized;
        Vector3 velocity = directionToTarget * speed;

        //  Vector3 moveAmount = velocity * Time.deltaTime;

        float distanceToTarget = displacementFromTarget.magnitude;

        if (distanceToTarget > 1.5f)
        {
            transform.Translate(velocity * Time.deltaTime);
        }



    }
}
