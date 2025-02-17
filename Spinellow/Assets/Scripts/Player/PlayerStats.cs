using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    static int skillPoints, strenght, speed, manaPoints, inteligence, lifePoints, luck;
    [SerializeField] TextMeshProUGUI[] SkillValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        skillPoints = 20;
        strenght = 0;
        speed = 0;
        manaPoints = 0;
        inteligence = 0;
        lifePoints = 0;
        luck = 0;
    }

    public void AssignPoints(int skillType)
    {
        if (skillPoints > 0)
        {
            

            switch (skillType)
            {
                case 0:
                    strenght += 1;
                    skillPoints--;
                    SkillValue[skillType].text = strenght.ToString();

                break;

                case 1:
                speed += 1;
                skillPoints--;
                    SkillValue[skillType].text = speed.ToString();
                    break;

                case 2:
                manaPoints += 1;
                skillPoints--;
                    SkillValue[skillType].text = manaPoints.ToString();
                    break;

                case 3:
                inteligence += 1;
                skillPoints--;
                    SkillValue[skillType].text = inteligence.ToString();
                    break;

                case 4:
                lifePoints += 1;
                skillPoints--;
                    SkillValue[skillType].text = lifePoints.ToString();
                    break;

                case 5:
                luck += 1;
                skillPoints--;
                    SkillValue[skillType].text = luck.ToString();
                    break;

                default:
                    Debug.Log("Occhio ai pulsanti");
                    break;
            }
          SkillValue[6].text = "Assignable: "+skillPoints.ToString();  
        }
        else
        {
            Debug.Log("Those are ur stats:");
            Debug.Log("Strenght: "+strenght);
            Debug.Log("Speed: " + speed);
            Debug.Log("Mana: " + manaPoints);
            Debug.Log("Inteligence: " + inteligence);
            Debug.Log("Lifepoints: " + lifePoints);
            Debug.Log("Luck: " + luck);

        }
    }
    public void DeAssignPoints(int skillType)
    {
        if (skillPoints >= 0)
        {


            switch (skillType)
            {
                case 0:
                    if(strenght > 0)
                    {
                    strenght -= 1;
                    skillPoints++;
                    SkillValue[skillType].text = strenght.ToString();
                    }
                    

                    break;

                case 1:
                    if (speed > 0)
                    {
                        speed -= 1;
                        skillPoints++;
                        SkillValue[skillType].text = speed.ToString();
                    }
                    break;

                case 2:
                    if (manaPoints > 0)
                    {
                        manaPoints -= 1;
                        skillPoints++;
                        SkillValue[skillType].text = manaPoints.ToString();
                    }
                    break;

                case 3:
                    if (inteligence > 0)
                    {
                        inteligence -= 1;
                        skillPoints++;
                        SkillValue[skillType].text = inteligence.ToString();
                    }
                    break;

                case 4:
                    if (lifePoints > 0)
                    {
                        lifePoints -= 1;
                        skillPoints++;
                        SkillValue[skillType].text = lifePoints.ToString();
                    }
                    break;

                case 5:
                    if (luck > 0)
                    {
                        luck -= 1;
                        skillPoints++;
                        SkillValue[skillType].text = luck.ToString();
                    }
                    break;

                default:
                    Debug.Log("Occhio ai pulsanti");
                    break;
            }
            SkillValue[6].text = "Assignable: " + skillPoints.ToString();
        }
        else
        {
            Debug.Log("Those are ur stats:");
            Debug.Log("Strenght: " + strenght);
            Debug.Log("Speed: " + speed);
            Debug.Log("Mana: " + manaPoints);
            Debug.Log("Inteligence: " + inteligence);
            Debug.Log("Lifepoints: " + lifePoints);
            Debug.Log("Luck: " + luck);

        }
    }

}
