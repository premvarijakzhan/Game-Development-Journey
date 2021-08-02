using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    // Update is called once per frame
    void Update()
    {
        //movement always calculate input, direction, add in speed, velocity, movemount

        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        Vector3 velocity = speed * direction;
        Vector3 moveAmount = velocity * Time.deltaTime;

        transform.Translate(moveAmount);
    }
}
