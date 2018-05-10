using UnityEngine;

/// <summary>
/// 游戏入口。
/// </summary>
public partial class GameEntry : MonoBehaviour
{
    public static ICharacterSystem characterSystem = null;
    private void Start()
    {
        characterSystem = new CharacterSystem();
        InitBuiltinComponents();
        InitCustomComponents();
    }
}