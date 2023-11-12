using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StopWatch : MonoBehaviour
{
    // The text on display
    public TextMeshProUGUI stopWatch;

    // Current time
    public float time;

    //
    public bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        // Reset the display
        stopWatch.text = time.ToString();       
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying == true)
        {
            // Add time passed to the time variable
            time += Time.deltaTime;

            // Preform math and assign values
            int timeMin = Mathf.FloorToInt(time / 60f);
            int timeSec = Mathf.FloorToInt(time % 60f);
            int timeMil = Mathf.FloorToInt((time * 100f) % 100f);

            // Set the text in the display
            stopWatch.text = timeMin.ToString("00") + ":" +
                timeSec.ToString("00") + ":" +
                timeMil.ToString("00");
        }
    }
}
