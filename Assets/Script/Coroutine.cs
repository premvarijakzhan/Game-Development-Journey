using System.Collections;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    IEnumerator currentMoveCoroutine;

    public Transform[] path;

    // Start is called before the first frame update
    void Start()
    {
        string[] messages = { "Hi", "Welcome", "To", "The", "Game" };

        StartCoroutine(PrintMessage(messages, .5f));

        StartCoroutine(FollowPath());
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentMoveCoroutine != null)
            {
                StopCoroutine(currentMoveCoroutine);
            }

            currentMoveCoroutine = Move(Random.onUnitSphere * 5, 8);
            StartCoroutine(currentMoveCoroutine);
        }
    }

    IEnumerator FollowPath()
    {
        foreach (var waypoints in path)
        {
            yield return Move(waypoints.position, 8);
        }
    }

    IEnumerator Move(Vector3 destination, float speed)
    {
        while (transform.position != destination)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            yield return null;

        }
    }

    IEnumerator PrintMessage(string[] messages, float delay)
    {

        foreach (var message in messages)
        {
            print(message);
            yield return new WaitForSeconds(delay);
        }

    }
}
