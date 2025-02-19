using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SelectCharacter : MonoBehaviour
{
    int character;
    public static int OfficialCharacter;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WannaBeAHuman()
    {
        character = 0;
        SetCharcter();

    }

    public void WannaBeAVampire()
    {
        character = 1;
        SetCharcter();
    }

    public void WannaBeAElf()
    {
        character = 2;
        SetCharcter();
    }

    public void WannaBeAOgre()
    {
        character = 3;
        SetCharcter();
        
    }

    void SetCharcter()
    {
        OfficialCharacter = character;
        Debug.Log(OfficialCharacter);
    }


}
