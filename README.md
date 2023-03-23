# Azaza Project

2022 SSWU ConputerGraphics Project  

- xxoznge 이소정
- YeJiKim06  김예지
- surimshim 심수림
- hlytw05 전소정


### 1. Earthy Scene 김예지  
> Design, 3D Object placement,Animation, Shader 

지상으로 이동하려면 J키를 누르세요.

<지상 스토리>
> 평범하게 살고있던 어느 마을에 갑자기 거대한 탑이 생겼다. 거대한 탑과 같이 살고있는 일상이 익숙해졌지만 탑 주변의 보이지 않는 포탈을 건들이니 처음보는 곳으로 이동된다.

1. Terrain 구축
* Earth Scene
*  Terrain 추가
*  Raise or Lower Terrain 적용
*  Paint Texture로 6개의 Layer 적용
*  set Height로 탑 주변 지형 정리
* Paint Tree로 4가지의 나무 생성
*  Water를 이용하여 호수 생성

2. 탑
* 성 : Normal Map 셰이더 적용
* 포탈 : 계단 옆 쪽에 있는 포탈을 사용하면 UnderGround Scene으로 이동
	   탑 앞의 포탈을 이용하여 Tower Scene으로 이동
* 계단 : Set Height를 이용하여 탑으로 향하는 계단 제작

3. 공원
* 분수 : Water 오브젝트 2가지를 이용하여 분수에 고여있는 물 제작
	  3D 오브젝트와 애니메이션 효과를 이용하여 물방울이 튀는 것을 제작
	  파티클의 Water-BigSplash를 이용하여 물이 튀는 형상 표현
* 호수 : WaterBasicDaytime을 이용하여 호수 제작
* 조각상 : 	Format FBX - 금속 질감의 Shader, Ceramic-frog - 흑백 셰이더

4. 학교 - 3D object 제작
* 펜스 : 학교로 들어갈 수 있도록 입구가 움직이도록 제작
*학교 : 1층과 2층을 이동할 수 있도록 계단 제작

5. 도시
* 도시 : 분질적 음영을 적용

6. Image Effect Shader
* Overlay : Display 2
* Invert : Display 3


### 2. Heaven Scene 전소정 
> Design, 3D Object placement,Animation, Shader   
천상으로 이동하려면 K키를 누르세요.

<천상 스토리>
> 높은 절벽으로 둘러싸여있는 천상 세계. 건물들은 모두 공중에 띄워져 있고, 누군가 살고 있는 것 같은 성이 보인다. 그 성을 지키는 두 마리의 용은 동상처럼 보이지만 누군가 다가가면 위협을 가한다. 성의 주인이 키우는 것 같은 고래가 천상 세계 하늘을 자유롭게 떠다니고 있다.

1. Terrain
- cloud, mountain, mountain2 3개의 terrain 사용
- paint texture, Raise or Lower Terrain으로 여러개의 레이어 사용, smooth height 사용

2. Material/Shader
- 배, 성(메인, 미니), 타워: 텍스쳐 쉐이더 사용
- 구름: contrast 조절
- 용: brightness 조절
- 고래: saturation 조절

3. C# Script
- PostEffect_Blend 적용 -> Camera
- PostEffect_GrayScale 적용 ->Camera_for_MiniMap

4. Animation
- 구름 상하 움직임 애니메이션 적용
- 배 앞뒤 움직임 애니메이션 적용

5. Light
- 씬 전체 천상 분위기 조성을 위한 Directional Light 설정


### 3. Underground Scene 이소정 
> Design, 3D Object placement,Animation, Shader  

지하로 이동하려면 J키를 누르세요.

<지하 스토리>
> 보물이 숨겨져있는 지하세계. 지하세계는 다른 세계와 탑으로 연결되어 있으며 탑과 연결되어있는 계단을 내려가면 미로같은 산을 헤매게 된다. 지하세계에는 모두가 원하는 보물이 있는데 이 보물을 마녀가 지키고 있어 지금까지 아무도 차지하지 못하고 있었다. 하지만 보물을 지키던 마녀는 저주를 받아 동상이 되었고 주인없는 보물을 훔치기 위해 지상의 사람들이 몰려들게 되었다.

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



### 4. A Magnificent Tower 심수림  
> Design, 3D Object placement,Animation, Shader  

Tower로 이동하려면 L키를 누르세요.

<탑 스토리>
> 탑에 들어서자 느껴지는 음산한 분위기. 탑 한가운데 거대한 조각상이 보인다. 조각상을 건드리니 지하 세계로 떨어졌다. 다시 탑으로 올라와 이번엔 벽을 따라 길게 이어진 계단을 따라갔다. 쭉 올라가 계단의 끝에 있는 문을 열어보니 하늘 위 천국과 이어지는 구름이 보인다.

1. 탑
- 지상, 지하, 천상을 이어주는 공간
- 3D object Cube, Cylinder로 제작
- 탑 벽, 바닥) 컬러+텍스처 알비도 셰이더
- 계단, 벽 조명) 컬러+텍스처 알비도, Metalic/Smooth 셰이더
- 계단 조명에 스포트라이트 조명 배치
- 어두운 분위기 나타내는 배경음악 사용

2. 비너스 조각상
- 클릭하면 지하로 이동하는 오브젝트
- UI “Venus/클릭 시 지하로 이동합니다.”
- 텍스처 Lerp Range 셰이더
- Asset store 오브젝트
- 마우스 클릭 LoadtoScene C# 스크립트
- 조각상 위 스포트라이트 조명

3. 탑 입구 포탈
- 접근하면 지상으로 이동하는 오브젝트
- UI “Portal/지상으로 이동합니다.”
- 투명 메터리얼 셰이더
- 3D object Cube로 제작
- 텍스처 포토샵으로 직접 제작
- 오브젝트 충돌 콜라이더 LoadtoScene C# 스크립트

4. 다이아몬드
- 접근하면 계단 꼭대기로 텔레포트하는 오브젝트
- UI “Diamond/계단 꼭대기로 이동합니다.”
- Mesh scripting으로 제작한 3D object
- 오브젝트 충돌 콜라이더 텔레포트 C# 스크립트

5. 문
- 접근하면 천상으로 이동하는 오브젝트
- UI “Door/천상으로 이동합니다.”
- 3D object Cube로 제작
- Hinged Door 자동문 Animation
- 컬러+텍스처 알비도, Metalic/Smooth 셰이더
- 오브젝트 충돌 콜라이더 LoadtoScene C# 스크립트

### 4. FPS Controller Interaction  / Camera / Mirror
> 이소정, 김예지, 심수림

### 6. Minimap / UI Text
- Scene 내부 사용 메뉴얼 포함
> 김예지 수림

### 7. Light  
> 전소정  

### 8. Sound / Music  
 > 심수림  
 
### 9. 인덱스 씬 (또는 인덱스 캔버스) --> 일종의 사이트 맵 기능 
- 팀원이 수행한 활동 내역을 확인할 수 있도록 UI를 활용하여 제작할 것  
- "U" 키는 인덱스 씬을 로딩하는 (또는 인덱스 컨버스를 활성화하는) 키로 예약함  
> 수림

### 9. Game View의 규격은 Full HD로 정할 것
> 수림

### 10. Unity 빌드 파일
> 예지

### 11. 중간 / 최종 발표 PPT / 일정 / 리드미
> 이소정

