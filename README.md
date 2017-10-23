* 專案下載
  1. 專案連結：https://github.com/BonioTw/UnityInterview.git
  2. 使用Unity載入專案
* 商店介面
  1. 打開 `Assets/Scenes/1-ShopScene.unity`
  2. 說明：請參考`Assets/Images/Reference`資料夾的內容
  3. 完成目標：
     * 照Reference內的內容做出直向16:9的UI
     * 點擊shop1右上角的寶箱圖案按鈕會切換為bag1<br>
       點擊bag1右上角購物圖圖示之按妞會必換為shop1
     * 繼承`Assets/Scripts/BaseModal.cs`來實做結帳與賣出畫面<br>
       點擊Shop1下方9個物品會跳出結帳畫面shop2<br>
       點擊Bag1下方9個物品會跳出結帳畫面bag2
     * 物品價格及其內容可隨意自訂 但按加減鈕後的值必需正確

* 方塊動畫與材質
  1. 打開 `Assets/Scenes/2-CubeScene.unity`
  2. 說明：該Scene中有個方塊，方塊上有
     * Animator: 此方塊已綁上CubeAnimator，包含兩個讓方塊旋轉的Animations其中一個是讓方塊沿著X軸旋轉，另一個沿著Y軸旋轉
     * Material: 方塊的Material是Cube
  3. 完成目標：
     * 按鍵盤 "Q" 鍵讓方塊播放Animation沿著X軸旋轉
     * 按鍵盤 "W" 鍵讓方塊播放Animation沿著Y軸旋轉
     * 按鍵盤 "E" 鍵讓方塊播放Animation沿著X軸反向旋轉
     * 按鍵盤 "R" 鍵讓方塊播放Animation沿著Y軸反向旋轉
     * 按鍵盤 "T" 鍵讓方塊播放Animation沿著X軸旋轉，速度變兩倍
     * 按鍵盤 "Y" 鍵讓方塊播放Animation沿著Y軸旋轉，速度變兩倍
     * 按鍵盤 "M" 鍵改變方塊材質（變色或變換材質）
  4. 加分目標：
     * 在場景中製作UI按鈕達成以上事項
