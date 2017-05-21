# The AxImp.exe command path.
$aximpExePath = 'C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7 Tools\x64\AxImp.exe'

# The mstscax.dll file path.
$mstscaxDllPath = 'C:\Windows\System32\mstscax.dll'

# The path for stored the generated files.
$storeFolderPath = Join-Path -Path $PSScriptRoot -ChildPath 'bin'

# Check the paths.
if (-not (Test-Path -LiteralPath $aximpExePath -PathType Leaf)) { throw ('Not found the AxImp.exe at "{0}"' -f $aximpExePath) }
if (-not (Test-Path -LiteralPath $mstscaxDllPath -PathType Leaf)) { throw ('Not found the mstscax.dll at "{0}"' -f $mstscaxDllPath) }
if (-not (Test-Path -LiteralPath $storeFolderPath -PathType Container)) { New-Item -Path $storeFolderPath -ItemType 'Directory' }

# Create the wrapper control.
Start-Process -FilePath $aximpExePath -ArgumentList $mstscaxDllPath,'/source' -WorkingDirectory $storeFolderPath -Wait
