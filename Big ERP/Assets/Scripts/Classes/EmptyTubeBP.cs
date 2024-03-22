using UnityEngine;

[System.Serializable]
public class EmptyTubeBP
{

    [SerializeField] private string codeNo;
    public string CodeNo
    {
        get { return codeNo; }
    }


    [SerializeField] private string size;
    public string Size
    {
        get { return size; }
    }
    public float qty;

    public EmptyTubeBP(string _codeNo, string _size, float _qty)
    {
        this.codeNo = _codeNo;
        this.size = _size;
        this.qty = _qty;

    } //constructor

} //class
