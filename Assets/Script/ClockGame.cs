using UnityEngine;

public class ClockGame : MonoBehaviour
{
    int waitForTime;

    float roundHasStarted;

    float newRoundStartDelay = 3;

    bool roundCurrentlyPlaying;

    // Start is called before the first frame update
    void Start()
    {
        print("Press the spacebar once you think the allocated time is up. ");

        Invoke("SetNewRandomTime", newRoundStartDelay);



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && roundCurrentlyPlaying)
        {
            InputReceived();

        }
    }

    void InputReceived()
    {
        roundCurrentlyPlaying = false;

        //find how long player has been waiting
        float playerWaitedTime = Time.time - roundHasStarted;

        //calculate how off the value is
        float error = Mathf.Abs(waitForTime - playerWaitedTime);


        print("You have waited for " + playerWaitedTime + " seocnds. That's " + error + " seconds off. " + GenerateMessage(error));

        Invoke("SetNewRandomTime", newRoundStartDelay);
    }

    string GenerateMessage(float error)
    {
        string message = "";

        if (error < .15f)
        {
            message = "Outstanding!";
        }
        else if (error < .75f)
        {
            message = "Exceeds the Expectations !";
        }
        else if (error < 1.25f)
        {
            message = "Acceptable";
        }
        else if (error < 1.75f)
        {
            message = "Poor.";
        }
        else
        {
            message = "Dreadful.";
        }

        return message;
    }

    void SetNewRandomTime()
    {
        waitForTime = Random.Range(5, 21);
        roundHasStarted = Time.time;
        roundCurrentlyPlaying = true;



        print(waitForTime + " seconds.");


    }
}
