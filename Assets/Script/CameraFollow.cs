using UnityEngine;

public class CameraFollow : MonoSingleton<CameraFollow>
{
    public Transform target; 
    public float smoothing = 0.125f; 
    public Vector2 offset; 

    void LateUpdate()
    {
        if(!MaskController.Instance.UnlockMask_2)
        {
            Vector2 desiredPosition = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothing);
            transform.position = smoothedPosition;
        }
        else
        {
            Vector2 desiredPosition = new Vector3(target.position.x , transform.position.y + offset.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothing);
            transform.position = smoothedPosition;
        }
       
    }
}
