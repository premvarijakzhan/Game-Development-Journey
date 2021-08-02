using UnityEngine;

public class ExerciseScript : MonoBehaviour
{
    int frameCount;
    int x = 3;
    int y = 8;



    // Start is called before the first frame update
    void Start()
    {
        print("Start");

        float distance = DistanceCalculatedByPythogarasTheoram(0.5f, 5.0f, 2.0f, 10.0f);
        print("Distance is " + distance);

        bool a = x == y;
        print(a);
        bool b = x != y;
        print(b);
    }

    // Update is called once per frame
    void Update()
    {
        frameCount += 1;

        //print("Update");
        // print("Frame Count is: " + frameCount);
    }

    //calculaqte distance by using pythogaras theorem

    float DistanceCalculatedByPythogarasTheoram(float x1, float x2, float y1, float y2)
    {
        float deltaX = x2 - x1;
        float deltaY = y2 - y1;
        float squaredDelta = deltaX * deltaX + deltaY * deltaY;
        float distance = Mathf.Sqrt(squaredDelta);
        return distance;
    }
}
