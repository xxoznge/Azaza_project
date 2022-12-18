# Azaza Project

2022 SSWU ConputerGraphics Project  

### 1. Earthy Scene  
> Design, 3D Object placement,Animation, Shader 김예지  
- Park 
-> 놀이터, 호수, 조각상이 있는 산책로 구성
- Apartment
-> 차가 지니다닐 수 있고, 학교로 향하는 횡단보도, 신호등이 있다. 
-> 사람들의 생활공간
- Tower
-> 탑 내부로 향하는 포탈과 지하씬으로 향하는 포탈이 존재
- School
-> 

### 2. Heaven Scene  
> Design, 3D Object placement,Animation, Shader  전소정  
- Castle
- Island

### 3. Underground Scene  
> Design, 3D Object placement,Animation, Shader 이소정  
- 지하에 있는 길을 찾지못할 정도로 큰 산 
- TREASURE  
> 보물을 찾기위해 지하세계로 찾아온다.  
- WITCH CATSTLE  
> 보물의 주인 마녀가 사는 성  
> 마녀는 저주를 받고 동상으로 변했다.  
> 불을 뿜는 용과 날아다니는 용이 살고 있다. 
- CAVE  
> 곰이 살고 있는 동굴  
> 들어가면 살아나오지 못한다.  
- LAKE
> 산 위에 있는 호수  
> 집과 낡은 배, 상어가 살고 있다.  
- HOUSE  
> 보물을 찾으러 온 사람이 살던 집  
> 마녀를 피해 보물을 훔치려했지만 늙어서 죽었다.  
- GRAVE  
> 마녀로 인해 죽은 사람을 묻어둔 무덤
- TOWER
> 다른 세계에서 넘어올 수 있는 탑  
> 긴 계단으로 이어져있다.  
> 재생시키면 다이아몬드 오브젝트가 등장한다. 
- WATERFALL  
> 호수와 이어져있는 폭포  
- FERRIS WHEEL  
> 해골이 걸려있는 관람차  
- TREE  
> 재생시키고 스페이스바를 누르면 돌아가는 바람개비가 달린 큰 나무  
> 나무 뒤에는 거울이 있다. 

1. terrain 구축
- Underground Scene
- Terrain 추가
- Raise or Lower Terrain 
- Paint Texture로 3개 이상의 Layer 
- Set Height
 - Smooth Height 
 - Paint Tree로 3개 이상 
 - Water를 활용하여 강, 호수, 바다 

2. 마녀가 사는 성 : 보물의 주인 / 마녀는 저주에 걸려서 동상이 됨. 

- 성 : 쉐이더 완료
- 용 : 불 뿜는 쉐이더
- 마녀 : 외곽선을 표시하는 동시에 음영이 분절적
- 출입문 : 쉐이더 완료 
- 성 뒤 탑 : 쉐이더 완료
- 나는 용 : 쉐이더, 애니메이션 

3. 보물상자

- 버려진 배 : 쉐이더 완료
- 보물상자 : 쉐이더 완료
- 보물들 : 쉐이더 완료
- 탑 : 쉐이더 완료
- 가드 : 쉐이더 완료 
- 해골 : 쉐이더 완료
- 해골바가지 : 쉐이더 완료

4. 움막집 : 사람이 살다가 죽음 / 보물 훔쳐가려고 기회만 노리다가 늙어서 죽음

- 움막집 : 쉐이더 완료
- 불 : 쉐이더 완료
- 해골 : 쉐이더 완료
- 무너진 집 : 쉐이더 완료
- 정자 : 쉐이더 완료


5. 동굴 : 보물이 있는 줄 알고 들어가지만 사나운 곰이 있음
- 동굴 : 쉐이더 완료
- 곰 : 쉐이더 완료
- 나무, 돌 : 쉐이더 완료

6. 타워
- 타워 - 쉐이더
- 계단 - 쉐이더 ( 텍스처 움직임 )
- 3d 모델링 다이아몬드 

7. 큰 나무
- 나무 : 금속 질감의 Shader
- 바람개비 : Prefab, Animator 컴포넌트의 speed 속성 키보드 ( SPACE ) - 재생, 정지
- 나무 뒤 카메라 거울

8. 시체를 걸어둔 놀이기구
- 놀이기구 : Lerp 함수로 혼합할 두 텍스처가 50%
- 해골 : 흑백 셰이터, 외곽선을 표시하는 Shader, 음영이 분절적인 Shader

9. 가운데 호수
- free suburban structure kit 추가
- 나룻배 - 쉐이더 
- 상어 - 쉐이더, Transform 컴포넌트와 관련된 애니메이션

10. 무덤
- 무덤 : Alpha 값이 있는 Texture의 배경에 다른 Texture
- 묘비 : NormalMap

11. 폭포 
- 폭포 : 흘러내리는 "폭포" Shader


### 4. A Magnificent Tower
> Design, 3D Object placement,Animation, Shader  심수림  


### 4. FPS Controller Interaction  / Camera / Mirror
> 이소정  

### 6. Minimap / UI Text
- Scene 내부 사용 메뉴얼 포함
> 김예지  

### 7. Light  
> 전소정  

### 8. Sound / Music  
 > 심수림  
 
### 9. 인덱스 씬 (또는 인덱스 캔버스) --> 일종의 사이트 맵 기능 
- 팀원이 수행한 활동 내역을 확인할 수 있도록 UI를 활용하여 제작할 것  
- "U" 키는 인덱스 씬을 로딩하는 (또는 인덱스 컨버스를 활성화하는) 키로 예약함  

### 10. Game View의 규격은 Full HD로 정할 것

## 평가요소  

- 새로운 프로젝트를 만들 수 있는가? 
> 이소정  

- 프로젝트는 정상적으로 실행(Play)되는가? 
> 확인 완료

- 일상적인 시각 경험과 유사한 사실적인 씬 1개를 만들 수 있는가? 
> 예지  

- 일상적인 시각 경험과 다른 비사실적인 씬 2개를 만들 수 있는가? 가령, SF적이거나 판타지적인 씬을 구현할 수 있는가? 
> 전소정, 이소정, 심수림 

- 런타임 중에 씬을 바꿀 수 있는가? 
> 수림 작업중

- Terrain 오브젝트를 씬에 추가할 수 있는가? 
> 이소정 예지

- Paint Terrain의 Raise or Lower Terrain을 사용하여 지형의 고저를 표현할 수 있는가? 
> 이소정 예지

- Paint Terrain의 Paint Texture로 3개 이상의 Layer를 만들고 Terrain에 칠할 수 있는가? 
> 이소정 예지
 
- Paint Terrain의 Set Height로 일정한 높이의 평지를 만들 수 있는가?  
> 이소정 예지

- Paint Terrain의 Smooth Height로 지형의 고저를 완만하게 처리할 수 있는가? 
> 이소정 예지

- Paint Tree로 3개 이상의 Tree를 Terrain에 그릴 수 있는가?  
> 이소정 예지

- Water를 활용하여 강, 호수, 바다 등을 표현할 수 있는가?  
> 이소정 예지

- Wind Zone을 활용하여 바람 효과를 만들 수 있는가? 
> 예지

- Asset Store에서 적절한 건축물(Free Suburban Structure Kit) 애셋을 다운로드 받아 지형에 추가할 수 있는가? 
> 이소정 수림

- 3D 오브젝트를 활용하여 간단한 구조물(예: 원두막 등)을 FPSController의 스케일에 부합하게 만들 수 있는가? 
> 예지

- Prefab을 만들 수 있는가? 
> 예지 이소정

- 3D 오브젝트(가령, Cube 등)에 Transform 컴포넌트와 관련된 애니메이션(가령, 회전 등) 기능을 추가할 수 있는가? 
> 이소정 예지 수림

- Animator 컴포넌트의 speed 속성을 키보드, 마우스, 충돌판단 등으로 제어하여 재생, 정지 등의 기능을 구현할 수 있는가? 
> 이소정

- Animation State Machine(Animator 창)을 사용하여 애니메이션 클립의 재생 순서를 구성하고 제어할 수 있는가? 
> 예지 수림

- 머티리얼을 통해 변수를 입력 받아 밝기(_Brightness)를 제어할 수 있는 셰이더를 만들 수 있는가? 
> 수림 작업중

- 금속 질감의 Shader(Metalic, Smooth)를 만들 수 있는가?
> 이소정 수림

- 표면의 요철을 잘 나타내는 Shader(NormalMap)를 만들 수 있는가? 
> 이소정 예지

- 두 개의 Texture를 Lerp 함수로 혼합할 두 텍스처가 50%씩 보이게 할 수 있는가? 
> 이소정

- Alpha 값이 있는 Texture의 배경에 다른 Texture가 보이도록 혼합할 수 있는가?  
> 이소정

- 흘러내리는 "폭포" Shader 만들 수 있는가? 
> 이소정

- 흑백 셰이터를 만들 수 있는가? 
> 이소정

- 3D 오브젝트의 외곽선을 표시하는 Shader를 만들 수 있는가? 
> 이소정

- 3D 오브젝트의 음영이 분절적인 Shader를 만들 수 있는가? 
> 예지 이소정

- 3D 오브젝트의 외곽선을 표시하는 동시에 음영이 분절적으로 보이는 Shader를 만들 수 있는가? 
> 이소정

- Post-Process Layer 및 Post-Process Volume 컴포넌트를 사용하여 카메라에 후처리 효과를 줄 수 있는가? 
> ( 소정 해야함 )

- 카메라를 사용하여 미니맵을 만들 수 있는가? 
> 예지

- 카메라를 사용하여 거울을 만들 수 있는가?  
> 이소정

- Image Effect Shader와 C# 스크립트를 사용하여 색반전 효과(Invert Color)를 만들 수 있는가? 
> 예지

- Image Effect Shader와 C# 스크립트를 사용하여 깊이(Depth, 거리) 효과를 만들 수 있는가? 
> 수림 해야함

- Image Effect Shader와 C# 스크립트를 사용하여 무채색(GrayScale) 효과를 만들 수 있는가? 
> 소정 해야함

- Image Effect Shader와 C# 스크립트를 사용하여 이미지 합성(Blend) 효과를 만들 수 있는가? 
> 소정 해야함

- Image Effect Shader와 C# 스크립트를 사용하여 이미지 오버레이(Overlay) 효과를 만들 수 있는가? 
> 예지 

- Image Effect Shader와 C# 스크립트를 사용하여 멀티 패스(Multi-Pass)를 효과를 만들고 제어할 수 있는가? 
> 수림 해야함

- Image Effect Shader와 C# 스크립트를 사용하여 명도(Brightness), 대비(Contrast), 채도(Saturation)를 효과를 만들고 제어할 수 있는가? 
> 전소정 ( 두개 해주세용 )

- UI 오브젝트를 사용하여 보다 수월한 상호작용 환경을 제공하는가? 
> 예지

- 3D 오디오 효과를 만들 수 있는가? 
> ( 수림 모든 씬에 해야함 )

- 각 팀원은 적어도 하나의 3D 오브젝트를 스크립트로 구현할 수 있는가? (Vertex, Triangle, Normal, UV) 
> 이소정 예지 수림 전소정

- 프로젝트의 각 씬은 컴퓨터그래픽스 효과를 잘 보여줄 수 있도록 기획했는가? 
> 당연하죠 ! 
