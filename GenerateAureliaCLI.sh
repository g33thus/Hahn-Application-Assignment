npm install aurelia-cli@latest -g
cd aureliaApp.Spa
au new 'ClientApp' --unattended --select webpack,http1,typescript,htmlmin-max,none,none,none,none,vscode,no
rm '..\GenerateAureliaCLI.sh'
rm '..\GenerateAureliaCLI.ps1'