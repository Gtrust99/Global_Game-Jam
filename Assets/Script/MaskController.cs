using UnityEngine;

public class MaskController : MonoSingleton<LevelController>
{
    public bool Mask_1;
    public bool Mask_2;
    public bool Mask_3;
    public GameObject Mask1;
    public GameObject Mask2;
    public GameObject Mask3;
    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.A)) //PickMask1
        {
            Mask_1 = !Mask_1;
        }
        if ( Input.GetKeyDown(KeyCode.S)) //PickMask2
        {
            Mask_2 = !Mask_2;
        }
        if ( Input.GetKeyDown(KeyCode.D)) //PickMask3
        {
            Mask_3 = !Mask_3;
        }
        if (Mask_1)
        {

            Mask1.SetActive(true);
        }
        if (Mask_2)
        {
            Mask2.SetActive(true);
        }
        if (Mask_3)
        {
            Mask3.SetActive(true);
        }


    }
}
