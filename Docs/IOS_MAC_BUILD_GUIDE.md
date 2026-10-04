# PhoneLOL: Mac에서 iPhone 설치·IPA 준비

**0.23.0/build250 Xcode ZIP의 내보내기·무결성·실행 권한·업로드 크기/digest 확인 완료.** [v0.23.0 릴리스](https://github.com/kimjae134679/PhoneLoL_02/releases/tag/v0.23.0)에서 `PhoneLOL-0.23.0-iOS-Xcode.zip`을 내려받으세요. 기존 Android250 APK와 이전241 자산도 보존합니다.

이 준비물은 서명된 IPA가 아닙니다. **Mac에서 실제 링크·서명·IPA 생성·iPhone 설치는 아직 검증하지 않았습니다.**

다운로드 검증: ZIP **346,323,322바이트**, SHA256 `44983A2DFBFD218F7C48A47361519A95F9B767E27902B802D2A64E15B9FAED03`. 로컬 검사와 GitHub uploaded 크기·digest 일치 확인을 완료했습니다.

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

## 개발 소스에서 다시 내보내기

Unity **6000.3.14f1 + iOS Build Support**와 비공개 소스 접근 권한이 필요합니다. `v0.23.0` 소스 태그의 `PhoneLOL-02`를 열어 **PhoneLOL → Export 0.23.0 iOS Xcode project**를 실행합니다. 로컬 출력은 `D:/A_KJ/AI/PhoneLoL_02/PhoneLOL-02/Builds/iOS/PhoneLOL-0.23.0`입니다.

현재 Windows export는 종료0/Succeeded/오류0/경고760 및 실제0.23.0/250 확인 상태입니다. ZIP CRC·실행 도구17개 Unix0755·크기/SHA256 및 알려진 자격정보 패턴 검사와 GitHub uploaded 크기·digest 일치 확인을 완료했습니다. 게임 코드·버전·아티팩트 태그는 변경하지 않고 같은250 릴리스에 준비물만 추가합니다. 다음 변경은0.23.1/build251입니다. [현재 인수인계](../HANDOFF.md).

기존241의 ZIP/권한 검증은 과거 증거이며 새250의 Mac 링크·설치 성공을 뜻하지 않습니다. 과거 `GADU*` 링크 오류나 새 Xcode 오류도 실제 Mac 빌드에서 별도로 확인해야 합니다.
