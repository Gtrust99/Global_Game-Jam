using UnityEngine;

public class Mask_1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MaskController.Instance.UnlockMask_1=true;
            gameObject.SetActive(false);
        }

    }
}
