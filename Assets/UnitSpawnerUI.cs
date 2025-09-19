using UnityEngine;
using UnityEngine.UI;

public class UnitSpawnerUI : MonoBehaviour
{
    public Button spawnButton;       // ���� ��ư
    public int unitCost = 100;       // ���� ���� ���
    public int currentGold = 0;      // ���� �ڿ� 
    void Start()
    {
        
    }

    
    void Update()
    {
        // �ڿ��� ������� Ȯ���Ͽ� ��ư Ȱ��ȭ ���� ����
        spawnButton.interactable = currentGold >= unitCost;
    }

    // �ܺο��� �ڿ� ���� �� ȣ���� �� �ִ� �Լ�
    public void AddGold(int amount)
    {
        currentGold += amount;
    }
}
