# EasyStateManager
간단한 어플리케이션 구현에 자주 사용하는 Unity3d Visual Script Function Collection
## Build Custom Visual Script Node
1. Assets
2. Assets내에서 커스텀 스크립트 생성
3. Visual Scripting in Project Settings
4. 노드에 커스텀 타입을 추가하고 Regenerate Nodes
<img src="https://user-images.githubusercontent.com/12027747/166627493-0a46173c-0443-454a-8ef6-aabe799ddf30.png" width="400"/>
<img src="https://user-images.githubusercontent.com/12027747/166627574-ec405ea4-74a6-47b1-b36a-ecee417cc365.png" width="400"/>

## Simple GuideTextList
타이틀, 설명, 나레이션을 리스트로 넣을 수 있도록 되어있음
### Node Name: Super_GuideTextList
- Input
  - GuideTextList: App Variable Name
  - Index: TextListIndex
  - Title: Object Variable Name
  - Description: Object Varialble Name
- Output
  - Title
  - Description
  - Voice
<img src="https://user-images.githubusercontent.com/12027747/170455338-31d41754-6de6-46ac-8575-854d0cc54b49.png" width="400"/>
<img src="https://user-images.githubusercontent.com/12027747/166649630-f0ec20f1-6cb8-4da7-8c75-ed1612451173.png" width="400"/>

## Instantiate Model from List
리스트에서 모델을 생성
### Node Name: Super_InstantiateModelFromList
- Input
  - ModelList: Object Variable Name
  - ModelIndex
  - Parent: Object Variable Name
  - DisplayModelName: Object Variable Name
  - TitleTextMesh: Object Variable Name
<img src="https://user-images.githubusercontent.com/12027747/170457096-3515ca10-554b-4adc-89e1-c4cad5dc87d6.png" width="400"/>
<img src="https://user-images.githubusercontent.com/12027747/170457300-85d87a11-2f59-43a1-ab82-059b87a736bc.png" width="400"/>

## Move to Previous Scene
빌드 씬 뒤로가기

<img src="https://user-images.githubusercontent.com/12027747/170620939-0b43e323-55a5-40d2-a1d4-d7b316ffbc4a.png" width="400"/>
<img src="https://user-images.githubusercontent.com/12027747/170621052-1907d715-449a-456b-9691-418852e97336.png" width="400"/>


## Trigger In-Out
트리거 들어가고 나가는 이벤트
- Node Name: **Super_OnTriggerInOut**
## Random Audio Player
리스트의 오디오를 랜덤으로 재생
- Node Name: **Super_RandomAudioPlaying**
## Reload Current Scene
현재 활성화된 씬을 다시 로드
- Node Name: **Super_ReloadCurrentScene**
## Singleton
오브젝트 싱글턴
- Node Name: **Super_GuideReturnString**
