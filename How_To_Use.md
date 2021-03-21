# ElswordVoice 使用步驟

以下為本軟體的設定流程，請依序由上往下閱讀。

如有難疑之處：

1. 歡迎至 [issues](https://github.com/explooosion/ElswordVoice/issues) 建立問題。
2. 或是到粉專 [艾爾之光-Line](https://www.facebook.com/LINEC8763) 私訊。

---

## I.下載

1. 請先至本專案首頁下，選擇 [releases](https://github.com/explooosion/ElswordVoice/releases) 頁籤。

    ![](https://i.imgur.com/ENTibMd.png)

2. 選擇最新的版本，於下方點選 [ElswordVoice.zip](https://github.com/explooosion/ElswordVoice/releases/download/4.8.120519/ElswordVoice.zip)。

    ![](https://i.imgur.com/WZtTNEs.png)

---

## II. 解壓縮與放置資料夾

1. 將下載後的檔案右鍵，選擇 `解壓縮至此`。

    ![](https://i.imgur.com/68FyF3P.png)

2. 完成後會得到 `ElswordVoice` 資料夾。

    ![](https://i.imgur.com/HNPwSpv.png)

3. 將資料夾剪下貼到艾爾之光安裝的目錄底下，官方預設放置於 `C:\Program Files\Elsword`

    ![](https://i.imgur.com/W74of3s.png)

4. 確認 `ElswordVoice` 資料夾內容包含了：
    + Ex_Voice 資料夾
    + ElswordVoice.exe

    ![](https://i.imgur.com/80NQbJQ.png)


5. `Ex_Voice` 資料夾，用來放置你想替換的 .kom 檔案。
    
    ![](https://i.imgur.com/Dwue328.png)

6. 建議將軟體設定使用管理員權限執行。右鍵 `ElswordVoice.exe` 選擇內容。
    
    ![](https://i.imgur.com/PWbgrYV.png)

7. 頁籤選擇【**相容性**】，底下請勾選【**以系統管理員的身分執行此程式**】，套用並確定。
    
    ![](https://i.imgur.com/ZMiFtLg.png)
    
8. 完成後，檢視模式使用【**中圖示**】，應該可以看到 `ElswordVoice.exe` 右下出現小盾牌。
    
    ![](https://i.imgur.com/PxfNF0A.png)

9. 若沒有出現，也可每次右鍵選擇【**以系統管理員的身分執行**】執行轉換器。
    
    ![](https://i.imgur.com/SXuqrGD.png)

---

## III. 啟動轉換器

1. 每次轉換器都會在艾爾之光啟動時進行環境檢測，包含復原官方kom檔案。

2. 點選執行轉換器，只有在第一次啟動遊戲時需要，後續轉換器會自動隱藏於右下工具列表，若誤關閉程式，重新點擊執行即可。

3. 轉換器表單外觀圖片由網友提供，目前暫不進行UI的更新，若有網友提供，當然就會進行更新囉！

4. 轉換器開啟時畫面為**灰階**，表示尚未進入遊戲偵測。
    
    ![](https://i.imgur.com/l7lo6Hm.png)

5. 點選伊芙**任一個部位**就會變成**彩色**，表示進入遊戲偵測，你可以安心啟動遊戲。
    
    ![](https://i.imgur.com/2yStc7D.png)

---

## IV. 執行遊戲

1. 將轉換器啟動，變成彩色狀態後，就可以從官方 **beanfun** 執行遊戲。
    
    ![](https://i.imgur.com/T0h1Ykd.png)

2. 當遊戲完成更新檢查後，轉換器便會開始進行轉換。

3. 在轉換時，會看到~~奇妙的~~畫面在轉：
    
    ![](https://i.imgur.com/zRoHaPr.png)

---

## V. 完成轉換時的資料夾結構

1. 完成轉換後，可以在遊戲安裝目錄 `data` 底下發現，有許多 **dataOOO.kom.temp**，
這些都是你原本的檔案，單純只是換個名字暫存。

    ![](https://i.imgur.com/N3W3QYJ.png)

---

## VI. 完成轉換時的遊戲畫面

1. 當登入遊戲後，出現【**錯誤**】屬於正常現象！

    ![](https://i.imgur.com/DlMSPnp.png)

---

## VII. 手動復原

1. 在轉換器的工作中，每次監聽到艾爾之光 beanfun 啟動時，就會先進行一次系統還原。
因此基本上不太需要進行手動復原。

2. 如果想手動還原，可以在工作列表中，右鍵轉換器，選擇【**手動還原**】，
會將遊戲安裝目錄 `data` 底下的 **dataOOO.kom.temp** 全部還原回來。
    
    ![](https://i.imgur.com/Yu950jO.png)

    ![](https://i.imgur.com/El1vd7G.png)

---

## 轉換器注意事項

- 轉換器目前僅能從黑橘的 beanfun 啟動遊戲。
- 轉換器不支援從 steam 上執行。
