using UnityEngine;

public class MaskController : MonoSingleton<MaskController>
{
    public bool Mask_1;
    public bool Mask_2;
    public bool Mask_3;
    public bool UnlockMask_1;
    public bool UnlockMask_2;
    public bool UnlockMask_3;
    public bool Skill1;
    public bool Skill2;
    public bool Skill3;
    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.A) && UnlockMask_1) //PickMask1
        {
            Mask_1 = !Mask_1;
        }
        if ( Input.GetKeyDown(KeyCode.S) && UnlockMask_2) //PickMask2
        {
            Mask_2 = !Mask_2;
        }
        if ( Input.GetKeyDown(KeyCode.D) && UnlockMask_3) //PickMask3
        {
            Mask_3 = !Mask_3;
        }
        if(Mask_1)
        {
            PlayerUI.Instance.Mask1_selected();
            Skill1=true;
        }
        if (!Mask_1)
        {
            PlayerUI.Instance.Mask1_unselected();
            Skill1 = false;
        }
        if (Mask_2)
        {
            PlayerUI.Instance.Mask2_selected();
            Skill2 = true;
        }
        if (!Mask_2)
        {
            PlayerUI.Instance.Mask2_unselected();
            Skill2 = false;
        }
        if (Mask_3)
        {
            PlayerUI.Instance.Mask3_selected();
            Skill3 = true;
        }
        if (!Mask_3)
        {
            PlayerUI.Instance.Mask3_unselected();
            Skill3 = false;
        }
    }
}
