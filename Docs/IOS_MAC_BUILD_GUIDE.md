# PhoneLOL: Mac에서 iPhone 설치·IPA 준비

**0.22.7/build247 Xcode ZIP의 내보내기·무결성·실행 권한·업로드 크기/digest 확인 완료.** [v0.22.7 릴리스](https://github.com/kimjae134679/PhoneLoL_02/releases/tag/v0.22.7)에서 `PhoneLOL-0.22.7-iOS-Xcode.zip`을 내려받으세요. 기존 Android247 APK와 이전241 자산도 보존합니다.

이 준비물은 서명된 IPA가 아닙니다. **Mac에서 실제 링크·서명·IPA 생성·iPhone 설치는 아직 검증하지 않았습니다.**

다운로드 검증: ZIP **346,235,295바이트**, SHA256 `7A4DB4CB6F801587B18149BC41F1B5B940B7FD4E072ED9633B2D484168DEFE4C`. 로컬 검사와 GitHub uploaded 크기·digest 일치 확인을 완료했습니다.

## iPhone에서 직접 실행

1. Mac에 Xcode를 설치하고, 릴리스의 ZIP을 풀어 `Unity-iPhone.xcodeproj`를 엽니다. 이미 생성된 프로젝트를 쓰는 경우 Unity를 다시 설치할 필요는 없습니다.
2. **TARGETS → Unity-iPhone → Signing & Capabilities**에서 **Automatically manage signing**을 켜고 본인의 **Team**을 선택합니다. 프로젝트/다른 target에도 Team 오류가 나오면 해당 target의 서명 설정을 확인합니다.
3. Bundle Identifier `com.jcl.lmulti`가 계정에서 중복되면 본인에게 고유한 값으로 변경합니다.
4. iPhone을 연결하고 실행 대상으로 선택한 뒤 **Run**을 누릅니다. Xcode/iPhone이 요청하는 개발자 모드·신뢰 설정을 완료합니다.

무료 **Personal Team**의 본인 기기 테스트와 일반 배포/IPA 내보내기 권한은 동일하지 않습니다. 계정 가입 상태와 선택한 배포 방식에 따라 인증서·프로파일 및 사용 가능한 기능이 달라집니다. [Apple 계정 안내](https://developer.apple.com/help/account/basics/about-your-developer-account).

## 서명된 IPA 내보내기

1. 위 서명 설정을 마치고 시뮬레이터가 아닌 기기용 대상을 선택합니다.
2. **Product → Archive**를 실행합니다.
3. Organizer에서 Archive를 선택하고 **Distribute App**을 누릅니다.
4. 본인 계정에 허용된 배포 방식을 선택하고 인증서·프로파일을 확인한 뒤 **Export**합니다. 내보낸 폴더에서 `.ipa`를 확인합니다. IPA 하나가 모든 iPhone에 설치 가능한 것은 아닙니다.

세부 절차: [Apple 공식 IPA 내보내기 안내](https://help.apple.com/xcode/mac/current/en.lproj/dev23ea8b877.html).

## 준비물과 실행 권한

- Xcode 프로젝트에는 Unity IL2CPP 생성C++가 포함됩니다. 서명키·배포 프로파일은 동봉하지 않으므로 본인의 Apple 계정으로 서명해야 합니다.
- ZIP의 스크립트와 Mac 실행 도구17개에 Unix0755 실행 권한을 보존했으며 CRC 검사를 통과했습니다. 압축을 풀 때 실행 권한을 유지하세요.
- 권한 오류가 나면 오류에 표시된 파일에 `chmod +x "파일 경로"`를 적용합니다. `process_symbols*.sh`, `usymtool*`, IL2CPP/UnityLinker/bee_backend 같은 실행 도구도 대상입니다.
