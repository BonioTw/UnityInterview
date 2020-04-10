## 作業說明
  1. 請到專案連結（Branch `assignment/2020`）下載專案：https://github.com/BonioTw/UnityInterview/tree/assignment/2020
  （或執行 `git clone --single-branch --branch assignment/2020 https://github.com/BonioTw/UnityInterview.git`）
  2. 實作寵物找尋主人小遊戲（地圖障礙物尋路）
  3. 使用 Unity 3D 實作（建議使用 Unity 2019.2.21f1）

## 遊戲說明
* 目標：在矩形的地圖（圖片以 10 x 10 地圖為例）上，寵物（左下角，藍色圓柱）需要越過重重障礙物（黃色方塊），找尋路徑（綠色方塊代表可走路徑）回到主人（右上角，粉紅色圓柱代表）身邊。
<br><img width="550" src="https://user-images.githubusercontent.com/6658966/78992787-b0bcbe80-7b6e-11ea-93ca-e4280e72e66c.png"><br><img width="550" src="https://user-images.githubusercontent.com/6658966/78993036-61c35900-7b6f-11ea-9a80-de599e6597bc.png"><br><img width="550" src="https://user-images.githubusercontent.com/6658966/78993038-64be4980-7b6f-11ea-8df7-8f2771f07d23.png">

* 地圖配置：<br><img width="550" src="https://user-images.githubusercontent.com/6658966/78992787-b0bcbe80-7b6e-11ea-93ca-e4280e72e66c.png">
  * 給定長寬大小 N x M，以方塊組成
  * 寵物起始放在地圖左下角
  * 主人固定放在地圖右上角
  * 除了左下角（寵物起始位置）與右上角（主人位置）兩塊方塊固定為可走方塊（綠色方塊），其他方塊由程式隨機生成為可走方塊（綠色方塊）或障礙方塊（黃色方塊）
  * 寵物可行走經過可走方塊（綠色方塊），但不可穿越或抵達障礙方塊（黃色方塊）
* 玩家操作：
  * 玩家可以在地圖上任意點選（滑鼠左鍵）地圖方塊，選取的方塊會增高突顯出來（參考 `Assets/References/4_game_select_cell.mov`）<br><img width="550" src="https://user-images.githubusercontent.com/6658966/78993107-8ae3e980-7b6f-11ea-9098-9b546c2c26a4.gif">

  * 玩家可透過鍵盤「上」、「下」按鍵切換地圖選取方塊狀態（可走方塊 <-> 障礙方塊；左下角與右上角方塊除外）（參考 `Assets/References/5_game_cell_switch.mov`）<br><img width="550" src="https://user-images.githubusercontent.com/6658966/78993280-f75ee880-7b6f-11ea-9be0-3b55339632cb.gif">

  * 玩家可按下鍵盤「Enter」按鍵觸發寵物移動到玩家選取的方塊，若選取的方塊為寵物可抵達的目標（參考 `Assets/References/6_game_pet_moving.mov`）<br><img width="550" src="https://user-images.githubusercontent.com/6658966/78993350-1cebf200-7b70-11ea-9cd1-5ec53d88f5a5.gif">

* 寵物路徑預覽：（參考 `Assets/References/7_game_path_preview.mov`）<br><img width="550" src="https://user-images.githubusercontent.com/6658966/78993433-3f7e0b00-7b70-11ea-90bb-b8ec39053497.gif">

  * 玩家點選地圖方塊時，若選取的方塊可由寵物位置抵達，寵物所在方塊到選取方塊的路徑會以橘色方塊顯示
  * 若選取方塊不可抵達，不顯示任何橘色路徑
  * 路徑以「寵物位置」到「選取方塊位置」的「最短路徑」顯示
  * 方塊距離以「曼哈頓距離」計算即可（`Math.Abs(x1 - x2) + Math.Abs(y1 - y2)`）
* 寵物移動：（參考 `Assets/References/8_game_pet_moving.mov`）<br><img width="550" src="https://user-images.githubusercontent.com/6658966/78993536-76ecb780-7b70-11ea-9961-75aaaade1133.gif">

  * 若玩家選取可寵物可抵達的方塊，並按下鍵盤「Enter」按鍵，寵物即會動身前往該方塊
  * 寵物遵照預覽路徑（橘色方塊）行走
  * 寵物邊行走，預覽路徑也會同時更新
  * 寵物行走中（尚未抵達選取方塊前），玩家不可進行其他操作（選取方塊、改變方塊狀態）
* 回歸主人：（參考 `Assets/References/9_game_reset.mov`）<br><img width="550" src="https://user-images.githubusercontent.com/6658966/78993586-94218600-7b70-11ea-9d00-692d95af047c.gif">

  * 若寵物成功抵達主人位置（右上角），遊戲會重置（重新產生地圖，寵物位置、選取方塊初始化）


## 實作遊戲
### 請按照參考圖，實作以下六個目標：
#### 【目標一】：實作動態地圖產生功能（給定地圖長寬大小）
  * 按照「地圖配置」說明產生地圖

#### 【目標二】：實作玩家選取地圖方塊功能
  * 玩家點選土地任意方塊，選取方塊會增高顯示

#### 【目標三】：實作選取方塊切換狀態功能
  * 對選取方塊按下鍵盤「上」按鍵（`KeyCode.UpArrow`），可將該方塊轉換為「障礙方塊（黃色方塊）」
  * 對選取方塊按下鍵盤「下」按鍵（`KeyCode.DownArrow`），可將該方塊轉換為「可走方塊（綠色方塊）」
  * 寵物起始方塊（左下角）與主人方塊（右上角）皆不可切換狀態

#### 【目標四】：實作選取方塊寵物行走路徑預覽功能
  * 按照「寵物路徑預覽」說明實作寵物路徑預覽功能

#### 【目標五】：實作寵物行走功能
  * 若選取方塊可由寵物位置抵達，按下鍵盤「Enter」按鍵（`KeyCode.Return`），讓寵物按照「預覽路徑」行走抵達選取方塊
  * 按照「寵物移動」說明實作寵物行走功能
  * 請以 Unity Script 實作搜尋演算法，請勿使用 Unity 內建 Navigation 功能實作

#### 【目標六】：實作回歸主人功能
  * 按照「回歸主人」說明實作回歸主人功能


## 參考設定
* 地圖方塊
  * Unity 內建 3D Cube
  * 綠色：`Color.green`
  * 黃色：`Color.yellow`
* 寵物
  * Unity 內建 3D Capsule
  * 藍色：`Color.blue`
* 主人
  * Unity 內建 3D Capsule
  * 粉紅字：`Color.magenta`
* 路徑預覽
  * 橘色：`Color(0.988f, 0.667f, 0.176f)`

