# 현재 인수인계
2026-09-25. 재개 시 이 문서, VERSIONING.md, RECOVERY_STATUS.md 상단 및 실제 Git 상태를 확인합니다.

## 소스·산출물
- 현재 소스: D:\A_KJ\AI\PhoneLoL_02, 브랜치 work/v1164-unity6-recovery. 전투 수정 기준 커밋4aac295.
- Unity 프로젝트: D:\A_KJ\AI\PhoneLoL_02\PhoneLOL-02. Unity6000.3.14f1.
- 완료 APK: D:\A_KJ\AI\PhoneLoL_02\PhoneLOL-02\Builds\PhoneLOL-1.7.4.apk.
- 143247790 bytes; SHA-256 b3470e62b324ca67050263de3746c7a2f1fbbc4dcae08da1c2a354367d9dcd63.
- 실제1.7.4/code201, Android ARM64/IL2CPP, 빌드 오류0/경고762. 빌드 성공은 폰 실행 성공이 아닙니다.
- 다음 기본값1.17.4/code202. 이번 정리는 새 APK 빌드를 요청하거나 기존 APK를 이름만 변경하지 않습니다.
- Android: PhoneLOLBuild.BuildAndroidCandidate(). iOS: PhoneLOLBuild.BuildIOSCandidate().
- 기존 Automation/BuildV174.cs 등은 당시 실행 이력이며 공통 빌더를 호출하므로 지금 재실행하면 다음 기본 버전을 사용합니다.

## 검증과 다음 작업
- Recovery/V174ServerVerification.txt: 모드20/10/103×방장/게스트 탈주, 결과/조회/중복·위조 거부.
- V174ProtocolVerification.txt: 실제 탈주 패킷, 플레이어 표시·마스터 이전,10000초 idle, 치명 로그.
- V174CombatVerification.txt / V174AnimationVerification.txt:1024회 재사용 및 티모/이즈리얼/베인 공속2.5/10/50/200.
- V174SceneInspection.txt / V174DeploymentVerification.txt: 맵 위치/UI 및 서버 배포.
- 수정 APK를 두 폰에 맞춰 설치하고 GitHub #1 체크리스트부터 진행. 실제 폰 콘솔 표시는 아직 미확인.
- 이사/공유기 교체 후 서버 PC·터널 자동 시작과 앱 DNS 주소 접속을 다른 외부망 폰에서 재검증.
- iOS는 친구 Mac 연결 후 최신 소스로 다시 내보내기, Xcode 빌드·서명·배포 (#2).
- 원본 경기 종료 계정 보상/경험치와 랭킹 규칙은 미복구 (#3).

## 서버 실행·복구
- 기존 런타임: C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime.
- 엔트리: recovery\01_server_v0965_snapshot\APK\server_central_authority_v33.py.
- 실행 Python: C:\TempPy13\python.exe. 로컬29000; 앱 공개 DNS uko9ef6n.free.pwrp.cc:10045.
- 이번 정리에서 공개 DNS 진단 POST /phonelol-diag/v1 HTTP204 확인. 과거115.88.104.135 거절은 현 앱 DNS의 연결 실패를 증명하지 않습니다. 별도 휴대폰 외부망은 미검증.
- 시작: 기존 런타임 START_REMOTE_STACK.ps1 또는 런타임의00_PHONELOL_TEST_HERE\PHONELOL_TEST_V213.ps1. 원본 저장소의 launcher만 단독 실행하지 마세요(기존 의존성 필요).
- 배포 원본: Automation/Server 및 central_v33_runtime_files.json. 기존 시작 시 구버전 소스 덮어쓰기는 수정됨.
- 배포 전 접속 중인 사용자를 확인하고 소스/SQLite 온라인 백업. 계정16개와 DB integrity 보존 확인.
- 최근 배포 전 백업: recovery\04_runtime\backups\before-v174-20260925-162945.
- 코드 롤백만 필요하면 DB를 과거 것으로 되돌리지 않습니다. DB/계정·서명 비밀은 GitHub에 올리지 않습니다.
- 이벤트61002와 확장 인원/슬롯 계약 때문에 참가자는 같은 새 클라이언트를 사용해야 합니다.

## 기존 환경과 보존
- Unity 실행은 Automation/OpenUnity.ps1 사용(원격 실행 환경변수 누락에 따른 Package Manager 재시도 방지).
- 기존 D:\A_KJ\AI, 사용자 Unity 및 Python, MultiGod 서버 경로는 안정 설치 예외로 유지. 새 도구 설치/위치 이동 없음.
- 새 AI 설치 기본 C:\Program Files\_My\AI 정책은 향후 신규 설치에 적용.
- 독립 사용자 수정 UnityConnectSettings.asset은 커밋하지 않습니다. ProjectSettings.asset의 빌드 자동 저장 공백 변경도 별도 보존합니다.
- 기존 APK/백업/Known-Good 및 Remote Desktop 연결 유지. 새 바탕화면 복사/ZIP 없음.
- 통합 소통은 project-operations-hub의 T-0010 THREAD.md에 추가하고 실제 버전/검증 원본은 이 저장소에 기록합니다.
