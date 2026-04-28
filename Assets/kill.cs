using UnityEngine;

public class kill : MonoBehaviour
{
    public Transform player;

    public float killRadius = 1.5f;
    public float warningRadius = 3f;

    public Vector3 respawnPoint = new Vector3(0, 1, 0);

    Vector3 originalPos;

    Renderer r;
    Color originalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        originalPos = transform.position;

        r = GetComponent<Renderer>();

        if (r != null)
        {
            originalColor = r.material.color;
        }
    }

    // Update is called once per frame

    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance < killRadius)
        {
            player.position = respawnPoint;

            if (r != null)
                r.material.color = originalColor;
        }

        else if (distance < warningRadius)
        {
            float shakeAmount = 0.1f;

            transform.position = originalPos + new Vector3(
                Random.Range(-shakeAmount, shakeAmount),
                0,
                Random.Range(-shakeAmount, shakeAmount)
            );

            if (r != null)
                r.material.color = Color.red;
        }

        else
        {
            transform.position = originalPos;

            if (r != null)
                r.material.color = originalColor;
        }
    }
}