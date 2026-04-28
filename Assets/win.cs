using UnityEngine;

public class win : MonoBehaviour
{
    public Transform player;
    public float winRadius = 2f;

    public GameObject winText; 

    bool hasWon = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasWon) return;

        float distance = Vector3.Distance(player.position, transform.position);

        if (distance < winRadius)
        {
            hasWon = true;
            winText.SetActive(true);
        }
    }
}
