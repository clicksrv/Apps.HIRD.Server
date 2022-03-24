@echo off
set /p v="Enter Version Name in format (vX.Y.Z[-suffix]): "

set pulling_msg=[ Pulling any Unsynced Changes ]
set publish_msg=[ Publishing Files for Setup ]
set compile_msg=[ Compiling Setup Exe ]
set deploy_msg=[ Deploying Release ]

title Compiling HIRD Windows Server Setup

echo:
echo %pulling_msg%
echo:

cd src\HIRD
echo:
echo %publish_msg%
echo:

dotnet publish -p:PublishProfile=FolderProfile

cd ..\..

echo:
echo %compile_msg%
echo:

iscc setup_with_version.iss /DMyAppVersion=%v%

echo:
echo %deploy_msg%
echo:

git add .
git commit -m "Deploying Release %v%"
git push origin %v%

echo:
echo: