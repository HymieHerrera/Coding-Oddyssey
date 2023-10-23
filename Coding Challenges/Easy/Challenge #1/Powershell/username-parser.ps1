# Prompt user for input
$name = Read-Host "What is your name?"
$age = Read-Host "What is your age?"
$username = Read-Host "What is your github username"

# Log input to CSV file with timestamps
$timestamp = Get-Date -Format "yyyy-MM-dd HH:mm:ss"
$log = "$timestamp,$name,$age,$username"
$outFile = Join-Path -Path $PSScriptRoot -ChildPath "user-log.csv"
$log | Out-File -FilePath $outFile -Append


$log | Out-File -FilePath "user-log.csv" -Append

# Output formatted string
Write-Host "Your name is $name, you are $age years old, and your username is $username"

# Future: Add error handling
# Future: Convert to function

