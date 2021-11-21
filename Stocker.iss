;変数
#define MyAppName    "MachineLink"
#define MyAppVersion "1.0.0.0"
#define MyAppPublisher "suruga.mtoeds"
#define MyAppExeName   "MachineLink.exe"
#define MyAppDirName "MachineLink"
#define MyAppPath "src\controller\MachineLink\bin\Debug"
#define MyDbPath "C:\SurugaFAS\Database\MachineLink"
#define MyDbName "MachineLink.db"
;#define MyAppMutex     "https://misw.jp/sampleapp"

[Setup]
;インストールウィザード表示タイトル
AppName        = {#MyAppName}
;アプリケーションバージョン
AppVersion     = {#MyAppVersion}
AppVerName           = {#MyAppName} {#MyAppVersion}
;製作情報
AppPublisher         = {#MyAppPublisher}
;インストールフォルダのデフォルトパス　{pf}はProgram Filesの略
;DefaultDirName = "C:\{#MyAppDirName}"
;DefaultDirName = {pf}\{#MyAppDirName}
DefaultDirName = {userdesktop}\{#MyAppDirName}
;その他
DefaultGroupName     = {#MyAppDirName}
OutputBaseFilename   = setup_{#MyAppName}
;AppMutex             = {#MyAppMutex}
UninstallDisplayIcon = {app}\uninstal_{#MyAppName}
UninstallDisplayName = {app}\uninstal_{#MyAppName}
;UninstallDisplayIcon = {app}\uninstal_{#MyAppExeName}
;UninstallDisplayName = {app}\uninstal_{#MyAppExeName}
;UninstallDisplayIcon = {userdesktop}\uninstal_AGVControlSystem.exe

[Languages]
;未指定の場合英語
Name: "japanese"; MessagesFile: "compiler:Languages\Japanese.isl"

[Dirs]
;Name: "{app}\Database\backup"
;Name: "{#MyDbPath}"; Check: isDbDirExist

[Files]
;インストールファイルの指定
;Source:インストールファイル名、DestDir:インストール先
;{app}指定インストール先フォルダ 標準ではDefaultDirNameで指定した場所
;ignoreversion フラグ：ファイル日付バージョンを無視し上書きインストール
Source: "{#MyAppPath}\*";    DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\backup\*";    DestDir: "{app}\backup"; Flags: ignoreversion
Source: "{#MyAppPath}\cncapi\*";    DestDir: "{app}\cncapi"; Flags: ignoreversion
Source: "{#MyAppPath}\cnc-jobs\*";    DestDir: "{app}\cnc-jobs"; Flags: ignoreversion
Source: "{#MyAppPath}\cnc-jobs\ArtcamPostProcessor\*";    DestDir: "{app}\cnc-jobs\ArtcamPostProcessor"; Flags: ignoreversion
Source: "{#MyAppPath}\cnc-jobs\AutdeskInventorHSMWorks\*";    DestDir: "{app}\cnc-jobs\AutdeskInventorHSMWorks"; Flags: ignoreversion
Source: "{#MyAppPath}\cnc-jobs\ecam\*";    DestDir: "{app}\cnc-jobs\ecam"; Flags: ignoreversion
Source: "{#MyAppPath}\cnc-jobs\Mastercampostprocessor\*";    DestDir: "{app}\cnc-jobs\Mastercampostprocessor"; Flags: ignoreversion
Source: "{#MyAppPath}\cnc-jobs\mecsoftpostprocessor\*";    DestDir: "{app}\cnc-jobs\mecsoftpostprocessor"; Flags: ignoreversion
Source: "{#MyAppPath}\cnc-jobs\raptor-big\*";    DestDir: "{app}\cnc-jobs\raptor-big"; Flags: ignoreversion
Source: "{#MyAppPath}\cnc-jobs\SheetCAMPosProcessor\*";    DestDir: "{app}\cnc-jobs\SheetCAMPosProcessor"; Flags: ignoreversion
Source: "{#MyAppPath}\cnc-jobs\vectricpostprocessor\*";    DestDir: "{app}\cnc-jobs\vectricpostprocessor"; Flags: ignoreversion
Source: "{#MyAppPath}\dialogPictures\*";    DestDir: "{app}\dialogPictures"; Flags: ignoreversion
Source: "{#MyAppPath}\drivers\x86\*";    DestDir: "{app}\drivers\x86"; Flags: ignoreversion
Source: "{#MyAppPath}\drivers\x64\*";    DestDir: "{app}\drivers\x64"; Flags: ignoreversion
Source: "{#MyAppPath}\ExampleKinsDLL\*";    DestDir: "{app}\ExampleKinsDLL"; Flags: ignoreversion
Source: "{#MyAppPath}\html\help\*";    DestDir: "{app}\html\help"; Flags: ignoreversion
Source: "{#MyAppPath}\html\help_old\*";    DestDir: "{app}\html\help_old"; Flags: ignoreversion
Source: "{#MyAppPath}\html\start\*";    DestDir: "{app}\html\start"; Flags: ignoreversion
Source: "{#MyAppPath}\html\start\start_bestanden\*";    DestDir: "{app}\html\start\start_bestanden"; Flags: ignoreversion
Source: "{#MyAppPath}\html\terms\*";    DestDir: "{app}\html\terms"; Flags: ignoreversion
Source: "{#MyAppPath}\html\terms\terms_bestanden\*";    DestDir: "{app}\html\terms\terms_bestanden"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\*";    DestDir: "{app}\icons"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_f_key\*";    DestDir: "{app}\icons\op_f_key"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_f_key\auto\*";    DestDir: "{app}\icons\op_f_key\auto"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_f_key\graph\*";    DestDir: "{app}\icons\op_f_key\graph"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_f_key\home\*";    DestDir: "{app}\icons\op_f_key\home"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_f_key\io\*";    DestDir: "{app}\icons\op_f_key\io"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_f_key\jog\*";    DestDir: "{app}\icons\op_f_key\jog"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_f_key\jogpad\*";    DestDir: "{app}\icons\op_f_key\jogpad"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_f_key\main\*";    DestDir: "{app}\icons\op_f_key\main"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_f_key\user\*";    DestDir: "{app}\icons\op_f_key\user"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_f_key\zero\*";    DestDir: "{app}\icons\op_f_key\zero"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_left\*";    DestDir: "{app}\icons\op_left"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\op_right\*";    DestDir: "{app}\icons\op_right"; Flags: ignoreversion
Source: "{#MyAppPath}\icons\program\*";    DestDir: "{app}\icons\program"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\*";    DestDir: "{app}\icons_120dpi"; Flags: ignoreversion
;Source: "{#MyAppPath}\icons_120dpi\op_f_key\*";    DestDir: "{app}\icons_120dpi\op_f_key"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_f_key\auto\*";    DestDir: "{app}\icons_120dpi\op_f_key\auto"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_f_key\graph\*";    DestDir: "{app}\icons_120dpi\op_f_key\graph"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_f_key\home\*";    DestDir: "{app}\icons_120dpi\op_f_key\home"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_f_key\io\*";    DestDir: "{app}\icons_120dpi\op_f_key\io"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_f_key\jog\*";    DestDir: "{app}\icons_120dpi\op_f_key\jog"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_f_key\jogpad\*";    DestDir: "{app}\icons_120dpi\op_f_key\jogpad"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_f_key\main\*";    DestDir: "{app}\icons_120dpi\op_f_key\main"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_f_key\user\*";    DestDir: "{app}\icons_120dpi\op_f_key\user"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_f_key\zero\*";    DestDir: "{app}\icons_120dpi\op_f_key\zero"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_left\*";    DestDir: "{app}\icons_120dpi\op_left"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\op_right\*";    DestDir: "{app}\icons_120dpi\op_right"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_120dpi\program\*";    DestDir: "{app}\icons_120dpi\program"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\*";    DestDir: "{app}\icons_old"; Flags: ignoreversion
;Source: "{#MyAppPath}\icons_old\op_f_key\*";    DestDir: "{app}\icons_old\op_f_key"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_f_key\auto\*";    DestDir: "{app}\icons_old\op_f_key\auto"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_f_key\graph\*";    DestDir: "{app}\icons_old\op_f_key\graph"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_f_key\home\*";    DestDir: "{app}\icons_old\op_f_key\home"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_f_key\io\*";    DestDir: "{app}\icons_old\op_f_key\io"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_f_key\jog\*";    DestDir: "{app}\icons_old\op_f_key\jog"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_f_key\jogpad\*";    DestDir: "{app}\icons_old\op_f_key\jogpad"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_f_key\main\*";    DestDir: "{app}\icons_old\op_f_key\main"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_f_key\user\*";    DestDir: "{app}\icons_old\op_f_key\user"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_f_key\zero\*";    DestDir: "{app}\icons_old\op_f_key\zero"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_left\*";    DestDir: "{app}\icons_old\op_left"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\op_right\*";    DestDir: "{app}\icons_old\op_right"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_old\program\*";    DestDir: "{app}\icons_old\program"; Flags: ignoreversion
;Source: "{#MyAppPath}\icons_tr\*";    DestDir: "{app}\icons_tr"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_f_key\*";    DestDir: "{app}\icons_tr\op_f_key"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_f_key\auto\*";    DestDir: "{app}\icons_tr\op_f_key\auto"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_f_key\graph\*";    DestDir: "{app}\icons_tr\op_f_key\graph"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_f_key\home\*";    DestDir: "{app}\icons_tr\op_f_key\home"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_f_key\io\*";    DestDir: "{app}\icons_tr\op_f_key\io"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_f_key\jog\*";    DestDir: "{app}\icons_tr\op_f_key\jog"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_f_key\jogpad\*";    DestDir: "{app}\icons_tr\op_f_key\jogpad"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_f_key\main\*";    DestDir: "{app}\icons_tr\op_f_key\main"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_f_key\user\*";    DestDir: "{app}\icons_tr\op_f_key\user"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_f_key\zero\*";    DestDir: "{app}\icons_tr\op_f_key\zero"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_left\*";    DestDir: "{app}\icons_tr\op_left"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\op_right\*";    DestDir: "{app}\icons_tr\op_right"; Flags: ignoreversion
Source: "{#MyAppPath}\icons_tr\program\*";    DestDir: "{app}\icons_tr\program"; Flags: ignoreversion
;Source: "{#MyAppPath}\logging\*";    DestDir: "{app}\logging"; Flags: ignoreversion
Source: "{#MyAppPath}\logos\*";    DestDir: "{app}\logos"; Flags: ignoreversion
;Source: "{#MyAppPath}\Plain_pictures\*";    DestDir: "{app}\Plain_pictures"; Flags: ignoreversion
Source: "{#MyAppPath}\qt_cnc_opengl_plugin\*";    DestDir: "{app}\qt_cnc_opengl_plugin"; Flags: ignoreversion
Source: "{#MyAppPath}\QT_ExampleUI\*";    DestDir: "{app}\QT_ExampleUI"; Flags: ignoreversion
;Source: "{#MyAppPath}\*";    DestDir: "{app}"; Flags: ignoreversion

Source: "assets\*";    DestDir: "{app}\assets"; Flags: ignoreversion
Source: "assets\core\camera\*";    DestDir: "{app}\assets\core\camera"; Flags: ignoreversion
Source: "assets\core\cnc\*";    DestDir: "{app}\assets\core\cnc"; Flags: ignoreversion
Source: "assets\core\plc\*";    DestDir: "{app}\assets\core\plc"; Flags: ignoreversion
Source: "data\core\cnc\*";    DestDir: "{app}\data\core\cnc"; Flags: ignoreversion
Source: "dist\core\cnc\*";    DestDir: "{app}\dist\core\cnc"; Flags: ignoreversion
Source: "dist\core\camera\*";    DestDir: "{app}\dist\core\camera"; Flags: ignoreversion
Source: "docs\*";    DestDir: "{app}\docs"; Flags: ignoreversion
;Source: "Solution Items\ConsoleCommandSamples\*";    DestDir: "{app}\Solution Items\ConsoleCommandSamples"; Flags: ignoreversion
;Source: "Solution Items\Calibrations\*";    DestDir: "{app}\Solution Items\Calibrations"; Flags: ignoreversion
Source: "utils\*";    DestDir: "{app}\utils"; Flags: ignoreversion

;Source: "{#MyAppPath}\appconfigs.json"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\cncapi.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\cncapi.txt"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\cncapi64.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\CncapiNet.dll"; DestDir: "{app}"; Flags: ignoreversion
;;Source: "{#MyAppPath}\CncapiNet64.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\CncServer.exe"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\CsvHelper.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\CsvHelper.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\EdingCncGCodes.json"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\EdingCncMCodes.json"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\KillCNC.exe"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Controller.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Controller.KansaiKaku.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Controller.KansaiKaku.dll.config"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Core.IPC.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Core.Motion.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Core.Store.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Driver.CNC.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Driver.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Driver.PC.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.exe"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.exe.config"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Models.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Repository.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Manufact.Repository.dll.config"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Bcl.AsyncInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Bcl.AsyncInterfaces.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Bcl.HashCode.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Bcl.HashCode.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.EntityFrameworkCore.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.EntityFrameworkCore.Abstractions.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.EntityFrameworkCore.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.EntityFrameworkCore.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Caching.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Caching.Abstractions.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Caching.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Caching.Memory.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.DependencyInjection.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.DependencyInjection.Abstractions.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.DependencyInjection.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.DependencyInjection.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Logging.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Logging.Abstractions.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Logging.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Logging.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Options.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Options.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Microsoft.Extensions.Primitives.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Buffers.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Collections.Immutable.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Collections.Immutable.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.ComponentModel.Annotations.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Diagnostics.DiagnosticSource.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Diagnostics.DiagnosticSource.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Memory.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Numerics.Vectors.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Runtime.CompilerServices.Unsafe.xml"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Threading.Tasks.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
;Source: "{#MyAppPath}\System.Threading.Tasks.Extensions.xml"; DestDir: "{app}"; Flags: ignoreversion

;Source: "Solution Items\CNC\EdingCNC\CNC4.03\*";    DestDir: "{app}"; Flags: ignoreversion
;;Source: "Solution Items\CNC\EdingCNC\CNC4.03\backup\*";    DestDir: "{app}\backup"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\cncapi\*";    DestDir: "{app}\cncapi"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\cnc-jobs\*";    DestDir: "{app}\cnc-jobs"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\cnc-jobs\ArtcamPostProcessor\*";    DestDir: "{app}\cnc-jobs\ArtcamPostProcessor"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\cnc-jobs\AutdeskInventorHSMWorks\*";    DestDir: "{app}\cnc-jobs\AutdeskInventorHSMWorks"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\cnc-jobs\ecam\*";    DestDir: "{app}\cnc-jobs\ecam"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\cnc-jobs\Mastercampostprocessor\*";    DestDir: "{app}\cnc-jobs\Mastercampostprocessor"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\cnc-jobs\mecsoftpostprocessor\*";    DestDir: "{app}\cnc-jobs\mecsoftpostprocessor"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\cnc-jobs\raptor-big\*";    DestDir: "{app}\cnc-jobs\raptor-big"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\cnc-jobs\SheetCAMPosProcessor\*";    DestDir: "{app}\cnc-jobs\SheetCAMPosProcessor"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\cnc-jobs\vectricpostprocessor\*";    DestDir: "{app}\cnc-jobs\vectricpostprocessor"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\dialogPictures\*";    DestDir: "{app}\dialogPictures"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\drivers\x86\*";    DestDir: "{app}\drivers\x86"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\drivers\x64\*";    DestDir: "{app}\drivers\x64"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\ExampleKinsDLL\*";    DestDir: "{app}\ExampleKinsDLL"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\html\help\*";    DestDir: "{app}\html\help"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\html\help_old\*";    DestDir: "{app}\html\help_old"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\html\start\*";    DestDir: "{app}\html\start"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\html\start\start_bestanden\*";    DestDir: "{app}\html\start\start_bestanden"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\html\terms\*";    DestDir: "{app}\html\terms"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\html\terms\terms_bestanden\*";    DestDir: "{app}\html\terms\terms_bestanden"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\*";    DestDir: "{app}\icons"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_f_key\*";    DestDir: "{app}\icons\op_f_key"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_f_key\auto\*";    DestDir: "{app}\icons\op_f_key\auto"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_f_key\graph\*";    DestDir: "{app}\icons\op_f_key\graph"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_f_key\home\*";    DestDir: "{app}\icons\op_f_key\home"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_f_key\io\*";    DestDir: "{app}\icons\op_f_key\io"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_f_key\jog\*";    DestDir: "{app}\icons\op_f_key\jog"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_f_key\jogpad\*";    DestDir: "{app}\icons\op_f_key\jogpad"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_f_key\main\*";    DestDir: "{app}\icons\op_f_key\main"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_f_key\user\*";    DestDir: "{app}\icons\op_f_key\user"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_f_key\zero\*";    DestDir: "{app}\icons\op_f_key\zero"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_left\*";    DestDir: "{app}\icons\op_left"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\op_right\*";    DestDir: "{app}\icons\op_right"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons\program\*";    DestDir: "{app}\icons\program"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\*";    DestDir: "{app}\icons_120dpi"; Flags: ignoreversion
;;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_f_key\*";    DestDir: "{app}\icons_120dpi\op_f_key"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_f_key\auto\*";    DestDir: "{app}\icons_120dpi\op_f_key\auto"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_f_key\graph\*";    DestDir: "{app}\icons_120dpi\op_f_key\graph"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_f_key\home\*";    DestDir: "{app}\icons_120dpi\op_f_key\home"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_f_key\io\*";    DestDir: "{app}\icons_120dpi\op_f_key\io"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_f_key\jog\*";    DestDir: "{app}\icons_120dpi\op_f_key\jog"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_f_key\jogpad\*";    DestDir: "{app}\icons_120dpi\op_f_key\jogpad"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_f_key\main\*";    DestDir: "{app}\icons_120dpi\op_f_key\main"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_f_key\user\*";    DestDir: "{app}\icons_120dpi\op_f_key\user"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_f_key\zero\*";    DestDir: "{app}\icons_120dpi\op_f_key\zero"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_left\*";    DestDir: "{app}\icons_120dpi\op_left"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\op_right\*";    DestDir: "{app}\icons_120dpi\op_right"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_120dpi\program\*";    DestDir: "{app}\icons_120dpi\program"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\*";    DestDir: "{app}\icons_old"; Flags: ignoreversion
;;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_f_key\*";    DestDir: "{app}\icons_old\op_f_key"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_f_key\auto\*";    DestDir: "{app}\icons_old\op_f_key\auto"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_f_key\graph\*";    DestDir: "{app}\icons_old\op_f_key\graph"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_f_key\home\*";    DestDir: "{app}\icons_old\op_f_key\home"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_f_key\io\*";    DestDir: "{app}\icons_old\op_f_key\io"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_f_key\jog\*";    DestDir: "{app}\icons_old\op_f_key\jog"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_f_key\jogpad\*";    DestDir: "{app}\icons_old\op_f_key\jogpad"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_f_key\main\*";    DestDir: "{app}\icons_old\op_f_key\main"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_f_key\user\*";    DestDir: "{app}\icons_old\op_f_key\user"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_f_key\zero\*";    DestDir: "{app}\icons_old\op_f_key\zero"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_left\*";    DestDir: "{app}\icons_old\op_left"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\op_right\*";    DestDir: "{app}\icons_old\op_right"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_old\program\*";    DestDir: "{app}\icons_old\program"; Flags: ignoreversion
;;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\*";    DestDir: "{app}\icons_tr"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_f_key\*";    DestDir: "{app}\icons_tr\op_f_key"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_f_key\auto\*";    DestDir: "{app}\icons_tr\op_f_key\auto"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_f_key\graph\*";    DestDir: "{app}\icons_tr\op_f_key\graph"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_f_key\home\*";    DestDir: "{app}\icons_tr\op_f_key\home"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_f_key\io\*";    DestDir: "{app}\icons_tr\op_f_key\io"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_f_key\jog\*";    DestDir: "{app}\icons_tr\op_f_key\jog"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_f_key\jogpad\*";    DestDir: "{app}\icons_tr\op_f_key\jogpad"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_f_key\main\*";    DestDir: "{app}\icons_tr\op_f_key\main"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_f_key\user\*";    DestDir: "{app}\icons_tr\op_f_key\user"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_f_key\zero\*";    DestDir: "{app}\icons_tr\op_f_key\zero"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_left\*";    DestDir: "{app}\icons_tr\op_left"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\op_right\*";    DestDir: "{app}\icons_tr\op_right"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\icons_tr\program\*";    DestDir: "{app}\icons_tr\program"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\logging\*";    DestDir: "{app}\logging"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\logos\*";    DestDir: "{app}\logos"; Flags: ignoreversion
;;Source: "Solution Items\CNC\EdingCNC\CNC4.03\Plain_pictures\*";    DestDir: "{app}\Plain_pictures"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\qt_cnc_opengl_plugin\*";    DestDir: "{app}\qt_cnc_opengl_plugin"; Flags: ignoreversion
;Source: "Solution Items\CNC\EdingCNC\CNC4.03\QT_ExampleUI\*";    DestDir: "{app}\QT_ExampleUI"; Flags: ignoreversion
;;Source: "Solution Items\CNC\EdingCNC\CNC4.03\*";    DestDir: "{app}"; Flags: ignoreversion

[Tasks] 
Name: startmenu; Description:"スタートメニューにショートカットを作成する(&P)"; Flags:
Name: desktopicon; Description: "デスクトップにアイコンを作成する(&D)"; Flags:

[Icons]
Name: "{userdesktop}\MachineLink"; Filename: "{app}\MachineLink.exe"; WorkingDir: "{app}"; IconFilename: "{app}\MachineLink.exe"; IconIndex: 0

[Run]
//Filename: "{app}\SolutionItems\README.md"; Description: "READMEを表示する"; Flags: postinstall shellexec skipifsilent unchecked
//Filename: "{app}\readme.txt"; Description: "READMEを表示する"; Flags: postinstall shellexec skipifsilent unchecked
//Filename: "{app}\MobileLinks.exe"; Description: "インストール完了後起動する"; Flags: postinstall shellexec skipifsilent   