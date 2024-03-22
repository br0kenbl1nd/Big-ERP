using UnityEngine;

[System.Serializable]
public class MudFilledTube
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

    [SerializeField] private string rqdTubeCodeNo;
    public string RqdTubeCodeNo
    {
        get { return rqdTubeCodeNo; }
    }

    public float qty;    

} //class

