# PhoneLOL: Mac에서 iPhone 설치·IPA 준비

**0.23.2/build252 Xcode ZIP 내보내기·CRC·크기/digest·실행 권한 확인 완료.** [v0.23.2 릴리스](https://github.com/kimjae134679/PhoneLoL_02/releases/tag/v0.23.2)에서 `PhoneLOL-0.23.2-iOS-Xcode.zip`을 내려받으세요.

서명된 IPA가 아닙니다. **Mac 실제 링크·서명·IPA 생성·iPhone 설치는 미검증입니다.**

ZIP 346576172바이트/SHA256 `79fb8ae29113981a993697dc6acd774b7b68f25fa579167bc0687a00b216bc5c`; 파일3007/텍스트2288/Unix0755도구17개. 실제 export Succeeded/Errors0/Warnings762.

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

Unity **6000.3.14f1 + iOS Build Support**와 비공개 소스 접근 권한이 필요합니다. `v0.23.2` 소스 태그의 `PhoneLOL-02`를 열어 **PhoneLOL → Export 0.23.2 iOS Xcode project**를 실행합니다. 로컬 출력은 `D:/A_KJ/AI/PhoneLoL_02/PhoneLOL-02/Builds/iOS/PhoneLOL-0.23.2`입니다.

제한된 알려진 자격정보 패턴 검사는 보안 보장이 아닙니다. Mac의 `GADU*` 링크 오류나 다른 Xcode 오류는 실제 Mac 빌드에서 별도 확인해야 합니다.

## 이전 준비물 보존

기존0.23.1/build251 Xcode와 이전241·그 밖의 기존 릴리스 자산은 삭제·교체하지 않았습니다. 과거 ZIP/실행 권한 검사도 Mac 설치 성공을 뜻하지 않습니다.

## 252 APK 정식 공개 확인

Release 402936588 / APK asset609511319 / Source `b2337fcc37df0d55b85d0875736d68a5f7794786`. [v0.23.2 다운로드](https://github.com/kimjae134679/PhoneLoL_02/releases/tag/v0.23.2). 익명 latest 정식 v0.23.2, uploaded 113938141바이트/SHA256 `1108969ef06c41ac14721b68050d1cd609cd05d9faa0c1575e5ff50dc67e1fad` 일치. 이전 11릴리스/17자산 ID·이름·크기·digest 보존. 소스 artifact 태그 이동 없음. 같은 릴리스 Xcode252 asset609517418 uploaded 346576172바이트/SHA256 `79fb8ae29113981a993697dc6acd774b7b68f25fa579167bc0687a00b216bc5c` 일치. 파일3007/텍스트2288/Unix0755도구17개/CRC pass. 실제 export Succeeded/Errors0/Warnings762. Mac 링크·서명·IPA·실폰 미검증. receipt review disabled/unmanaged.
