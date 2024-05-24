Terminal%LocalAppData%\Microsoft\WindowsApps\wt.exe

Microsoft Store --> PowerShell

terminal JSON
{
	"name": "Snazzy",
	"foreground": "#eff0eb",
	"background": "#282a36",
	"selectionBackground": "#3e404a",
	"cursorColor": "#97979b",
	"black": "#282a36",
	"red": "#ff5c57",
	"green": "#5af78e",
	"yellow": "#f3f99d",
	"blue": "#57c7ff",
	"purple": "#ff6ac1",
	"cyan": "#9aedfe",
	"white": "#f1f1f0",
	"brightBlack": "#686868",
	"brightRed": "#ff5c57",
	"brightGreen": "#5af78e",
	"brightYellow": "#f3f99d",
	"brightBlue": "#57c7ff",
	"brightPurple": "#ff6ac1",
	"brightCyan": "#9aedfe",
	"brightWhite": "#eff0eb"
}

------------------
https://ohmyposh.dev/

winget install JanDeDobbeleer.OhMyPosh -s winget
oh-my-posh font install
  (firaCode)
-------
seleccionar firaCodeMono en las opciones de la terminal

oh-my-posh

oh-my-posh init pwsh --config "$env:POSH_THEMES_PATH\jandedobbeleer.omp.json"
(copiar y pegar el comando generado)

Get-PoshThemes

-------probua.minimal

(@(& 'C:/Users/Omar/AppData/Local/Programs/oh-my-posh/bin/oh-my-posh.exe' init pwsh --config='C:\Users\Omar\AppData\Local\Programs\oh-my-posh\themes\catppuccin_mocha.omp.json' --print) -join "`n") | Invoke-Expression ----NO PRESIONAR ENTER, SOLO COPIARLO

New-Item -Path $PROFILE -Type File -Force
notepad $PROFILE
copia el comando anterior en el notepad creado

Install-Module -Name Terminal-Icons -Repository PSGallery
Import-Module Terminal-Icons
