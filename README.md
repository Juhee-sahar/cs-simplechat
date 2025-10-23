# 간단한 채팅 프로그램 (server - client 구조)

<br>

![화면이미지](imgs/screen01.png)


<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>

핵심 개념 : 역할 분리
TCPSocketServer (네트워크 계층) >> 소켓 연결/해제/메시지 수신/전송만 담당한다.
즉, 데이터가 왔어요~ 만 알려주는 역할을 명확히 인지할 것

