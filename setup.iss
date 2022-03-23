; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "HIRD"
#define MyAppExeName "HIRD.exe"
#define MyAppSettingsFile "HIRD.settings.json"
#define MyAppVersion "0.2.4-alpha"
#define MyAppPublisher "Saurav KS"
#define MyAppURL "https://clicksrv.github.io/HIRD"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{98001817-9598-4513-9DD1-61707E6B3F9C}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; Remove the following line to run in administrative install mode (install for all users.)
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=.\src\HIRD\bin\
OutputBaseFilename=.\publish\Setup.exe
SetupIconFile=.\src\HIRD\icon.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern
FlatComponentsList=yes
DirExistsWarning=no
UninstallDisplayIcon={app}\{#MyAppExeName}

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; Flags: unchecked
Name: "enableautostart"; Description: "Start HIRD with Windows"; Flags: unchecked
Name: "overridesettings"; Description: "Delete existing settings"; Flags: checkedonce

[InstallDelete]
Type: files; Name: "{app}\{#MyAppSettingsFile}"; Tasks: overridesettings

[Registry]
Root: HKCU; Subkey: "Software\Microsoft\Windows\CurrentVersion\Run"; ValueType: string; ValueName: "{#MyAppName}"; ValueData: """{app}\{#MyAppExeName}"" --silent --delayed"; Flags: uninsdeletevalue;
Root: HKCU; Subkey: "Software\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\Run"; ValueType: binary; ValueName: "{#MyAppName}"; ValueData: "03 00 00 00 00 00 00 00 00 00 00 00"; Flags: uninsdeletevalue;
Root: HKCU; Subkey: "Software\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\Run"; ValueType: binary; ValueName: "{#MyAppName}"; ValueData: "02 00 00 00 00 00 00 00 00 00 00 00"; Tasks: enableautostart

[Files]
Source: ".\src\HIRD\bin\setup\{#MyAppExeName}"; DestDir: "{app}"; Flags: 
Source: ".\src\HIRD\bin\setup\*"; DestDir: "{app}"; Flags: recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[UninstallDelete]
Type: files; Name: "{app}\{#MyAppSettingsFile}"