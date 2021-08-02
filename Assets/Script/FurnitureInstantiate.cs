using UnityEngine;

public class FurnitureInstantiate : MonoBehaviour
{
    public GameObject chairPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
            Vector3 randomSpawnRotation = Vector3.up * Random.Range(0, 360);

            GameObject chair = (GameObject)Instantiate(chairPrefab, randomSpawnPosition, Quaternion.Euler(randomSpawnRotation));

            chair.transform.parent = transform;
        }
    }
}
