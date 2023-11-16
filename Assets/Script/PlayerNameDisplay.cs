using UnityEngine;
using UnityEngine.UI;

public class PlayerNameDisplay : MonoBehaviour
{
    public Text playerNameText; // Reference đến Text để hiển thị tên người chơi
    private GameObject player; // Reference đến GameObject của nhân vật

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); // Tìm đối tượng nhân vật

        if (player != null && PlayerNameManager.playerName != null)
        {
            // Tạo một Text hiển thị tên người chơi trên đầu nhân vật
            Text nameText = Instantiate(playerNameText, player.transform);
            nameText.text = PlayerNameManager.playerName;
        }
    }

    void LateUpdate()
    {
        if (player != null)
        {
            // Cập nhật vị trí của Text tên người chơi theo vị trí đầu của nhân vật
            playerNameText.transform.position = Camera.main.WorldToScreenPoint(player.transform.position + Vector3.up * 2f);
        }
    }
}