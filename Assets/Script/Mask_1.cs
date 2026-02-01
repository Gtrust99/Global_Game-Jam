using UnityEngine;

public class Mask_1 : MonoBehaviour
{
    public GameObject startlevel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        startlevel.SetActive(false);
        if (collision.gameObject.CompareTag("Player"))
        {
            MaskController.Instance.Mask_1 = true;
            MaskController.Instance.UnlockMask_1=true;
            gameObject.SetActive(false);
        }

    }
}
