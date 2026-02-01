using UnityEngine;

public class Mask_2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MaskController.Instance.Mask_2 = true;
            MaskController.Instance.UnlockMask_2 = true;
            gameObject.SetActive(false);
        }

    }
}
