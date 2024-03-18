using UnityEngine;

[System.Serializable]
public class EmptyTubeBP
{

    public string codeNo;
    public string size;
    public float qty;

    public EmptyTubeBP(string _codeNo, string _size, float _qty)
    {
        this.codeNo = _codeNo;
        this.size = _size;
        this.qty = _qty;

    } //constructor

} //class
