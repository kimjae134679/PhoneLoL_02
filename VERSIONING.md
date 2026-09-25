# 버전 규칙
2026-09-25 사용자 최종 지시를 적용합니다.

- 다음 버전: **1.17.4**, 이후 **1.17.5**, 기능 단위 변경 시 **1.18.0**처럼 세 자리 숫자를 사용합니다.
- 버전 뒤에 candidate, arm64, final 같은 글자를 붙이지 않습니다.
- APK 이름: `PhoneLOL-1.17.4.apk`. iOS 내보내기: `Builds/iOS/PhoneLOL-1.17.4`.
- 다음 Android versionCode / iOS buildNumber는 **202**입니다. 이후 배포 때마다 증가시켜 기존 code201보다 높게 유지합니다.
- `PhoneLOL-02/Assets/Editor/PhoneLOLBuild.cs`의 DisplayVersion / BuildNumber가 다음 빌드 기본값입니다. Android/iOS와 출력명에 함께 적용됩니다.
- 현재 실제 빌드된 파일은 **1.7.4 / 201**입니다. 이를1.17.4로 이름만 바꾸거나 이미1.17.4를 빌드했다고 기록하지 않습니다.
- 과거1.16.9,1.16.10,1.7.0~1.7.4 기록과 산출물은 실제 버전을 유지합니다. 프로젝트 PlayerSettings는 마지막 실제 빌드 값이며 다음 빌드 메서드가 갱신합니다.
- 새 요청이 없으면 바탕화면 복사, ZIP 생성, iOS 재출력은 하지 않습니다.
