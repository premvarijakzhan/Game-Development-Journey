using UnityEngine;

public class Trigonometry : MonoBehaviour
{
    public float angleInDegree;





    // Update is called once per frame
    void Update()
    //degree2rad = Pi/180
    {
        Vector3 direction = new Vector3(Mathf.Sin(angleInDegree * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegree * Mathf.Deg2Rad));

        Debug.DrawRay(transform.position, direction * 3, Color.green);

        Vector3 inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

        transform.Translate(inputDirection * Time.deltaTime * 5, Space.World);

        float inputAngle = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg;
        transform.eulerAngles = Vector3.up * inputAngle;


    }
}
