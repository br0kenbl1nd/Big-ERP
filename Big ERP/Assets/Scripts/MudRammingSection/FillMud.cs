using UnityEngine;

public class FillMud : MonoBehaviour
{
    MudRammingShop mudRammingShop;

    private void Awake()
    {
        mudRammingShop = GetComponent<MudRammingShop>();
    } //awake

    public void Fill_Mud(string _size, float _qty)
    {
        mudRammingShop.AddStock(_size, _qty);
    }

} //Class
