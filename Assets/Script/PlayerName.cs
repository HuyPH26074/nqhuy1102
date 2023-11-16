using UnityEngine;
using UnityEngine.UI;

public class PlayerNameManager : MonoBehaviour
{
    public static string playerName; // Biến lưu tên người chơi

    public InputField nameInputField; // Reference đến Input Field để nhập tên

    public void SavePlayerName()
    {
        playerName = nameInputField.text; // Lưu tên người chơi từ Input Field
    }
}