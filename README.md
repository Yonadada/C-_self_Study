# C-_self_Study
# 🖥️ YokiKiosk - WinForms 키오스크 프로젝트

---
## 📚 개념 정리 및 퀴즈 복습

#### (❓ WinForms 사용자 정의 컨트롤 Quiz 1)

#### 1. 사용자 정의 컨트롤을 사용하는 주된 이유는?
- 자주 사용되는 UI 요소를 **재사용 가능한 형태로 만들고 관리하기 위해서**

#### 2. 사용자 정의 컨트롤 내부의 레이블 텍스트를 외부에서 바꾸고 싶다면?
- **속성(Property)** 을 만들어 외부에서 값을 설정할 수 있게 한다

#### 3. 새로 만든 사용자 정의 컨트롤이 도구 상자(툴박스)에 나타나지 않을 때는?
- **프로젝트를 빌드(Build)** 해야 Visual Studio가 컨트롤을 인식하고 도구 상자에 자동으로 추가된다



#### 4. 외부에서 속성 값을 설정했을 때 내부 레이블에 바로 반영되게 하려면?
- 속성의 **`set` 접근자** 안에 내부 컨트롤 텍스트 업데이트 코드를 작성한다

```csharp
public string Title
{
    get => lblTitle.Text;
    set => lblTitle.Text = value.Trim();
}
```
---
## 📚 개념 정리 및 퀴즈 복습
#### (❓ WinForms 사용자 정의 컨트롤 속성 Quiz 2)

### 1. `DefaultValueAttribute`를 지정하는 주된 목적은?

- **정답**: 디자이너에서 기본값으로 초기화할 수 있게 하기 위해

> **해설**:  
> `DefaultValueAttribute`는 속성 창에서 '기본값으로 다시 설정' 기능을 가능하게 해 줍니다.  
> 또한 컨트롤을 디자인할 때 초기값으로 설정되는 데 도움을 줍니다.



### 2. 사용자 정의 컨트롤에서 직접 화면을 그릴 때 사용하는 메서드는?

- **정답**: `OnPaint`

> **해설**:  
> 컨트롤이 그려질 때마다 `OnPaint` 메서드가 호출됩니다.  
> 이 메서드 내부에서 `Graphics` 객체를 사용해 보더, 텍스트, 도형 등을 직접 그릴 수 있습니다.



### 3. 속성값이 바뀌었을 때 디자이너 화면에 즉시 반영되게 하려면?

- **정답**: `Invalidate` 호출

> **해설**:  
> `Invalidate()`는 "다시 그려야 해!"라고 컨트롤에게 알려주는 역할을 합니다.  
> 호출 시 자동으로 `OnPaint()`가 다시 실행되어 변경된 내용이 반영됩니다.



### 4. 컨트롤 크기 변경 시 다시 그리게 하려면 보통 어디에서 `Invalidate`를 호출할까요?

- **정답**: `Resize` 이벤트 핸들러

> **해설**:  
> 크기가 바뀌면 `Resize` 이벤트가 발생합니다.  
> 여기서 `Invalidate()`를 호출하면 컨트롤이 새 크기에 맞게 다시 그려집니다.



### 5. 속성 창에서 속성들을 그룹으로 묶고 설명을 붙이기 위한 Attribute는?

- **정답**: `Category` 와 `Description`

> **해설**:  
> `CategoryAttribute`를 사용하면 속성을 **그룹별로 나눌 수 있고**,  
> `DescriptionAttribute`를 쓰면 **속성 창 하단에 설명이 표시**되어 디자이너 사용성을 높일 수 있습니다.

---


## 🛠️ 2025-05-16 작업 기록: PickItem 기능 구현

### 📌 주요 기능
- `PickItem`(사용자 정의 컨트롤)에서 수량/삭제 관련 기능 구현
- 키오스크에서 장바구니에 담은 상품 수량과 가격을 표시하는 역할

### ✅ 구현한 내용
#### 1. 수량 변경 이벤트 (`CountChanged`)
- 수량이 바뀌었을 때 외부에 알림
```csharp
public event EventHandler? CountChanged;
CountChanged?.Invoke(this, EventArgs.Empty);
```

#### 2. 삭제 이벤트 (DeleteClicked)
- 삭제 버튼 클릭 시 외부에 알림
```csharp
public event EventHandler? DeleteClicked;
DeleteClicked?.Invoke(this, EventArgs.Empty);
```

#### 3. 수량 1개 미만일 경우 무시
- 수량이 0 또는 음수가 되는 것을 방지
```csharp
if (value < 1) return;
```

#### 4. 수량과 가격 계산 후 화면에 표시
- 수량 × 단가로 총액 계산 후 출력
```csharp
lblSumPrice.Text = $"{_count * _defaultPrice:#,0} 원";
```

#### 5. 수량을 화면에 표시
```csharp
lblCount.Text = _count.ToString();
```

##### 🔍 주의할 점
- Count 프로퍼티에서 _count = value;를 빠뜨리지 않도록 주의!

##### 💡 느낀 점
- 이벤트는 사용자 동작을 다른 곳에 알려주는 신호 역할을 함
- set 접근자에서 값을 바꾸는 것과 동시에 화면도 같이 바꿔줘야 함
- return은 "이 아래 코드는 실행하지 말고 빠져나가"는 의미


