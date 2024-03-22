using UnityEngine;

public class BuyTube : MonoBehaviour
{
    private GodownInventory godownInventory;

    private void Awake()
    {
        godownInventory = GetComponent<GodownInventory>();
    } //awake

    /// <summary>
    /// Purchase a tube and update stock using code number of the tube and quantity
    /// </summary>
    /// <param name="_codeNo"></param>
    /// <param name="_qty"></param>
    public void Buy_Tube(string _codeNo, float _qty)
    {
        godownInventory.AddStock(_codeNo, _qty);
    } //purchase tube

} //class
