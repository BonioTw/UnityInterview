## 專案下載
  1. 專案連結：https://github.com/BonioTw/UnityInterview.git
  2. 使用 Unity (Unity 2019.2.21f1) 載入專案

## 實作道具商店介面
### 配置：
  1. 打開 `Assets/Scenes/ShopScene.unity`
  2. 設定參考解析度為 750 x 1334（與 Reference 相同）
  3. 圖片素材在 `Assets/Images` 或 `Assets/Resources` 資料夾中
  4. 道具資料在 `Assets/StreamingAssets/ShopItems.json` 檔案中

### 請按照參考圖，實作以下三個目標：
#### 【目標一】：實作道具商店介面 - 3 x 3 道具商店
  * 參考 `Assets/Images/Reference/Reference_Step1.png` 實作商店基本介面框架（不需要道具資料）<br><br><img width="250" src="https://user-images.githubusercontent.com/6658966/77414529-28af8880-6dfc-11ea-92b1-8c51b08ecb0c.png">

#### 【目標二】：串接 JSON 道具資料，顯示在道具商店中
  * 讀取並解析 `Assets/StreamingAssets/ShopItems.json` 的資料
  * 參考 `Assets/Images/Reference/Reference_Step2.png`，將解析完成的資料顯示在道具商店中<br><br><img width="250" src="https://user-images.githubusercontent.com/6658966/77414904-abd0de80-6dfc-11ea-8f77-44d75f55a940.png">

  * 道具圖片位於 `Assets/Resources/Images/ShopItems` 中，圖片名稱與道具資料的 `name` 欄位相同
  * 提示：可使用 `UnityEngine.JsonUtility` 解析 JSON 格式

#### 【目標三】：點擊商店道具，彈出視窗顯示道具詳細資訊
  * 參考 `Assets/Images/Reference/Reference_Step3.png` 與 `Assets/Images/Reference/Reference_Step3.gif`，實作商店道具詳細資訊視窗<br><br><img width="250" src="https://user-images.githubusercontent.com/6658966/77415202-12ee9300-6dfd-11ea-9545-1ed6d156775b.gif">

  * 詳細視窗顯示的道具資訊為使用者點擊的道具
  * 商店道具詳細資訊視窗可以點擊右上角的「x」關閉

#### 【加分目標】：為商店道具詳細資訊「彈出」與「關閉」增加 Bounce 動畫

## 附件
* `Assets/StreamingAssets/ShopItems.json` 參考格式：
```js
{
  "items": [
    { "id": 1, "name": "terrain_mountain", "title": "造山者", "description": "...", "money": 500 },
    { "id": 2, "name": "terrain_golden_statue", "title": "黃金女神", "description": "...", "money": 5000 },
    ...
  ]
}
```
