using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4.85f;

    void Start()
    {
        
    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xValue * moveSpeed, yValue, zValue * moveSpeed);
    }
}
