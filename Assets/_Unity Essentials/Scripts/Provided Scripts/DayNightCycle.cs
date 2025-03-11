using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Time in seconds for a full day-night cycle.")]
    public float dayDuration = 60f;  // Seconds for one full day cycle

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed so that the light rotates 360 degrees in 'dayDuration' seconds.
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the light on the X-axis over time to simulate the passing day.
        transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
    }
}
