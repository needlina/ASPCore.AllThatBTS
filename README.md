# 로컬 환경 세팅
로컬 환경을 위해 아래 프로그램을 설치합니다.

## 준비물
* 소스 - https://github.com/needlina/ASPCore.AllThatBTS
* 형상관리 툴 - GitExtension 2.43 (https://sourceforge.net/projects/gitextensions/files/2.47/)
* git - https://git-scm.com/download/win
* DB Tool- HeidiSql (https://www.heidisql.com/installers/HeidiSQL_9.5.0.5196_Setup.exe)
* Openshift CLI - https://github.com/openshift/origin/releases/download/v3.11.0/openshift-origin-client-tools-v3.11.0-0cbc58b-windows.zip

## 소스 다운로드

### 1. GitHub 사이트 접속하여 Link를 복사한다. https://github.com/needlina/ASPCore.AllThatBTS
![그림 1](https://github.com/needlina/Textbook/blob/master/Images/20190119_200549.png)

### 2. Git Extension에 그림과 같이 입력 후 Local Repository를 생성한다.
![그림 2](https://github.com/needlina/Textbook/blob/master/Images/20190119_200719.png)

## Openshift 상 DB 접속
**DB 접속 상태일 때 로컬 실행이 가능! 주기적으로 Port가 닫히니 확인필요!**

### 1. Openshift Portal에 접속 후 Token을 얻는다.
![그림 3](https://github.com/needlina/Textbook/blob/master/Images/20190119_201200.png)

### 2. git bash 를 이용하여 Openshift 에 접속한다.
![그림 4](https://github.com/needlina/Textbook/blob/master/Images/20190119_201227.png)

### 3. Openshift CLI를 로 Port-forwarding 한다.
![그림 5](https://github.com/needlina/Textbook/blob/master/Images/20190119_201300.png)

### 3-1. Port-fowarding할 Pod이 올바르지 않으면 에러메시지가 발생한다.
### Pod의 확인은 아래와 같이한다.
![그림 5-1](https://github.com/needlina/Textbook/blob/master/Images/ocdbportforward.PNG)

### 4. HeidiSQL을 실행하고 127.0.0.1 root / 비밀번호를 입력한다.
![그림 6](https://github.com/needlina/Textbook/blob/master/Images/20190119_201348.png)

### 5. DB 서버 접속 완료
![그림 7](https://github.com/needlina/Textbook/blob/master/Images/20190119_201408.png)


## 소스 Commit 및 빌드 방법

### 1. 소스 수정 후 Commit 버튼을 누르면 대화창이 뜨는데 소스 확인 후 stage로 이동
### (개발은 ReadMe상 Dev Branch로 진행하는데, 자신의 브랜치 생성하여 개발이 가능)
![그림 8](https://github.com/needlina/Textbook/blob/master/Images/20190119_214004.png)

### 2. Commit하면 아래와 같이 Commit 완료
![그림 9](https://github.com/needlina/Textbook/blob/master/Images/20190119_200817.png)

:sparkles:**주의사항**
**appsetting.json 파일은 commit시 제외한다.**  
**로컬 개발시에는 127.0.0.1 (port-forwarded)로 설정**  
**운영 빌드시에는 172.30.77.240으로 설정되어야 배포시 DB 접근이 가능하다.**  
![그림 10](https://github.com/needlina/Textbook/blob/master/Images/20190119_201849.png)


### 3. 로컬 환경에서 정상동작 확인 후 start build 클릭한다.
![그림 11](https://github.com/needlina/Textbook/blob/master/Images/20190119_214751.png)

### 3-1. Branch를 변경하여 빌드하려면 아래와 같이 세팅한다.  
### build - allthatbts
![그림 12](https://github.com/needlina/Textbook/blob/master/Images/editbuildbranch-1.PNG)  

### Actions - Edit
![그림 13](https://github.com/needlina/Textbook/blob/master/Images/editbuildbranch-2.PNG)  

## Git Reference를 원하는 branch명으로 적는다.  
![그림 14](https://github.com/needlina/Textbook/blob/master/Images/editbuildbranch-3.PNG)
