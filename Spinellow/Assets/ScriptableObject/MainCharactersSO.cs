using TMPro;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/MainCharacterScriptableObjects")]
public class MainCharactersSO : ScriptableObject
{
    public Image icon;
    public new string name;
    public string specialAbility;
    public int strenght;
    public int speed;
    public int mana;
    public int inteligence;
    public int life_points;
    public int luck;

    public AnimationClip Attack1;
    public AnimationClip Attack2;
    public AnimationClip Attack3;
    public AnimationClip Attack4;

}
