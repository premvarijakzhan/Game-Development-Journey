using UnityEngine;

public class Collision_Player : MonoBehaviour
{
    Rigidbody myRigibody;
    public float speed = 6;
    Vector3 velocity;

    int coinCount;

    // Start is called before the first frame update
    void Start()
    {
        myRigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        velocity = direction * speed;
    }

    private void FixedUpdate()
    {
        myRigibody.position += velocity * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider TriggerCollider)
    {
        print(TriggerCollider.gameObject.name);

        if (TriggerCollider.tag == "Coin")
        {
            Destroy(TriggerCollider.gameObject);
            coinCount++;
            print(coinCount);
        }
    }
}
