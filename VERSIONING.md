# 버전 및 파일명 규칙
2026-09-25 사용자 최종 지시를 적용합니다.

- 현재 빌드: **1.17.4 / Android versionCode202**. 실제 APK manifest 검사 완료.
- 다음 수정 버전은 **1.17.5 / 코드203**, 기능 단위 변경 시 **1.18.0**처럼 세 자리 숫자를 사용합니다.
- 버전 뒤 candidate, arm64, final 등의 글자를 붙이지 않습니다.
- APK: `PhoneLOL-1.17.4.apk`. iOS 내보내기 폴더: `Builds/iOS/PhoneLOL-1.17.4`.
- `PhoneLOL-02/Assets/Editor/PhoneLOLBuild.cs`의 DisplayVersion/BuildNumber를 다음 변경 때 함께 증가시킵니다. 현재 상수1.17.4/202는 이번 빌드 재현용입니다.
- Android/iOS 표시 버전과 빌드 번호·출력명은 공통 상수에서 설정합니다. 실제 iOS 최신 내보내기는 아직1.7.0이며 IPA는 없습니다.
- 과거1.16.9,1.16.10,1.7.0~1.7.4 기록/산출물은 실제 버전을 유지합니다. 이름만 바꿔 새 버전으로 전달하지 않습니다.
- 새 요청이 없으면 바탕화면 복사, ZIP 생성, iOS 재출력은 하지 않습니다.
