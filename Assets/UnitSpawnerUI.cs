using UnityEngine;
using UnityEngine.UI;

public class UnitSpawnerUI : MonoBehaviour
{
    public Button spawnButton;       // 생성 버튼
    public int unitCost = 100;       // 유닛 생성 비용
    public int currentGold = 0;      // 현재 자원 
    void Start()
    {
        
    }

    
    void Update()
    {
        // 자원이 충분한지 확인하여 버튼 활성화 여부 조절
        spawnButton.interactable = currentGold >= unitCost;
    }

    // 외부에서 자원 증가 시 호출할 수 있는 함수
    public void AddGold(int amount)
    {
        currentGold += amount;
    }
}
