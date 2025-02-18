using TMPro;
using UnityEngine;

public class SelectableCards : MonoBehaviour
{
    [SerializeField]MainCharactersSO MainCharactersSO;
    [SerializeField] TextMeshProUGUI[] SkillValue;
    [SerializeField] TextMeshProUGUI nameC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SkillValue[0].text = MainCharactersSO.strenght.ToString();
        SkillValue[1].text = MainCharactersSO.speed.ToString();
        SkillValue[2].text = MainCharactersSO.mana.ToString();
        SkillValue[3].text = MainCharactersSO.inteligence.ToString();
        SkillValue[4].text = MainCharactersSO.life_points.ToString();
        SkillValue[5].text = MainCharactersSO.luck.ToString();
        nameC.text = MainCharactersSO.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
