using UnityEngine;

public class CharacterStats : MonoBehaviour
{
   [SerializeField] MainCharactersSO[] mainCharactersSOs;

    public int strenght, speed, manaPoints, inteligence, lifePoints, luck;

    public void SetCharacterStats()
    {


        //[SelectCharacter.OfficialCharacter] == 0 Umano
        //[SelectCharacter.OfficialCharacter] == 1 Vampiro
        //[SelectCharacter.OfficialCharacter] == 2 Elfo
        //[SelectCharacter.OfficialCharacter] == 3 Orco
        strenght = mainCharactersSOs[SelectCharacter.OfficialCharacter].strenght;
        speed = mainCharactersSOs[SelectCharacter.OfficialCharacter].speed;
        manaPoints = mainCharactersSOs[SelectCharacter.OfficialCharacter].mana;
        inteligence = mainCharactersSOs[SelectCharacter.OfficialCharacter].inteligence;
        lifePoints = mainCharactersSOs[SelectCharacter.OfficialCharacter].life_points;
        luck = mainCharactersSOs[SelectCharacter.OfficialCharacter].luck;

    }
}
