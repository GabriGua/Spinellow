using UnityEngine;

public class CharacterStats : MonoBehaviour
{
   [SerializeField] MainCharactersSO[] mainCharactersSOs;

    public int strenght, speed, manaPoints, inteligence, lifePoints, luck;

    public void SetCharacterStats()
    {
        
        strenght = mainCharactersSOs[SelectCharacter.OfficialCharacter].strenght;
        speed = mainCharactersSOs[SelectCharacter.OfficialCharacter].speed;
        manaPoints = mainCharactersSOs[SelectCharacter.OfficialCharacter].mana;
        inteligence = mainCharactersSOs[SelectCharacter.OfficialCharacter].inteligence;
        lifePoints = mainCharactersSOs[SelectCharacter.OfficialCharacter].life_points;
        luck = mainCharactersSOs[SelectCharacter.OfficialCharacter].luck;

    }
}
