using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class TrackManager2 : MonoBehaviour
{
    public GameObject[] trackSegments;

    public float score2;

    public float startingSpeed = 5f;
    public float acceleration = 0.5f;

    private float speed;

    public float maxSpeed = 15f;

    public float segmentWidth = 1f;

    //Limits how fast the player can go
    public float speedCap = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Mathf.Min(speed + acceleration * Time.deltaTime, maxSpeed);

        if (speed > speedCap){ speed = speedCap; }
        if (speed == 0)
        {
            startingSpeed = 5f;
            acceleration = 0.5f;
        }

        if (Input.GetKey(KeyCode.D)) {
            foreach (GameObject TrackSegment in trackSegments)
            {
                TrackSegment.transform.position += Vector3.left * speed * Time.deltaTime;
                score2 = score2 + (speed * 1);
                // Check if segment has left the screen
                if (TrackSegment.transform.position.x < -17)
                {
                    // Find the rightmost segment
                    float rightmost = GetRightmostSegment();

                    // Reposition the segment
                    TrackSegment.transform.position = new Vector3(
                        rightmost + segmentWidth,
                        TrackSegment.transform.position.y,
                        TrackSegment.transform.position.z
                    );
                }
            }  
        }
        if (Input.GetKeyUp(KeyCode.D)) { speed = 0; }
    }
    float GetRightmostSegment()
    {
        float rightmost =
            trackSegments[0].transform.position.x;

        foreach (GameObject segment in trackSegments)
        {
            if (segment.transform.position.x > rightmost)
            {
                rightmost = segment.transform.position.x;
            }
        }


        return rightmost;
    }
    public void ResetSpeed()
    {
        speed = startingSpeed;
    }
}
