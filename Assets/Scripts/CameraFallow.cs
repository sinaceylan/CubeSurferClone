using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;

    private Vector3 newPosition;
    private Vector3 offset;

    [SerializeField] private float smoothValue; 

    void Start()
    {
        SetOffsetValue();
    }

    private void LateUpdate()
    {
        SmoothCameraFallow();
    }

    private void SetOffsetValue()
    {
        offset = transform.position - heroTransform.position;
    }

    private void SmoothCameraFallow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f,heroTransform.position.y,heroTransform.position.z) + offset, smoothValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
