using UnityEngine;

public class RoadSegmentMove : MonoBehaviour
{
    [SerializeField] private float segmentSpeed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(transform.position.x, transform.position.y, -1 * segmentSpeed * Time.deltaTime);
            transform.position += new Vector3(transform.position.x, transform.position.y, -1 * segmentSpeed * Time.deltaTime);
            if (transform.position.z <= -10.0f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 50);
            }
        }
    }
}
